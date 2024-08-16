using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICMeasureUnits")]
public partial class IcmeasureUnit
{
    [Key]
    [Column("ICMeasureUnitID")]
    public int IcmeasureUnitId { get; set; }

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
    [Column("ICMeasureUnitNo")]
    [StringLength(50)]
    public string IcmeasureUnitNo { get; set; }

    [Required]
    [Column("ICMeasureUnitName")]
    [StringLength(50)]
    public string IcmeasureUnitName { get; set; }

    [Column("ICMeasureUnitDesc")]
    [StringLength(512)]
    public string IcmeasureUnitDesc { get; set; }

    [Column("ICMeasureUnitRoundNum")]
    public int? IcmeasureUnitRoundNum { get; set; }

    [Column("ICMeasureUnitRoundNumInBatchProduct")]
    public int? IcmeasureUnitRoundNumInBatchProduct { get; set; }

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<AcretailVatitem> AcretailVatitems { get; set; } = new List<AcretailVatitem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ApbillOfLadingItem> ApbillOfLadingItems { get; set; } = new List<ApbillOfLadingItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<AppriceSheetItem> AppriceSheetItems { get; set; } = new List<AppriceSheetItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<AppurchaseOrderItemDelivery> AppurchaseOrderItemDeliveries { get; set; } = new List<AppurchaseOrderItemDelivery>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<AppurchaseOrderItemOutSourcing> AppurchaseOrderItemOutSourcings { get; set; } = new List<AppurchaseOrderItemOutSourcing>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<AracceptanceItemWork> AracceptanceItemWorks { get; set; } = new List<AracceptanceItemWork>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<AradjustSaleOrderQuantityItem> AradjustSaleOrderQuantityItems { get; set; } = new List<AradjustSaleOrderQuantityItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArcancelSaleForecastItem> ArcancelSaleForecastItems { get; set; } = new List<ArcancelSaleForecastItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArcancelVoucherItemCost> ArcancelVoucherItemCosts { get; set; } = new List<ArcancelVoucherItemCost>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArcancelVoucherItem> ArcancelVoucherItems { get; set; } = new List<ArcancelVoucherItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArcanceledDeliveryPlanItem> ArcanceledDeliveryPlanItems { get; set; } = new List<ArcanceledDeliveryPlanItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArdeliveryPlanMachineDevice> ArdeliveryPlanMachineDevices { get; set; } = new List<ArdeliveryPlanMachineDevice>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArdeliveryPlanTruck> ArdeliveryPlanTrucks { get; set; } = new List<ArdeliveryPlanTruck>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArdeliveryPlanWorkAsset> ArdeliveryPlanWorkAssets { get; set; } = new List<ArdeliveryPlanWorkAsset>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArdeliveryPlanWork> ArdeliveryPlanWorks { get; set; } = new List<ArdeliveryPlanWork>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArinvoiceItemWork> ArinvoiceItemWorks { get; set; } = new List<ArinvoiceItemWork>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArpriceSheetItemWork> ArpriceSheetItemWorks { get; set; } = new List<ArpriceSheetItemWork>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArpriceSheetItem> ArpriceSheetItems { get; set; } = new List<ArpriceSheetItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArproductionPlanningItem> ArproductionPlanningItems { get; set; } = new List<ArproductionPlanningItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArproposalAreaItem> ArproposalAreaItems { get; set; } = new List<ArproposalAreaItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArproposalItemWorkItem> ArproposalItemWorkItems { get; set; } = new List<ArproposalItemWorkItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArproposalItemWorkTask> ArproposalItemWorkTasks { get; set; } = new List<ArproposalItemWorkTask>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArproposalItemWork> ArproposalItemWorks { get; set; } = new List<ArproposalItemWork>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArproposalTemplateItem> ArproposalTemplateItems { get; set; } = new List<ArproposalTemplateItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArsaleForecastItem> ArsaleForecastItems { get; set; } = new List<ArsaleForecastItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArsaleOrderItemWorkItem> ArsaleOrderItemWorkItems { get; set; } = new List<ArsaleOrderItemWorkItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArsaleOrderItemWork> ArsaleOrderItemWorks { get; set; } = new List<ArsaleOrderItemWork>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<ArsaleReturnItem> ArsaleReturnItems { get; set; } = new List<ArsaleReturnItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<HremployeePieceWork> HremployeePieceWorks { get; set; } = new List<HremployeePieceWork>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IccollectionItem> IccollectionItems { get; set; } = new List<IccollectionItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcconversionProposalItem> IcconversionProposalItems { get; set; } = new List<IcconversionProposalItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcfeeConfig> IcfeeConfigs { get; set; } = new List<IcfeeConfig>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcmaterialConfig> IcmaterialConfigs { get; set; } = new List<IcmaterialConfig>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcpackagingNormItem> IcpackagingNormItems { get; set; } = new List<IcpackagingNormItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcpriceAdjustmentItem> IcpriceAdjustmentItems { get; set; } = new List<IcpriceAdjustmentItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcproductApplyPriceItem> IcproductApplyPriceItems { get; set; } = new List<IcproductApplyPriceItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcproductConversionItem> IcproductConversionItems { get; set; } = new List<IcproductConversionItem>();

