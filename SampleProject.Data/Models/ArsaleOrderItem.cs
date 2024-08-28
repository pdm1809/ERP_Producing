using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkArsaleOrderId", Name = "Idx_ARSaleOrderItems")]
public partial class ArsaleOrderItem
{
    [Key]
    [Column("ARSaleOrderItemID")]
    public int ArsaleOrderItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_ARProposalID")]
    public int? FkArproposalId { get; set; }

    [Column("FK_ARProposalItemID")]
    public int? FkArproposalItemId { get; set; }

    [Column("ARSaleOrderItemProductType")]
    [StringLength(50)]
    public string ArsaleOrderItemProductType { get; set; }

    [Column("ARSaleOrderItemProductSerialNo")]
    [StringLength(50)]
    public string ArsaleOrderItemProductSerialNo { get; set; }

    [Column("ARSaleOrderItemProductAttribute")]
    [StringLength(200)]
    public string ArsaleOrderItemProductAttribute { get; set; }

    [Column("ARSaleOrderItemSortOrder")]
    public int? ArsaleOrderItemSortOrder { get; set; }

    [Column("ARSaleOrderItemProductName")]
    [StringLength(50)]
    public string ArsaleOrderItemProductName { get; set; }

    [Column("ARSaleOrderItemProductDesc")]
    [StringLength(4000)]
    public string ArsaleOrderItemProductDesc { get; set; }

    [Column("ARSaleOrderItemProductSellUnit")]
    [StringLength(50)]
    public string ArsaleOrderItemProductSellUnit { get; set; }

    [Column("ARSaleOrderItemProductBasicUnit")]
    [StringLength(50)]
    public string ArsaleOrderItemProductBasicUnit { get; set; }

    [Column("ARSaleOrderItemProductPackagingUnit")]
    [StringLength(50)]
    public string ArsaleOrderItemProductPackagingUnit { get; set; }

