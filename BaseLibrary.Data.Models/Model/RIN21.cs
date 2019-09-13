namespace BaseLibrary.Data.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public partial class RIN21
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DocEntry { get; set; }
        [StringLength(20)]
        public string ObjectType { get; set; }
        public int? LogInstanc { get; set; }
        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string RefType { get; set; }
        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineNum { get; set; }
        public int? RefDocEntr { get; set; }
        public int? RefDocNum { get; set; }
        [StringLength(100)]
        public string ExtDocNum { get; set; }
        [StringLength(20)]
        public string RefObjType { get; set; }
        [StringLength(100)]
        public string AccessKey { get; set; }
        public DateTime? IssueDate { get; set; }
        [StringLength(100)]
        public string IssuerCNPJ { get; set; }
        [StringLength(10)]
        public string IssuerCode { get; set; }
        [StringLength(6)]
        public string Model { get; set; }
        [StringLength(3)]
        public string Series { get; set; }
        public int? Number { get; set; }
        [StringLength(100)]
        public string RefAccKey { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? RefAmount { get; set; }
        [StringLength(3)]
        public string SubSeries { get; set; }
        [StringLength(254)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string LinkRefTyp { get; set; }
    }
}
