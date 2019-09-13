namespace BaseLibrary.Data.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("OUSR")]
    public partial class OUSR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short USERID { get; set; }
        [StringLength(254)]
        public string PASSWORD { get; set; }
        [StringLength(8)]
        public string PASSWORD1 { get; set; }
        [StringLength(8)]
        public string PASSWORD2 { get; set; }
        public short INTERNAL_K { get; set; }
        [Required]
        [StringLength(25)]
        public string USER_CODE { get; set; }
        [StringLength(155)]
        public string U_NAME { get; set; }
        public short? GROUPS { get; set; }
        [StringLength(254)]
        public string PASSWORD4 { get; set; }
        //[Column(TypeName = "ntext")]
        //public string ALLOWENCES { get; set; }
        [StringLength(1)]
        public string SUPERUSER { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? DISCOUNT { get; set; }
        [StringLength(8)]
        public string PASSWORD3 { get; set; }
        [StringLength(4)]
        public string Info1File { get; set; }
        public short? Info1Field { get; set; }
        [StringLength(4)]
        public string Info2File { get; set; }
        public short? Info2Field { get; set; }
        [StringLength(4)]
        public string Info3File { get; set; }
        public short? Info3Field { get; set; }
        [StringLength(4)]
        public string Info4File { get; set; }
        public short? Info4Field { get; set; }
        [StringLength(1)]
        public string dType { get; set; }
        [StringLength(100)]
        public string E_Mail { get; set; }
        [StringLength(50)]
        public string PortNum { get; set; }
        [StringLength(1)]
        public string OutOfOffic { get; set; }
        [StringLength(1)]
        public string SendEMail { get; set; }
        [StringLength(1)]
        public string SendSMS { get; set; }
        [StringLength(8)]
        public string DfltsGroup { get; set; }
        [StringLength(1)]
        public string CashLimit { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? MaxCashSum { get; set; }
        [StringLength(20)]
        public string Fax { get; set; }
        [StringLength(1)]
        public string SendFax { get; set; }
        [StringLength(1)]
        public string Locked { get; set; }
        public short? Department { get; set; }
        public short? Branch { get; set; }
        //[Column(TypeName = "image")]
        //public byte[] UserPrefs { get; set; }
        public int? Language { get; set; }
        public short? Charset { get; set; }
        [StringLength(1)]
        public string OpenCdt { get; set; }
        public int? CdtPrvDays { get; set; }
        [StringLength(1)]
        public string DsplyRates { get; set; }
        [StringLength(1)]
        public string AuImpRates { get; set; }
        [StringLength(1)]
        public string OpenDps { get; set; }
        [StringLength(1)]
        public string RcrFlag { get; set; }
        [StringLength(1)]
        public string CheckFiles { get; set; }
        [StringLength(1)]
        public string OpenCredit { get; set; }
        public short? CreditDay1 { get; set; }
        public short? CreditDay2 { get; set; }
        [Column(TypeName = "ntext")]
        public string WallPaper { get; set; }
        public short? WllPprDsp { get; set; }
        [StringLength(1)]
        public string AdvImagePr { get; set; }
        [StringLength(1)]
        public string ContactLog { get; set; }
        public DateTime? LastWarned { get; set; }
        public short? AlertPolFr { get; set; }
        public short? ScreenLock { get; set; }
        [StringLength(1)]
        public string ShowNewMsg { get; set; }
        [StringLength(200)]
        public string Picture { get; set; }
        [StringLength(90)]
        public string Position { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(3)]
        public string Country { get; set; }
        [StringLength(20)]
        public string Tel1 { get; set; }
        [StringLength(20)]
        public string Tel2 { get; set; }
        [StringLength(1)]
        public string GENDER { get; set; }
        public DateTime? Birthday { get; set; }
        [StringLength(1)]
        public string EnbMenuFlt { get; set; }
        [StringLength(20)]
        public string objType { get; set; }
        public int? logInstanc { get; set; }
        public short? userSign { get; set; }
        public DateTime? createDate { get; set; }
        public short? userSign2 { get; set; }
        public DateTime? updateDate { get; set; }
        [StringLength(1)]
        public string OneLogPwd { get; set; }
        public DateTime? lastLogin { get; set; }
        [Column(TypeName = "ntext")]
        public string LastPwds { get; set; }
        [StringLength(254)]
        public string LastPwds2 { get; set; }
        public DateTime? LastPwdSet { get; set; }
        public int? FailedLog { get; set; }
        [StringLength(1)]
        public string PwdNeverEx { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? SalesDisc { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? PurchDisc { get; set; }
        public DateTime? LstLogoutD { get; set; }
        public int? LstLoginT { get; set; }
        public int? LstLogoutT { get; set; }
        public int? LstPwdChT { get; set; }
        [StringLength(8)]
        public string LstPwdChB { get; set; }
        [StringLength(1)]
        public string RclFlag { get; set; }
        [StringLength(1)]
        public string MobileUser { get; set; }
        [StringLength(64)]
        public string MobileIMEI { get; set; }
        [StringLength(1)]
        public string PrsWkCntEb { get; set; }
        public int? SnapShotId { get; set; }
        [StringLength(40)]
        public string STData { get; set; }
        [StringLength(1)]
        public string SupportUsr { get; set; }
        public short? NoSTPwdNum { get; set; }
        [StringLength(50)]
        public string DomainUser { get; set; }
        [StringLength(1)]
        public string CUSAgree { get; set; }
        [Column(TypeName = "ntext")]
        public string EmailSig { get; set; }
        public short? TPLId { get; set; }
        [Column(TypeName = "ntext")]
        public string DigCrtPath { get; set; }
        [StringLength(1)]
        public string ShowNewTsk { get; set; }
        [StringLength(1)]
        public string IntgrtEb { get; set; }
        [StringLength(1)]
        public string AllBrnchF { get; set; }
        [StringLength(1)]
        public string EvtNotify { get; set; }
        [StringLength(1)]
        public string IgnDtOwn { get; set; }
        [StringLength(1)]
        public string EnterAsTab { get; set; }
        [StringLength(1)]
        public string DotAsSep { get; set; }
        [StringLength(1)]
        public string MouseOnly { get; set; }
        public short? Color { get; set; }
        [StringLength(254)]
        public string SkinType { get; set; }
        [StringLength(50)]
        public string Font { get; set; }
        public int? FontSize { get; set; }
        [StringLength(1)]
        public string NaturalPer { get; set; }
        [StringLength(1)]
        public string DPPStatus { get; set; }
        [StringLength(1)]
        public string AutoAsnBPL { get; set; }
        [StringLength(50)]
        public string U_RedApiKey { get; set; }
    }
}