    [Column("ARSaleOrderItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductSellFactor { get; set; }

    [Column("ARSaleOrderItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductPackagingFactor { get; set; }

    [Column("ARSaleOrderItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductUnitPrice { get; set; }

    [Column("ARSaleOrderItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductUnitCost { get; set; }

    [Column("ARSaleOrderItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductGroupDiscount { get; set; }

    [Column("ARSaleOrderItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductDiscount { get; set; }

    [Column("ARSaleOrderItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductTaxPercent { get; set; }

    [Column("ARSaleOrderItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductQtyOld { get; set; }

    [Column("ARSaleOrderItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductQty { get; set; }

    [Column("ARSaleOrderItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductBasicQty { get; set; }

    [Column("ARSaleOrderItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductPakagingQty { get; set; }

    [Column("ARSaleOrderItemCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemCanceledQty { get; set; }

    [Column("ARSaleOrderItemShippedQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemShippedQty { get; set; }

    [Column("ARSaleOrderItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemQty1 { get; set; }

    [Column("ARSaleOrderItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemQty2 { get; set; }

    [Column("ARSaleOrderItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemQty3 { get; set; }

    [Column("ARSaleOrderItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemQty4 { get; set; }

    [Column("ARSaleOrderItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemQty5 { get; set; }

    [Column("ARSaleOrderItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemQty6 { get; set; }

    [Column("ARSaleOrderItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemPrice { get; set; }

    [Column("ARSaleOrderItemComment")]
    [StringLength(50)]
    public string ArsaleOrderItemComment { get; set; }

    [Column("ARSaleOrderItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemUnitVolumn { get; set; }

    [Column("ARSaleOrderItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemUnitWeight { get; set; }

    [Column("ARSaleOrderItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemTaxAmount { get; set; }

    [Column("ARSaleOrderItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemDiscountAmount { get; set; }

    [Column("ARSaleOrderItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemNetAmount { get; set; }

    [Column("ARSaleOrderItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemTotalAmount { get; set; }

    [Column("ARSaleOrderItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemTotalCost { get; set; }

    [Column("ARSaleOrderItemDeliveryDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderItemDeliveryDate { get; set; }

    [Column("ARSaleOrderItemDeliveryTime", TypeName = "datetime")]
    public DateTime? ArsaleOrderItemDeliveryTime { get; set; }

    [Column("ICProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductUnitPrice { get; set; }

    [Column("ARSaleOrderItemProductSupplierNo")]
    [StringLength(50)]
    public string ArsaleOrderItemProductSupplierNo { get; set; }

    [Column("ARSaleOrderItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductLength { get; set; }

    [Column("ARSaleOrderItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductWidth { get; set; }

    [Column("ARSaleOrderItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductHeight { get; set; }

    [Column("ARSaleOrderItemProductCartonLength", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductCartonLength { get; set; }

    [Column("ARSaleOrderItemProductCartonWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductCartonWidth { get; set; }

    [Column("ARSaleOrderItemProductCartonHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductCartonHeight { get; set; }

    [Column("ARSaleOrderItemProductContainerLoading20", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductContainerLoading20 { get; set; }

    [Column("ARSaleOrderItemProductContainerLoading40", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductContainerLoading40 { get; set; }

    [Column("ARSaleOrderItemProductContainerLoadingHC", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductContainerLoadingHc { get; set; }

    [Column("ARSaleOrderItemProductFOBPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductFobprice { get; set; }

    [Column("ARSaleOrderItemProductTargetPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductTargetPrice { get; set; }

    [Column("ARSaleOrderItemQuantityOfBox", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemQuantityOfBox { get; set; }

    [Column("FK_ARSaleForecastID")]
    public int? FkArsaleForecastId { get; set; }

    [Column("FK_ARSaleForecastItemID")]
    public int? FkArsaleForecastItemId { get; set; }

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

    [Column("ARSaleOrderItemProductCustomerNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderItemProductCustomerNumber { get; set; }

    [Column("ARSaleOrderItemProposedQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProposedQty { get; set; }

    [Column("ARSaleOrderItemRemark")]
    [StringLength(500)]
    public string ArsaleOrderItemRemark { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("ARSaleOrderItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWoodQty { get; set; }

    [Column("ARSaleOrderItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemHeight { get; set; }

    [Column("ARSaleOrderItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWidth { get; set; }

    [Column("ARSaleOrderItemLength", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemLength { get; set; }

    [Column("ARSaleOrderItemPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemPerimeter { get; set; }

    [Column("ARSaleOrderItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemHeightMin { get; set; }

    [Column("ARSaleOrderItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWidthMin { get; set; }

    [Column("ARSaleOrderItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemLengthMin { get; set; }

    [Column("ARSaleOrderItemPerimeterMin", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemPerimeterMin { get; set; }

    [Column("ARSaleOrderItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemHeightMax { get; set; }

    [Column("ARSaleOrderItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWidthMax { get; set; }

    [Column("ARSaleOrderItemLentghMax", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemLentghMax { get; set; }

    [Column("ARSaleOrderItemPerimeterMax", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemPerimeterMax { get; set; }

    [Column("ARSaleOrderItemLotNo")]
    [StringLength(50)]
    public string ArsaleOrderItemLotNo { get; set; }

    [Column("FK_MMAllocationPlanID")]
    public int? FkMmallocationPlanId { get; set; }

    [Column("FK_MMAllocationPlanItemID")]
    public int? FkMmallocationPlanItemId { get; set; }

    [Column("ARSaleOrderItemProductUnitPrice2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductUnitPrice2 { get; set; }

    [Column("ARSaleOrderItemTotalAmount2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemTotalAmount2 { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("ARSaleOrderItemWoodTypeID")]
    [StringLength(50)]
    public string ArsaleOrderItemWoodTypeId { get; set; }

    [Column("ARSaleOrderItemWoodTypeText")]
    [StringLength(512)]
    public string ArsaleOrderItemWoodTypeText { get; set; }

    [Column("ARSaleOrderItemColorID")]
    [StringLength(50)]
    public string ArsaleOrderItemColorId { get; set; }

    [Column("ARSaleOrderItemColorText")]
    [StringLength(512)]
    public string ArsaleOrderItemColorText { get; set; }

    [Column("ARSaleOrderItemHTID")]
    [StringLength(50)]
    public string ArsaleOrderItemHtid { get; set; }

    [Column("ARSaleOrderItemHTText")]
    [StringLength(512)]
    public string ArsaleOrderItemHttext { get; set; }

    [Column("ARSaleOrderItemPONo")]
    [StringLength(50)]
    public string ArsaleOrderItemPono { get; set; }

    [Column("ARSaleOrderItemProductLoadContQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductLoadContQty { get; set; }

    [Column("ARSaleOrderItemProductInventoryQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductInventoryQty { get; set; }

    [Column("ARSaleOrderItemBlockPerOne", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemBlockPerOne { get; set; }

    [Column("ARSaleOrderItemBlock", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemBlock { get; set; }

    [Column("ARSaleOrderItemGrantedFrom")]
    [StringLength(256)]
    public string ArsaleOrderItemGrantedFrom { get; set; }

    [Column("ARSaleOrderItemOriginOfProduct")]
    [StringLength(256)]
    public string ArsaleOrderItemOriginOfProduct { get; set; }

    [Column("ARSaleOrderItemPOIQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemPoiqty { get; set; }

    [Column("ARSaleOrderItemPOICancelQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemPoicancelQty { get; set; }

    [Column("ARSaleOrderItemPlanQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemPlanQty { get; set; }

    [Column("ARSaleOrderItemIsAcceptance")]
    public bool? ArsaleOrderItemIsAcceptance { get; set; }

    [Column("ARSaleOrderItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ArsaleOrderItemProductNoOfOldSys { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    public int? FkIcproductAttributeColorId { get; set; }

    [Column("ARSaleOrderItemProductColorAttribute")]
    [StringLength(512)]
    public string ArsaleOrderItemProductColorAttribute { get; set; }

    [Column("FK_ICProductFormulaPriceConfigID")]
    public int? FkIcproductFormulaPriceConfigId { get; set; }

    [Column("ARSaleOrderItemFormulaPriceConfigQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemFormulaPriceConfigQty { get; set; }

    [Column("ARSaleOrderItemProductNo")]
    [StringLength(50)]
    public string ArsaleOrderItemProductNo { get; set; }

    [Column("ARSaleOrderItemOneLevelArea")]
    [StringLength(1024)]
    public string ArsaleOrderItemOneLevelArea { get; set; }

    [Column("ARSaleOrderItemTwoLevelArea")]
    [StringLength(1024)]
    public string ArsaleOrderItemTwoLevelArea { get; set; }

    [Column("ARSaleOrderItemThreeLevelArea")]
    [StringLength(1024)]
    public string ArsaleOrderItemThreeLevelArea { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("ARSaleOrderItemIsDeliveryPlan")]
    public bool? ArsaleOrderItemIsDeliveryPlan { get; set; }

    [Column("ARSaleOrderItemIsSaleOrderShipment")]
    public bool? ArsaleOrderItemIsSaleOrderShipment { get; set; }

    [Column("ARSaleOrderItemIsInvoiceAndShipment")]
    public bool? ArsaleOrderItemIsInvoiceAndShipment { get; set; }

    [Column("ARSaleOrderItemIsVehicleAllocation")]
    public bool? ArsaleOrderItemIsVehicleAllocation { get; set; }

    [Column("ARSaleOrderItemIsPromotionProduct")]
    public bool? ArsaleOrderItemIsPromotionProduct { get; set; }

    [Column("FK_ICSectionProductID")]
    public int? FkIcsectionProductId { get; set; }

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("FK_ARProposalTemplateItemID")]
    public int? FkArproposalTemplateItemId { get; set; }

    [Column("FK_ARDiscountProgramID")]
    public int? FkArdiscountProgramId { get; set; }

    [Column("FK_ARDiscountProgramItemID")]
    public int? FkArdiscountProgramItemId { get; set; }

    [Column("ARSaleOrderItemIsContainerLoader")]
    public bool? ArsaleOrderItemIsContainerLoader { get; set; }

    [Column("FK_ICLengthGroupID")]
    public int? FkIclengthGroupId { get; set; }

    [Column("FK_ICMeasureUnitBeforeChangeID")]
    public int? FkIcmeasureUnitBeforeChangeId { get; set; }

    [Column("FK_ICPerimeterGroupID")]
    public int? FkIcperimeterGroupId { get; set; }

    public bool? IsInlandItemProductName { get; set; }

    [Column("ARSaleOrderItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductFactor { get; set; }

    [Column("ARSaleOrderItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductExchangeQty { get; set; }

    [Column("ARSaleOrderItemExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemExchangeUnitCost { get; set; }

    [Column("ARSaleOrderItemExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemExchangeTotalCost { get; set; }

    [Column("ARSaleOrderItemProductCBM", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemProductCbm { get; set; }

    [Column("ARSaleOrderItemVirtualID")]
    [StringLength(50)]
    public string ArsaleOrderItemVirtualId { get; set; }

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArcancelVoucherItemCost> ArcancelVoucherItemCosts { get; set; } = new List<ArcancelVoucherItemCost>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArcancelVoucherItem> ArcancelVoucherItems { get; set; } = new List<ArcancelVoucherItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArcanceledDeliveryPlanItem> ArcanceledDeliveryPlanItems { get; set; } = new List<ArcanceledDeliveryPlanItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArdeliveryPlanMachineDevice> ArdeliveryPlanMachineDevices { get; set; } = new List<ArdeliveryPlanMachineDevice>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArdeliveryPlanWorkAsset> ArdeliveryPlanWorkAssets { get; set; } = new List<ArdeliveryPlanWorkAsset>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArdeliveryPlanWork> ArdeliveryPlanWorks { get; set; } = new List<ArdeliveryPlanWork>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArproductionPlanningItem> ArproductionPlanningItems { get; set; } = new List<ArproductionPlanningItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArsaleOrderItemWorkItem> ArsaleOrderItemWorkItems { get; set; } = new List<ArsaleOrderItemWorkItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArsaleOrderItemWork> ArsaleOrderItemWorks { get; set; } = new List<ArsaleOrderItemWork>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<ArsoitemComponent> ArsoitemComponents { get; set; } = new List<ArsoitemComponent>();

    [InverseProperty("FasellOrderItem")]
    public virtual ICollection<FaproposalItemSellOrderItem> FaproposalItemSellOrderItems { get; set; } = new List<FaproposalItemSellOrderItem>();

    [InverseProperty("FasellOrderItem")]
    public virtual ICollection<FapurchaseOrderItemSellOrderItem> FapurchaseOrderItemSellOrderItems { get; set; } = new List<FapurchaseOrderItemSellOrderItem>();

    [ForeignKey("FkAcassetId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkArsaleForecastId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual ArsaleForecast FkArsaleForecast { get; set; }

    [ForeignKey("FkArsaleForecastItemId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual ArsaleForecastItem FkArsaleForecastItem { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIclengthGroupId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual IclengthGroup FkIclengthGroup { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcperimeterGroupId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual IcperimeterGroup FkIcperimeterGroup { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsaleOrderItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeColorId")]
    [InverseProperty("ArsaleOrderItemFkIcproductAttributeColors")]
    public virtual IcproductAttribute FkIcproductAttributeColor { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("ArsaleOrderItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ArsaleOrderItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("ArsaleOrderItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("ArsaleOrderItemFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductFormulaPriceConfigId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual IcproductFormulaPriceConfig FkIcproductFormulaPriceConfig { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcsectionProductId")]
    [InverseProperty("ArsaleOrderItemFkIcsectionProducts")]
    public virtual Icproduct FkIcsectionProduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }

    [ForeignKey("FkMmallocationPlanId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual MmallocationPlan FkMmallocationPlan { get; set; }

    [ForeignKey("FkMmallocationPlanItemId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual MmallocationPlanItem FkMmallocationPlanItem { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("ArsaleOrderItems")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<IcshipmentItemSaleOrderItem> IcshipmentItemSaleOrderItems { get; set; } = new List<IcshipmentItemSaleOrderItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<MmproductionNorm> MmproductionNorms { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<MmproposalItem> MmproposalItems { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkArsaleOrderItem")]
    public virtual ICollection<PmbuidingProposalItem> PmbuidingProposalItems { get; set; } = new List<PmbuidingProposalItem>();
}
