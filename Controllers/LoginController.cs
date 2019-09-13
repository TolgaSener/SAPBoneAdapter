using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using BaseLibrary.Data.Models.Response;
using BaseLibrary.Data.WebService.User;
using BaseLibrary.Engine.Contracts;
namespace BaseLibrary.Hosting.Api.Controllers
{
    
    public class LoginController : ApiController
    {
        private readonly IUserEngine _userEngine;
        public LoginController(IUserEngine userEngine)
        {
            _userEngine = userEngine;
        }
        [HttpPost]
        public Task<string> Login(LoginRequest request)
        {
            return _userEngine.LoginAsync(request);
        }
       
        [HttpGet]
        public Task<List<UserBranchResponse>> GetUserBranch(string user)
        {
            return _userEngine.GetUserBranchAsync(user);
        }
    }
}
