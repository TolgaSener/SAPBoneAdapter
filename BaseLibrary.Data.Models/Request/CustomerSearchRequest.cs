using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaseLibrary.Data.Models.Request
{
   public class CustomerSearchRequest
    {
        public string CardCode { get; set; } // otomatik sistem tarafından verilecek
        public string CardName { get; set; } // businessPartners.CardName 
        public string LicTradNum { get; set; } //
        public string Cellular { get; set; } //businessPartners.Phone1 
    }
}
