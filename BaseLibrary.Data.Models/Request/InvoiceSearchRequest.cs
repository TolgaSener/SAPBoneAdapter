using System;
namespace BaseLibrary.Data.Models.Request
{
    public class InvoiceSearchRequest
    {
        public string Barcode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Identity { get; set; }
        public string DocEntry { get; set; }
    }
}
