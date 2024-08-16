using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostGeneralCostAllocationCollectDocuments")]
public partial class MmproductionCostGeneralCostAllocationCollectDocument
{
    [Key]
    [Column("MMProductionCostGeneralCostAllocationCollectDocumentID")]
    public int MmproductionCostGeneralCostAllocationCollectDocumentId { get; set; }

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

    [Column("FK_MMProductionCostGeneralCostAllocationID")]
    public int? FkMmproductionCostGeneralCostAllocationId { get; set; }

    [Column("FK_ACActualCostBudgetDetailID")]
    public int? FkAcactualCostBudgetDetailId { get; set; }

    [Column("FK_ACTransactionReferenceID")]
    public int? FkActransactionReferenceId { get; set; }

    [ForeignKey("FkAcactualCostBudgetDetailId")]
    [InverseProperty("MmproductionCostGeneralCostAllocationCollectDocuments")]
    public virtual AcactualCostBudgetDetail FkAcactualCostBudgetDetail { get; set; }

    [ForeignKey("FkMmproductionCostGeneralCostAllocationId")]
    [InverseProperty("MmproductionCostGeneralCostAllocationCollectDocuments")]
    public virtual MmproductionCostGeneralCostAllocation FkMmproductionCostGeneralCostAllocation { get; set; }
}
