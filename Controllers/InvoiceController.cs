using System.Threading.Tasks;
using System.Web.Http;
using BaseLibrary.Data.WebService.InvoicesService;
using BaseLibrary.Engine.Contracts;
namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class InvoiceController : ApiController
    {
        private readonly IInvoiceEngine _invoiceEngine;
        public InvoiceController(IInvoiceEngine invoiceEngine)
        {
            _invoiceEngine = invoiceEngine;
        }

        [HttpPost]
        public Task<Document> InvoiceGetApprovalTemplates()
        {
            return _invoiceEngine.InvoiceGetApprovalTemplatesAsync();
        }

        [HttpPost]
        public Task<Document> InvoiceGetByParams(DocumentParams documentParams)
        {
            return _invoiceEngine.InvoiceGetByParamsAsync(documentParams);
        }

        [HttpPost]
        public Task InvoiceUpdate(Document document)
        {
            return _invoiceEngine.InvoiceUpdateAsync(document);
        }

        [HttpPost]
        public Task InvoicetUpdateFromXml(Document document)
        {
            return _invoiceEngine.InvoicetUpdateFromXmlAsync(document);
        }

        [HttpGet]
        public Task InvoiceSaveDraftToDocument()
        {
            return _invoiceEngine.InvoiceSaveDraftToDocumentAsync();
        }

        [HttpPost]
        public Task InvoiceReopen(DocumentParams documentParams)
        {
            return _invoiceEngine.InvoiceReopenAsync(documentParams);
        }

        [HttpPost]
        public Task InvoiceRemove(DocumentParams documentParams)
        {
            return _invoiceEngine.InvoiceRemoveAsync(documentParams);
        }

        [HttpPost]
        public Task InvoicePreview(Document document)
        {
            return _invoiceEngine.InvoicePreviewAsync(document);
        }

        [HttpPost]
        public Task InvoiceCreateCancellationDocument(DocumentParams documentParams)
        {
            return _invoiceEngine.InvoiceCreateCancellationDocumentAsync(documentParams);
        }

        [HttpPost]
        public Task<DocumentParams> InvoiceAdd(Document document)
        {
            return _invoiceEngine.InvoiceAddAsync(document);
        }

        [HttpPost]
        public Task InvoiceCancel(DocumentParams documentParams)
        {
            return _invoiceEngine.InvoiceCancelAsync(documentParams);
        }

        [HttpPost]
        public Task InvoiceClose(DocumentParams documentParams)
        {
            return _invoiceEngine.InvoiceCloseAsync(documentParams);
        }
    }
}
