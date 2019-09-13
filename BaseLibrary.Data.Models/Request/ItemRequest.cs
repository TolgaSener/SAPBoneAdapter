namespace BaseLibrary.Data.Models.Request
{
   public class ItemRequest
    {
        public int LineNum { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Barcode { get; set; }
        public double ItemPrice { get; set; } // indirimsiz fiyatı belirtir
        public double ItemVat { get; set; }
        public string ItemVatDesc { get; set; }
        public double Quantity { get; set; }
        public double DiscountAmount { get; set; }
        public double DiscountPercentage { get; set; }
        public double UnitPrice { get; set; } // birim fiyatı belirtir
        public double NetTotalPrice { get; set; }  // indirimsiz toplam fiyat
        public double TotalPrice { get; set; } // indirimli toplam fiyat
        public string ImagePath { get; set; } //ürüne ait resim
        public string CustomerCode { get; set; }
        public int Stock { get; set; }
        public bool Installation { get; set; }
        public string WareHouse { get; set; }
        public int SalesPersonCode { get; set; } //satış çalışanı b1 kod    
        public string SalesPersonName { get; set; } //satış çalışanı b1 adı
    }
}
