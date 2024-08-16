using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostGeneralCostAllocations")]
public partial class MmproductionCostGeneralCostAllocation
{
    [Key]
    [Column("MMProductionCostGeneralCostAllocationID")]
    public int MmproductionCostGeneralCostAllocationId { get; set; }

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

    [Required]
    [Column("MMProductionCostGeneralCostAllocationNo")]
    [StringLength(50)]
    public string MmproductionCostGeneralCostAllocationNo { get; set; }

    [Column("MMProductionCostGeneralCostAllocationDate", TypeName = "datetime")]
    public DateTime? MmproductionCostGeneralCostAllocationDate { get; set; }

    [Column("MMProductionCostGeneralCostAllocationFromDate", TypeName = "datetime")]
    public DateTime? MmproductionCostGeneralCostAllocationFromDate { get; set; }

    [Column("MMProductionCostGeneralCostAllocationToDate", TypeName = "datetime")]
    public DateTime? MmproductionCostGeneralCostAllocationToDate { get; set; }

    [Column("MMProductionCostGeneralCostAllocationDesc")]
    [StringLength(512)]
    public string MmproductionCostGeneralCostAllocationDesc { get; set; }

    [Column("FK_MMProductionCostFactorID")]
    public int? FkMmproductionCostFactorId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("MMProductionCostGeneralCostAllocationTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostGeneralCostAllocationTotalCost { get; set; }

    [Column("MMProductionCostGeneralCostAllocationPostedStatus")]
    [StringLength(64)]
    public string MmproductionCostGeneralCostAllocationPostedStatus { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("MmproductionCostGeneralCostAllocationFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("MmproductionCostGeneralCostAllocationFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmproductionCostGeneralCostAllocations")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkMmproductionCostFactorId")]
    [InverseProperty("MmproductionCostGeneralCostAllocations")]
    public virtual MmproductionCostFactor FkMmproductionCostFactor { get; set; }

    [InverseProperty("FkMmproductionCostGeneralCostAllocation")]
    public virtual ICollection<MmproductionCostGeneralCostAllocationCollectDocument> MmproductionCostGeneralCostAllocationCollectDocuments { get; set; } = new List<MmproductionCostGeneralCostAllocationCollectDocument>();

    [InverseProperty("FkMmproductionCostGeneralCostAllocation")]
    public virtual ICollection<MmproductionCostGeneralCostAllocationDetail> MmproductionCostGeneralCostAllocationDetails { get; set; } = new List<MmproductionCostGeneralCostAllocationDetail>();
}
