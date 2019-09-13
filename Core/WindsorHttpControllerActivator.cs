using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using BaseLibrary.Core;

namespace BaseLibrary.Hosting.Api.Core
{
    public class WindsorHttpControllerActivator : IHttpControllerActivator
    {
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var instance = DependencyContainer.Resolve(controllerType);

            if (instance == null)
            {
                throw new HttpException((int)HttpStatusCode.NotFound, $"{controllerType.Name} cannot be resolved.");
            }

            return (IHttpController)instance;
        }
    }
}