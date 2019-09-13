namespace BaseLibrary.Data.Models.Response
{
    public class ItemResponse
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; } // indirimsiz fiyatı belirtir
        public string ImagePath { get; set; }
        public double ItemVat { get; set; }
        public string ItemVatDesc { get; set; }
        public int Stock { get; set; }
        public string WareHouse { get; set; }
        public bool Installation { get; set; }
        public string Barcode { get; set; }
    }
}
