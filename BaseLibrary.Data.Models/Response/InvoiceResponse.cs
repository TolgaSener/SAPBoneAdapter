using System;
using System.Collections.Generic;
using BaseLibrary.Data.Models.Request;
namespace BaseLibrary.Data.Models.Response
{
   public class InvoiceResponse
    {
         public string RefNo { get; set; } // check out sistemi tarafından üreilmiş olan ve ökc ile haberleşme sırasındaki ref no
         public CustomerResponse Customer { get; set; }
         public List<ItemRequest> Items { get; set; } // fatura içindeki satırları temsil eder
         public double DiscountAmount { get; set; } // eğer fatura toplamı üzerinden belli bir miktarda indirim yapılmış indirim bedeli
         public double DiscountPercentage { get; set; } // eğer fatura toplamı üzerinden belli bir oranda indirim yapılmış indirim yüzdesi
         public List<PaymentResponse> PaymentList { get; set; } //faturanın ödeme bilgileri
         public string InvoiceNo { get; set; } // fatura no
         public int InvoiceStatus { get; set; } // fatura durumu - beklemeye alındı - iptal - aktif 
         public double InvoiceAmount { get; set; } // fatura toplamı
         public double InvoiceNetAmount { get; set; } // fatura indirimsiz toplamı
         public string UserName { get; set; } //işlemi yapan kullanıcı
         public string Branch { get; set; } //işlem yapılan mağaza
         public string Terminal { get; set; } //işlem yapılan terminal
         public DateTime InvoiceDate { get; set; }
         public int SalesPersonCode { get; set; } //satış çalışanı b1 kod    
         public string SalesPersonName { get; set; } //satış çalışanı b1 adı
    }
}
