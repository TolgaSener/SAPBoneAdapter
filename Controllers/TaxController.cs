using System.Web.Http;
using BaseLibrary.Engine.Contracts;

namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class TaxController : ApiController
    {
        private readonly ITaxEngine _taxEngine;

        public TaxController(ITaxEngine taxEngine)
        {
            _taxEngine = taxEngine;
        }
    }
}
