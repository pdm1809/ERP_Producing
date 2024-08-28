using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPurchaseOrderItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkAppurchaseOrderId", "AppurchaseOrderItemType", Name = "Idx_APPurchaseOrderItems")]
public partial class AppurchaseOrderItem
{
    [Key]
    [Column("APPurchaseOrderItemID")]
    public int AppurchaseOrderItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_APProposalID")]
    public int? FkApproposalId { get; set; }

    [Column("FK_APProposalItemID")]
    public int? FkApproposalItemId { get; set; }

    [Column("APPurchaseOrderItemProductType")]
    [StringLength(50)]
    public string AppurchaseOrderItemProductType { get; set; }

    [Column("APPurchaseOrderItemSortOrder")]
    public int? AppurchaseOrderItemSortOrder { get; set; }

    [Column("APPurchaseOrderItemProductSerialNo")]
    [StringLength(50)]
    public string AppurchaseOrderItemProductSerialNo { get; set; }

    [Column("APPurchaseOrderItemProductAttribute")]
    [StringLength(200)]
    public string AppurchaseOrderItemProductAttribute { get; set; }

    [Column("APPurchaseOrderItemProductName")]
    [StringLength(50)]
    public string AppurchaseOrderItemProductName { get; set; }

    [Column("APPurchaseOrderItemProductDesc")]
    [StringLength(1024)]
    public string AppurchaseOrderItemProductDesc { get; set; }

    [Column("APPurchaseOrderItemProductSellUnit")]
    [StringLength(50)]
    public string AppurchaseOrderItemProductSellUnit { get; set; }

    [Column("APPurchaseOrderItemProductBasicUnit")]
    [StringLength(50)]
    public string AppurchaseOrderItemProductBasicUnit { get; set; }

    [Column("APPurchaseOrderItemProductPackagingUnit")]
    [StringLength(50)]
    public string AppurchaseOrderItemProductPackagingUnit { get; set; }

