using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APInvoiceInItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkApinvoiceInId", Name = "Idx_APInvoiceInItems")]
public partial class ApinvoiceInItem
{
    [Key]
    [Column("APInvoiceInItemID")]
    public int ApinvoiceInItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

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

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_APPurchaseOrderItemID")]
    public int? FkAppurchaseOrderItemId { get; set; }

    [Column("APInvoiceInItemProductType")]
    [StringLength(50)]
    public string ApinvoiceInItemProductType { get; set; }

    [Column("APInvoiceInItemProductSerialNo")]
    [StringLength(50)]
    public string ApinvoiceInItemProductSerialNo { get; set; }

    [Column("APInvoiceInItemProductAttribute")]
    [StringLength(200)]
    public string ApinvoiceInItemProductAttribute { get; set; }

    [Column("APInvoiceInItemSortOrder")]
    public int? ApinvoiceInItemSortOrder { get; set; }

    [Column("APInvoiceInItemProductDesc")]
    [StringLength(1024)]
    public string ApinvoiceInItemProductDesc { get; set; }

    [Column("APInvoiceInItemProductSellUnit")]
    [StringLength(50)]
    public string ApinvoiceInItemProductSellUnit { get; set; }

    [Column("APInvoiceInItemProductBasicUnit")]
    [StringLength(50)]
    public string ApinvoiceInItemProductBasicUnit { get; set; }

    [Column("APInvoiceInItemProductPackagingUnit")]
    [StringLength(50)]
    public string ApinvoiceInItemProductPackagingUnit { get; set; }

    [Column("APInvoiceInItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductSellFactor { get; set; }

    [Column("APInvoiceInItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductPackagingFactor { get; set; }

    [Column("APInvoiceInItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductUnitPrice { get; set; }

    [Column("APInvoiceInItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductUnitCost { get; set; }

    [Column("APInvoiceInItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductGroupDiscount { get; set; }

    [Column("APInvoiceInItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductDiscount { get; set; }

    [Column("APInvoiceInItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductTaxPercent { get; set; }

    [Column("APInvoiceInItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductQtyOld { get; set; }

    [Column("APInvoiceInItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? ApinvoiceInItemProductQty { get; set; }

    [Column("APInvoiceInItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductBasicQty { get; set; }

    [Column("APInvoiceInItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductPakagingQty { get; set; }

    [Column("APInvoiceInItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemQty1 { get; set; }

    [Column("APInvoiceInItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemQty2 { get; set; }

    [Column("APInvoiceInItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemQty3 { get; set; }

    [Column("APInvoiceInItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemQty4 { get; set; }

    [Column("APInvoiceInItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemQty5 { get; set; }

    [Column("APInvoiceInItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemQty6 { get; set; }

    [Column("APInvoiceInItemComment")]
    [StringLength(50)]
    public string ApinvoiceInItemComment { get; set; }

    [Column("APInvoiceInItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemUnitVolumn { get; set; }

    [Column("APInvoiceInItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemUnitWeight { get; set; }

    [Column("APInvoiceInItemExtCost", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemExtCost { get; set; }

    [Column("APInvoiceInItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemTaxAmount { get; set; }

    [Column("APInvoiceInItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemDiscountAmount { get; set; }

    [Column("APInvoiceInItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemTotalCost { get; set; }

    [Column("APInvoiceInItemReceiptedQty", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemReceiptedQty { get; set; }

    [Column("APInvoiceInItemProductSupplierNo")]
    [StringLength(50)]
    public string ApinvoiceInItemProductSupplierNo { get; set; }

    [Column("FK_APPurchaseOrderPaymentTimeID")]
    public int? FkAppurchaseOrderPaymentTimeId { get; set; }

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_ICReceiptItemID")]
    public int? FkIcreceiptItemId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("APInvoiceInItemLogListNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInItemLogListNo { get; set; }

    [Column("APInvoiceInItemLotNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInItemLotNo { get; set; }

    [Column("APInvoiceInItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductHeight { get; set; }

    [Column("APInvoiceInItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductWidth { get; set; }

    [Column("APInvoiceInItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductLength { get; set; }

    [Column("APInvoiceInItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductPerimeter { get; set; }

    [Column("APInvoiceInItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemWoodQty { get; set; }

    [Column("APInvoiceInItemContainerNo")]
    [StringLength(50)]
    public string ApinvoiceInItemContainerNo { get; set; }

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

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("APInvoiceInItemProductUnitCostTam", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductUnitCostTam { get; set; }

    [Column("APInvoiceInItemTotalCostTam", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemTotalCostTam { get; set; }

    [Column("APInvoiceInItemProductQtySter", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductQtySter { get; set; }

    [Column("APInvoiceInItemProductUnitCostSter", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductUnitCostSter { get; set; }

    [Column("APInvoiceInItemTotalCostSter", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemTotalCostSter { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("APInvoiceInItemHasProductPackage")]
    public bool? ApinvoiceInItemHasProductPackage { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_ACAccountTaxID")]
    public int? FkAcaccountTaxId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("APInvoiceInItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInItemProductFactor { get; set; }

    [Column("APInvoiceInItemProductExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? ApinvoiceInItemProductExchangeQty { get; set; }

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ICMeasureUnitBeforeChangeID")]
    public int? FkIcmeasureUnitBeforeChangeId { get; set; }

    [InverseProperty("FkApinvoiceInItem")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkAppurchaseOrderPaymentTimeId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual AppurchaseOrderPaymentTime FkAppurchaseOrderPaymentTime { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("ApinvoiceInItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ApinvoiceInItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("ApinvoiceInItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual Icreceipt FkIcreceipt { get; set; }

    [ForeignKey("FkIcreceiptItemId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual IcreceiptItem FkIcreceiptItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("ApinvoiceInItems")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
