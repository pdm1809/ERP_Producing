using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICTransferItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIctransferId", Name = "Idx_ICTransferItems")]
public partial class IctransferItem
{
    [Key]
    [Column("ICTransferItemID")]
    public int IctransferItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICTransferID")]
    public int? FkIctransferId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICFromStockID")]
    public int? FkIcfromStockId { get; set; }

    [Column("FK_ICToStockID")]
    public int? FkIctoStockId { get; set; }

    [Column("FK_ICTransitStockID")]
    public int? FkIctransitStockId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICTransferItemProductType")]
    [StringLength(50)]
    public string IctransferItemProductType { get; set; }

    [Column("ICTransferItemSortOrder")]
    public int? IctransferItemSortOrder { get; set; }

    [Column("ICTransferItemProductSerialNo")]
    [StringLength(50)]
    public string IctransferItemProductSerialNo { get; set; }

    [Column("ICTransferItemProductAttribute")]
    [StringLength(200)]
    public string IctransferItemProductAttribute { get; set; }

    [Column("ICTransferItemProductName")]
    [StringLength(50)]
    public string IctransferItemProductName { get; set; }

    [Column("ICTransferItemProductDesc", TypeName = "ntext")]
    public string IctransferItemProductDesc { get; set; }

    [Column("ICTransferItemProductSellUnit")]
    [StringLength(50)]
    public string IctransferItemProductSellUnit { get; set; }

    [Column("ICTransferItemProductBasicUnit")]
    [StringLength(50)]
    public string IctransferItemProductBasicUnit { get; set; }

    [Column("ICTransferItemProductPackagingUnit")]
    [StringLength(50)]
    public string IctransferItemProductPackagingUnit { get; set; }

