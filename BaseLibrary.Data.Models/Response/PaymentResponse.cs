using System;
namespace BaseLibrary.Data.Models.Response
{
   public class PaymentResponse
    {
        public string BankName { get; set; }
        public string PaymentType { get; set; }
        public double PaymentAmount { get; set; }
        public DateTime PaymentTime { get; set; }
        public string ProvisionNumber { get; set; }
        public string CreditCardNumber { get; set; }
    }
}
