using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormItemPackings")]
public partial class MmproductionNormItemPacking
{
    [Key]
    [Column("MMProductionNormItemPackingID")]
    public int MmproductionNormItemPackingId { get; set; }

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

    [Column("FK_MMProductionNormID")]
    public int FkMmproductionNormId { get; set; }

    [Column("FK_MMProductionNormItemSemiProductID")]
    public int? FkMmproductionNormItemSemiProductId { get; set; }

    [Column("FK_MMProductionNormItemPackagingID")]
    public int? FkMmproductionNormItemPackagingId { get; set; }

    [Column("MMProductionNormItemPackingQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPackingQuantity { get; set; }

    [Column("FK_ICProductPackageID")]
    public int? FkIcproductPackageId { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmproductionNormItemPackings")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }
}