    [Column("ICTransferItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductSellFactor { get; set; }

    [Column("ICTransferItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductPackagingFactor { get; set; }

    [Column("ICTransferItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductUnitPrice { get; set; }

    [Column("ICTransferItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductUnitCost { get; set; }

    [Column("ICTransfertItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IctransfertItemProductGroupDiscount { get; set; }

    [Column("ICTransferItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductDiscount { get; set; }

    [Column("ICTransferItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductTaxPercent { get; set; }

    [Column("ICTransferItemProductQtyOld", TypeName = "decimal(18, 6)")]
    public decimal? IctransferItemProductQtyOld { get; set; }

    [Column("ICTransferItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? IctransferItemProductQty { get; set; }

    [Column("ICTransferItemProductBasicQty", TypeName = "decimal(18, 6)")]
    public decimal? IctransferItemProductBasicQty { get; set; }

    [Column("ICTransferItemProductPakagingQty", TypeName = "decimal(18, 6)")]
    public decimal? IctransferItemProductPakagingQty { get; set; }

    [Column("ICTransferItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemQty1 { get; set; }

    [Column("ICTransferItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemQty2 { get; set; }

    [Column("ICTransferItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemQty3 { get; set; }

    [Column("ICTransferItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemQty4 { get; set; }

    [Column("ICTransferItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemQty5 { get; set; }

    [Column("ICTransferItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemQty6 { get; set; }

    [Column("ICTransferItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemPrice { get; set; }

    [Column("ICTransferItemComment")]
    [StringLength(50)]
    public string IctransferItemComment { get; set; }

    [Column("ICTransferItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemUnitVolumn { get; set; }

    [Column("ICTransferItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemUnitWeight { get; set; }

    [Column("ICTransferItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferItemStatus { get; set; }

    [Column("ICTransferItemProductSupplierNo")]
    [StringLength(50)]
    public string IctransferItemProductSupplierNo { get; set; }

    [Column("ICTransferItemReceiptedQty", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemReceiptedQty { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ARDeliveryPlanWorkID")]
    public int? FkArdeliveryPlanWorkId { get; set; }

    [Column("FK_ARSaleOrderItemWorkID")]
    public int? FkArsaleOrderItemWorkId { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_APPurchaseOrderItemID")]
    public int? FkAppurchaseOrderItemId { get; set; }

    [Column("ICTransferItemType")]
    [StringLength(50)]
    public string IctransferItemType { get; set; }

    [Column("FK_MMAllocationPlanItemID")]
    public int? FkMmallocationPlanItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemHardwareID")]
    public int? FkMmbatchProductProductionNormItemHardwareId { get; set; }

    [Column("FK_ICTransferProposalID")]
    public int? FkIctransferProposalId { get; set; }

    [Column("FK_ICTransferProposalItemID")]
    public int? FkIctransferProposalItemId { get; set; }

    [Column("ICTransferItemProductNoOfOldSys")]
    [StringLength(100)]
    public string IctransferItemProductNoOfOldSys { get; set; }

    [Column("FK_ICProductOutsourcingID")]
    public int? FkIcproductOutsourcingId { get; set; }

    [Column("FK_APPurchaseOrderItemForOutsourcingID")]
    public int? FkAppurchaseOrderItemForOutsourcingId { get; set; }

    [Column("ICTransferItemParentID")]
    public int? IctransferItemParentId { get; set; }

    [Column("ICTransferItemIsSpecificCalculation")]
    public bool? IctransferItemIsSpecificCalculation { get; set; }

    [Column("ICTransferItemIsAverageCalculation")]
    public bool? IctransferItemIsAverageCalculation { get; set; }

    [Column("ICTransferItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductFactor { get; set; }

    [Column("ICTransferItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemTotalCost { get; set; }

    [Column("ICTransferItemProductExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? IctransferItemProductExchangeQty { get; set; }

    [Column("ICTransferItemExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemExchangeUnitCost { get; set; }

    [Column("ICTransferItemExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemExchangeTotalCost { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("FK_ACTransitInAccountID")]
    public int? FkActransitInAccountId { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("ICTransferItemCode01Combo")]
    [StringLength(256)]
    public string IctransferItemCode01Combo { get; set; }

    [Column("ICTransferItemCode02Combo")]
    [StringLength(256)]
    public string IctransferItemCode02Combo { get; set; }

    [Column("ICTransferItemCode03Combo")]
    [StringLength(256)]
    public string IctransferItemCode03Combo { get; set; }

    [Column("ICTransferItemCode04Combo")]
    [StringLength(256)]
    public string IctransferItemCode04Combo { get; set; }

    [Column("ICTransferItemCode05Combo")]
    [StringLength(256)]
    public string IctransferItemCode05Combo { get; set; }

    [Column("ICTransferItemCode06Combo")]
    [StringLength(256)]
    public string IctransferItemCode06Combo { get; set; }

    [Column("ICTransferItemCode07Combo")]
    [StringLength(256)]
    public string IctransferItemCode07Combo { get; set; }

    [Column("ICTransferItemCode08Combo")]
    [StringLength(256)]
    public string IctransferItemCode08Combo { get; set; }

    [Column("ICTransferItemCode09Combo")]
    [StringLength(256)]
    public string IctransferItemCode09Combo { get; set; }

    [Column("ICTransferItemCode10Combo")]
    [StringLength(256)]
    public string IctransferItemCode10Combo { get; set; }

    [Column("ICTransferItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductHeight { get; set; }

    [Column("ICTransferItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductWidth { get; set; }

    [Column("ICTransferItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemProductLength { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_APPurchaseOrderItemOutSourcingID")]
    public int? FkAppurchaseOrderItemOutSourcingId { get; set; }

    [InverseProperty("FkIctransferItem")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkIctransferItem")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("IctransferItemFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("IctransferItems")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAcoffsetAccountId")]
    [InverseProperty("IctransferItemFkAcoffsetAccounts")]
    public virtual Acaccount FkAcoffsetAccount { get; set; }

    [ForeignKey("FkActransitInAccountId")]
    [InverseProperty("IctransferItemFkActransitInAccounts")]
    public virtual Acaccount FkActransitInAccount { get; set; }

    [ForeignKey("FkArdeliveryPlanWorkId")]
    [InverseProperty("IctransferItems")]
    public virtual ArdeliveryPlanWork FkArdeliveryPlanWork { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("IctransferItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("IctransferItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkArsaleOrderItemWorkId")]
    [InverseProperty("IctransferItems")]
    public virtual ArsaleOrderItemWork FkArsaleOrderItemWork { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IctransferItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcfromStockId")]
    [InverseProperty("IctransferItemFkIcfromStocks")]
    public virtual Icstock FkIcfromStock { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IctransferItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("IctransferItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("IctransferItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IctransferItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("IctransferItemFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IctransferItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IctransferItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIctoStockId")]
    [InverseProperty("IctransferItemFkIctoStocks")]
    public virtual Icstock FkIctoStock { get; set; }

    [ForeignKey("FkIctransferId")]
    [InverseProperty("IctransferItems")]
    public virtual Ictransfer FkIctransfer { get; set; }

    [ForeignKey("FkIctransitStockId")]
    [InverseProperty("IctransferItemFkIctransitStocks")]
    public virtual Icstock FkIctransitStock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IctransferItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("IctransferItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [InverseProperty("FkIctransferItem")]
    public virtual ICollection<IctransferItemPackage> IctransferItemPackages { get; set; } = new List<IctransferItemPackage>();
}
