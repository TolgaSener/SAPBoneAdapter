using System.Web.Http;
using BaseLibrary.Engine.Contracts;

namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class ReturnsController : ApiController
    {
        private readonly IReturnsEngine _returnsEngine;

        public ReturnsController(IReturnsEngine returnsEngine)
        {
            _returnsEngine = returnsEngine;
        }
    }
}
