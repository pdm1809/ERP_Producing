using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPackingMaterialMarketDimensions")]
public partial class MmpackingMaterialMarketDimension
{
    [Key]
    [Column("MMPackingMaterialMarketDimensionID")]
    public int MmpackingMaterialMarketDimensionId { get; set; }

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

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    public int? FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [Column("MMPackingMaterialMarketDimensionProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpackingMaterialMarketDimensionProductHeight { get; set; }

    [Column("MMPackingMaterialMarketDimensionProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmpackingMaterialMarketDimensionProductLength { get; set; }

    [Column("MMPackingMaterialMarketDimensionProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmpackingMaterialMarketDimensionProductWidth { get; set; }
}
