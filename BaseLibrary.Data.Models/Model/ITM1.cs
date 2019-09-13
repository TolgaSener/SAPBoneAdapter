namespace BaseLibrary.Data.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public partial class ITM1
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PriceList { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        [StringLength(1)]
        public string Ovrwritten { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? Factor { get; set; }
        public int? LogInstanc { get; set; }
        [StringLength(20)]
        public string ObjType { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? AddPrice1 { get; set; }
        [StringLength(3)]
        public string Currency1 { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? AddPrice2 { get; set; }
        [StringLength(3)]
        public string Currency2 { get; set; }
        [StringLength(1)]
        public string Ovrwrite1 { get; set; }
        [StringLength(1)]
        public string Ovrwrite2 { get; set; }
        public short? BasePLNum { get; set; }
        public int? UomEntry { get; set; }
        [StringLength(1)]
        public string PriceType { get; set; }
    }
}
