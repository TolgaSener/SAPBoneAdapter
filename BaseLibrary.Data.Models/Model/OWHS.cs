namespace BaseLibrary.Data.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public partial class OWHS
    {
        [Key]
        [StringLength(8)]
        public string WhsCode { get; set; }
        [StringLength(100)]
        public string WhsName { get; set; }
        public int? IntrnalKey { get; set; }
        [StringLength(4)]
        public string Grp_Code { get; set; }
        [StringLength(15)]
        public string BalInvntAc { get; set; }
        [StringLength(15)]
        public string SaleCostAc { get; set; }
        [StringLength(15)]
        public string TransferAc { get; set; }
        [StringLength(1)]
        public string Locked { get; set; }
        [StringLength(1)]
        public string DataSource { get; set; }
        public short? UserSign { get; set; }
        [StringLength(15)]
        public string RevenuesAc { get; set; }
        [StringLength(15)]
        public string VarianceAc { get; set; }
        [StringLength(15)]
        public string DecreasAc { get; set; }
        [StringLength(15)]
        public string IncreasAc { get; set; }
        [StringLength(15)]
        public string ReturnAc { get; set; }
        [StringLength(15)]
        public string ExpensesAc { get; set; }
        [StringLength(15)]
        public string EURevenuAc { get; set; }
        [StringLength(15)]
        public string EUExpensAc { get; set; }
        [StringLength(15)]
        public string FrRevenuAc { get; set; }
        [StringLength(15)]
        public string FrExpensAc { get; set; }
        [StringLength(8)]
        public string VatGroup { get; set; }
        [StringLength(100)]
        public string Street { get; set; }
        [StringLength(100)]
        public string Block { get; set; }
        [StringLength(20)]
        public string ZipCode { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string County { get; set; }
        [StringLength(3)]
        public string Country { get; set; }
        [StringLength(3)]
        public string State { get; set; }
        public int? Location { get; set; }
        [StringLength(1)]
        public string DropShip { get; set; }
        [StringLength(15)]
        public string ExmptIncom { get; set; }
        [StringLength(1)]
        public string UseTax { get; set; }
        [StringLength(15)]
        public string PriceDifAc { get; set; }
        [StringLength(15)]
        public string ExchangeAc { get; set; }
        [StringLength(15)]
        public string BalanceAcc { get; set; }
        [StringLength(15)]
        public string PurchaseAc { get; set; }
        [StringLength(15)]
        public string PAReturnAc { get; set; }
        [StringLength(15)]
        public string PurchOfsAc { get; set; }
        [StringLength(32)]
        public string FedTaxID { get; set; }
        [Column(TypeName = "ntext")]
        public string Building { get; set; }
        [StringLength(15)]
        public string ShpdGdsAct { get; set; }
        [StringLength(15)]
        public string VatRevAct { get; set; }
        [StringLength(15)]
        public string DecresGlAc { get; set; }
        [StringLength(15)]
        public string IncresGlAc { get; set; }
        [StringLength(1)]
        public string Nettable { get; set; }
        [StringLength(15)]
        public string StokRvlAct { get; set; }
        [StringLength(15)]
        public string StkOffsAct { get; set; }
        [StringLength(15)]
        public string WipAcct { get; set; }
        [StringLength(15)]
        public string WipVarAcct { get; set; }
        [StringLength(15)]
        public string CostRvlAct { get; set; }
        [StringLength(15)]
        public string CstOffsAct { get; set; }
        [StringLength(15)]
        public string ExpClrAct { get; set; }
        [StringLength(15)]
        public string ExpOfstAct { get; set; }
        [StringLength(20)]
        public string objType { get; set; }
        public int? logInstanc { get; set; }
        public DateTime? createDate { get; set; }
        public short? userSign2 { get; set; }
        public DateTime? updateDate { get; set; }
        [StringLength(15)]
        public string ARCMAct { get; set; }
        [StringLength(15)]
        public string ARCMFrnAct { get; set; }
        [StringLength(15)]
        public string ARCMEUAct { get; set; }
        [StringLength(15)]
        public string ARCMExpAct { get; set; }
        [StringLength(15)]
        public string APCMAct { get; set; }
        [StringLength(15)]
        public string APCMFrnAct { get; set; }
        [StringLength(15)]
        public string APCMEUAct { get; set; }
        [StringLength(15)]
        public string RevRetAct { get; set; }
        public int? BPLid { get; set; }
        [StringLength(1)]
        public string OwnerCode { get; set; }
        [StringLength(15)]
        public string NegStckAct { get; set; }
        [StringLength(15)]
        public string StkInTnAct { get; set; }
        [StringLength(100)]
        public string AddrType { get; set; }
        [StringLength(100)]
        public string StreetNo { get; set; }
        [StringLength(15)]
        public string PurBalAct { get; set; }
        [StringLength(1)]
        public string Excisable { get; set; }
        [StringLength(15)]
        public string WhICenAct { get; set; }
        [StringLength(15)]
        public string WhOCenAct { get; set; }
        [StringLength(100)]
        public string WhShipTo { get; set; }
        [StringLength(15)]
        public string WipOffset { get; set; }
        [StringLength(15)]
        public string StockOffst { get; set; }
        public int? StorKeeper { get; set; }
        [StringLength(15)]
        public string Shipper { get; set; }
        [StringLength(1)]
        public string BinActivat { get; set; }
        [StringLength(5)]
        public string BinSeptor { get; set; }
        public int? DftBinAbs { get; set; }
        [StringLength(1)]
        public string DftBinEnfd { get; set; }
        public short? AutoIssMtd { get; set; }
        [StringLength(1)]
        public string ManageSnB { get; set; }
        public short? RecItemsBy { get; set; }
        [StringLength(1)]
        public string RecBinEnab { get; set; }
        [StringLength(50)]
        public string GlblLocNum { get; set; }
        [StringLength(1)]
        public string RecvEmpBin { get; set; }
        [StringLength(1)]
        public string Inactive { get; set; }
        [StringLength(1)]
        public string RecvMaxQty { get; set; }
        public short? AutoRecvMd { get; set; }
        [StringLength(1)]
        public string RecvMaxWT { get; set; }
        [StringLength(6)]
        public string RecvUpTo { get; set; }
        [StringLength(15)]
        public string FreeChrgSA { get; set; }
        [StringLength(15)]
        public string FreeChrgPU { get; set; }
        [StringLength(50)]
        public string TaxOffice { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string Address3 { get; set; }
        [StringLength(1)]
        public string External { get; set; }
    }
}
