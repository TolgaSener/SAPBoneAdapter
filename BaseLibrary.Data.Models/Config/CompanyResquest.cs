namespace BaseLibrary.Data.Models.Config
{
    public class CompanyResquest
    {
        public string SapServer { get; set; }
        public string SapLinsansServer { get; set; }
        public string CompanyDB { get; set; }
        public SAPbobsCOM.BoDataServerTypes DbServerType { get; set; }
        public string DbUserName { get; set; }
        public string DbPassword { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
