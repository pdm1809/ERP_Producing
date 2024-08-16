using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductItemOperationInfos")]
public partial class MmbatchProductItemOperationInfo
{
    [Key]
    [Column("MMBatchProductItemOperationInfoID")]
    public int MmbatchProductItemOperationInfoId { get; set; }

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

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

    [Column("FK_MMProductionNormItemOperationID")]
    public int? FkMmproductionNormItemOperationId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMBatchProductItemOperationInfoPeriod")]
    public int? MmbatchProductItemOperationInfoPeriod { get; set; }

    [Column("MMBatchProductItemOperationInfoSetupTime", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemOperationInfoSetupTime { get; set; }

    [Column("MMBatchProductItemOperationInfoProcessTime", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemOperationInfoProcessTime { get; set; }

    [Column("MMBatchProductItemOperationInfoLeadTime", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemOperationInfoLeadTime { get; set; }

    [Column("MMBatchProductItemOperationInfoCapacity", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemOperationInfoCapacity { get; set; }

    [Column("MMBatchProductItemOperationInfoDesc")]
    [StringLength(524)]
    public string MmbatchProductItemOperationInfoDesc { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_MMBatchProductItemOperationID")]
    public int? FkMmbatchProductItemOperationId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmbatchProductItemOperationInfos")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductItemOperationId")]
    [InverseProperty("MmbatchProductItemOperationInfos")]
    public virtual MmbatchProductItemOperation FkMmbatchProductItemOperation { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmbatchProductItemOperationInfos")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmbatchProductItemOperationInfos")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmbatchProductItemOperationInfos")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmbatchProductItemOperationInfos")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }

    [ForeignKey("FkMmproductionNormItemOperationId")]
    [InverseProperty("MmbatchProductItemOperationInfos")]
    public virtual MmproductionNormItemOperation FkMmproductionNormItemOperation { get; set; }
}
