using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICImportStockMinMaxs")]
public partial class IcimportStockMinMax
{
    [Key]
    [Column("ICImportStockMinMaxID")]
    public int IcimportStockMinMaxId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ICImportStockMinMaxProductNo")]
    [StringLength(50)]
    public string IcimportStockMinMaxProductNo { get; set; }

    [Column("ICImportStockMinMaxStockMinQty", TypeName = "decimal(18, 5)")]
    public decimal? IcimportStockMinMaxStockMinQty { get; set; }

    [Column("ICImportStockMinMaxStockMaxQty", TypeName = "decimal(18, 5)")]
    public decimal? IcimportStockMinMaxStockMaxQty { get; set; }

    [Column("ICImportStockMinMaxStockMaxFromDate", TypeName = "datetime")]
    public DateTime? IcimportStockMinMaxStockMaxFromDate { get; set; }

    [Column("ICImportStockMinMaxStockMaxFromTo", TypeName = "datetime")]
    public DateTime? IcimportStockMinMaxStockMaxFromTo { get; set; }

    [Column("ICImportStockMinMaxStockMinFromDate", TypeName = "datetime")]
    public DateTime? IcimportStockMinMaxStockMinFromDate { get; set; }

    [Column("ICImportStockMinMaxStockMinFromTo", TypeName = "datetime")]
    public DateTime? IcimportStockMinMaxStockMinFromTo { get; set; }

    [Column("ICImportStockMinMaxStatus")]
    [StringLength(50)]
    public string IcimportStockMinMaxStatus { get; set; }

    [Column("ICImportStockMinMaxStockImportDate", TypeName = "datetime")]
    public DateTime? IcimportStockMinMaxStockImportDate { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcimportStockMinMaxes")]
    public virtual Icproduct FkIcproduct { get; set; }
}
