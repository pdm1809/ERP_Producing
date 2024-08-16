using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReturnSupplierItems")]
public partial class FareturnSupplierItem
{
    [Key]
    [Column("FAReturnSupplierItemID")]
    public int FareturnSupplierItemId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("FAReturnSupplierID")]
    public int? FareturnSupplierId { get; set; }

    [Column("FAProductIDCombo")]
    public int? FaproductIdcombo { get; set; }

    [Column("FATextIDCombo")]
    public int? FatextIdcombo { get; set; }

    [Column("FAStockIDCombo")]
    public int? FastockIdcombo { get; set; }

    [Column("FAStockSlotIDCombo")]
    public int? FastockSlotIdcombo { get; set; }

    [Column("FAReturnSupplierItemProductType")]
    [StringLength(50)]
    public string FareturnSupplierItemProductType { get; set; }

    [Column("FAReturnSupplierItemTypeCombo")]
    [StringLength(20)]
    public string FareturnSupplierItemTypeCombo { get; set; }

    [Column("FAReturnSupplierItemSortOrder")]
    public int? FareturnSupplierItemSortOrder { get; set; }

    [Column("FAReturnSupplierItemProductDesc", TypeName = "ntext")]
    public string FareturnSupplierItemProductDesc { get; set; }

    [Column("FAReturnSupplierItemProductDescOri")]
    [StringLength(500)]
    public string FareturnSupplierItemProductDescOri { get; set; }

    [Column("FASellerOrderItemSerieNumberCheck")]
    public bool? FasellerOrderItemSerieNumberCheck { get; set; }

    [Column("FAReturnSupplierItemProductSellUnit")]
    [StringLength(50)]
    public string FareturnSupplierItemProductSellUnit { get; set; }

    [Column("FAReturnSupplierItemProductBasicUnit")]
    [StringLength(50)]
    public string FareturnSupplierItemProductBasicUnit { get; set; }

    [Column("FAReturnSupplierItemProductPackagingUnit")]
    [StringLength(50)]
    public string FareturnSupplierItemProductPackagingUnit { get; set; }

    [Column("FAReturnSupplierItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductSellFactor { get; set; }

    [Column("FAReturnSupplierItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductPackagingFactor { get; set; }

    [Column("FAReturnSupplierItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductUnitPrice { get; set; }

    [Column("FAReturnSupplierItemProductUnitBuyingPrice", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductUnitBuyingPrice { get; set; }

    [Column("FAReturnSupplierItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductGroupDiscount { get; set; }

    [Column("FAReturnSupplierItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductDiscount { get; set; }

    [Column("FAReturnSupplierItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductTaxPercent { get; set; }

    [Column("FAReturnSupplierItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductQtyOld { get; set; }

    [Column("FAReturnSupplierItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductQty { get; set; }

    [Column("FAReturnSupplierItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductBasicQty { get; set; }

    [Column("FAReturnSupplierItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemProductPakagingQty { get; set; }

    [Column("FAReturnSupplierItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemQty1 { get; set; }

    [Column("FAReturnSupplierItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemQty2 { get; set; }

    [Column("FAReturnSupplierItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemQty3 { get; set; }

    [Column("FAReturnSupplierItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemQty4 { get; set; }

    [Column("FAReturnSupplierItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemQty5 { get; set; }

    [Column("FAReturnSupplierItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemQty6 { get; set; }

    [Column("FAReturnSupplierItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemPrice { get; set; }

    [Column("FAReturnSupplierItemComment")]
    [StringLength(50)]
    public string FareturnSupplierItemComment { get; set; }

    [Column("FAReturnSupplierItemKalkuEKFix", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemKalkuEkfix { get; set; }

    [Column("FAReturnSupplierItemKalkuEK", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemKalkuEk { get; set; }

    [Column("FAReturnSupplierItemKalkuGP", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemKalkuGp { get; set; }

    [Column("FAReturnSupplierItemKalkuVP", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemKalkuVp { get; set; }

    [Column("FAReturnSupplierItemKalkuVK", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemKalkuVk { get; set; }

    [Column("FAReturnSupplierItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemUnitVolumn { get; set; }

    [Column("FAReturnSupplierItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierItemUnitWeight { get; set; }

    [Column("FAReturnSupplierItemKalkuExcel1")]
    [StringLength(50)]
    public string FareturnSupplierItemKalkuExcel1 { get; set; }

    [Column("FAReturnSupplierItemKalkuExcel2")]
    [StringLength(50)]
    public string FareturnSupplierItemKalkuExcel2 { get; set; }

    [Column("FAItemDeliverydate", TypeName = "datetime")]
    public DateTime? FaitemDeliverydate { get; set; }

    [Column("FAItemDeliverydate1", TypeName = "datetime")]
    public DateTime? FaitemDeliverydate1 { get; set; }

    [Column("FAItemWeight", TypeName = "decimal(18, 5)")]
    public decimal? FaitemWeight { get; set; }

    [Column("FAItemVolumen", TypeName = "decimal(18, 5)")]
    public decimal? FaitemVolumen { get; set; }

    [Column("FAItemPiece")]
    public int? FaitemPiece { get; set; }

    [Column("FAItemGroup")]
    [StringLength(50)]
    public string FaitemGroup { get; set; }

    [Column("FAItemRemark")]
    [StringLength(100)]
    public string FaitemRemark { get; set; }

    [Column("FAItemStatus")]
    [StringLength(50)]
    public string FaitemStatus { get; set; }

    [Column("FAItemTour")]
    [StringLength(50)]
    public string FaitemTour { get; set; }

    [Column("NEWFAReturnSupplierItem")]
    public int? NewfareturnSupplierItem { get; set; }

    [ForeignKey("FaproductIdcombo")]
    [InverseProperty("FareturnSupplierItems")]
    public virtual Icproduct FaproductIdcomboNavigation { get; set; }

    [ForeignKey("FareturnSupplierId")]
    [InverseProperty("FareturnSupplierItems")]
    public virtual FareturnSupplier FareturnSupplier { get; set; }

    [InverseProperty("FareturnSupplierItem")]
    public virtual ICollection<FareturnSupplierItemReceiptItem> FareturnSupplierItemReceiptItems { get; set; } = new List<FareturnSupplierItemReceiptItem>();

    [ForeignKey("FastockSlotIdcombo")]
    [InverseProperty("FareturnSupplierItems")]
    public virtual IcstockSlot FastockSlotIdcomboNavigation { get; set; }

    [ForeignKey("FatextIdcombo")]
    [InverseProperty("FareturnSupplierItems")]
    public virtual Getext FatextIdcomboNavigation { get; set; }
}
