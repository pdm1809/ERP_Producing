using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDepartments")]
[Microsoft.EntityFrameworkCore.Index("HrdepartmentNo", Name = "Idx_HRDepartments")]
public partial class Hrdepartment
{
    [Key]
    [Column("HRDepartmentID")]
    public int HrdepartmentId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("HRDepartmentNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrdepartmentNo { get; set; }

    [Column("HRDepartmentName")]
    [StringLength(50)]
    public string HrdepartmentName { get; set; }

    [Column("HRDepartmentDesc")]
    [StringLength(255)]
    public string HrdepartmentDesc { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("HRDepartmentTotalEmployee", TypeName = "decimal(18, 5)")]
    public decimal? HrdepartmentTotalEmployee { get; set; }

    [Column("HRDepartmentIsBatch")]
    public bool? HrdepartmentIsBatch { get; set; }

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItemFkHrdepartments { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkHrtoDepartment")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItemFkHrtoDepartments { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AccostBudgetDetail> AccostBudgetDetails { get; set; } = new List<AccostBudgetDetail>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AccostObjectItem> AccostObjectItems { get; set; } = new List<AccostObjectItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItemFkHrdepartments { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkHrfromDepartment")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItemFkHrfromDepartments { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AcsalaryEntryTypeDetailPart> AcsalaryEntryTypeDetailParts { get; set; } = new List<AcsalaryEntryTypeDetailPart>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AdremindWorking> AdremindWorkings { get; set; } = new List<AdremindWorking>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AdtargetReportBudget> AdtargetReportBudgets { get; set; } = new List<AdtargetReportBudget>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<ApcancelPurchaseProposal> ApcancelPurchaseProposals { get; set; } = new List<ApcancelPurchaseProposal>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Approposal> Approposals { get; set; } = new List<Approposal>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<ArdeliveryPlanTruck> ArdeliveryPlanTrucks { get; set; } = new List<ArdeliveryPlanTruck>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<ArproposalItemWorkTask> ArproposalItemWorkTasks { get; set; } = new List<ArproposalItemWorkTask>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Hrdepartments")]
    public virtual Brbranch FkBrbranch { get; set; }

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Hrauthorization> Hrauthorizations { get; set; } = new List<Hrauthorization>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrbonusSaleItem> HrbonusSaleItems { get; set; } = new List<HrbonusSaleItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrdepartmentRoomGroupTeam> HrdepartmentRoomGroupTeams { get; set; } = new List<HrdepartmentRoomGroupTeam>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrdepartmentRoomGroup> HrdepartmentRoomGroups { get; set; } = new List<HrdepartmentRoomGroup>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrdepartmentRoom> HrdepartmentRooms { get; set; } = new List<HrdepartmentRoom>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeeContract> HremployeeContracts { get; set; } = new List<HremployeeContract>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeeKpievaluationItem> HremployeeKpievaluationItems { get; set; } = new List<HremployeeKpievaluationItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeeKpiregistrationItem> HremployeeKpiregistrationItems { get; set; } = new List<HremployeeKpiregistrationItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeeOt> HremployeeOts { get; set; } = new List<HremployeeOt>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeePayRollAudit> HremployeePayRollAudits { get; set; } = new List<HremployeePayRollAudit>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeePayRoll> HremployeePayRolls { get; set; } = new List<HremployeePayRoll>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeePieceWageItem> HremployeePieceWageItems { get; set; } = new List<HremployeePieceWageItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeeSalaryConfig> HremployeeSalaryConfigs { get; set; } = new List<HremployeeSalaryConfig>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranfers { get; set; } = new List<HremployeeTranfer>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HremployeeTransmit> HremployeeTransmits { get; set; } = new List<HremployeeTransmit>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Hrkpievaluation> Hrkpievaluations { get; set; } = new List<Hrkpievaluation>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrkpiformItem> HrkpiformItems { get; set; } = new List<HrkpiformItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Hrkpiform> Hrkpiforms { get; set; } = new List<Hrkpiform>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Hrkpiregistration> Hrkpiregistrations { get; set; } = new List<Hrkpiregistration>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Hrkpi> Hrkpis { get; set; } = new List<Hrkpi>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrlabouringConfigItem> HrlabouringConfigItems { get; set; } = new List<HrlabouringConfigItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrlevelDetail> HrlevelDetails { get; set; } = new List<HrlevelDetail>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrotherLeaveDayConfig> HrotherLeaveDayConfigs { get; set; } = new List<HrotherLeaveDayConfig>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrrecruitmentNeed> HrrecruitmentNeeds { get; set; } = new List<HrrecruitmentNeed>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrrecruitmentPlan> HrrecruitmentPlans { get; set; } = new List<HrrecruitmentPlan>();

    [InverseProperty("HrrequestEditEmployeeDepartment")]
    public virtual ICollection<HrrequestEditEmployee> HrrequestEditEmployees { get; set; } = new List<HrrequestEditEmployee>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<HrtimeKeeperComplete> HrtimeKeeperCompletes { get; set; } = new List<HrtimeKeeperComplete>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<IcproductTask> IcproductTasks { get; set; } = new List<IcproductTask>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Ictask> Ictasks { get; set; } = new List<Ictask>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<Ictransfer> Ictransfers { get; set; } = new List<Ictransfer>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmbpoperationDepartment> MmbpoperationDepartments { get; set; } = new List<MmbpoperationDepartment>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmconfigAccountOperation> MmconfigAccountOperations { get; set; } = new List<MmconfigAccountOperation>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MminProgressStatistic> MminProgressStatistics { get; set; } = new List<MminProgressStatistic>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmlabourProductivityTargetConfig> MmlabourProductivityTargetConfigs { get; set; } = new List<MmlabourProductivityTargetConfig>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; } = new List<MmproductionCostCalculationPrice>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmproductionCostFactorAllocationRate> MmproductionCostFactorAllocationRates { get; set; } = new List<MmproductionCostFactorAllocationRate>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmproductionCostGeneralCostAllocationDetail> MmproductionCostGeneralCostAllocationDetails { get; set; } = new List<MmproductionCostGeneralCostAllocationDetail>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<MmquantityAllocationPercentConfig> MmquantityAllocationPercentConfigs { get; set; } = new List<MmquantityAllocationPercentConfig>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();

    [InverseProperty("FkHrdepartment")]
    public virtual ICollection<PmtemplateItemTask> PmtemplateItemTasks { get; set; } = new List<PmtemplateItemTask>();
}
