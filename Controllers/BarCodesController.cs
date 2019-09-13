using System.Threading.Tasks;
using System.Web.Http;
using BaseLibrary.Data.WebService.BarCodesService;
using BaseLibrary.Engine.Contracts;

namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class BarCodesController : ApiController
    {
        private readonly IBarCodesEngine _barCodesEngine;

        public BarCodesController(IBarCodesEngine barCodesEngine)
        {
            _barCodesEngine = barCodesEngine;
        }

        public Task<BarCode> GetBarcode(BarCodeParams barCodeParams)
        {
            return _barCodesEngine.GetBarcodeAsync(barCodeParams);
        }

        public Task BarkodeDelete( BarCodeParams barCodeParams)
        {
            return _barCodesEngine.BarkodeDelete(barCodeParams);
        }

        public Task<BarCodeParams> BarcodeAdd(BarCode barcode)
        {
            return _barCodesEngine.BarcodeAddAsync(barcode);
        }

        public Task BarcodeUpdate(BarCode barCode)
        {
            return _barCodesEngine.BarcodeUpdateAsync(barCode);
        }
    }
}
