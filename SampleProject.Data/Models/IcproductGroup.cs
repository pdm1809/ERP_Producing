using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductGroups")]
public partial class IcproductGroup
{
    [Key]
    [Column("ICProductGroupID")]
    public int IcproductGroupId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Required]
    [Column("ICProductGroupNo")]
    [StringLength(50)]
    public string IcproductGroupNo { get; set; }

    [Column("ICProductGroupName")]
    [StringLength(512)]
    public string IcproductGroupName { get; set; }

    [Column("ICProductGroupDesc")]
    [StringLength(512)]
    public string IcproductGroupDesc { get; set; }

    [Column("ICProductGroupParentID")]
    public int? IcproductGroupParentId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("ICProductGroupIsShowWeb")]
    public bool? IcproductGroupIsShowWeb { get; set; }

    [Column("ICProductGroupType")]
    [StringLength(50)]
    public string IcproductGroupType { get; set; }

    [Column("FK_ICProductTypeAccountConfigID")]
    public int? FkIcproductTypeAccountConfigId { get; set; }

    [Column("ICProductGroupConfigStart")]
    public int? IcproductGroupConfigStart { get; set; }

    [Column("ICProductGroupConfigLength")]
    public int? IcproductGroupConfigLength { get; set; }

    [Column("ICProductGroupConfigGroupNoLength")]
    public int? IcproductGroupConfigGroupNoLength { get; set; }

    [Column("FK_GEVATID")]
    public int? FkGevatid { get; set; }

    [Column("ICProductGroupAbbreviation")]
    [StringLength(50)]
    public string IcproductGroupAbbreviation { get; set; }

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ApsupplierProductGroupDiscount> ApsupplierProductGroupDiscounts { get; set; } = new List<ApsupplierProductGroupDiscount>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<AracceptanceItemWork> AracceptanceItemWorks { get; set; } = new List<AracceptanceItemWork>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<AradjustSaleOrderQuantityItem> AradjustSaleOrderQuantityItems { get; set; } = new List<AradjustSaleOrderQuantityItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArcancelSaleForecastItem> ArcancelSaleForecastItems { get; set; } = new List<ArcancelSaleForecastItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArcancelVoucherItemCost> ArcancelVoucherItemCosts { get; set; } = new List<ArcancelVoucherItemCost>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArcancelVoucherItem> ArcancelVoucherItems { get; set; } = new List<ArcancelVoucherItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArcustomerProductGroupDiscount> ArcustomerProductGroupDiscounts { get; set; } = new List<ArcustomerProductGroupDiscount>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArinvoiceItemWork> ArinvoiceItemWorks { get; set; } = new List<ArinvoiceItemWork>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArpriceSheetItemWork> ArpriceSheetItemWorks { get; set; } = new List<ArpriceSheetItemWork>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArproductionPlanningItem> ArproductionPlanningItems { get; set; } = new List<ArproductionPlanningItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArproposalItemWorkItem> ArproposalItemWorkItems { get; set; } = new List<ArproposalItemWorkItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArproposalItemWork> ArproposalItemWorks { get; set; } = new List<ArproposalItemWork>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArproposalTemplateItem> ArproposalTemplateItems { get; set; } = new List<ArproposalTemplateItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArsaleForecastItem> ArsaleForecastItems { get; set; } = new List<ArsaleForecastItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArsaleOrderItemWorkItem> ArsaleOrderItemWorkItems { get; set; } = new List<ArsaleOrderItemWorkItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArsaleOrderItemWork> ArsaleOrderItemWorks { get; set; } = new List<ArsaleOrderItemWork>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<ArsaleReturnItem> ArsaleReturnItems { get; set; } = new List<ArsaleReturnItem>();

    [InverseProperty("IcproductGroup")]
    public virtual ICollection<ArsellerProductGroup> ArsellerProductGroups { get; set; } = new List<ArsellerProductGroup>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<Brpositem> Brpositems { get; set; } = new List<Brpositem>();

    [ForeignKey("FkGevatid")]
    [InverseProperty("IcproductGroups")]
    public virtual Gevat FkGevat { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcproductGroups")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductTypeAccountConfigId")]
    [InverseProperty("IcproductGroups")]
    public virtual IcproductTypeAccountConfig FkIcproductTypeAccountConfig { get; set; }

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcadjustmentItem> IcadjustmentItems { get; set; } = new List<IcadjustmentItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcaverageCost> IcaverageCosts { get; set; } = new List<IcaverageCost>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcbarcodeItem> IcbarcodeItems { get; set; } = new List<IcbarcodeItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcconversionProposalItem> IcconversionProposalItems { get; set; } = new List<IcconversionProposalItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcinventoryStockCount> IcinventoryStockCounts { get; set; } = new List<IcinventoryStockCount>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcpriceAdjustmentItem> IcpriceAdjustmentItems { get; set; } = new List<IcpriceAdjustmentItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcproductAttribute> IcproductAttributes { get; set; } = new List<IcproductAttribute>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcproductConfigRate> IcproductConfigRates { get; set; } = new List<IcproductConfigRate>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcproductGroupMeasureUnit> IcproductGroupMeasureUnits { get; set; } = new List<IcproductGroupMeasureUnit>();

    [InverseProperty("FkIcproductGroupRelationChild")]
    public virtual ICollection<IcproductGroupRelation> IcproductGroupRelationFkIcproductGroupRelationChildren { get; set; } = new List<IcproductGroupRelation>();

    [InverseProperty("FkIcproductGroupRelationParent")]
    public virtual ICollection<IcproductGroupRelation> IcproductGroupRelationFkIcproductGroupRelationParents { get; set; } = new List<IcproductGroupRelation>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcpromotionItem> IcpromotionItems { get; set; } = new List<IcpromotionItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcreceiptComponentItem> IcreceiptComponentItems { get; set; } = new List<IcreceiptComponentItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcreturnShippingItem> IcreturnShippingItems { get; set; } = new List<IcreturnShippingItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IcstockConfigRate> IcstockConfigRates { get; set; } = new List<IcstockConfigRate>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItems { get; set; } = new List<IctransferProposalItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmcalculatorProductionNormCost> MmcalculatorProductionNormCosts { get; set; } = new List<MmcalculatorProductionNormCost>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; } = new List<MmcancelAllocationPlanItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmdefaultAllocationOperationConfig> MmdefaultAllocationOperationConfigs { get; set; } = new List<MmdefaultAllocationOperationConfig>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmexchangeRateConfig> MmexchangeRateConfigs { get; set; } = new List<MmexchangeRateConfig>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetails { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmnormTemplateProduct> MmnormTemplateProducts { get; set; } = new List<MmnormTemplateProduct>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmpaintProcessess> MmpaintProcessesses { get; set; } = new List<MmpaintProcessess>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproductionCostCalculationDetailCost> MmproductionCostCalculationDetailCosts { get; set; } = new List<MmproductionCostCalculationDetailCost>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; } = new List<MmproductionCostCalculationPrice>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproductionCostFormulaProduct> MmproductionCostFormulaProducts { get; set; } = new List<MmproductionCostFormulaProduct>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmproposalItem> MmproposalItems { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<MmsemiProductIngredientItem> MmsemiProductIngredientItems { get; set; } = new List<MmsemiProductIngredientItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<PmbuidingCommandItem> PmbuidingCommandItems { get; set; } = new List<PmbuidingCommandItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<PmbuidingProposalItem> PmbuidingProposalItems { get; set; } = new List<PmbuidingProposalItem>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkIcproductGroup")]
    public virtual ICollection<PmtemplateItem> PmtemplateItems { get; set; } = new List<PmtemplateItem>();
}
