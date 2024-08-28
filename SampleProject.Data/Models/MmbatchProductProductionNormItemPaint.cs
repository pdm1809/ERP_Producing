using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductProductionNormItemPaints")]
public partial class MmbatchProductProductionNormItemPaint
{
    [Key]
    [Column("MMBatchProductProductionNormItemPaintID")]
    public int MmbatchProductProductionNormItemPaintId { get; set; }

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

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMBatchProductProductionNormItemPaintQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemPaintQty { get; set; }

    [Column("MMBatchProductProductionNormItemPaintDesc")]
    [StringLength(524)]
    public string MmbatchProductProductionNormItemPaintDesc { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("MmbatchProductProductionNormItemPaints")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductProductionNormItemPaints")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmbatchProductProductionNormItemPaints")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmbatchProductProductionNormItemPaints")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmbatchProductProductionNormItemPaints")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }
}
