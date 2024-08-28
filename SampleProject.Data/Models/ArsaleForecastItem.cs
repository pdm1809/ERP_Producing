using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleForecastItems")]
public partial class ArsaleForecastItem
{
    [Key]
    [Column("ARSaleForecastItemID")]
    public int ArsaleForecastItemId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleForecastID")]
    public int? FkArsaleForecastId { get; set; }

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

    [Column("ARSaleForecastItemProductType")]
    [StringLength(50)]
    public string ArsaleForecastItemProductType { get; set; }

    [Column("ARSaleForecastItemProductSerialNo")]
    [StringLength(50)]
    public string ArsaleForecastItemProductSerialNo { get; set; }

    [Column("ARSaleForecastItemProductAttribute")]
    [StringLength(200)]
    public string ArsaleForecastItemProductAttribute { get; set; }

    [Column("ARSaleForecastItemSortOrder")]
    public int? ArsaleForecastItemSortOrder { get; set; }

    [Column("ARSaleForecastItemProductName")]
    [StringLength(50)]
    public string ArsaleForecastItemProductName { get; set; }

    [Column("ARSaleForecastItemProductDesc", TypeName = "ntext")]
    public string ArsaleForecastItemProductDesc { get; set; }

    [Column("ARSaleForecastItemProductSellUnit")]
    [StringLength(50)]
    public string ArsaleForecastItemProductSellUnit { get; set; }

    [Column("ARSaleForecastItemProductBasicUnit")]
    [StringLength(50)]
    public string ArsaleForecastItemProductBasicUnit { get; set; }

    [Column("ARSaleForecastItemProductPackagingUnit")]
    [StringLength(50)]
    public string ArsaleForecastItemProductPackagingUnit { get; set; }

    [Column("ARSaleForecastItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductSellFactor { get; set; }

    [Column("ARSaleForecastItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductPackagingFactor { get; set; }

    [Column("ARSaleForecastItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductUnitPrice { get; set; }

    [Column("ARSaleForecastItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductUnitCost { get; set; }

    [Column("ARSaleForecastItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductGroupDiscount { get; set; }

    [Column("ARSaleForecastItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductDiscount { get; set; }

    [Column("ARSaleForecastItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductTaxPercent { get; set; }

    [Column("ARSaleForecastItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductQtyOld { get; set; }

    [Column("ARSaleForecastItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductQty { get; set; }

    [Column("ARSaleForecastItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductBasicQty { get; set; }

    [Column("ARSaleForecastItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductPakagingQty { get; set; }

    [Column("ARSaleForecastItemCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemCanceledQty { get; set; }

    [Column("ARSaleForecastItemShippedQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemShippedQty { get; set; }

    [Column("ARSaleForecastItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemQty1 { get; set; }

    [Column("ARSaleForecastItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemQty2 { get; set; }

    [Column("ARSaleForecastItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemQty3 { get; set; }

    [Column("ARSaleForecastItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemQty4 { get; set; }

    [Column("ARSaleForecastItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemQty5 { get; set; }

    [Column("ARSaleForecastItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemQty6 { get; set; }

    [Column("ARSaleForecastItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemPrice { get; set; }

    [Column("ARSaleForecastItemComment")]
    [StringLength(512)]
    public string ArsaleForecastItemComment { get; set; }

    [Column("ARSaleForecastItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemUnitVolumn { get; set; }

    [Column("ARSaleForecastItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemUnitWeight { get; set; }

    [Column("ARSaleForecastItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemTaxAmount { get; set; }

    [Column("ARSaleForecastItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemDiscountAmount { get; set; }

    [Column("ARSaleForecastItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemNetAmount { get; set; }

    [Column("ARSaleForecastItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemTotalAmount { get; set; }

    [Column("ARSaleForecastItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemTotalCost { get; set; }

    [Column("ARSaleForecastItemDeliveryDate", TypeName = "datetime")]
    public DateTime? ArsaleForecastItemDeliveryDate { get; set; }

    [Column("ARSaleForecastItemDeliveryTime", TypeName = "datetime")]
    public DateTime? ArsaleForecastItemDeliveryTime { get; set; }

    [Column("ICProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductUnitPrice { get; set; }

    [Column("ARSaleForecastItemProductSupplierNo")]
    [StringLength(50)]
    public string ArsaleForecastItemProductSupplierNo { get; set; }

    [Column("ARSaleForecastItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductLength { get; set; }

    [Column("ARSaleForecastItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductWidth { get; set; }

    [Column("ARSaleForecastItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductHeight { get; set; }

    [Column("ARSaleForecastItemProductCartonLength", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductCartonLength { get; set; }

    [Column("ARSaleForecastItemProductCartonWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductCartonWidth { get; set; }

    [Column("ARSaleForecastItemProductCartonHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductCartonHeight { get; set; }

    [Column("ARSaleForecastItemProductContainerLoading20", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductContainerLoading20 { get; set; }

    [Column("ARSaleForecastItemProductContainerLoading40", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductContainerLoading40 { get; set; }

    [Column("ARSaleForecastItemProductContainerLoadingHC", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductContainerLoadingHc { get; set; }

    [Column("ARSaleForecastItemProductFOBPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductFobprice { get; set; }

    [Column("ARSaleForecastItemProductTargetPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductTargetPrice { get; set; }

    [Column("ARSaleForecastItemQuantityOfBox", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemQuantityOfBox { get; set; }

    [Column("ARSaleForecastItemProductSOQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductSoqty { get; set; }

    [Column("ARSaleForecastItemProductCustomerNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastItemProductCustomerNumber { get; set; }

    [Column("ARSaleForecastItemProductUnitPrice2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemProductUnitPrice2 { get; set; }

    [Column("ARSaleForecastItemTotalAmount2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastItemTotalAmount2 { get; set; }

    [Column("ARSaleForecastItemPONo")]
    [StringLength(50)]
    public string ArsaleForecastItemPono { get; set; }

    [Column("ARSaleForecastItemLotNo")]
    [StringLength(50)]
    public string ArsaleForecastItemLotNo { get; set; }

    [Column("ARSaleForecastItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ArsaleForecastItemProductNoOfOldSys { get; set; }

    [InverseProperty("FkArsaleForecastItem")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkArsaleForecastItem")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkArsaleForecastItem")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkArsaleForecastItem")]
    public virtual ICollection<ArsfitemComponent> ArsfitemComponents { get; set; } = new List<ArsfitemComponent>();

    [ForeignKey("FkArsaleForecastId")]
    [InverseProperty("ArsaleForecastItems")]
    public virtual ArsaleForecast FkArsaleForecast { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArsaleForecastItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArsaleForecastItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsaleForecastItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArsaleForecastItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ArsaleForecastItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArsaleForecastItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("ArsaleForecastItems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }
}
