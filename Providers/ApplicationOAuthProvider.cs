using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BaseLibrary.Core;
using BaseLibrary.Core.Contracts;
using BaseLibrary.Data;
using BaseLibrary.Data.Contracts.Service.Repository;
using BaseLibrary.Data.Models.Model;
using BaseLibrary.Data.WebService.LoginService;
using BaseLibrary.Data.WebService.User;
using BaseLibrary.Engine;
using BaseLibrary.Engine.Contracts;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using BaseLibrary.Hosting.Api.Models;
namespace BaseLibrary.Hosting.Api.Providers
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly string _publicClientId;
        private readonly IUserEngine _userEngine = new UserEngine(new OusrRepository());
        protected IConfigurationHelper Configuration;
        public ApplicationOAuthProvider(string publicClientId)
        {
            if (publicClientId == null)
            {
                throw new ArgumentNullException("publicClientId");
            }
            _publicClientId = publicClientId;
            Configuration = DependencyContainer.Resolve<IConfigurationHelper>();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();
            ApplicationUser user = await userManager.FindAsync(context.UserName, context.Password);
            if (user == null)
            {
                //Sap Login
                var login = new LoginRequest
                {
                    LanguageSpecified = true,
                    CompanyPassword = context.Password,
                    CompanyUsername = context.UserName,
                    DatabaseName = Configuration.CompanyDB,
                    DatabaseServer = Configuration.SapServer,
                    DatabaseType = true,
                    DatabaseTypeSpecified = true,
                    Language = LoginLanguage.ln_Turkish_Tr,
                    LicenseServer = Configuration.SapLinsansServer,
                    LoginDatabaseType = LoginDatabaseType.dst_MSSQL2014
                };
                var sapuser = await _userEngine.LoginAsync(login);
                if (sapuser != "")
                {
                    var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                    identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
                    identity.AddClaim(new Claim(ClaimTypes.SerialNumber, sapuser));
                    AuthenticationProperties properties = CreateProperties(context.UserName);
                    AuthenticationTicket ticket = new AuthenticationTicket(identity, properties);
                    context.Validated(ticket);
                }
                else
                {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }
            }
            else
            {
                ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(userManager,
                    OAuthDefaults.AuthenticationType);
                ClaimsIdentity cookiesIdentity = await user.GenerateUserIdentityAsync(userManager,
                    CookieAuthenticationDefaults.AuthenticationType);
                AuthenticationProperties properties = CreateProperties(user.UserName);
                AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);
                context.Validated(ticket);
                context.Request.Context.Authentication.SignIn(cookiesIdentity);
            }
           
        }
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }
            return Task.FromResult<object>(null);
        }
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.
            if (context.ClientId == null)
            {
                context.Validated();
            }
            return Task.FromResult<object>(null);
        }
        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == _publicClientId)
            {
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");
                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }
            return Task.FromResult<object>(null);
        }
        public static AuthenticationProperties CreateProperties(string userName)
        {
            IDictionary<string, string> data = new Dictionary<string, string>
            {
                { "userName", userName }
            };
            return new AuthenticationProperties(data);
        }
    }
}