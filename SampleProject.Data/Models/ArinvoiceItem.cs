using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkArinvoiceId", "ArinvoiceItemReference", Name = "Idx_ARInvoiceItems")]
public partial class ArinvoiceItem
{
    [Key]
    [Column("ARInvoiceItemID")]
    public int ArinvoiceItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

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
    public int FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("ARInvoiceItemProductType")]
    [StringLength(50)]
    public string ArinvoiceItemProductType { get; set; }

    [Column("ARInvoiceItemProductSerialNo")]
    [StringLength(50)]
    public string ArinvoiceItemProductSerialNo { get; set; }

    [Column("ARInvoiceItemProductAttribute")]
    [StringLength(200)]
    public string ArinvoiceItemProductAttribute { get; set; }

    [Column("ARInvoiceItemSortOrder")]
    public int? ArinvoiceItemSortOrder { get; set; }

    [Column("ARInvoiceItemProductName")]
    [StringLength(50)]
    public string ArinvoiceItemProductName { get; set; }

    [Column("ARInvoiceItemProductDesc", TypeName = "ntext")]
    public string ArinvoiceItemProductDesc { get; set; }

    [Column("ARInvoiceItemProductSellUnit")]
    [StringLength(50)]
    public string ArinvoiceItemProductSellUnit { get; set; }

    [Column("ARInvoiceItemProductBasicUnit")]
    [StringLength(50)]
    public string ArinvoiceItemProductBasicUnit { get; set; }

    [Column("ARInvoiceItemProductPackagingUnit")]
    [StringLength(50)]
    public string ArinvoiceItemProductPackagingUnit { get; set; }

    [Column("ARInvoiceItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductSellFactor { get; set; }

    [Column("ARInvoiceItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductPackagingFactor { get; set; }

    [Column("ARInvoiceItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductUnitPrice { get; set; }

    [Column("ARInvoiceItemProductInternalUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductInternalUnitPrice { get; set; }

    [Column("ARInvoiceItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductUnitCost { get; set; }

    [Column("ARInvoiceItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductGroupDiscount { get; set; }

    [Column("ARInvoiceItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductDiscount { get; set; }

    [Column("ARInvoiceItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductTaxPercent { get; set; }

    [Column("ARInvoiceItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductQtyOld { get; set; }

    [Column("ARInvoiceItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductQty { get; set; }

    [Column("ARInvoiceItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductBasicQty { get; set; }

    [Column("ARInvoiceItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductPakagingQty { get; set; }

    [Column("ARInvoiceItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemQty1 { get; set; }

    [Column("ARInvoiceItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemQty2 { get; set; }

    [Column("ARInvoiceItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemQty3 { get; set; }

    [Column("ARInvoiceItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemQty4 { get; set; }

    [Column("ARInvoiceItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemQty5 { get; set; }

    [Column("ARInvoiceItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemQty6 { get; set; }

    [Column("ARInvoiceItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemPrice { get; set; }

    [Column("ARInvoiceItemInternalPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemInternalPrice { get; set; }

    [Column("ARInvoiceItemComment")]
    [StringLength(50)]
    public string ArinvoiceItemComment { get; set; }

    [Column("ARInvoiceItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemUnitVolumn { get; set; }

    [Column("ARInvoiceItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemUnitWeight { get; set; }

    [Column("ARInvoiceItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemTaxAmount { get; set; }

    [Column("ARInvoiceItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemDiscountAmount { get; set; }

    [Column("ARInvoiceItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemNetAmount { get; set; }

    [Column("ARInvoiceItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemTotalAmount { get; set; }

    [Column("ARInvoiceItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemTotalCost { get; set; }

    [Column("ARInvoiceItemProductSupplierNo")]
    [StringLength(50)]
    public string ArinvoiceItemProductSupplierNo { get; set; }

    [Column("ARInvoiceItemDeliveryDate", TypeName = "datetime")]
    public DateTime? ArinvoiceItemDeliveryDate { get; set; }

    [Column("ARInvoiceItemReference")]
    [StringLength(50)]
    public string ArinvoiceItemReference { get; set; }

    [Column("ICProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductUnitPrice { get; set; }

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

    [Column("ARInvoiceItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWoodQty { get; set; }

    [Column("ARInvoiceItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemHeight { get; set; }

    [Column("ARInvoiceItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWidth { get; set; }

    [Column("ARInvoiceItemLength", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemLength { get; set; }

    [Column("ARInvoiceItemPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemPerimeter { get; set; }

    [Column("ARInvoiceItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemHeightMin { get; set; }

    [Column("ARInvoiceItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWidthMin { get; set; }

    [Column("ARInvoiceItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemLengthMin { get; set; }

    [Column("ARInvoiceItemPerimeterMin", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemPerimeterMin { get; set; }

    [Column("ARInvoiceItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemHeightMax { get; set; }

    [Column("ARInvoiceItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWidthMax { get; set; }

    [Column("ARInvoiceItemLentghMax", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemLentghMax { get; set; }

    [Column("ARInvoiceItemPerimeterMax", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemPerimeterMax { get; set; }

    [Column("ARInvoiceItemLotNo")]
    [StringLength(50)]
    public string ArinvoiceItemLotNo { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ARInvoiceItemPONo")]
    [StringLength(50)]
    public string ArinvoiceItemPono { get; set; }

    [Column("FK_ACAccountRevenueID")]
    public int? FkAcaccountRevenueId { get; set; }

    [Column("FK_ICShipmentItemID")]
    public int? FkIcshipmentItemId { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [Column("ARInvoiceItemAcceptanceProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemAcceptanceProductQty { get; set; }

    [Column("FK_ARAcceptanceID")]
    public int? FkAracceptanceId { get; set; }

    [Column("FK_ARAcceptanceItemID")]
    public int? FkAracceptanceItemId { get; set; }

    [Column("ARInvoiceItemLoadingAmount")]
    public double? ArinvoiceItemLoadingAmount { get; set; }

    [Column("ARInvoiceItemTransferFeeAmount")]
    public double? ArinvoiceItemTransferFeeAmount { get; set; }

    [Column("FK_ACAccountDiscountID")]
    public int? FkAcaccountDiscountId { get; set; }

    [Column("ARTransactionCode01Combo")]
    [StringLength(256)]
    public string ArtransactionCode01Combo { get; set; }

    [Column("ARTransactionCode02Combo")]
    [StringLength(256)]
    public string ArtransactionCode02Combo { get; set; }

    [Column("ARTransactionCode03Combo")]
    [StringLength(256)]
    public string ArtransactionCode03Combo { get; set; }

    [Column("ARTransactionCode04Combo")]
    [StringLength(256)]
    public string ArtransactionCode04Combo { get; set; }

    [Column("ARTransactionCode05Combo")]
    [StringLength(256)]
    public string ArtransactionCode05Combo { get; set; }

    [Column("ARTransactionCode06Combo")]
    [StringLength(256)]
    public string ArtransactionCode06Combo { get; set; }

    [Column("ARTransactionCode07Combo")]
    [StringLength(256)]
    public string ArtransactionCode07Combo { get; set; }

    [Column("ARTransactionCode08Combo")]
    [StringLength(256)]
    public string ArtransactionCode08Combo { get; set; }

    [Column("ARTransactionCode09Combo")]
    [StringLength(256)]
    public string ArtransactionCode09Combo { get; set; }

    [Column("ARTransactionCode10Combo")]
    [StringLength(256)]
    public string ArtransactionCode10Combo { get; set; }

    [Column("ARInvoiceItemIsSpecificCalculation")]
    public bool? ArinvoiceItemIsSpecificCalculation { get; set; }

    [Column("FK_ICSectionProductID")]
    public int? FkIcsectionProductId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("FK_ARDeliveryPlanItemID")]
    public int? FkArdeliveryPlanItemId { get; set; }

    [Column("FK_ARProposalTemplateItemID")]
    public int? FkArproposalTemplateItemId { get; set; }

    [Column("FK_ARContainerLoaderItemID")]
    public int? FkArcontainerLoaderItemId { get; set; }

    [Column("FK_ARProposalItemID")]
    public int? FkArproposalItemId { get; set; }

    [Column("FK_ARContainerLoaderID")]
    public int? FkArcontainerLoaderId { get; set; }

    [Column("FK_ICMeasureUnitBeforeChangeID")]
    public int? FkIcmeasureUnitBeforeChangeId { get; set; }

    [Column("ARInvoiceItemProductFactor", TypeName = "decimal(18, 8)")]
    public decimal? ArinvoiceItemProductFactor { get; set; }

    [Column("ARInvoiceItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemProductExchangeQty { get; set; }

    [Column("ARInvoiceItemExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemExchangeUnitCost { get; set; }

    [Column("ARInvoiceItemExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemExchangeTotalCost { get; set; }

    [Column("ARInvoiceItemContainerNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceItemContainerNumber { get; set; }

    [Column("ARInvoiceItemContainerSealNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceItemContainerSealNumber { get; set; }

    [Column("ARInvoiceItemTractorTrailerNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceItemTractorTrailerNumber { get; set; }

    [Column("ARInvoiceItemShipNumber")]
    [StringLength(50)]
    public string ArinvoiceItemShipNumber { get; set; }

    [Column("ARInvoiceItemETDDate", TypeName = "datetime")]
    public DateTime? ArinvoiceItemEtddate { get; set; }

    [Column("ARInvoiceItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ArinvoiceItemProductNoOfOldSys { get; set; }

    [Column("ARInvoiceItemProductBarCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceItemProductBarCode { get; set; }

    [Column("ARInvoiceItemProductName2")]
    [StringLength(255)]
    public string ArinvoiceItemProductName2 { get; set; }

    [InverseProperty("FkArinvoiceItem")]
    public virtual ICollection<AcretailVatitem> AcretailVatitems { get; set; } = new List<AcretailVatitem>();

    [InverseProperty("FkArinvoiceItem")]
    public virtual ICollection<ArcreditNoteItemInvoiceItem> ArcreditNoteItemInvoiceItems { get; set; } = new List<ArcreditNoteItemInvoiceItem>();

    [InverseProperty("FkArinvoiceItem")]
    public virtual ICollection<ArinvoiceItemComponent> ArinvoiceItemComponents { get; set; } = new List<ArinvoiceItemComponent>();

    [InverseProperty("FkArinvoiceItem")]
    public virtual ICollection<ArinvoiceItemPackage> ArinvoiceItemPackages { get; set; } = new List<ArinvoiceItemPackage>();

    [InverseProperty("FkArinvoiceItem")]
    public virtual ICollection<ArinvoiceItemShipmentItem> ArinvoiceItemShipmentItems { get; set; } = new List<ArinvoiceItemShipmentItem>();

    [InverseProperty("FkArinvoiceItem")]
    public virtual ICollection<ArinvoiceItemWork> ArinvoiceItemWorks { get; set; } = new List<ArinvoiceItemWork>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("ArinvoiceItemFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcaccountRevenueId")]
    [InverseProperty("ArinvoiceItemFkAcaccountRevenues")]
    public virtual Acaccount FkAcaccountRevenue { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAracceptanceId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual Aracceptance FkAracceptance { get; set; }

    [ForeignKey("FkAracceptanceItemId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual AracceptanceItem FkAracceptanceItem { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArinvoiceItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("ArinvoiceItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ArinvoiceItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("ArinvoiceItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("ArinvoiceItemFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcsectionProductId")]
    [InverseProperty("ArinvoiceItemFkIcsectionProducts")]
    public virtual Icproduct FkIcsectionProduct { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual Icshipment FkIcshipment { get; set; }

    [ForeignKey("FkIcshipmentItemId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual IcshipmentItem FkIcshipmentItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("ArinvoiceItems")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }
}
