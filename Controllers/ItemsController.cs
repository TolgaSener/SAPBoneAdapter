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
    public class ItemsController : ApiController
    {
        private readonly IItemsEngine _itemsEngine;
        public ItemsController(IItemsEngine itemsEngine)
        {
            _itemsEngine = itemsEngine;
        }
        [HttpGet]
        public Task<List<OitmResponse>> GetAllItems()
        {
            return _itemsEngine.GetAllItemsAsync();
        }

        [HttpPost]
        public Task<List<OitmResponse>> GetByItems(ItemRequest request)
        {
            return _itemsEngine.GetByItemsAsync(request);
        }

        [HttpGet]
        public Task<Item> GetByItem(ItemParams ItemCode)
        {
            return _itemsEngine.GetByAsync(ItemCode);
        }

        [HttpPost]
        public Task<UserItemResponse> GetByUserItem(UserItemRequest request)
        {
            return _itemsEngine.GetByUserItemAsync(request);
        }
    }
}
