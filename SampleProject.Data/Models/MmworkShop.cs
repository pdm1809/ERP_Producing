using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMWorkShops")]
public partial class MmworkShop
{
    [Key]
    [Column("MMWorkShopID")]
    public int MmworkShopId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Required]
    [Column("MMWorkShopNo")]
    [StringLength(50)]
    public string MmworkShopNo { get; set; }

    [Required]
    [Column("MMWorkShopName")]
    [StringLength(100)]
    public string MmworkShopName { get; set; }

    [Column("MMWorkShopDesc")]
    [StringLength(512)]
    public string MmworkShopDesc { get; set; }

    [Column("MMWorkShopLength", TypeName = "decimal(18, 5)")]
    public decimal? MmworkShopLength { get; set; }

    [Column("MMWorkShopWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmworkShopWidth { get; set; }

    [Column("MMWorkShopContactName")]
    [StringLength(50)]
    public string MmworkShopContactName { get; set; }

    [Column("MMWorkShopContactBirthday", TypeName = "datetime")]
    public DateTime? MmworkShopContactBirthday { get; set; }

    [Column("MMWorkShopContactFirstName")]
    [StringLength(50)]
    public string MmworkShopContactFirstName { get; set; }

    [Column("MMWorkShopContactLastName")]
    [StringLength(50)]
    public string MmworkShopContactLastName { get; set; }

    [Column("MMWorkShopContactTitle")]
    [StringLength(50)]
    public string MmworkShopContactTitle { get; set; }

    [Column("MMWorkShopContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmworkShopContactPhone { get; set; }

    [Column("MMWorkShopContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmworkShopContactCellPhone { get; set; }

    [Column("MMWorkShopContactEmail")]
    [StringLength(100)]
    public string MmworkShopContactEmail { get; set; }

    [Column("MMWorkShopContactFax")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmworkShopContactFax { get; set; }

    [Column("MMWorkShopContactDepartment")]
    [StringLength(50)]
    public string MmworkShopContactDepartment { get; set; }

    [Column("MMWorkShopContactRoom")]
    [StringLength(256)]
    public string MmworkShopContactRoom { get; set; }

    [Column("MMWorkShopActiveCheck")]
    public bool MmworkShopActiveCheck { get; set; }

    [Column("MMWorkShopGELocationName")]
    [StringLength(512)]
    public string MmworkShopGelocationName { get; set; }

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItems { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<ArproductionPlanning> ArproductionPlannings { get; set; } = new List<ArproductionPlanning>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmworkShops")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGelocationId")]
    [InverseProperty("MmworkShops")]
    public virtual Gelocation FkGelocation { get; set; }

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<HremployeeSalaryConfig> HremployeeSalaryConfigs { get; set; } = new List<HremployeeSalaryConfig>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<HremployeeTransmit> HremployeeTransmits { get; set; } = new List<HremployeeTransmit>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<HrmachineTimeKeeper> HrmachineTimeKeepers { get; set; } = new List<HrmachineTimeKeeper>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<HrtimeKeeperComplete> HrtimeKeeperCompletes { get; set; } = new List<HrtimeKeeperComplete>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<HrtimeKeeper> HrtimeKeepers { get; set; } = new List<HrtimeKeeper>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<IcconversionProposal> IcconversionProposals { get; set; } = new List<IcconversionProposal>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmbatchProductItemGeneralPlan> MmbatchProductItemGeneralPlans { get; set; } = new List<MmbatchProductItemGeneralPlan>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmbatchProduct> MmbatchProducts { get; set; } = new List<MmbatchProduct>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmbpoperationDepartment> MmbpoperationDepartments { get; set; } = new List<MmbpoperationDepartment>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmconfigAccountOperation> MmconfigAccountOperations { get; set; } = new List<MmconfigAccountOperation>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmdepartmentAndOperation> MmdepartmentAndOperations { get; set; } = new List<MmdepartmentAndOperation>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmdepartmentCapacityConfig> MmdepartmentCapacityConfigs { get; set; } = new List<MmdepartmentCapacityConfig>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmdepartmentCapacityDetail> MmdepartmentCapacityDetails { get; set; } = new List<MmdepartmentCapacityDetail>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetails { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MminProgressStatistic> MminProgressStatistics { get; set; } = new List<MminProgressStatistic>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmjobTicket> MmjobTickets { get; set; } = new List<MmjobTicket>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmlabourProductivityTargetConfig> MmlabourProductivityTargetConfigs { get; set; } = new List<MmlabourProductivityTargetConfig>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmlineOperation> MmlineOperations { get; set; } = new List<MmlineOperation>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<Mmline> Mmlines { get; set; } = new List<Mmline>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmmachineUnit> MmmachineUnits { get; set; } = new List<MmmachineUnit>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmoperationDetailPlanCancel> MmoperationDetailPlanCancels { get; set; } = new List<MmoperationDetailPlanCancel>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmoperationDetailPlanCapacity> MmoperationDetailPlanCapacities { get; set; } = new List<MmoperationDetailPlanCapacity>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItems { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; } = new List<MmoperationDetailPlanItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmoperationDetailPlan> MmoperationDetailPlans { get; set; } = new List<MmoperationDetailPlan>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmproductionCostCalculationDetailCost> MmproductionCostCalculationDetailCosts { get; set; } = new List<MmproductionCostCalculationDetailCost>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; } = new List<MmproductionCostCalculationPrice>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmproductionCostFactor> MmproductionCostFactors { get; set; } = new List<MmproductionCostFactor>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmproductionCostFormulaDetail> MmproductionCostFormulaDetails { get; set; } = new List<MmproductionCostFormulaDetail>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItems { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlans { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmquantityAllocationPercentConfig> MmquantityAllocationPercentConfigs { get; set; } = new List<MmquantityAllocationPercentConfig>();

    [InverseProperty("FkMmworkShop")]
    public virtual ICollection<MmwoodPlan> MmwoodPlans { get; set; } = new List<MmwoodPlan>();
}
