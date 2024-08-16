using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInitializedInventoryStocks")]
public partial class IcinitializedInventoryStock
{
    [Key]
    [Column("ICInitializedInventoryStockID")]
    public int IcinitializedInventoryStockId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICInitializedInventoryStockUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcinitializedInventoryStockUnitCost { get; set; }

    [Column("ICInitializedInventoryStockToDate", TypeName = "datetime")]
    public DateTime? IcinitializedInventoryStockToDate { get; set; }

    [Column("ICInitializedInventoryStockQty", TypeName = "decimal(18, 0)")]
    public decimal? IcinitializedInventoryStockQty { get; set; }

    [Column("ICInitializedInventoryStockStatus")]
    [StringLength(100)]
    public string IcinitializedInventoryStockStatus { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcinitializedInventoryStocks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcinitializedInventoryStocks")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcinitializedInventoryStocks")]
    public virtual Icstock FkIcstock { get; set; }
}
