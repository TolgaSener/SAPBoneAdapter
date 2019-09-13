using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaseLibrary.Data.Models.Response
{
   public class CustomerSearchResponse
    {
        public string CardCode { get; set; } // otomatik sistem tarafından verilecek
        public string CardName { get; set; } // businessPartners.CardName 
        //public string FederalTaxID { get; set; } //
        //public string UnifiedFederalTaxID { get; set; } //businessPartners.Phone1 
        //public string AdditionalID { get; set; } // businessPartners.Phone2 
        public string EmailAddress { get; set; } // businessPartners.celluar 
        public string Phone1 { get; set; }
        public string Phone2 { get; set; } // businessPartners.Series = 2;
        public string Cellular { get; set; } //businessPartners.VatIDNum = "852147";
        public string LicTradNum { get; set; }
        
    }
}