    [InverseProperty("FkIcproductBasicUnit")]
    public virtual ICollection<Icproduct> IcproductFkIcproductBasicUnits { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductPurchaseUnit")]
    public virtual ICollection<Icproduct> IcproductFkIcproductPurchaseUnits { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductSaleUnit")]
    public virtual ICollection<Icproduct> IcproductFkIcproductSaleUnits { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcproductMeasureUnit> IcproductMeasureUnits { get; set; } = new List<IcproductMeasureUnit>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcproductOutsourcing> IcproductOutsourcings { get; set; } = new List<IcproductOutsourcing>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcproductTask> IcproductTasks { get; set; } = new List<IcproductTask>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcproductTemplateItem> IcproductTemplateItems { get; set; } = new List<IcproductTemplateItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcproductUnit> IcproductUnits { get; set; } = new List<IcproductUnit>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcreceiptComponentItem> IcreceiptComponentItems { get; set; } = new List<IcreceiptComponentItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcreturnShippingItem> IcreturnShippingItems { get; set; } = new List<IcreturnShippingItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<Ictask> Ictasks { get; set; } = new List<Ictask>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIcbpmeasureUnit")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItemFkIcbpmeasureUnits { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItemFkIcmeasureUnits { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmbatchItemWood> MmbatchItemWoods { get; set; } = new List<MmbatchItemWood>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmbatchProductInputItem> MmbatchProductInputItems { get; set; } = new List<MmbatchProductInputItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItems { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmbatchProductProductionNormItemEquipment> MmbatchProductProductionNormItemEquipments { get; set; } = new List<MmbatchProductProductionNormItemEquipment>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmbatchProductProductionNormItemHardware> MmbatchProductProductionNormItemHardwares { get; set; } = new List<MmbatchProductProductionNormItemHardware>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmbatchProductProductionNormItemMeterial> MmbatchProductProductionNormItemMeterials { get; set; } = new List<MmbatchProductProductionNormItemMeterial>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; } = new List<MmcancelAllocationPlanItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcbpmeasureUnit")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItemFkIcbpmeasureUnits { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItemFkIcmeasureUnits { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkIcfromMeasureUnit")]
    public virtual ICollection<MmexchangeMeasureUnitConfig> MmexchangeMeasureUnitConfigFkIcfromMeasureUnits { get; set; } = new List<MmexchangeMeasureUnitConfig>();

    [InverseProperty("FkIctoMeasureUnit")]
    public virtual ICollection<MmexchangeMeasureUnitConfig> MmexchangeMeasureUnitConfigFkIctoMeasureUnits { get; set; } = new List<MmexchangeMeasureUnitConfig>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmexecuteTimeConfig> MmexecuteTimeConfigs { get; set; } = new List<MmexecuteTimeConfig>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmpaintProcessesItem> MmpaintProcessesItems { get; set; } = new List<MmpaintProcessesItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmprocessInfo> MmprocessInfos { get; set; } = new List<MmprocessInfo>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproductionNormCostFactor> MmproductionNormCostFactors { get; set; } = new List<MmproductionNormCostFactor>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproductionNormItemEquipment> MmproductionNormItemEquipments { get; set; } = new List<MmproductionNormItemEquipment>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproductionNormItemHardware> MmproductionNormItemHardwares { get; set; } = new List<MmproductionNormItemHardware>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproductionNormItemMeterial> MmproductionNormItemMeterials { get; set; } = new List<MmproductionNormItemMeterial>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproductionNormItem> MmproductionNormItems { get; set; } = new List<MmproductionNormItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmproposalItem> MmproposalItems { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItems { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkIcbpmeasureUnit")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItemFkIcbpmeasureUnits { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItemFkIcmeasureUnits { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkIcbpmeasureUnit")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotalFkIcbpmeasureUnits { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotalFkIcmeasureUnits { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmsemiProductIngredientItem> MmsemiProductIngredientItems { get; set; } = new List<MmsemiProductIngredientItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItems { get; set; } = new List<MmwoodPlanItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmbuidingCommandItem> PmbuidingCommandItems { get; set; } = new List<PmbuidingCommandItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmbuidingProposalItem> PmbuidingProposalItems { get; set; } = new List<PmbuidingProposalItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmbuildingAllocationItem> PmbuildingAllocationItems { get; set; } = new List<PmbuildingAllocationItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmbuildingPlanItem> PmbuildingPlanItems { get; set; } = new List<PmbuildingPlanItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmprojectNormItem> PmprojectNormItems { get; set; } = new List<PmprojectNormItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmtemplateItemComponent> PmtemplateItemComponents { get; set; } = new List<PmtemplateItemComponent>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmtemplateItemTask> PmtemplateItemTasks { get; set; } = new List<PmtemplateItemTask>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<PmtemplateItem> PmtemplateItems { get; set; } = new List<PmtemplateItem>();

    [InverseProperty("FkIcmeasureUnit")]
    public virtual ICollection<Vmvehicle> Vmvehicles { get; set; } = new List<Vmvehicle>();
}
