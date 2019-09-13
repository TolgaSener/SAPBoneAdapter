using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaseLibrary.Data.Models.Response
{
   public class PersonResponse
    {
        //  lastName, firstName, email, mobile, userId, int, jobTitle, sex
        public int empID { get; set; }
        public char PrePRWeb { get; set; }
        public char PRWebAccss { get; set; }
        public char Active { get; set; }
        public string PymMeth { get; set; }
        public string PersGroup { get; set; }
        public string NamePos { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public int userId { get; set; }
        public int salesPrson { get; set; }
        public string jobTitle { get; set; }
        public char sex { get; set; }
    }
}
