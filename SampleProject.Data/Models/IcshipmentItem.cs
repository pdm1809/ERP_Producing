using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcstockId", "FkIcproductSerieId", "FkIcshipmentId", Name = "Idx_ICShipmentItems")]
public partial class IcshipmentItem
{
    [Key]
    [Column("ICShipmentItemID")]
    public int IcshipmentItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

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

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("FK_ARInvoiceItemID")]
    public int? FkArinvoiceItemId { get; set; }

    [Column("FK_APReturnSupplierID")]
    public int? FkApreturnSupplierId { get; set; }

    [Column("FK_APReturnSupplierItemID")]
    public int? FkApreturnSupplierItemId { get; set; }

    [Column("ICShipmentItemProductSerialNo")]
    [StringLength(50)]
    public string IcshipmentItemProductSerialNo { get; set; }

    [Column("ICShipmentItemProductType")]
    [StringLength(50)]
    public string IcshipmentItemProductType { get; set; }

    [Column("ICShipmentItemProductAttribute")]
    [StringLength(200)]
    public string IcshipmentItemProductAttribute { get; set; }

    [Column("ICShipmentItemSortOrder")]
    public int? IcshipmentItemSortOrder { get; set; }

    [Column("ICShipmentItemProductName")]
    [StringLength(256)]
    public string IcshipmentItemProductName { get; set; }

    [Column("ICShipmentItemProductDesc", TypeName = "ntext")]
    public string IcshipmentItemProductDesc { get; set; }

    [Column("ICShipmentItemProductSellUnit")]
    [StringLength(50)]
    public string IcshipmentItemProductSellUnit { get; set; }

    [Column("ICShipmentItemProductBasicUnit")]
    [StringLength(50)]
    public string IcshipmentItemProductBasicUnit { get; set; }

    [Column("ICShipmentItemProductPackagingUnit")]
    [StringLength(50)]
    public string IcshipmentItemProductPackagingUnit { get; set; }

    [Column("ICShipmentItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductSellFactor { get; set; }

    [Column("ICShipmentItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductPackagingFactor { get; set; }

    [Column("ICShipmentItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductUnitPrice { get; set; }

    [Column("ICShipmentItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductUnitCost { get; set; }

    [Column("ICShipmentItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductGroupDiscount { get; set; }

    [Column("ICShipmentItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductDiscount { get; set; }

    [Column("ICShipmentItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductTaxPercent { get; set; }

    [Column("ICShipmentItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductQtyOld { get; set; }

    [Column("ICShipmentItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? IcshipmentItemProductQty { get; set; }

    [Column("ICShipmentItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductBasicQty { get; set; }

    [Column("ICShipmentItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductPakagingQty { get; set; }

    [Column("ICShipmentItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemQty1 { get; set; }

    [Column("ICShipmentItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemQty2 { get; set; }

    [Column("ICShipmentItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemQty3 { get; set; }

    [Column("ICShipmentItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemQty4 { get; set; }

    [Column("ICShipmentItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemQty5 { get; set; }

    [Column("ICShipmentItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemQty6 { get; set; }

    [Column("ICShipmentItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemPrice { get; set; }

    [Column("ICShipmentItemComment")]
    [StringLength(50)]
    public string IcshipmentItemComment { get; set; }

    [Column("ICShipmentItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemUnitVolumn { get; set; }

    [Column("ICShipmentItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemUnitWeight { get; set; }

    [Column("ICShipmentItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemTaxAmount { get; set; }

    [Column("ICShipmentItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemDiscountAmount { get; set; }

    [Column("ICShipmentItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemNetAmount { get; set; }

    [Column("ICShipmentItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemTotalAmount { get; set; }

    [Column("ICShipmentItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemTotalCost { get; set; }

    [Column("ICShipmentItemProductSupplierNo")]
    [StringLength(50)]
    public string IcshipmentItemProductSupplierNo { get; set; }

    [Column("ICShipmentItemDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemDepreciatedAmount { get; set; }

    [Column("ICShipmentItemProductRemainedQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductRemainedQty { get; set; }

    [Column("FK_ICEquipmentShipmentItemID")]
    public int? FkIcequipmentShipmentItemId { get; set; }

    [Column("FK_ACEquipmentTransferItemID")]
    public int? FkAcequipmentTransferItemId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_ICReceiptItemID")]
    public int? FkIcreceiptItemId { get; set; }

    [Column("FK_MMAllocationProposalID")]
    public int? FkMmallocationProposalId { get; set; }

    [Column("FK_MMAllocationProposalItemID")]
    public int? FkMmallocationProposalItemId { get; set; }

    [Column("FK_ICShipmentProposalID")]
    public int? FkIcshipmentProposalId { get; set; }

    [Column("FK_ICShipmentProposalItemID")]
    public int? FkIcshipmentProposalItemId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("ICShipmentItemLoglist")]
    [StringLength(512)]
    public string IcshipmentItemLoglist { get; set; }

    [Column("ICShipmentItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemHeight { get; set; }

    [Column("ICShipmentItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemWidth { get; set; }

    [Column("ICShipmentItemLength", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemLength { get; set; }

    [Column("ICShipmentItemPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemPerimeter { get; set; }

    [Column("ICShipmentItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemHeightMin { get; set; }

    [Column("ICShipmentItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemWidthMin { get; set; }

    [Column("ICShipmentItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemLengthMin { get; set; }

    [Column("ICShipmentItemPerimeterMin", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemPerimeterMin { get; set; }

    [Column("ICShipmentItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemHeightMax { get; set; }

    [Column("ICShipmentItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemWidthMax { get; set; }

    [Column("ICShipmentItemLengthMax", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemLengthMax { get; set; }

    [Column("ICShipmentItemPerimeterMax", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemPerimeterMax { get; set; }

    [Column("ICShipmentItemContainerNo")]
    [StringLength(50)]
    public string IcshipmentItemContainerNo { get; set; }

    [Column("ICShipmentItemWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? IcshipmentItemWoodQty { get; set; }

    [Column("ICShipmentItemLotNo")]
    [StringLength(50)]
    public string IcshipmentItemLotNo { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("ICShipmentItemBatchProductItemProductSerial")]
    [StringLength(50)]
    public string IcshipmentItemBatchProductItemProductSerial { get; set; }

    [Column("FK_ICProductIdentifiedEquipmentID")]
    public int? FkIcproductIdentifiedEquipmentId { get; set; }

    [Column("ICShipmentItemProductIdentifiedEquipmentNo")]
    [StringLength(50)]
    public string IcshipmentItemProductIdentifiedEquipmentNo { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ICShipmentItemWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemWoodFee { get; set; }

    [Column("ICShipmentItemGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemGeneralFee { get; set; }

    [Column("ICShipmentItemDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemDirectSalaryFee { get; set; }

    [Column("ICShipmentItemHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemHardwareFee { get; set; }

    [Column("ICShipmentItemPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemPaintFee { get; set; }

    [Column("ICShipmentItemMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemMaintainFee { get; set; }

    [Column("ICShipmentItemElecFee", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemElecFee { get; set; }

    [Column("ICShipmentItemDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemDepreciationFee { get; set; }

    [Column("ICShipmentItemOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemOtherFee { get; set; }

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

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("FK_ARDeliveryPlanItemID")]
    public int? FkArdeliveryPlanItemId { get; set; }

    [Column("FK_ARDeliveryPlanID")]
    public int? FkArdeliveryPlanId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ICImportAndExportReasonID")]
    public int? FkIcimportAndExportReasonId { get; set; }

    [Column("ICShipmentItemDepreciationMonths")]
    public int? IcshipmentItemDepreciationMonths { get; set; }

    [Column("ICShipmentItemDepriciationDate", TypeName = "datetime")]
    public DateTime? IcshipmentItemDepriciationDate { get; set; }

    [Column("FK_ICTransferID")]
    public int? FkIctransferId { get; set; }

    [Column("FK_ICTransferItemID")]
    public int? FkIctransferItemId { get; set; }

    [Column("ICShipmentItemType")]
    [StringLength(50)]
    public string IcshipmentItemType { get; set; }

    [Column("FK_ARDeliveryPlanWorkID")]
    public int? FkArdeliveryPlanWorkId { get; set; }

    [Column("ICShipmentItemProductNoOfOldSys")]
    [StringLength(100)]
    public string IcshipmentItemProductNoOfOldSys { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("ICShipmentItemHasProductPackage")]
    public bool? IcshipmentItemHasProductPackage { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ICShipmentItemIsSpecificCalculation")]
    public bool? IcshipmentItemIsSpecificCalculation { get; set; }

    [Column("ICShipmentItemIsAverageCalculation")]
    public bool? IcshipmentItemIsAverageCalculation { get; set; }

    [Column("ICShipmentItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemProductFactor { get; set; }

    [Column("ICShipmentItemProductExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? IcshipmentItemProductExchangeQty { get; set; }

    [Column("ICShipmentItemExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemExchangeUnitCost { get; set; }

    [Column("ICShipmentItemExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemExchangeTotalCost { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("FK_ACTransitInAccountID")]
    public int? FkActransitInAccountId { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("ICShipmentItemCode01Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode01Combo { get; set; }

    [Column("ICShipmentItemCode02Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode02Combo { get; set; }

    [Column("ICShipmentItemCode03Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode03Combo { get; set; }

    [Column("ICShipmentItemCode04Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode04Combo { get; set; }

    [Column("ICShipmentItemCode05Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode05Combo { get; set; }

    [Column("ICShipmentItemCode06Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode06Combo { get; set; }

    [Column("ICShipmentItemCode07Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode07Combo { get; set; }

    [Column("ICShipmentItemCode08Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode08Combo { get; set; }

    [Column("ICShipmentItemCode09Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode09Combo { get; set; }

    [Column("ICShipmentItemCode10Combo")]
    [StringLength(256)]
    public string IcshipmentItemCode10Combo { get; set; }

    [Column("FK_ICPerimeterGroupID")]
    public int? FkIcperimeterGroupId { get; set; }

    [Column("FK_ICLengthGroupID")]
    public int? FkIclengthGroupId { get; set; }

    [Column("FK_ACDepreciationAccountID")]
    public int? FkAcdepreciationAccountId { get; set; }

    [Column("ICShipmentItemOneLevelArea")]
    [StringLength(1024)]
    public string IcshipmentItemOneLevelArea { get; set; }

    [Column("ICShipmentItemTwoLevelArea")]
    [StringLength(1024)]
    public string IcshipmentItemTwoLevelArea { get; set; }

    [Column("ICShipmentItemThreeLevelArea")]
    [StringLength(1024)]
    public string IcshipmentItemThreeLevelArea { get; set; }

    [Column("FK_ICSectionProductID")]
    public int? FkIcsectionProductId { get; set; }

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("FK_ARProposalTemplateItemID")]
    public int? FkArproposalTemplateItemId { get; set; }

    [Column("FK_MMAllocationPlanID")]
    public int? FkMmallocationPlanId { get; set; }

    [Column("FK_MMAllocationPlanItemID")]
    public int? FkMmallocationPlanItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("ICShipmentItemRemainedAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemRemainedAmount { get; set; }

    [Column("FK_MMReceiveOperationID")]
    public int? FkMmreceiveOperationId { get; set; }

    [Column("ICShipmentItemCheckCarcass")]
    public bool? IcshipmentItemCheckCarcass { get; set; }

    [Column("FK_MMMachineUnitID")]
    public int? FkMmmachineUnitId { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_ICMeasureUnitBeforeChangeID")]
    public int? FkIcmeasureUnitBeforeChangeId { get; set; }

    [Column("FK_HREmployeeReceverID")]
    public int? FkHremployeeReceverId { get; set; }

    [Column("ICShipmentItemContainerNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentItemContainerNumber { get; set; }

    [Column("ICShipmentItemContainerSealNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentItemContainerSealNumber { get; set; }

    [Column("ICShipmentItemTractorTrailerNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentItemTractorTrailerNumber { get; set; }

    [Column("ICShipmentItemShipNumber")]
    [StringLength(50)]
    public string IcshipmentItemShipNumber { get; set; }

    [Column("ICShipmentItemETDDate", TypeName = "datetime")]
    public DateTime? IcshipmentItemEtddate { get; set; }

    [Column("ICShipmentItemQuantityOfBox", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemQuantityOfBox { get; set; }

    [Column("ICShipmentItemInternalSeal")]
    [StringLength(100)]
    public string IcshipmentItemInternalSeal { get; set; }

    [Column("FK_MMUpdatePositionItemID")]
    public int? FkMmupdatePositionItemId { get; set; }

    [InverseProperty("FkIcshipmentItem")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkIcshipmentItem")]
    public virtual ICollection<ArinvoiceItemShipmentItem> ArinvoiceItemShipmentItems { get; set; } = new List<ArinvoiceItemShipmentItem>();

    [InverseProperty("FkIcshipmentItem")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FashipmentItem")]
    public virtual ICollection<FashipmentItemInvoiceItem> FashipmentItemInvoiceItems { get; set; } = new List<FashipmentItemInvoiceItem>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("IcshipmentItemFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("IcshipmentItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("IcshipmentItems")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("IcshipmentItemFkAcdepreciationCostAccounts")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }

    [ForeignKey("FkAcoffsetAccountId")]
    [InverseProperty("IcshipmentItemFkAcoffsetAccounts")]
    public virtual Acaccount FkAcoffsetAccount { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkActransitInAccountId")]
    [InverseProperty("IcshipmentItemFkActransitInAccounts")]
    public virtual Acaccount FkActransitInAccount { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("IcshipmentItems")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("IcshipmentItems")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArdeliveryPlanItemId")]
    [InverseProperty("IcshipmentItems")]
    public virtual ArdeliveryPlanItem FkArdeliveryPlanItem { get; set; }

    [ForeignKey("FkArdeliveryPlanWorkId")]
    [InverseProperty("IcshipmentItems")]
    public virtual ArdeliveryPlanWork FkArdeliveryPlanWork { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("IcshipmentItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("IcshipmentItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("IcshipmentItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("IcshipmentItems")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("IcshipmentItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeUserId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Hremployee FkHremployeeUser { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcimportAndExportReasonId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcimportAndExportReason FkIcimportAndExportReason { get; set; }

    [ForeignKey("FkIclengthGroupId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IclengthGroup FkIclengthGroup { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcperimeterGroupId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcperimeterGroup FkIcperimeterGroup { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcshipmentItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("IcshipmentItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("IcshipmentItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcshipmentItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("IcshipmentItemFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("IcshipmentItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductIdentifiedEquipmentId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcproductIdentifiedEquipment FkIcproductIdentifiedEquipment { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Icreceipt FkIcreceipt { get; set; }

    [ForeignKey("FkIcreceiptItemId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcreceiptItem FkIcreceiptItem { get; set; }

    [ForeignKey("FkIcsectionProductId")]
    [InverseProperty("IcshipmentItemFkIcsectionProducts")]
    public virtual Icproduct FkIcsectionProduct { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Icshipment FkIcshipment { get; set; }

    [ForeignKey("FkIcshipmentProposalId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcshipmentProposal FkIcshipmentProposal { get; set; }

    [ForeignKey("FkIcshipmentProposalItemId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcshipmentProposalItem FkIcshipmentProposalItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("IcshipmentItems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("IcshipmentItems")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("FkMmallocationProposalItemId")]
    [InverseProperty("IcshipmentItems")]
    public virtual MmallocationProposalItem FkMmallocationProposalItem { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IcshipmentItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("IcshipmentItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmupdatePositionItemId")]
    [InverseProperty("IcshipmentItems")]
    public virtual MmupdatePositionItem FkMmupdatePositionItem { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("IcshipmentItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("IcshipmentItems")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("IcshipmentItems")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }

    [InverseProperty("FkIcshipmentItem")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcshipmentItem")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcshipmentItem")]
    public virtual ICollection<IcreturnShippingItem> IcreturnShippingItems { get; set; } = new List<IcreturnShippingItem>();

    [InverseProperty("FkIcshipmentItem")]
    public virtual ICollection<IcshipmentItemComponent> IcshipmentItemComponents { get; set; } = new List<IcshipmentItemComponent>();

    [InverseProperty("FkIcshipmentItem")]
    public virtual ICollection<IcshipmentItemSaleOrderItem> IcshipmentItemSaleOrderItems { get; set; } = new List<IcshipmentItemSaleOrderItem>();
}