    [Column("APPurchaseOrderItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductSellFactor { get; set; }

    [Column("APPurchaseOrderItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductPackagingFactor { get; set; }

    [Column("APPurchaseOrderItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductUnitPrice { get; set; }

    [Column("APPurchaseOrderItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductUnitCost { get; set; }

    [Column("APPurchaseOrderItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductGroupDiscount { get; set; }

    [Column("APPurchaseOrderItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductDiscount { get; set; }

    [Column("APPurchaseOrderItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductTaxPercent { get; set; }

    [Column("APPurchaseOrderItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductQtyOld { get; set; }

    [Column("APPurchaseOrderItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? AppurchaseOrderItemProductQty { get; set; }

    [Column("APPurchaseOrderItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductBasicQty { get; set; }

    [Column("APPurchaseOrderItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductPakagingQty { get; set; }

    [Column("APPurchaseOrderItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemQty1 { get; set; }

    [Column("APPurchaseOrderItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemQty2 { get; set; }

    [Column("APPurchaseOrderItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemQty3 { get; set; }

    [Column("APPurchaseOrderItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemQty4 { get; set; }

    [Column("APPurchaseOrderItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemQty5 { get; set; }

    [Column("APPurchaseOrderItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemQty6 { get; set; }

    [Column("APPurchaseOrderItemComment")]
    [StringLength(1000)]
    public string AppurchaseOrderItemComment { get; set; }

    [Column("APPurchaseOrderItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemUnitVolumn { get; set; }

    [Column("APPurchaseOrderItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemUnitWeight { get; set; }

    [Column("APPurchaseOrderItemExtCost", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemExtCost { get; set; }

    [Column("APPurchaseOrderItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemTaxAmount { get; set; }

    [Column("APPurchaseOrderItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemDiscountAmount { get; set; }

    [Column("APPurchaseOrderItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemTotalCost { get; set; }

    [Column("APPurchaseOrderItemDeliveryDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderItemDeliveryDate { get; set; }

    [Column("APPurchaseOrderItemType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderItemType { get; set; }

    [Column("APPurchaseOrderItemReceiptedQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemReceiptedQty { get; set; }

    [Column("APPurchaseOrderItemProductSupplierNo")]
    [StringLength(50)]
    public string AppurchaseOrderItemProductSupplierNo { get; set; }

    [Column("APPurchaseOrderItemPackagedQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemPackagedQty { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("APPurchaseOrderItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductHeight { get; set; }

    [Column("APPurchaseOrderItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductWidth { get; set; }

    [Column("APPurchaseOrderItemProductLenght", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductLenght { get; set; }

    [Column("APPurchaseOrderItemProductWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductWidthMax { get; set; }

    [Column("APPurchaseOrderItemProductLenghtMax", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductLenghtMax { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("FK_MMFromOperationID")]
    public int? FkMmfromOperationId { get; set; }

    [Column("FK_MMToOperationID")]
    public int? FkMmtoOperationId { get; set; }

    [Column("APPurchaseOrderItemProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductionNormItemPaint { get; set; }

    [Column("APPurchaseOrderItemProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductionNormItemBlocks { get; set; }

    [Column("APPurchaseOrderItemProductionNormItemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductionNormItemTotalPaint { get; set; }

    [Column("APPurchaseOrderItemProductionNormItemTotalBlocks", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductionNormItemTotalBlocks { get; set; }

    [Column("APPurchaseOrderItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductPerimeter { get; set; }

    [Column("APPurchaseOrderItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemWoodQty { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("APPurchaseOrderItemServiceFromDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderItemServiceFromDate { get; set; }

    [Column("APPurchaseOrderItemServiceToDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderItemServiceToDate { get; set; }

    [Column("APPurchaseOrderItemProductCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductCanceledQty { get; set; }

    [Column("APPurchaseOrderItemProductUnitCostTam", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductUnitCostTam { get; set; }

    [Column("APPurchaseOrderItemTotalCostTam", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemTotalCostTam { get; set; }

    [Column("APPurchaseOrderItemProductQtySter", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductQtySter { get; set; }

    [Column("APPurchaseOrderItemProductUnitCostSter", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductUnitCostSter { get; set; }

    [Column("APPurchaseOrderItemTotalCostSter", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemTotalCostSter { get; set; }

    [Column("APPurchaseOrderItemCanceledWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemCanceledWoodQty { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("APPurchaseOrderItemDivision")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderItemDivision { get; set; }

    [Column("APPurchaseOrderItemHasProductPackage")]
    public bool? AppurchaseOrderItemHasProductPackage { get; set; }

    [Column("APPurchaseOrderItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductFactor { get; set; }

    [Column("APPurchaseOrderItemProductExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? AppurchaseOrderItemProductExchangeQty { get; set; }

    [Column("APPurchaseOrderItemProductOrigin")]
    [StringLength(50)]
    public string AppurchaseOrderItemProductOrigin { get; set; }

    [Column("FK_MMPurchasePlanID")]
    public int? FkMmpurchasePlanId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("APPurchaseOrderItemOperation")]
    [StringLength(1024)]
    public string AppurchaseOrderItemOperation { get; set; }

    [Column("FK_ICMeasureUnitBeforeChangeID")]
    public int? FkIcmeasureUnitBeforeChangeId { get; set; }

    [Column("FK_ICLengthGroupID")]
    public int? FkIclengthGroupId { get; set; }

    [Column("FK_ICPerimeterGroupID")]
    public int? FkIcperimeterGroupId { get; set; }

    [Column("FK_ICProductThickGroupID")]
    public int? FkIcproductThickGroupId { get; set; }

    [Column("APPurchaseOrderItemProductLenghtMin", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductLenghtMin { get; set; }

    [Column("APPurchaseOrderItemProductWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemProductWidthMin { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkApproposalId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual Approposal FkApproposal { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIclengthGroupId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual IclengthGroup FkIclengthGroup { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcperimeterGroupId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual IcperimeterGroup FkIcperimeterGroup { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AppurchaseOrderItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("AppurchaseOrderItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("AppurchaseOrderItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("AppurchaseOrderItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("AppurchaseOrderItemFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductThickGroupId")]
    [InverseProperty("AppurchaseOrderItemFkIcproductThickGroups")]
    public virtual IcproductAttribute FkIcproductThickGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmfromOperationId")]
    [InverseProperty("AppurchaseOrderItemFkMmfromOperations")]
    public virtual Mmoperation FkMmfromOperation { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("AppurchaseOrderItems")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkMmtoOperationId")]
    [InverseProperty("AppurchaseOrderItemFkMmtoOperations")]
    public virtual Mmoperation FkMmtoOperation { get; set; }

    [InverseProperty("FkAppurchaseOrderItem")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkAppurchaseOrderItem")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();
}
