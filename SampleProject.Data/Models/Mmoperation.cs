using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperations")]
public partial class Mmoperation
{
    [Key]
    [Column("MMOperationID")]
    public int MmoperationId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("MMOperationParentID")]
    public int? MmoperationParentId { get; set; }

    [Required]
    [Column("MMOperationNo")]
    [StringLength(50)]
    public string MmoperationNo { get; set; }

    [Required]
    [Column("MMOperationName")]
    [StringLength(100)]
    public string MmoperationName { get; set; }

    [Column("MMOperationDesc")]
    [StringLength(512)]
    public string MmoperationDesc { get; set; }

    [Column("MMOperationActiveCheck")]
    public bool MmoperationActiveCheck { get; set; }

    [Column("MMOperationOrder")]
    public int? MmoperationOrder { get; set; }

    [Column("MMOperationCostCalculationCheck")]
    public bool? MmoperationCostCalculationCheck { get; set; }

    [Column("MMOperationInOutStockCheck")]
    public bool? MmoperationInOutStockCheck { get; set; }

    [Column("MMOperationGroup")]
    [StringLength(50)]
    public string MmoperationGroup { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACIngrogressAccountID")]
    public int? FkAcingrogressAccountId { get; set; }

    [Column("FK_ACCostAccountID")]
    public int? FkAccostAccountId { get; set; }

    [Column("MMOperationType")]
    [StringLength(50)]
    public string MmoperationType { get; set; }

    [Column("MMOperationCapacity")]
    public bool? MmoperationCapacity { get; set; }

    [Column("MMOperationAcronym")]
    [StringLength(50)]
    public string MmoperationAcronym { get; set; }

    [Column("MMOperationNeedQC")]
    public bool? MmoperationNeedQc { get; set; }

    [Column("MMOperationIsBeginOperation")]
    public bool? MmoperationIsBeginOperation { get; set; }

    [Column("MMOperationSyncProductCheck")]
    public bool? MmoperationSyncProductCheck { get; set; }

    [Column("MMOperationIsPlan")]
    public bool? MmoperationIsPlan { get; set; }

    [Column("FK_MMOperationSynID")]
    public int? FkMmoperationSynId { get; set; }

    [Column("MMOperationForParentSyncCheck")]
    public bool? MmoperationForParentSyncCheck { get; set; }

    [Column("MMOperationIsOutSourcing")]
    public bool? MmoperationIsOutSourcing { get; set; }

    [Column("MMOperationIsEndProcess")]
    public bool? MmoperationIsEndProcess { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<ApallocationCost> ApallocationCosts { get; set; } = new List<ApallocationCost>();

    [InverseProperty("FkMmfromOperation")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItemFkMmfromOperations { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkMmtoOperation")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItemFkMmtoOperations { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkMmfromOperation")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItemFkMmfromOperations { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkMmtoOperation")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItemFkMmtoOperations { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkMmfromOperation")]
    public virtual ICollection<ApproposalItem> ApproposalItemFkMmfromOperations { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkMmtoOperation")]
    public virtual ICollection<ApproposalItem> ApproposalItemFkMmtoOperations { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkMmfromOperation")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotalFkMmfromOperations { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkMmtoOperation")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotalFkMmtoOperations { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkMmfromOperation")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItemFkMmfromOperations { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkMmtoOperation")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItemFkMmtoOperations { get; set; } = new List<AppurchaseOrderItem>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("MmoperationFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAccostAccountId")]
    [InverseProperty("MmoperationFkAccostAccounts")]
    public virtual Acaccount FkAccostAccount { get; set; }

    [ForeignKey("FkAcingrogressAccountId")]
    [InverseProperty("MmoperationFkAcingrogressAccounts")]
    public virtual Acaccount FkAcingrogressAccount { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Mmoperations")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkMmoperationSynId")]
    [InverseProperty("InverseFkMmoperationSyn")]
    public virtual Mmoperation FkMmoperationSyn { get; set; }

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<HrbugManagement> HrbugManagements { get; set; } = new List<HrbugManagement>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<HremployeePieceWork> HremployeePieceWorks { get; set; } = new List<HremployeePieceWork>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<HrlabouringConfigItem> HrlabouringConfigItems { get; set; } = new List<HrlabouringConfigItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<IcconversionProposal> IcconversionProposals { get; set; } = new List<IcconversionProposal>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<IcproductAttributeItem> IcproductAttributeItems { get; set; } = new List<IcproductAttributeItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<IcproductItemProcesss> IcproductItemProcessses { get; set; } = new List<IcproductItemProcesss>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<IcproductSeries> IcproductSeries { get; set; } = new List<IcproductSeries>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkMmoperationSyn")]
    public virtual ICollection<Mmoperation> InverseFkMmoperationSyn { get; set; } = new List<Mmoperation>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmbatchProductCompletionPercentage> MmbatchProductCompletionPercentages { get; set; } = new List<MmbatchProductCompletionPercentage>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmbatchProductItemOperationInfo> MmbatchProductItemOperationInfos { get; set; } = new List<MmbatchProductItemOperationInfo>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmbatchProductItemOperation> MmbatchProductItemOperations { get; set; } = new List<MmbatchProductItemOperation>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmbatchProductProductionNormItemEquipment> MmbatchProductProductionNormItemEquipments { get; set; } = new List<MmbatchProductProductionNormItemEquipment>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmbatchProductProductionNormItemHardware> MmbatchProductProductionNormItemHardwares { get; set; } = new List<MmbatchProductProductionNormItemHardware>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmbatchProductProductionNormItemProcesss> MmbatchProductProductionNormItemProcessses { get; set; } = new List<MmbatchProductProductionNormItemProcesss>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmbatchProduct> MmbatchProducts { get; set; } = new List<MmbatchProduct>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmbpoperationDepartment> MmbpoperationDepartments { get; set; } = new List<MmbpoperationDepartment>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkMmfromOperation")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItemFkMmfromOperations { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkMmtoOperation")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItemFkMmtoOperations { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmconfigAccountOperation> MmconfigAccountOperations { get; set; } = new List<MmconfigAccountOperation>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmdefaultAllocationOperationConfig> MmdefaultAllocationOperationConfigs { get; set; } = new List<MmdefaultAllocationOperationConfig>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmexecuteTimeConfig> MmexecuteTimeConfigs { get; set; } = new List<MmexecuteTimeConfig>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetails { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmjobTicket> MmjobTickets { get; set; } = new List<MmjobTicket>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmlineOperation> MmlineOperations { get; set; } = new List<MmlineOperation>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmmergeBomchangeItemProcessBomlog> MmmergeBomchangeItemProcessBomlogs { get; set; } = new List<MmmergeBomchangeItemProcessBomlog>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmmergeBomchangeItemProcessBplog> MmmergeBomchangeItemProcessBplogs { get; set; } = new List<MmmergeBomchangeItemProcessBplog>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmoperationDetailPlanCancel> MmoperationDetailPlanCancels { get; set; } = new List<MmoperationDetailPlanCancel>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmoperationDetailPlanCapacity> MmoperationDetailPlanCapacities { get; set; } = new List<MmoperationDetailPlanCapacity>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItems { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmoperationDetailPlanItemChild> MmoperationDetailPlanItemChildren { get; set; } = new List<MmoperationDetailPlanItemChild>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; } = new List<MmoperationDetailPlanItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmoperationDetailPlan> MmoperationDetailPlans { get; set; } = new List<MmoperationDetailPlan>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmoperationMachineGroup> MmoperationMachineGroups { get; set; } = new List<MmoperationMachineGroup>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmoperationProduct> MmoperationProducts { get; set; } = new List<MmoperationProduct>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmprintRouting> MmprintRoutings { get; set; } = new List<MmprintRouting>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmprocessInfo> MmprocessInfos { get; set; } = new List<MmprocessInfo>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductGroupTypeSwitchingConfig> MmproductGroupTypeSwitchingConfigs { get; set; } = new List<MmproductGroupTypeSwitchingConfig>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCompletionTimeConfig> MmproductionCompletionTimeConfigs { get; set; } = new List<MmproductionCompletionTimeConfig>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionComplexityByOperation> MmproductionComplexityByOperations { get; set; } = new List<MmproductionComplexityByOperation>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostCalculationDetailCost> MmproductionCostCalculationDetailCosts { get; set; } = new List<MmproductionCostCalculationDetailCost>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; } = new List<MmproductionCostCalculationPrice>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostCalculation> MmproductionCostCalculations { get; set; } = new List<MmproductionCostCalculation>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostFactorAllocationRate> MmproductionCostFactorAllocationRates { get; set; } = new List<MmproductionCostFactorAllocationRate>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostFactor> MmproductionCostFactors { get; set; } = new List<MmproductionCostFactor>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostFormulaDetail> MmproductionCostFormulaDetails { get; set; } = new List<MmproductionCostFormulaDetail>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostFormulaOperationItem> MmproductionCostFormulaOperationItems { get; set; } = new List<MmproductionCostFormulaOperationItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostFormulaOperation> MmproductionCostFormulaOperations { get; set; } = new List<MmproductionCostFormulaOperation>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostGeneralCostAllocationDetail> MmproductionCostGeneralCostAllocationDetails { get; set; } = new List<MmproductionCostGeneralCostAllocationDetail>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostOtherFee> MmproductionCostOtherFees { get; set; } = new List<MmproductionCostOtherFee>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionCostOverall> MmproductionCostOveralls { get; set; } = new List<MmproductionCostOverall>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionNormCostFactor> MmproductionNormCostFactors { get; set; } = new List<MmproductionNormCostFactor>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionNormItemEquipment> MmproductionNormItemEquipments { get; set; } = new List<MmproductionNormItemEquipment>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionNormItemHardware> MmproductionNormItemHardwares { get; set; } = new List<MmproductionNormItemHardware>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmproductionNormItemOperation> MmproductionNormItemOperations { get; set; } = new List<MmproductionNormItemOperation>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<Mmproposal> Mmproposals { get; set; } = new List<Mmproposal>();

    [InverseProperty("FkMmfromOperation")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItemFkMmfromOperations { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkMmtoOperation")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItemFkMmtoOperations { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkMmfromOperation")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItemFkMmfromOperations { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkMmtoOperation")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItemFkMmtoOperations { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkMmfromOperation")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotalFkMmfromOperations { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmtoOperation")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotalFkMmtoOperations { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmpurchasePlanTracking> MmpurchasePlanTrackings { get; set; } = new List<MmpurchasePlanTracking>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmsemiProductIngredientItem> MmsemiProductIngredientItems { get; set; } = new List<MmsemiProductIngredientItem>();

    [InverseProperty("FkMmoperation")]
    public virtual ICollection<MmsemiProductIngredient> MmsemiProductIngredients { get; set; } = new List<MmsemiProductIngredient>();
}
