using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostFactors")]
public partial class MmproductionCostFactor
{
    [Key]
    [Column("MMProductionCostFactorID")]
    public int MmproductionCostFactorId { get; set; }

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

    [Column("MMProductionCostFactorNo")]
    [StringLength(50)]
    public string MmproductionCostFactorNo { get; set; }

    [Column("MMProductionCostFactorName")]
    [StringLength(512)]
    public string MmproductionCostFactorName { get; set; }

    [Column("FK_MMProductionCostFactorGroupID")]
    public int? FkMmproductionCostFactorGroupId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("MMProductionCostAllocationType")]
    [StringLength(100)]
    public string MmproductionCostAllocationType { get; set; }

    [Column("MMProductionCostFactorHasEndingInProgress")]
    public bool? MmproductionCostFactorHasEndingInProgress { get; set; }

    [Column("MMProductionCostInProgressCalType")]
    [StringLength(100)]
    public string MmproductionCostInProgressCalType { get; set; }

    [Column("MMProductionCostFactorIsDeduction")]
    public bool? MmproductionCostFactorIsDeduction { get; set; }

    [Column("FK_ACInProgressAccountID")]
    public int? FkAcinProgressAccountId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("MMProductionCostFactorAlias")]
    [StringLength(256)]
    public string MmproductionCostFactorAlias { get; set; }

    [Column("MMProductionCostFactorViewPermision")]
    public bool? MmproductionCostFactorViewPermision { get; set; }

    [Column("MMProductionCostFactorGroupAlias")]
    [StringLength(256)]
    public string MmproductionCostFactorGroupAlias { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("MmproductionCostFactorFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("MmproductionCostFactorFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcinProgressAccountId")]
    [InverseProperty("MmproductionCostFactorFkAcinProgressAccounts")]
    public virtual Acaccount FkAcinProgressAccount { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostFactors")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmproductionCostFactors")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmproductionCostFactor")]
    public virtual ICollection<MmbatchProductCompletionPercentage> MmbatchProductCompletionPercentages { get; set; } = new List<MmbatchProductCompletionPercentage>();

    [InverseProperty("FkMmproductionCostFactor")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetails { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkMmproductionCostFactor")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkMmproductionCostFactor")]
    public virtual ICollection<MmproductionCostCalculationDetailCost> MmproductionCostCalculationDetailCosts { get; set; } = new List<MmproductionCostCalculationDetailCost>();

    [InverseProperty("FkMmproductionCostFactor")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkMmproductionCostFactor")]
    public virtual ICollection<MmproductionCostFactorAllocationRate> MmproductionCostFactorAllocationRates { get; set; } = new List<MmproductionCostFactorAllocationRate>();

    [InverseProperty("FkMmproductionCostFactor")]
    public virtual ICollection<MmproductionCostFormulaDetail> MmproductionCostFormulaDetailFkMmproductionCostFactors { get; set; } = new List<MmproductionCostFormulaDetail>();

    [InverseProperty("FkMmrefProductionCostFactor")]
    public virtual ICollection<MmproductionCostFormulaDetail> MmproductionCostFormulaDetailFkMmrefProductionCostFactors { get; set; } = new List<MmproductionCostFormulaDetail>();

    [InverseProperty("FkMmproductionCostFactor")]
    public virtual ICollection<MmproductionCostGeneralCostAllocation> MmproductionCostGeneralCostAllocations { get; set; } = new List<MmproductionCostGeneralCostAllocation>();
}
