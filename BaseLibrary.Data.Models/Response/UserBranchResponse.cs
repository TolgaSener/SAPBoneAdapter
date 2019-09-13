namespace BaseLibrary.Data.Models.Response
{
   public class UserBranchResponse
    {
        public int BPLId { get; set; }
        public string BPLName { get; set; }
        public string BPLFrName { get; set; }
        public string Address { get; set; }
        public string DflWhs { get; set; }
        public int TaxIdNum { get; set; }
        public string MainBPL { get; set; }
        public string Country { get; set; }
    }
}
