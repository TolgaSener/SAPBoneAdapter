namespace BaseLibrary.Data.Models.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    public partial class AspOneCheckOut : DbContext
    {
        public AspOneCheckOut()
            : base("name=AspOneCheckOut")
        {
        }
        public virtual DbSet<OWTR> OWTR { get; set; }
        public virtual DbSet<OHEM> OHEM { get; set; }
        public virtual DbSet<INV1> INV1 { get; set; }
        public virtual DbSet<ITM1> ITM1 { get; set; }
        public virtual DbSet<OCRD> OCRD { get; set; }
        public virtual DbSet<OINV> OINV { get; set; }
        public virtual DbSet<OITM> OITM { get; set; }
        public virtual DbSet<OITW> OITW { get; set; }
        public virtual DbSet<OUSR> OUSR { get; set; }
        public virtual DbSet<OVTG> OVTG { get; set; }
        public virtual DbSet<OWHS> OWHS { get; set; }
        public virtual DbSet<RIN21> RIN21 { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DocType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.CANCELED)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Handwrtten)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Printed)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DocStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.InvntSttus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.VatPercent)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.VatSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.VatSumFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DiscPrcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DiscSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DiscSumFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DocRate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DocTotal)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DocTotalFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PaidToDate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PaidFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.GrosProfit)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.GrosProfFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PartSupply)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Confirmed)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.CreateTran)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SummryType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.UpdInvnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.UpdCardBal)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.InvntDirec)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ShowSCN)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SysRate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.CurSource)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.VatSumSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DiscSumSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DocTotalSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PaidSys)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FatherType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.GrosProfSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.IsICT)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Volume)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Weight)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.isCrin)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.selfInv)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.VatPaid)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.VatPaidFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.VatPaidSys)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.WddStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.TotalExpns)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.TotalExpFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.TotalExpSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Exported)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.NetProc)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.AqcsTax)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.AqcsTaxFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.AqcsTaxSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.CashDiscPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.CashDiscnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.CashDiscFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.CashDiscSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.WTSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.WTSumFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.WTSumSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.RoundDif)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.RoundDifFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.RoundDifSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.CheckDigit)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.submitted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PoPrss)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Rounding)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.RevisionPo)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PickStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Pick)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BlockDunn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PayBlock)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.MaxDscn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Reserve)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Max1099)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExpAppl)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExpApplFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExpApplSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DeferrTax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.WTApplied)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.WTAppliedF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BoeReserev)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.WTAppliedS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.EquVatSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.EquVatSumF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.EquVatSumS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.VATFirst)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.NnSbAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.NnSbAmntSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.NbSbAmntFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExepAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExepAmntSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExepAmntFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.CEECFlag)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseAmntSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseAmntFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.UseShpdGd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseVtAt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseVtAtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseVtAtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.NnSbVAt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.NnSbVAtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.NbSbVAtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExptVAt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExptVAtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExptVAtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.LYPmtAt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.LYPmtAtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.LYPmtAtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExpAnSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExpAnSys)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExpAnFrgn)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmAmntSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmAmntFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmDrawn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmPrcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PaidSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PaidSumFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PaidSumSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmAppl)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmApplFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmApplSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Posted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.IsPaytoBnk)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.isIns)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BPNameOW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BillToOW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ShipToOW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.RetInvoice)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.TaxOnExp)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.TaxOnExpFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.TaxOnExpSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.TaxOnExAp)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.TaxOnExApF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.TaxOnExApS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.LastPmnTyp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.UseCorrVat)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BlkCredMmo)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.OpenForLaC)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Excised)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SrvGpPrcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DutyStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.AutoCrtFlw)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmVat)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmVatFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmVatSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmAppVat)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmAppVatF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmAppVatS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.InsurOp347)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.IgnRelDoc)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ResidenNum)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SSIExmpt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PQTGrpHW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ReopOriDoc)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ReopManCls)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DocManClsd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Ordered)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.NTSApprov)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PayDuMonth)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.EDocGenTyp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.OnlineQuo)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.EDocStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.EDocProces)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.EDocCancel)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.EDocTest)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DpmAsDscnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.GTSRlvnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseDisc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseDiscSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseDiscFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.BaseDiscPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SrvTaxRule)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Notify)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.OriginType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.IsReuseNum)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.IsReuseNFN)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.DocDlvry)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PaidDpm)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PaidDpmF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PaidDpmS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.IsAlt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PrintSEPA)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FreeChrg)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FreeChrgFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FreeChrgSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.NfeValue)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FoCTax)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FoCTaxFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FoCTaxSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FoCFrght)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FoCFrghtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.FoCFrghtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Letter)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SplitTax)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SplitTaxFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SplitTaxSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PriceMode)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.PoDropPrss)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ExclTaxRep)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.Revision)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ComTrade)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.UseBilAddr)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.ComTradeRt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SplitPmnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.SelfPosted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_PAZGELIRI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_KOMTUTAR)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_VADEFARKI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_REKLAMTUTARI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_KARGOBEDN11)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_KARGOBEDFINSPOR)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_IADEKARBED)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_HIZBEDELI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_GFHIZBEDELI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_IADEKOMBEDELI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_IADEKARBEDFIN)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_TEDGECHEDCEK)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_SATICIUCRETLERI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_ISLEMUCRETGIDERI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_IADETUTARI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_KAMPANYAINDTUTARI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_IsFreeInvoice)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_ISArchived)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWTR>()
                .Property(e => e.U_EArvISDespatch)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
               .Property(e => e.sex)
               .IsFixedLength()
               .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.salary)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.salaryUnit)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.emplCost)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.empCostUnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.martStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.DispMidNam)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.NamePos)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.DispComma)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.ExemptAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.AddiAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.DevBAOwner)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.ContResp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.RepLegal)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.DirfDeclar)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.Active)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.PRWebAccss)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.PrePRWeb)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.NaturalPer)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OHEM>()
                .Property(e => e.DPPStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LineStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Price)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Rate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DiscPrcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TotalFrgn)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenSumFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Commission)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TreeType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.GrossBuyPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PriceBefDi)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenCreQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.UseBaseUn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TotalSumSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenSumSys)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.InvntSttus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatPrcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PriceAfVAT)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Height1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Height2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Width1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Width2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Length1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.length2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Volume)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Weight1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Weight2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Factor1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Factor2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Factor3)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Factor4)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PackQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.UpdInvntry)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatSumFrgn)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatSumSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DedVatSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DedVatSumF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DedVatSumS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.IsAqcuistn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DistribSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DstrbSumFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DstrbSumSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.GrssProfit)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.GrssProfSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.GrssProfFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.INMPrice)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DropShip)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.BackOrdr)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PickStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PickOty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatAppld)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatAppldFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatAppldSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.BaseQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.BaseOpnQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatDscntPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.WtLiable)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DeferrTax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.EquVatPer)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.EquVatSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.EquVatSumF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.EquVatSumS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LineVat)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LineVatlF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LineVatS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.NumPerMsr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.CEECFlag)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ToStock)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ToDiff)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ExciseAmt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxPerUnit)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TotInclTax)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckDstSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ReleasQtty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LineType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TranType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StockPrice)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ConsumeFCT)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LstByDsSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckINMPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LstBINMPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckDstFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckDstSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LstByDsFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LstByDsSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StockSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StockSumFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StockSumSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckSumApp)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppD)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppDFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppDSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.BasePrice)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.GTotal)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.GTotalFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.GTotalSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DistribExp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DescOW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DetailsOW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatWoDpm)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatWoDpmFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatWoDpmSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxOnly)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.WtCalced)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.QtyToShip)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DelivrdQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.OrderedQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ChgAsmBoMW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxDistSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxDistSFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxDistSSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PostTax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Excisable)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.AssblValue)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LnExcised)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.StockValue)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.GPTtlBasPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.NumPerMsr2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.SpecPrice)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.isSrvCall)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PQTReqQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PcQuantity)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LinManClsd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.VatGrpSrc)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.NoInvtryMv)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenRtnQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.CredOrigin)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Surpluses)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DefBreak)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.Shortages)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.NeedQty)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PartRetire)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.RetireQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.RetireAPC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.RetirAPCFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.RetirAPCSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.InvQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenInvQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.EnSetCost)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.RetCost)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.DistribIS)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ISDistrb)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ISDistrbFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ISDistrbSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<INV1>()
                .Property(e => e.IsByPrdct)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.PriceEdit)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.LinePoPrss)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.FreeChrgBP)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxRelev)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ThirdParty)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.InvQtyOnly)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.ExpOpType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<INV1>()
                .Property(e => e.GPBefDisc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<ITM1>()
                .Property(e => e.Price)
                .HasPrecision(19, 6);
            modelBuilder.Entity<ITM1>()
                .Property(e => e.Ovrwritten)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<ITM1>()
                .Property(e => e.Factor)
                .HasPrecision(19, 6);
            modelBuilder.Entity<ITM1>()
                .Property(e => e.AddPrice1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<ITM1>()
                .Property(e => e.AddPrice2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<ITM1>()
                .Property(e => e.Ovrwrite1)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<ITM1>()
                .Property(e => e.Ovrwrite2)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<ITM1>()
                .Property(e => e.PriceType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.CardType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.CmpPrivate)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.Balance)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.ChecksBal)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DNotesBal)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.OrdersBal)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.CreditLine)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DebtLine)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.Discount)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.VatStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DdctStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DdctPrcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DNoteBalFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.OrderBalFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DNoteBalSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.OrderBalSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.BalTrnsfrd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.IntrstRate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.Commission)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.PrevYearAc)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.BalanceSys)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.BalanceFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.Protected)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.FatherType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup1)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup2)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup3)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup4)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup5)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup6)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup7)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup8)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup9)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup10)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup11)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup12)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup13)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup14)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup15)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup16)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup17)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup18)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup19)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup20)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup21)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup22)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup23)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup24)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup25)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup26)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup27)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup28)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup29)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup30)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup31)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup32)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup33)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup34)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup35)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup36)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup37)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup38)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup39)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup40)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup41)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup42)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup43)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup44)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup45)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup46)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup47)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup48)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup49)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup50)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup51)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup52)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup53)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup54)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup55)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup56)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup57)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup58)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup59)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup60)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup61)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup62)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup63)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.QryGroup64)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DscntRel)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.MinIntrst)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.LocMth)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.validFor)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.frozenFor)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.sEmployed)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.chainStore)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DiscInRet)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.Deleted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.BackOrder)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.PartDelivr)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.BlockDunn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.CollecAuth)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.SinglePaym)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.PaymBlock)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.SelfInvoic)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DeferrTax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.MaxAmount)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.WTLiable)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.AccCritria)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.Equ)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.TypWTReprt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.IsDomestic)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.IsResident)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.AutoCalBCG)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.UseShpdGd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.InsurOp347)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.TaxRndRule)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.ThreshOver)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.SurOver)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.OpCode347)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.ResidenNum)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.Affiliate)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.MivzExpSts)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.HierchDdct)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.CertWHT)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.CertBKeep)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.WHShaamGrp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DatevFirst)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.AutoPost)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.TaxIdIdent)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DiscRel)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.NoDiscount)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.SCAdjust)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.SefazCheck)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.free312)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.free313)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.TypeOfOp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.BlockComm)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.ExcptnlEvt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.ExpnPrfFnd)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.EdrsFromBP)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.EdrsToBP)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.EDocGenTyp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.PriceMode)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.EffecPrice)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.TxExMxVdTp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.UseBilAddr)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.NaturalPer)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.DPPStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.U_ISEInvoiceCustomer)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OCRD>()
                .Property(e => e.U_IsTcCitizen)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DocType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.CANCELED)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Handwrtten)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Printed)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DocStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.InvntSttus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.VatPercent)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.VatSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.VatSumFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DiscPrcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DiscSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DiscSumFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DocRate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DocTotal)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DocTotalFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidToDate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.GrosProfit)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.GrosProfFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PartSupply)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Confirmed)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.CreateTran)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SummryType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.UpdInvnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.UpdCardBal)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.InvntDirec)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ShowSCN)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SysRate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.CurSource)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.VatSumSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DiscSumSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DocTotalSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidSys)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FatherType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.GrosProfSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.IsICT)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Volume)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Weight)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.isCrin)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.selfInv)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.VatPaid)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.VatPaidFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.VatPaidSys)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.WddStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.TotalExpns)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.TotalExpFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.TotalExpSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Exported)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.NetProc)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.AqcsTax)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.AqcsTaxFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.AqcsTaxSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.CashDiscPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.CashDiscnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.CashDiscFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.CashDiscSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.WTSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.WTSumFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.WTSumSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.RoundDif)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.RoundDifFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.RoundDifSy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.CheckDigit)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.submitted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PoPrss)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Rounding)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.RevisionPo)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PickStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Pick)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BlockDunn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PayBlock)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.MaxDscn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Reserve)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Max1099)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpAppl)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpApplFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpApplSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DeferrTax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.WTApplied)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.WTAppliedF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BoeReserev)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.WTAppliedS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.EquVatSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.EquVatSumF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.EquVatSumS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.VATFirst)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.NnSbAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.NnSbAmntSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.NbSbAmntFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExepAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExepAmntSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExepAmntFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.CEECFlag)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseAmntSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseAmntFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.UseShpdGd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseVtAt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseVtAtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseVtAtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.NnSbVAt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.NnSbVAtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.NbSbVAtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExptVAt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExptVAtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExptVAtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.LYPmtAt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.LYPmtAtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.LYPmtAtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpAnSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpAnSys)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpAnFrgn)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAmntSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAmntFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmDrawn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmPrcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidSumFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidSumSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAppl)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmApplFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmApplSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Posted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.IsPaytoBnk)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.isIns)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BPNameOW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BillToOW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ShipToOW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.RetInvoice)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExp)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExpFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExpSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExAp)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExApF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExApS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.LastPmnTyp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.UseCorrVat)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BlkCredMmo)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.OpenForLaC)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Excised)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SrvGpPrcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DutyStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.AutoCrtFlw)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmVat)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmVatFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmVatSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAppVat)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAppVatF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAppVatS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.InsurOp347)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.IgnRelDoc)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ResidenNum)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SSIExmpt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PQTGrpHW)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ReopOriDoc)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ReopManCls)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DocManClsd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Ordered)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.NTSApprov)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PayDuMonth)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocGenTyp)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.OnlineQuo)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocProces)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocCancel)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocTest)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAsDscnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.GTSRlvnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseDisc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseDiscSc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseDiscFc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseDiscPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SrvTaxRule)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Notify)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.OriginType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.IsReuseNum)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.IsReuseNFN)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.DocDlvry)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidDpm)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidDpmF)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidDpmS)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.IsAlt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PrintSEPA)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FreeChrg)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FreeChrgFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FreeChrgSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.NfeValue)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FoCTax)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FoCTaxFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FoCTaxSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FoCFrght)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FoCFrghtFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.FoCFrghtSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Letter)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SplitTax)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SplitTaxFC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SplitTaxSC)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PriceMode)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.PoDropPrss)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ExclTaxRep)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.Revision)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ComTrade)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.UseBilAddr)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.ComTradeRt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SplitPmnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.SelfPosted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_PAZGELIRI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_KOMTUTAR)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_VADEFARKI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_REKLAMTUTARI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_KARGOBEDN11)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_KARGOBEDFINSPOR)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_IADEKARBED)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_HIZBEDELI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_GFHIZBEDELI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_IADEKOMBEDELI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_IADEKARBEDFIN)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_TEDGECHEDCEK)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_SATICIUCRETLERI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_ISLEMUCRETGIDERI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_IADETUTARI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_KAMPANYAINDTUTARI)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_IsFreeInvoice)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_ISArchived)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OINV>()
                .Property(e => e.U_EArvISDespatch)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.VATLiable)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PrchseItem)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SellItem)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.InvntItem)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.OnHand)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.IsCommited)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.OnOrder)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.MaxLevel)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.NumInBuy)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ReorderQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.MinLevel)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.LstEvlPric)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.CustomPer)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.WholSlsTax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.RetilrTax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SpcialDisc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.TrackSales)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.NumInSale)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Consig)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Counted)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.OpenBlnc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.EvalSystem)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.FREE)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BlncTrnsfr)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.CommisPcnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.CommisSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.TreeType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.TreeQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.LastPurPrc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ExitPrice)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.AssetItem)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.WasCounted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ManSerNum)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SHeight1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SHeight2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SWidth1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SWidth2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SLength1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Slength2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SVolume)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SWeight1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SWeight2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BHeight1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BHeight2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BWidth1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BWidth2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BLength1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Blength2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BVolume)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BWeight1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BWeight2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup1)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup2)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup3)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup4)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup5)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup6)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup7)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup8)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup9)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup10)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup11)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup12)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup13)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup14)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup15)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup16)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup17)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup18)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup19)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup20)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup21)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup22)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup23)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup24)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup25)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup26)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup27)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup28)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup29)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup30)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup31)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup32)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup33)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup34)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup35)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup36)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup37)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup38)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup39)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup40)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup41)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup42)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup43)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup44)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup45)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup46)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup47)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup48)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup49)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup50)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup51)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup52)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup53)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup54)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup55)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup56)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup57)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup58)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup59)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup60)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup61)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup62)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup63)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.QryGroup64)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SalFactor1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SalFactor2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SalFactor3)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SalFactor4)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PurFactor1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PurFactor2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PurFactor3)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PurFactor4)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.AvgPrice)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PurPackUn)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SalPackUn)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ManBtchNum)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ManOutOnly)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.validFor)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.frozenFor)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.BlockOut)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Deleted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.GLMethod)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.TaxType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ByWh)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.WTLiable)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ItemType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.StockValue)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Phantom)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.IssueMthd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.FREE1)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PricingPrc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.MngMethod)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ReorderPnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PlaningSys)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PrcrmntMtd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.OrdrMulti)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.MinOrdrQty)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.IndirctTax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ItemClass)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Excisable)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.AssblValue)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.StatAsset)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Cession)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.DeacAftUL)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.AsstStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.GLPickMeth)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.NoDiscount)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.MgrByQty)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.AssetAmnt1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.AssetAmnt2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.NumInCnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.OneBOneRec)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.IWeight1)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.IWeight2)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.CompoWH)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.VirtAstItm)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.InCostRoll)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.PrdStdCst)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.EnAstSeri)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.OnHldPert)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.onHldLimt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.GSTRelevnt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.GstTaxCtg)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.AssVal4WTR)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ExcFixAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.ExcRate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITM>()
                .Property(e => e.SOIExc)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.Imported)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITM>()
                .Property(e => e.AutoBatch)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITW>()
                .Property(e => e.OnHand)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.IsCommited)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.OnOrder)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.Consig)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.Counted)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.WasCounted)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITW>()
                .Property(e => e.MinStock)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.MaxStock)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.MinOrder)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.AvgPrice)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.Locked)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITW>()
                .Property(e => e.StockValue)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OITW>()
                .Property(e => e.DftBinEnfd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OITW>()
                .Property(e => e.Freezed)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.SUPERUSER)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.DISCOUNT)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.dType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.OutOfOffic)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.SendEMail)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.SendSMS)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.CashLimit)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.MaxCashSum)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.SendFax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.Locked)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.OpenCdt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.DsplyRates)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.AuImpRates)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.OpenDps)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.RcrFlag)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.CheckFiles)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.OpenCredit)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.AdvImagePr)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.ContactLog)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.ShowNewMsg)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.GENDER)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.EnbMenuFlt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.OneLogPwd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.PwdNeverEx)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.SalesDisc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.PurchDisc)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.RclFlag)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.MobileUser)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.PrsWkCntEb)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.SupportUsr)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.CUSAgree)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.ShowNewTsk)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.IntgrtEb)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.AllBrnchF)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.EvtNotify)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.IgnDtOwn)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.EnterAsTab)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.DotAsSep)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.MouseOnly)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.NaturalPer)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.DPPStatus)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OUSR>()
                .Property(e => e.AutoAsnBPL)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.Rate)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.Category)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.Locked)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.IsEC)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.Indicator)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.AcqstnRvrs)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.NonDedct)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.GoddsShip)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.EquVatPr)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.FixdAssts)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.CalcMethod)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.TaxType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.FixedAmnt)
                .HasPrecision(19, 6);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.Correction)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.TaxCtgr)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.IsIGIC)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.ServSupply)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.Inactive)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.TaxCtgrBL)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.Agent)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.Export)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.SplitPaymt)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.TaxAgent)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.Parag44)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.ProrataDed)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OVTG>()
                .Property(e => e.ExcFrmTaxS)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.Locked)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.DropShip)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.UseTax)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.Nettable)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.OwnerCode)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.Excisable)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.BinActivat)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.DftBinEnfd)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.ManageSnB)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.RecBinEnab)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.RecvEmpBin)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.Inactive)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.RecvMaxQty)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.RecvMaxWT)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<OWHS>()
                .Property(e => e.External)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<RIN21>()
                .Property(e => e.RefType)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<RIN21>()
                .Property(e => e.RefAmount)
                .HasPrecision(19, 6);
        }
    }
}
