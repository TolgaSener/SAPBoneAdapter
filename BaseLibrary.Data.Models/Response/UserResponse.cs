using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaseLibrary.Data.Models.Response
{
   public class UserResponse
    {
        public short UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string GroupName { get; set; }
        public string Departman { get; set; }
        public string SuperUser { get; set; }
        public string MobileUser { get; set; }
        public string PortNum { get; set; }
        public string E_Mail { get; set; }
        public string Gender { get; set; }
    }
}
