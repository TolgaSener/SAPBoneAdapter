using System.Threading.Tasks;
using System.Web.Http;
using BaseLibrary.Data.WebService.StockTransferService;
using BaseLibrary.Engine.Contracts;

namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class StockTransferController : ApiController
    {
        private readonly IStocksTransferEngine _stocksTransferEngine;

        public StockTransferController(IStocksTransferEngine stocksTransferEngine)
        {
            _stocksTransferEngine = stocksTransferEngine;
        }

        [HttpPost]
        public Task<StockTransfer> StocTransfer(StockTransferParams request)
        {
            return _stocksTransferEngine.StockTransferAsync(request);
        }

        [HttpPost]
        public Task<StockTransferParams> StocAdd(StockTransfer request)
        {
            return _stocksTransferEngine.StockAddAsync(request);
        }

        [HttpPost]
        public Task<bool> StocRemove(StockTransferParams request)
        {
            return _stocksTransferEngine.StockRemoveAsync(request);
        }
    }
}
