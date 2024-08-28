using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormItemPaints")]
public partial class MmproductionNormItemPaint
{
    [Key]
    [Column("MMProductionNormItemPaintID")]
    public int MmproductionNormItemPaintId { get; set; }

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

    [Column("MMProductionNormItemPaintQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPaintQty { get; set; }

    [Column("MMProductionNormItemPaintDesc")]
    [StringLength(524)]
    public string MmproductionNormItemPaintDesc { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("MmproductionNormItemPaints")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmproductionNormItemPaintFkMmproductionNorms")]
    public virtual MmproductionNormItem FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmproductionNormItemPaintFkMmproductionNormItems")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }
}
