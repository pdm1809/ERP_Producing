using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductCompletionPercentages")]
public partial class MmbatchProductCompletionPercentage
{
    [Key]
    [Column("MMBatchProductCompletionPercentageID")]
    public int MmbatchProductCompletionPercentageId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMProductionCostFactorID")]
    public int? FkMmproductionCostFactorId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMBatchProductCompletionPercentageValue", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductCompletionPercentageValue { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductCompletionPercentages")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmbatchProductCompletionPercentages")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmbatchProductCompletionPercentages")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostFactorId")]
    [InverseProperty("MmbatchProductCompletionPercentages")]
    public virtual MmproductionCostFactor FkMmproductionCostFactor { get; set; }
}
