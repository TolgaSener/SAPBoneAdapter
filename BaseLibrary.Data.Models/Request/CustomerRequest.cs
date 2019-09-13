using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaseLibrary.Data.Models.Request
{
   public class CustomerRequest
    {
        public string CardCode { get; set; } // otomatik sistem tarafından verilecek
        public string CardName { get; set; } // businessPartners.CardName 
        public string LicTradNum { get; set; } //
        public string Phone { get; set; } //businessPartners.Phone1 
        public string Cellular { get; set; } // businessPartners.celluar 
        //public string Phone2 { get; set; } // businessPartners.Phone2 
        //public List<AdresResponse> AddressList { get; set; }
        //public int CustomerGroup { get; set; } // businessPartners.Series = 2;
        //public string TaxNo { get; set; } //businessPartners.VatIDNum = "852147";
        //public string TaxOffice { get; set; } //businessPartners.AdditionalID = "kadıköy";
        //public bool Enabled { get; set; }
        //public string Email { get; set; } // businessPartners.EmailAddress = "email@mail.com";
        //public bool isLoyal { get; set; }
        //public CustomerResponse LoyalMaster { get; set; }
        //public int CustomerType { get; set; } // 1= şahıs 2 = şirket
    }
}
