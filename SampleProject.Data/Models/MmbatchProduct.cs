using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProducts")]
public partial class MmbatchProduct
{
    [Key]
    [Column("MMBatchProductID")]
    public int MmbatchProductId { get; set; }

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
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_MMProposalID")]
    public int? FkMmproposalId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_HREmployeeIDValidated")]
    public int? FkHremployeeIdvalidated { get; set; }

    [Column("FK_HREmployeeWoodApprove")]
    public int? FkHremployeeWoodApprove { get; set; }

    [Column("FK_HREmployeeHWApprove")]
    public int? FkHremployeeHwapprove { get; set; }

    [Column("FK_HREmployeePaintApprove")]
    public int? FkHremployeePaintApprove { get; set; }

    [Column("FK_HREmployeePackagingApprove")]
    public int? FkHremployeePackagingApprove { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("MMBatchProductValidatedDate", TypeName = "datetime")]
    public DateTime? MmbatchProductValidatedDate { get; set; }

    [Column("MMBatchProductWoodApproveDate", TypeName = "datetime")]
    public DateTime? MmbatchProductWoodApproveDate { get; set; }

    [Column("MMBatchProductHWApproveDate", TypeName = "datetime")]
    public DateTime? MmbatchProductHwapproveDate { get; set; }

    [Column("MMBatchProductPaintApproveDate", TypeName = "datetime")]
    public DateTime? MmbatchProductPaintApproveDate { get; set; }

    [Column("MMBatchProductPackagingApproveDate", TypeName = "datetime")]
    public DateTime? MmbatchProductPackagingApproveDate { get; set; }

    [Required]
    [Column("MMBatchProductNo")]
    [StringLength(50)]
    public string MmbatchProductNo { get; set; }

    [Column("MMBatchProductDesc")]
    [StringLength(512)]
    public string MmbatchProductDesc { get; set; }

    [Column("MMBatchProductRequirement")]
    [StringLength(512)]
    public string MmbatchProductRequirement { get; set; }

    [Column("MMBatchProductDate", TypeName = "datetime")]
    public DateTime? MmbatchProductDate { get; set; }

    [Column("MMBatchProductDeliveryDate", TypeName = "datetime")]
    public DateTime? MmbatchProductDeliveryDate { get; set; }

    [Column("MMBatchProductFromDate", TypeName = "datetime")]
    public DateTime? MmbatchProductFromDate { get; set; }

    [Column("MMBatchProductToDate", TypeName = "datetime")]
    public DateTime? MmbatchProductToDate { get; set; }

    [Column("MMBatchProductStatus")]
    [StringLength(50)]
    public string MmbatchProductStatus { get; set; }

    [Column("MMBatchProductType")]
    [StringLength(50)]
    public string MmbatchProductType { get; set; }

    [Column("MMPriority")]
    [StringLength(50)]
    public string Mmpriority { get; set; }

    [Column("MMBatchProductWoodStatus")]
    [StringLength(50)]
    public string MmbatchProductWoodStatus { get; set; }

    [Column("MMBatchProductHWStatus")]
    [StringLength(50)]
    public string MmbatchProductHwstatus { get; set; }

    [Column("MMBatchProductPaintStatus")]
    [StringLength(50)]
    public string MmbatchProductPaintStatus { get; set; }

    [Column("MMBatchProductPackagingStatus")]
    [StringLength(50)]
    public string MmbatchProductPackagingStatus { get; set; }

    [Column("MMBatchProductResourceType")]
    [StringLength(50)]
    public string MmbatchProductResourceType { get; set; }

    [Column("MMBatchProductSaleOrderNo")]
    [StringLength(50)]
    public string MmbatchProductSaleOrderNo { get; set; }

    [Column("FK_HREmployeeOperationApprove")]
    public int? FkHremployeeOperationApprove { get; set; }

    [Column("MMBatchProductOperationApproveDate", TypeName = "datetime")]
    public DateTime? MmbatchProductOperationApproveDate { get; set; }

