using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using BaseLibrary.Data.Models.Request;
using BaseLibrary.Data.Models.Response;
using BaseLibrary.Data.WebService.ItemsService;
using BaseLibrary.Engine.Contracts;
namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class CheckOutController : ApiController
    {
        //GET: CheckOut
        private readonly ICheckOutEngine _checkOutEngine;
        public CheckOutController(ICheckOutEngine checkOutEngine)
        {
            _checkOutEngine = checkOutEngine;
        }
        [HttpPost]
        public Task<List<CustomerResponse>> GetCustomer(CustomerSearchRequest request)
        {
            return _checkOutEngine.GetBussinesPatnerAsync(request);
        }
        [HttpPost]
        public Task<List<UserResponse>> GetPersons()
        {
            return _checkOutEngine.GetPersonsAsync();
        }
        [HttpPost]
        public Task<List<ItemResponse>> GetItems(ItemRequest request)
        {
            return _checkOutEngine.GetItemsAsync(request);
        }
        [HttpPost]
        public Task<Item> GetByItems(ItemParams request)
        {
            return _checkOutEngine.GetByItemAsync(request);
        }
    }
}