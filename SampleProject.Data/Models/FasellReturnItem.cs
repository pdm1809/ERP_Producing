using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellReturnItems")]
public partial class FasellReturnItem
{
    [Key]
    [Column("FASellReturnItemID")]
    public int FasellReturnItemId { get; set; }

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

    [Column("FASellReturnID")]
    public int? FasellReturnId { get; set; }

    [Column("FATextIDCombo")]
    public int? FatextIdcombo { get; set; }

    [Column("FAProductIDCombo")]
    public int? FaproductIdcombo { get; set; }

    [Column("FAStockIDCombo")]
    public int? FastockIdcombo { get; set; }

    [Column("FAStockSlotIDCombo")]
    public int? FastockSlotIdcombo { get; set; }

    [Column("FASellReturnItemProductType")]
    [StringLength(50)]
    public string FasellReturnItemProductType { get; set; }

    [Column("FASellReturnItemTypeCombo")]
    [StringLength(20)]
    public string FasellReturnItemTypeCombo { get; set; }

    [Column("FASellReturnItemSortOrder")]
    public int? FasellReturnItemSortOrder { get; set; }

    [Column("FASellReturnItemProductDesc", TypeName = "ntext")]
    public string FasellReturnItemProductDesc { get; set; }

    [Column("FASellReturnItemProductDescOri")]
    [StringLength(500)]
    public string FasellReturnItemProductDescOri { get; set; }

    [Column("FASellerOrderItemSerieNumberCheck")]
    public bool? FasellerOrderItemSerieNumberCheck { get; set; }

    [Column("FASellReturnItemProductSellUnit")]
    [StringLength(50)]
    public string FasellReturnItemProductSellUnit { get; set; }

    [Column("FASellReturnItemProductBasicUnit")]
    [StringLength(50)]
    public string FasellReturnItemProductBasicUnit { get; set; }

    [Column("FASellReturnItemProductPackagingUnit")]
    [StringLength(50)]
    public string FasellReturnItemProductPackagingUnit { get; set; }

    [Column("FASellReturnItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductSellFactor { get; set; }

    [Column("FASellReturnItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductPackagingFactor { get; set; }

    [Column("FASellReturnItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductUnitPrice { get; set; }

    [Column("FASellReturnItemProductUnitBuyingPrice", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductUnitBuyingPrice { get; set; }

    [Column("FASellReturnItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductGroupDiscount { get; set; }

    [Column("FASellReturnItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductDiscount { get; set; }

    [Column("FASellReturnItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductTaxPercent { get; set; }

    [Column("FASellReturnItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductQtyOld { get; set; }

    [Column("FASellReturnItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductQty { get; set; }

    [Column("FASellReturnItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductBasicQty { get; set; }

    [Column("FASellReturnItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemProductPakagingQty { get; set; }

    [Column("FASellReturnItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemQty1 { get; set; }

    [Column("FASellReturnItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemQty2 { get; set; }

    [Column("FASellReturnItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemQty3 { get; set; }

    [Column("FASellReturnItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemQty4 { get; set; }

    [Column("FASellReturnItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemQty5 { get; set; }

    [Column("FASelReturnItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? FaselReturnItemQty6 { get; set; }

    [Column("FASellReturnItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemPrice { get; set; }

    [Column("FASellReturnItemComment")]
    [StringLength(50)]
    public string FasellReturnItemComment { get; set; }

    [Column("FASellReturnItemKalkuEKFix", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemKalkuEkfix { get; set; }

    [Column("FASellReturnItemKalkuEK", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemKalkuEk { get; set; }

    [Column("FASellReturnItemKalkuGP", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemKalkuGp { get; set; }

    [Column("FASellReturnItemKalkuVP", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemKalkuVp { get; set; }

    [Column("FASellReturnItemKalkuVK", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemKalkuVk { get; set; }

    [Column("FASellReturnItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemUnitVolumn { get; set; }

    [Column("FASellReturnItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnItemUnitWeight { get; set; }

    [Column("FASellReturnItemKalkuExcel1")]
    [StringLength(50)]
    public string FasellReturnItemKalkuExcel1 { get; set; }

    [Column("FASellReturnItemKalkuExcel2")]
    [StringLength(50)]
    public string FasellReturnItemKalkuExcel2 { get; set; }

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

    [Column("NEWFASellReturnItem")]
    public int? NewfasellReturnItem { get; set; }

    [InverseProperty("FasellReturnItem")]
    public virtual ICollection<FainvoiceItemSellReturnItem> FainvoiceItemSellReturnItems { get; set; } = new List<FainvoiceItemSellReturnItem>();

    [ForeignKey("FaproductIdcombo")]
    [InverseProperty("FasellReturnItems")]
    public virtual Icproduct FaproductIdcomboNavigation { get; set; }

    [ForeignKey("FasellReturnId")]
    [InverseProperty("FasellReturnItems")]
    public virtual FasellReturn FasellReturn { get; set; }

    [InverseProperty("FasellReturnItem")]
    public virtual ICollection<FasellReturnItemDiscount> FasellReturnItemDiscounts { get; set; } = new List<FasellReturnItemDiscount>();

    [InverseProperty("FasellReturnItem")]
    public virtual ICollection<FasellReturnItemReceiptItem> FasellReturnItemReceiptItems { get; set; } = new List<FasellReturnItemReceiptItem>();

    [ForeignKey("FastockIdcombo")]
    [InverseProperty("FasellReturnItems")]
    public virtual Icstock FastockIdcomboNavigation { get; set; }

    [ForeignKey("FastockSlotIdcombo")]
    [InverseProperty("FasellReturnItems")]
    public virtual IcstockSlot FastockSlotIdcomboNavigation { get; set; }

    [ForeignKey("FatextIdcombo")]
    [InverseProperty("FasellReturnItems")]
    public virtual Getext FatextIdcomboNavigation { get; set; }
}