    [Column("MMBatchProductOperationStatus")]
    [StringLength(50)]
    public string MmbatchProductOperationStatus { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMBatchProductDatePrint")]
    public int? MmbatchProductDatePrint { get; set; }

    [Column("MMBatchProductPONo")]
    [StringLength(50)]
    public string MmbatchProductPono { get; set; }

    [Column("MMBatchProductDeliveryStatus")]
    [StringLength(50)]
    public string MmbatchProductDeliveryStatus { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("MMBatchProductRealDate", TypeName = "datetime")]
    public DateTime? MmbatchProductRealDate { get; set; }

    [Column("MMBatchProductGeneralMaterialStatus")]
    [StringLength(50)]
    public string MmbatchProductGeneralMaterialStatus { get; set; }

    [Column("MMBatchProductVersion")]
    public int? MmbatchProductVersion { get; set; }

    [Column("MMBatchProductGeneralMaterialApproveDate", TypeName = "datetime")]
    public DateTime? MmbatchProductGeneralMaterialApproveDate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("MMObjectType")]
    [StringLength(50)]
    public string MmobjectType { get; set; }

    [Column("FK_MMProductionCostFormulaID")]
    public int? FkMmproductionCostFormulaId { get; set; }

    [Column("MMBatchProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductPerimeter { get; set; }

    [Column("MMBatchProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductWoodQty { get; set; }

    [Column("MMBatchProductWorkShop")]
    [StringLength(100)]
    public string MmbatchProductWorkShop { get; set; }

    [Column("MMBatchProductMultiCustomer")]
    [StringLength(2000)]
    public string MmbatchProductMultiCustomer { get; set; }

    [Column("FK_HREmployeeGeneralMaterialApprove")]
    public int? FkHremployeeGeneralMaterialApprove { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_ARProductionPlanningID")]
    public int? FkArproductionPlanningId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ADUserIDClosed")]
    public int? FkAduserIdclosed { get; set; }

    [Column("MMBatchProductClosedDate", TypeName = "datetime")]
    public DateTime? MmbatchProductClosedDate { get; set; }

    [Column("MMBatchProductSaleType")]
    [StringLength(50)]
    public string MmbatchProductSaleType { get; set; }

    [Column("MMBatchProductSOName")]
    [StringLength(256)]
    public string MmbatchProductSoname { get; set; }

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ApallocationCost> ApallocationCosts { get; set; } = new List<ApallocationCost>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ApcancelPurchaseProposal> ApcancelPurchaseProposals { get; set; } = new List<ApcancelPurchaseProposal>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<Approposal> Approposals { get; set; } = new List<Approposal>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ArcontainerLoader> ArcontainerLoaders { get; set; } = new List<ArcontainerLoader>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmbatchProducts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArproductionPlanningId")]
    [InverseProperty("MmbatchProducts")]
    public virtual ArproductionPlanning FkArproductionPlanning { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmbatchProducts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmbatchProducts")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmbatchProducts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmbatchProducts")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("MmbatchProducts")]
    public virtual Mmproposal FkMmproposal { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmbatchProducts")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<IcproductSeries> IcproductSeries { get; set; } = new List<IcproductSeries>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkMmbatchProductTransfer")]
    public virtual ICollection<Icreceipt> IcreceiptFkMmbatchProductTransfers { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<Icreceipt> IcreceiptFkMmbatchProducts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkMmbatchProductTransfer")]
    public virtual ICollection<Icshipment> IcshipmentFkMmbatchProductTransfers { get; set; } = new List<Icshipment>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<Icshipment> IcshipmentFkMmbatchProducts { get; set; } = new List<Icshipment>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<IcshipmentProposal> IcshipmentProposals { get; set; } = new List<IcshipmentProposal>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<Ictransfer> Ictransfers { get; set; } = new List<Ictransfer>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchItemPlan> MmbatchItemPlans { get; set; } = new List<MmbatchItemPlan>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductCompletionPercentage> MmbatchProductCompletionPercentages { get; set; } = new List<MmbatchProductCompletionPercentage>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductInputItem> MmbatchProductInputItems { get; set; } = new List<MmbatchProductInputItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductItemGeneralPlan> MmbatchProductItemGeneralPlans { get; set; } = new List<MmbatchProductItemGeneralPlan>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductItemOperation> MmbatchProductItemOperations { get; set; } = new List<MmbatchProductItemOperation>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductItemOutSourcing> MmbatchProductItemOutSourcings { get; set; } = new List<MmbatchProductItemOutSourcing>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItems { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductProductionNormItemEquipment> MmbatchProductProductionNormItemEquipments { get; set; } = new List<MmbatchProductProductionNormItemEquipment>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductProductionNormItemHardware> MmbatchProductProductionNormItemHardwares { get; set; } = new List<MmbatchProductProductionNormItemHardware>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductProductionNormItemMeterial> MmbatchProductProductionNormItemMeterials { get; set; } = new List<MmbatchProductProductionNormItemMeterial>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductProductionNormItemPaint> MmbatchProductProductionNormItemPaints { get; set; } = new List<MmbatchProductProductionNormItemPaint>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbatchProductProductionNormItem> MmbatchProductProductionNormItems { get; set; } = new List<MmbatchProductProductionNormItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmbpoperationDepartment> MmbpoperationDepartments { get; set; } = new List<MmbpoperationDepartment>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmcalculatorProductionNormCost> MmcalculatorProductionNormCosts { get; set; } = new List<MmcalculatorProductionNormCost>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmcalculatorProductionNormItem> MmcalculatorProductionNormItems { get; set; } = new List<MmcalculatorProductionNormItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; } = new List<MmcancelAllocationPlan>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlans { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmchangeBominformation> MmchangeBominformations { get; set; } = new List<MmchangeBominformation>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmchangeDeliveryDateBatchProductItem> MmchangeDeliveryDateBatchProductItems { get; set; } = new List<MmchangeDeliveryDateBatchProductItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmchangeDeliveryDateBatchProduct> MmchangeDeliveryDateBatchProducts { get; set; } = new List<MmchangeDeliveryDateBatchProduct>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetails { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MminProgressStatistic> MminProgressStatistics { get; set; } = new List<MminProgressStatistic>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmmergeBomchangeBatchProduct> MmmergeBomchangeBatchProducts { get; set; } = new List<MmmergeBomchangeBatchProduct>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmmergeBomchangeItemMaterialBomlog> MmmergeBomchangeItemMaterialBomlogs { get; set; } = new List<MmmergeBomchangeItemMaterialBomlog>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmmergeBomchangeItemMaterialBplog> MmmergeBomchangeItemMaterialBplogs { get; set; } = new List<MmmergeBomchangeItemMaterialBplog>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmmergeBomchangeItemProcessBomlog> MmmergeBomchangeItemProcessBomlogs { get; set; } = new List<MmmergeBomchangeItemProcessBomlog>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmmergeBomchangeItemProcessBplog> MmmergeBomchangeItemProcessBplogs { get; set; } = new List<MmmergeBomchangeItemProcessBplog>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItems { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmoperationDetailPlanItemChild> MmoperationDetailPlanItemChildren { get; set; } = new List<MmoperationDetailPlanItemChild>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; } = new List<MmoperationDetailPlanItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmprintRouting> MmprintRoutings { get; set; } = new List<MmprintRouting>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductionCostCalculationDetailCost> MmproductionCostCalculationDetailCosts { get; set; } = new List<MmproductionCostCalculationDetailCost>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; } = new List<MmproductionCostCalculationPrice>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductionCostIngredientCostDd> MmproductionCostIngredientCostDds { get; set; } = new List<MmproductionCostIngredientCostDd>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductionCostOtherFee> MmproductionCostOtherFees { get; set; } = new List<MmproductionCostOtherFee>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmproductionCostOverall> MmproductionCostOveralls { get; set; } = new List<MmproductionCostOverall>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItems { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItems { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmpurchasePlanTracking> MmpurchasePlanTrackings { get; set; } = new List<MmpurchasePlanTracking>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlans { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmsemiProductIngredientItem> MmsemiProductIngredientItems { get; set; } = new List<MmsemiProductIngredientItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmsemiProductIngredient> MmsemiProductIngredients { get; set; } = new List<MmsemiProductIngredient>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmwoodPlanItemDetail> MmwoodPlanItemDetails { get; set; } = new List<MmwoodPlanItemDetail>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItems { get; set; } = new List<MmwoodPlanItem>();

    [InverseProperty("FkMmbatchProduct")]
    public virtual ICollection<MmwoodPlan> MmwoodPlans { get; set; } = new List<MmwoodPlan>();
}
