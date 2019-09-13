using System;
using System.Collections.Generic;
namespace BaseLibrary.Data.Models.Response
{
    public class CustomerResponse
    {
        public string CardCode { get; set; } // otomatik sistem tarafından verilecek
        public string CardName { get; set; } // businessPartners.CardName 
        public string GroupCode { get; set; } //
        public string Phone1 { get; set; } //businessPartners.Phone1 
        public string Phone2 { get; set; } // businessPartners.Phone2 
        public string Celluar { get; set; } // businessPartners.celluar 
        public string Address { get; set; }
        public int Series { get; set; } // businessPartners.Series = 2;
        public string VatIDNum { get; set; } //businessPartners.VatIDNum = "852147";
        public string AdditionalID { get; set; } //businessPartners.AdditionalID = "kadıköy";
        public bool Enabled { get; set; }
        public string EmailAddress { get; set; } // businessPartners.EmailAddress = "email@mail.com";
        public bool isLoyal { get; set; }
        public string CntctPrsn { get; set; }
        public string CardType { get; set; } // 1= şahıs 2 = şirket
    }
}
