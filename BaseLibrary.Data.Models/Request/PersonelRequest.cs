using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaseLibrary.Data.Models.Request
{
   public class PersonelRequest
    {
        public int empID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
    }
}
