using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptCDItems")]
public partial class IcreceiptCditem
{
    [Key]
    [Column("ICReceiptCDItemID")]
    public int IcreceiptCditemId { get; set; }

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

    [Column("FK_ICReceiptCDID")]
    public int? FkIcreceiptCdid { get; set; }

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

    [Column("ICReceiptCDItemProductType")]
    [StringLength(50)]
    public string IcreceiptCditemProductType { get; set; }

    [Column("ICReceiptCDItemSortOrder")]
    public int? IcreceiptCditemSortOrder { get; set; }

    [Column("ICReceiptCDItemProductSerialNo")]
    [StringLength(50)]
    public string IcreceiptCditemProductSerialNo { get; set; }

    [Column("ICReceiptCDItemProductAttribute")]
    [StringLength(200)]
    public string IcreceiptCditemProductAttribute { get; set; }

    [Column("ICReceiptCDItemProductName")]
    [StringLength(50)]
    public string IcreceiptCditemProductName { get; set; }

    [Column("ICReceiptCDItemProductDesc", TypeName = "ntext")]
    public string IcreceiptCditemProductDesc { get; set; }

    [Column("ICReceiptCDItemProductSellUnit")]
    [StringLength(50)]
    public string IcreceiptCditemProductSellUnit { get; set; }

    [Column("ICReceiptCDItemProductBasicUnit")]
    [StringLength(50)]
    public string IcreceiptCditemProductBasicUnit { get; set; }

    [Column("ICReceiptCDItemProductPackagingUnit")]
    [StringLength(50)]
    public string IcreceiptCditemProductPackagingUnit { get; set; }

    [Column("ICReceiptCDItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductSellFactor { get; set; }

    [Column("ICReceiptCDItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductPackagingFactor { get; set; }

    [Column("ICReceiptCDItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductUnitPrice { get; set; }

    [Column("ICReceiptCDItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductUnitCost { get; set; }

    [Column("ICReceiptCDItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductGroupDiscount { get; set; }

    [Column("ICReceiptCDItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductDiscount { get; set; }

    [Column("ICReceiptCDItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductTaxPercent { get; set; }

    [Column("ICReceiptCDItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductQtyOld { get; set; }

    [Column("ICReceiptCDItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductQty { get; set; }

    [Column("ICReceiptCDItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductBasicQty { get; set; }

    [Column("ICReceiptCDItemProductPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductPackageQty { get; set; }

    [Column("ICReceiptCDItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemQty1 { get; set; }

    [Column("ICReceiptCDItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemQty2 { get; set; }

    [Column("ICReceiptCDItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemQty3 { get; set; }

    [Column("ICReceiptCDItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemQty4 { get; set; }

    [Column("ICReceiptCDItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemQty5 { get; set; }

    [Column("ICReceiptCDItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemQty6 { get; set; }

    [Column("ICReceiptCDItemComment")]
    [StringLength(50)]
    public string IcreceiptCditemComment { get; set; }

    [Column("ICReceiptCDItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemUnitVolumn { get; set; }

    [Column("ICReceiptCDItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemUnitWeight { get; set; }

    [Column("ICReceiptCDItemExtCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemExtCost { get; set; }

    [Column("ICReceiptCDItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemDiscountAmount { get; set; }

    [Column("ICReceiptCDItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemTaxAmount { get; set; }

    [Column("ICReceiptCDItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemTotalCost { get; set; }

    [Column("ICReceiptCDItemProductSupplierNo")]
    [StringLength(50)]
    public string IcreceiptCditemProductSupplierNo { get; set; }

    [Column("ICReceiptCDItemInventoryCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemInventoryCost { get; set; }

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

    [Column("ICReceiptCDItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductHeight { get; set; }

    [Column("ICReceiptCDItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductWidth { get; set; }

    [Column("ICReceiptCDItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductLength { get; set; }

    [Column("ICReceiptCDItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductPerimeter { get; set; }

    [Column("ICReceiptCDItemLotNo")]
    [StringLength(50)]
    public string IcreceiptCditemLotNo { get; set; }

    [Column("ICReceiptCDItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemWoodQty { get; set; }

    [Column("ICReceiptCDItemLogListNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCditemLogListNo { get; set; }

    [Column("ICReceiptCDItemContainerNo")]
    [StringLength(50)]
    public string IcreceiptCditemContainerNo { get; set; }

    [Column("ICReceiptCDItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemHeightMax { get; set; }

    [Column("ICReceiptCDItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemWidthMax { get; set; }

    [Column("ICReceiptCDItemLenghtMax", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemLenghtMax { get; set; }

    [Column("ICReceiptCDItemNotJetExceptBlock", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemNotJetExceptBlock { get; set; }

    [Column("ICReceiptCDItemExceptedBlock", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemExceptedBlock { get; set; }

    [Column("ICReceiptCDItemInvoiceInQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemInvoiceInQty { get; set; }

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

    [Column("ICReceiptCDItemIsSplitted")]
    public bool? IcreceiptCditemIsSplitted { get; set; }

    [Column("ICReceiptCDItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemWidthMin { get; set; }

    [Column("ICReceiptCDItemLenghtMin", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemLenghtMin { get; set; }

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

    [Column("ICReceiptCDItemBPProductionNormItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemBpproductionNormItemQty { get; set; }

    [Column("ICReceiptCDItemProductTotalLength", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemProductTotalLength { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ICReceiptCDItemWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemWoodFee { get; set; }

    [Column("ICReceiptCDItemGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemGeneralFee { get; set; }

    [Column("ICReceiptCDItemDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemDirectSalaryFee { get; set; }

    [Column("ICReceiptCDItemHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemHardwareFee { get; set; }

    [Column("ICReceiptCDItemPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemPaintFee { get; set; }

    [Column("ICReceiptCDItemMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemMaintainFee { get; set; }

    [Column("ICReceiptCDItemElecFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemElecFee { get; set; }

    [Column("ICReceiptCDItemDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemDepreciationFee { get; set; }

    [Column("ICReceiptCDItemOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemOtherFee { get; set; }

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

    [Column("ICReceiptCDItemShipmentLength", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemShipmentLength { get; set; }

    [Column("ICReceiptCDItemShipmentPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemShipmentPerimeter { get; set; }

    [Column("ICReceiptCDItemShipmentQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCditemShipmentQty { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkAppurchaseOrderItemId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual AppurchaseOrderItem FkAppurchaseOrderItem { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeUserId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual Hremployee FkHremployeeUser { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcreceiptCditemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("IcreceiptCditemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("IcreceiptCditemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcreceiptCditemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("IcreceiptCditemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcreceiptCdid")]
    [InverseProperty("IcreceiptCditems")]
    public virtual IcreceiptCd FkIcreceiptCd { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual Icshipment FkIcshipment { get; set; }

    [ForeignKey("FkIcshipmentItemId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual IcshipmentItem FkIcshipmentItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("FkMmallocationProposalItemId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual MmallocationProposalItem FkMmallocationProposalItem { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("IcreceiptCditems")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkIcreceiptCditem")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();
}
