using System.Web.Http;
using BaseLibrary.Engine.Contracts;

namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class OrdersController : ApiController
    {
        private IOrdersEngine _ordersEngine;

        public OrdersController(IOrdersEngine ordersEngine)
        {
            _ordersEngine = ordersEngine;
        }
    }
}
