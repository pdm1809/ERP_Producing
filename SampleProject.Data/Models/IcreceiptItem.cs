using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcstockId", "FkIcproductSerieId", "FkIcreceiptId", Name = "Idx_ICReceiptItems")]
public partial class IcreceiptItem
{
    [Key]
    [Column("ICReceiptItemID")]
    public int IcreceiptItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

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

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("FK_APInvoiceInItemID")]
    public int? FkApinvoiceInItemId { get; set; }

    [Column("FK_ARSaleReturnID")]
    public int? FkArsaleReturnId { get; set; }

    [Column("FK_ARSaleReturnItemID")]
    public int? FkArsaleReturnItemId { get; set; }

    [Column("ICReceiptItemProductType")]
    [StringLength(50)]
    public string IcreceiptItemProductType { get; set; }

    [Column("ICReceiptItemSortOrder")]
    public int? IcreceiptItemSortOrder { get; set; }

    [Column("ICReceiptItemProductSerialNo")]
    [StringLength(50)]
    public string IcreceiptItemProductSerialNo { get; set; }

    [Column("ICReceiptItemProductAttribute")]
    [StringLength(200)]
    public string IcreceiptItemProductAttribute { get; set; }

    [Column("ICReceiptItemProductName")]
    [StringLength(256)]
    public string IcreceiptItemProductName { get; set; }

    [Column("ICReceiptItemProductDesc")]
    [StringLength(1024)]
    public string IcreceiptItemProductDesc { get; set; }

    [Column("ICReceiptItemProductSellUnit")]
    [StringLength(50)]
    public string IcreceiptItemProductSellUnit { get; set; }

    [Column("ICReceiptItemProductBasicUnit")]
    [StringLength(50)]
    public string IcreceiptItemProductBasicUnit { get; set; }

    [Column("ICReceiptItemProductPackagingUnit")]
    [StringLength(50)]
    public string IcreceiptItemProductPackagingUnit { get; set; }

    [Column("ICReceiptItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductSellFactor { get; set; }

    [Column("ICReceiptItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductPackagingFactor { get; set; }

    [Column("ICReceiptItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductUnitPrice { get; set; }

    [Column("ICReceiptItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductUnitCost { get; set; }

    [Column("ICReceiptItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductGroupDiscount { get; set; }

    [Column("ICReceiptItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductDiscount { get; set; }

    [Column("ICReceiptItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductTaxPercent { get; set; }

    [Column("ICReceiptItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductQtyOld { get; set; }

    [Column("ICReceiptItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? IcreceiptItemProductQty { get; set; }

    [Column("ICReceiptItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductBasicQty { get; set; }

    [Column("ICReceiptItemProductPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductPackageQty { get; set; }

    [Column("ICReceiptItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemQty1 { get; set; }

    [Column("ICReceiptItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemQty2 { get; set; }

    [Column("ICReceiptItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemQty3 { get; set; }

    [Column("ICReceiptItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemQty4 { get; set; }

    [Column("ICReceiptItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemQty5 { get; set; }

    [Column("ICReceiptItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemQty6 { get; set; }

    [Column("ICReceiptItemComment")]
    [StringLength(512)]
    public string IcreceiptItemComment { get; set; }

    [Column("ICReceiptItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemUnitVolumn { get; set; }

    [Column("ICReceiptItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemUnitWeight { get; set; }

    [Column("ICReceiptItemExtCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemExtCost { get; set; }

    [Column("ICReceiptItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemDiscountAmount { get; set; }

    [Column("ICReceiptItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemTaxAmount { get; set; }

    [Column("ICReceiptItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemTotalCost { get; set; }

    [Column("ICReceiptItemProductSupplierNo")]
    [StringLength(50)]
    public string IcreceiptItemProductSupplierNo { get; set; }

    [Column("ICReceiptItemInventoryCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemInventoryCost { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_APPurchaseOrderItemID")]
    public int? FkAppurchaseOrderItemId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("ICReceiptItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductHeight { get; set; }

    [Column("ICReceiptItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductWidth { get; set; }

    [Column("ICReceiptItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductLength { get; set; }

    [Column("ICReceiptItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductPerimeter { get; set; }

    [Column("ICReceiptItemLotNo")]
    [StringLength(50)]
    public string IcreceiptItemLotNo { get; set; }

    [Column("ICReceiptItemWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? IcreceiptItemWoodQty { get; set; }

    [Column("ICReceiptItemLogListNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptItemLogListNo { get; set; }

    [Column("ICReceiptItemContainerNo")]
    [StringLength(50)]
    public string IcreceiptItemContainerNo { get; set; }

    [Column("ICReceiptItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemHeightMax { get; set; }

    [Column("ICReceiptItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemWidthMax { get; set; }

    [Column("ICReceiptItemLenghtMax", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemLenghtMax { get; set; }

    [Column("ICReceiptItemNotJetExceptBlock", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemNotJetExceptBlock { get; set; }

    [Column("ICReceiptItemExceptedBlock", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemExceptedBlock { get; set; }

    [Column("ICReceiptItemInvoiceInQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemInvoiceInQty { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [Column("FK_ICShipmentItemID")]
    public int? FkIcshipmentItemId { get; set; }

    [Column("ICReceiptItemIsSplitted")]
    public bool? IcreceiptItemIsSplitted { get; set; }

    [Column("ICReceiptItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemWidthMin { get; set; }

    [Column("ICReceiptItemLenghtMin", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemLenghtMin { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("FK_MMAllocationProposalID")]
    public int? FkMmallocationProposalId { get; set; }

    [Column("FK_MMAllocationProposalItemID")]
    public int? FkMmallocationProposalItemId { get; set; }

    [Column("ICReceiptItemBPProductionNormItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemBpproductionNormItemQty { get; set; }

    [Column("ICReceiptItemProductTotalLength", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductTotalLength { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ICReceiptItemWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemWoodFee { get; set; }

    [Column("ICReceiptItemGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemGeneralFee { get; set; }

    [Column("ICReceiptItemDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemDirectSalaryFee { get; set; }

    [Column("ICReceiptItemHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemHardwareFee { get; set; }

    [Column("ICReceiptItemPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemPaintFee { get; set; }

    [Column("ICReceiptItemMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemMaintainFee { get; set; }

    [Column("ICReceiptItemElecFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemElecFee { get; set; }

    [Column("ICReceiptItemDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemDepreciationFee { get; set; }

    [Column("ICReceiptItemOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemOtherFee { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_HRDepartmentRoomGroupID")]
    public int? FkHrdepartmentRoomGroupId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_HREmployeeUserID")]
    public int? FkHremployeeUserId { get; set; }

    [Column("FK_ICReceiptCDID")]
    public int? FkIcreceiptCdid { get; set; }

    [Column("FK_ICReceiptCDItemID")]
    public int? FkIcreceiptCditemId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("ICReceiptItemShipmentLength", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemShipmentLength { get; set; }

    [Column("ICReceiptItemShipmentPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemShipmentPerimeter { get; set; }

    [Column("ICReceiptItemShipmentQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemShipmentQty { get; set; }

    [Column("ICReceiptItemProductQtySter", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductQtySter { get; set; }

    [Column("ICReceiptItemProductUnitCostSter", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductUnitCostSter { get; set; }

    [Column("ICReceiptItemTotalCostSter", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemTotalCostSter { get; set; }

    [Column("ICReceiptItemBlockPerOne", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemBlockPerOne { get; set; }

    [Column("FK_ICImportAndExportReasonID")]
    public int? FkIcimportAndExportReasonId { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    public int? FkIcproductAttributeColorId { get; set; }

    [Column("ICReceiptItemProductAttributeColor")]
    [StringLength(255)]
    public string IcreceiptItemProductAttributeColor { get; set; }

    [Column("ICReceiptItemProductAttributeWoodType")]
    [StringLength(255)]
    public string IcreceiptItemProductAttributeWoodType { get; set; }

    [Column("ICReceiptItemProductNoOfOldSys")]
    [StringLength(100)]
    public string IcreceiptItemProductNoOfOldSys { get; set; }

    [Column("ICReceiptItemHasProductPackage")]
    public bool? IcreceiptItemHasProductPackage { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("ICReceiptItemIsSpecificCalculation")]
    public bool? IcreceiptItemIsSpecificCalculation { get; set; }

    [Column("ICReceiptItemIsAverageCalculation")]
    public bool? IcreceiptItemIsAverageCalculation { get; set; }

    [Column("ICReceiptItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemProductFactor { get; set; }

    [Column("ICReceiptItemProductExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? IcreceiptItemProductExchangeQty { get; set; }

    [Column("ICReceiptItemExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemExchangeUnitCost { get; set; }

    [Column("ICReceiptItemExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemExchangeTotalCost { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("FK_ACTransitInAccountID")]
    public int? FkActransitInAccountId { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("ICReceiptItemCode01Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode01Combo { get; set; }

    [Column("ICReceiptItemCode02Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode02Combo { get; set; }

    [Column("ICReceiptItemCode03Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode03Combo { get; set; }

    [Column("ICReceiptItemCode04Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode04Combo { get; set; }

    [Column("ICReceiptItemCode05Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode05Combo { get; set; }

    [Column("ICReceiptItemCode06Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode06Combo { get; set; }

    [Column("ICReceiptItemCode07Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode07Combo { get; set; }

    [Column("ICReceiptItemCode08Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode08Combo { get; set; }

    [Column("ICReceiptItemCode09Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode09Combo { get; set; }

    [Column("ICReceiptItemCode10Combo")]
    [StringLength(256)]
    public string IcreceiptItemCode10Combo { get; set; }

    [Column("ICReceiptItemConversionFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemConversionFactor { get; set; }

    [Column("ICReceiptItemReturnShippingType")]
    [StringLength(50)]
    public string IcreceiptItemReturnShippingType { get; set; }

    [Column("FK_ICReplaceProductID")]
    public int? FkIcreplaceProductId { get; set; }

    [Column("FK_ICSectionProductID")]
    public int? FkIcsectionProductId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_MMOperationDetailPlanCapacityItemID")]
    public int? FkMmoperationDetailPlanCapacityItemId { get; set; }

    [Column("ICReceiptItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemTotalAmount { get; set; }

    [Column("FK_APProposalItemID")]
    public int? FkApproposalItemId { get; set; }

    [Column("FK_MMMachineUnitID")]
    public int? FkMmmachineUnitId { get; set; }

    [Column("FK_ICMeasureUnitBeforeChangeID")]
    public int? FkIcmeasureUnitBeforeChangeId { get; set; }

    [Column("FK_GETerminalID")]
    public int? FkGeterminalId { get; set; }

    [Column("FK_GEContainerID")]
    public int? FkGecontainerId { get; set; }

    [Column("FK_ICPerimeterGroupID")]
    public int? FkIcperimeterGroupId { get; set; }

    [Column("FK_ICLengthGroupID")]
    public int? FkIclengthGroupId { get; set; }

    [Column("ICReceiptItemContFeesAttribution", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemContFeesAttribution { get; set; }

    [Column("FK_APBillOfLadingID")]
    public int? FkApbillOfLadingId { get; set; }

    [Column("FK_APBillOfLadingItemID")]
    public int? FkApbillOfLadingItemId { get; set; }

    [Column("ICReceiptItemProductionDate", TypeName = "datetime")]
    public DateTime? IcreceiptItemProductionDate { get; set; }

    [Column("ICReceiptItemExpiryDate", TypeName = "datetime")]
    public DateTime? IcreceiptItemExpiryDate { get; set; }

    [Column("FK_MMUpdatePositionItemID")]
    public int? FkMmupdatePositionItemId { get; set; }

    [InverseProperty("FkIcreceiptItem")]
    public virtual ICollection<ApallocationCostItem> ApallocationCostItems { get; set; } = new List<ApallocationCostItem>();

    [InverseProperty("FkIcreceiptItem")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FareceiptItem")]
    public virtual ICollection<FapurchaseOrderItemReceiptItem> FapurchaseOrderItemReceiptItems { get; set; } = new List<FapurchaseOrderItemReceiptItem>();

    [InverseProperty("FareceiptItem")]
    public virtual ICollection<FareceiptItemCreditNoteItem> FareceiptItemCreditNoteItems { get; set; } = new List<FareceiptItemCreditNoteItem>();

    [InverseProperty("FareceiptItem")]
    public virtual ICollection<FareceiptItemDiscount> FareceiptItemDiscounts { get; set; } = new List<FareceiptItemDiscount>();

    [InverseProperty("FareceiptItem")]
    public virtual ICollection<FareturnSupplierItemReceiptItem> FareturnSupplierItemReceiptItems { get; set; } = new List<FareturnSupplierItemReceiptItem>();

    [InverseProperty("FareceiptItem")]
    public virtual ICollection<FasellReturnItemReceiptItem> FasellReturnItemReceiptItems { get; set; } = new List<FasellReturnItemReceiptItem>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("IcreceiptItemFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("IcreceiptItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("IcreceiptItems")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAcoffsetAccountId")]
    [InverseProperty("IcreceiptItemFkAcoffsetAccounts")]
    public virtual Acaccount FkAcoffsetAccount { get; set; }

    [ForeignKey("FkActransitInAccountId")]
    [InverseProperty("IcreceiptItemFkActransitInAccounts")]
    public virtual Acaccount FkActransitInAccount { get; set; }

    [ForeignKey("FkApbillOfLadingId")]
    [InverseProperty("IcreceiptItems")]
    public virtual ApbillOfLading FkApbillOfLading { get; set; }

    [ForeignKey("FkApbillOfLadingItemId")]
    [InverseProperty("IcreceiptItems")]
    public virtual ApbillOfLadingItem FkApbillOfLadingItem { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("IcreceiptItems")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkAppurchaseOrderItemId")]
    [InverseProperty("IcreceiptItems")]
    public virtual AppurchaseOrderItem FkAppurchaseOrderItem { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("IcreceiptItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkGecontainerId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Gecontainer FkGecontainer { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGeterminalId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Geterminal FkGeterminal { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("IcreceiptItems")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("IcreceiptItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeUserId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Hremployee FkHremployeeUser { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcimportAndExportReasonId")]
    [InverseProperty("IcreceiptItems")]
    public virtual IcimportAndExportReason FkIcimportAndExportReason { get; set; }

    [ForeignKey("FkIclengthGroupId")]
    [InverseProperty("IcreceiptItems")]
    public virtual IclengthGroup FkIclengthGroup { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcreceiptItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("IcreceiptItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcperimeterGroupId")]
    [InverseProperty("IcreceiptItems")]
    public virtual IcperimeterGroup FkIcperimeterGroup { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcreceiptItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("IcreceiptItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("IcreceiptItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcreceiptItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("IcreceiptItemFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("IcreceiptItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcreceiptItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcreceiptItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Icreceipt FkIcreceipt { get; set; }

    [ForeignKey("FkIcreceiptCdid")]
    [InverseProperty("IcreceiptItems")]
    public virtual IcreceiptCd FkIcreceiptCd { get; set; }

    [ForeignKey("FkIcreceiptCditemId")]
    [InverseProperty("IcreceiptItems")]
    public virtual IcreceiptCditem FkIcreceiptCditem { get; set; }

    [ForeignKey("FkIcreplaceProductId")]
    [InverseProperty("IcreceiptItemFkIcreplaceProducts")]
    public virtual Icproduct FkIcreplaceProduct { get; set; }

    [ForeignKey("FkIcsectionProductId")]
    [InverseProperty("IcreceiptItemFkIcsectionProducts")]
    public virtual Icproduct FkIcsectionProduct { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Icshipment FkIcshipment { get; set; }

    [ForeignKey("FkIcshipmentItemId")]
    [InverseProperty("IcreceiptItems")]
    public virtual IcshipmentItem FkIcshipmentItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("IcreceiptItems")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("FkMmallocationProposalItemId")]
    [InverseProperty("IcreceiptItems")]
    public virtual MmallocationProposalItem FkMmallocationProposalItem { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IcreceiptItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("IcreceiptItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("IcreceiptItems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmupdatePositionItemId")]
    [InverseProperty("IcreceiptItems")]
    public virtual MmupdatePositionItem FkMmupdatePositionItem { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("IcreceiptItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("IcreceiptItems")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkIcreceiptItem")]
    public virtual ICollection<IcreceiptComponentItem> IcreceiptComponentItems { get; set; } = new List<IcreceiptComponentItem>();

    [InverseProperty("FkIcreceiptItem")]
    public virtual ICollection<IcreceiptItemLog> IcreceiptItemLogs { get; set; } = new List<IcreceiptItemLog>();

    [InverseProperty("FkIcreceiptItem")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
