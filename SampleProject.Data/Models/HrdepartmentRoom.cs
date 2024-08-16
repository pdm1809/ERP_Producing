using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDepartmentRooms")]
public partial class HrdepartmentRoom
{
    [Key]
    [Column("HRDepartmentRoomID")]
    public int HrdepartmentRoomId { get; set; }

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

    [Column("FK_HRDepartmentID")]
    public int FkHrdepartmentId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("HRDepartmentRoomNo")]
    [StringLength(50)]
    public string HrdepartmentRoomNo { get; set; }

    [Column("HRDepartmentRoomName")]
    [StringLength(50)]
    public string HrdepartmentRoomName { get; set; }

    [Column("HRDepartmentRoomDesc")]
    [StringLength(512)]
    public string HrdepartmentRoomDesc { get; set; }

    [Column("HRDepartmentRoomIntend")]
    public int? HrdepartmentRoomIntend { get; set; }

    [Column("HRDepartmentRoomBoundary", TypeName = "decimal(18, 5)")]
    public decimal? HrdepartmentRoomBoundary { get; set; }

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Acasset> AcassetFkHrdepartmentRooms { get; set; } = new List<Acasset>();

    [InverseProperty("FkHrinitRoom")]
    public virtual ICollection<Acasset> AcassetFkHrinitRooms { get; set; } = new List<Acasset>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItemFkHrdepartmentRooms { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkHrfromRoom")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItemFkHrfromRooms { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkHrtoRoom")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItemFkHrtoRooms { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AccostObjectItem> AccostObjectItems { get; set; } = new List<AccostObjectItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItemFkHrdepartmentRooms { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkHrfromRoom")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItemFkHrfromRooms { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkHrtoRoom")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItemFkHrtoRooms { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AcsalaryEntryTypeDetailPart> AcsalaryEntryTypeDetailParts { get; set; } = new List<AcsalaryEntryTypeDetailPart>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AdremindWorking> AdremindWorkings { get; set; } = new List<AdremindWorking>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AdtargetReportBudget> AdtargetReportBudgets { get; set; } = new List<AdtargetReportBudget>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<ApcancelPurchaseProposal> ApcancelPurchaseProposals { get; set; } = new List<ApcancelPurchaseProposal>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Approposal> Approposals { get; set; } = new List<Approposal>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<ArdeliveryPlanTruck> ArdeliveryPlanTrucks { get; set; } = new List<ArdeliveryPlanTruck>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<ArproposalItemWorkTask> ArproposalItemWorkTasks { get; set; } = new List<ArproposalItemWorkTask>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrdepartmentRooms")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrdepartmentRooms")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Hrauthorization> Hrauthorizations { get; set; } = new List<Hrauthorization>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HrbonusSaleItem> HrbonusSaleItems { get; set; } = new List<HrbonusSaleItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HrdepartmentRoomGroupTeam> HrdepartmentRoomGroupTeams { get; set; } = new List<HrdepartmentRoomGroupTeam>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HrdepartmentRoomGroup> HrdepartmentRoomGroups { get; set; } = new List<HrdepartmentRoomGroup>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HrdepartmentRoomLeaveDayConfig> HrdepartmentRoomLeaveDayConfigs { get; set; } = new List<HrdepartmentRoomLeaveDayConfig>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeArrangementShift> HremployeeArrangementShifts { get; set; } = new List<HremployeeArrangementShift>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeContract> HremployeeContracts { get; set; } = new List<HremployeeContract>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeDiscipline> HremployeeDisciplines { get; set; } = new List<HremployeeDiscipline>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeKpievaluationItem> HremployeeKpievaluationItems { get; set; } = new List<HremployeeKpievaluationItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeKpiregistrationItem> HremployeeKpiregistrationItems { get; set; } = new List<HremployeeKpiregistrationItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeOt> HremployeeOts { get; set; } = new List<HremployeeOt>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeePayRollAudit> HremployeePayRollAudits { get; set; } = new List<HremployeePayRollAudit>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeePayRoll> HremployeePayRolls { get; set; } = new List<HremployeePayRoll>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeePieceWageItem> HremployeePieceWageItems { get; set; } = new List<HremployeePieceWageItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeSalaryConfig> HremployeeSalaryConfigs { get; set; } = new List<HremployeeSalaryConfig>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeTimeSheetAudit> HremployeeTimeSheetAudits { get; set; } = new List<HremployeeTimeSheetAudit>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeTimeSheet> HremployeeTimeSheets { get; set; } = new List<HremployeeTimeSheet>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranfers { get; set; } = new List<HremployeeTranfer>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeTransmitItem> HremployeeTransmitItems { get; set; } = new List<HremployeeTransmitItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HremployeeTransmit> HremployeeTransmits { get; set; } = new List<HremployeeTransmit>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Hrkpievaluation> Hrkpievaluations { get; set; } = new List<Hrkpievaluation>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HrkpiformItem> HrkpiformItems { get; set; } = new List<HrkpiformItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Hrkpiform> Hrkpiforms { get; set; } = new List<Hrkpiform>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Hrkpiregistration> Hrkpiregistrations { get; set; } = new List<Hrkpiregistration>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Hrkpi> Hrkpis { get; set; } = new List<Hrkpi>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HrlabouringConfigItem> HrlabouringConfigItems { get; set; } = new List<HrlabouringConfigItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HrrecruitmentNeed> HrrecruitmentNeeds { get; set; } = new List<HrrecruitmentNeed>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<HrrecruitmentPlan> HrrecruitmentPlans { get; set; } = new List<HrrecruitmentPlan>();

    [InverseProperty("HrrequestEditEmployeeDepartmentRoom")]
    public virtual ICollection<HrrequestEditEmployee> HrrequestEditEmployees { get; set; } = new List<HrrequestEditEmployee>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<IcproductTask> IcproductTasks { get; set; } = new List<IcproductTask>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Ictask> Ictasks { get; set; } = new List<Ictask>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Ictransfer> Ictransfers { get; set; } = new List<Ictransfer>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<MmbpoperationDepartment> MmbpoperationDepartments { get; set; } = new List<MmbpoperationDepartment>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<Mmproposal> Mmproposals { get; set; } = new List<Mmproposal>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<PmbuidingCommand> PmbuidingCommands { get; set; } = new List<PmbuidingCommand>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<PmbuidingProposal> PmbuidingProposals { get; set; } = new List<PmbuidingProposal>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();

    [InverseProperty("FkHrdepartmentRoom")]
    public virtual ICollection<PmtemplateItemTask> PmtemplateItemTasks { get; set; } = new List<PmtemplateItemTask>();
}
