using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrderItems")]
public partial class FapurchaseOrderItem
{
    [Key]
    [Column("FAPurchaseOrderItemID")]
    public int FapurchaseOrderItemId { get; set; }

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

    [Column("FAPurchaseOrderID")]
    public int? FapurchaseOrderId { get; set; }

    [Column("FATextIDCombo")]
    public int? FatextIdcombo { get; set; }

    [Column("FAProductIDCombo")]
    public int? FaproductIdcombo { get; set; }

    [Column("FAStockIDCombo")]
    public int? FastockIdcombo { get; set; }

    [Column("FAStockSlotIDCombo")]
    public int? FastockSlotIdcombo { get; set; }

    [Column("FAPurchaseOrderItemProductType")]
    [StringLength(50)]
    public string FapurchaseOrderItemProductType { get; set; }

    [Column("FAPurchaseOrderItemTypeCombo")]
    [StringLength(20)]
    public string FapurchaseOrderItemTypeCombo { get; set; }

    [Column("FAPurchaseOrderItemSortOrder")]
    public int? FapurchaseOrderItemSortOrder { get; set; }

    [Column("FAPurchaseOrderItemProductDesc", TypeName = "ntext")]
    public string FapurchaseOrderItemProductDesc { get; set; }

    [Column("FAPurchaseOrderItemProductDescOri")]
    [StringLength(500)]
    public string FapurchaseOrderItemProductDescOri { get; set; }

    [Column("FASellerOrderItemSerieNumberCheck")]
    public bool? FasellerOrderItemSerieNumberCheck { get; set; }

    [Column("FAPurchaseOrderItemProductSellUnit")]
    [StringLength(50)]
    public string FapurchaseOrderItemProductSellUnit { get; set; }

    [Column("FAPurchaseOrderItemProductBasicUnit")]
    [StringLength(50)]
    public string FapurchaseOrderItemProductBasicUnit { get; set; }

    [Column("FAPurchaseOrderItemProductPackagingUnit")]
    [StringLength(50)]
    public string FapurchaseOrderItemProductPackagingUnit { get; set; }

    [Column("FAPurchaseOrderItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductSellFactor { get; set; }

    [Column("FAPurchaseOrderItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductPackagingFactor { get; set; }

    [Column("FAPurchaseOrderItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductUnitPrice { get; set; }

    [Column("FAPurchaseOrderItemProductUnitBuyingPrice", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductUnitBuyingPrice { get; set; }

    [Column("FAPurchaseOrderItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductGroupDiscount { get; set; }

    [Column("FAPurchaseOrderItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductDiscount { get; set; }

    [Column("FAPurchaseOrderItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductTaxPercent { get; set; }

    [Column("FAPurchaseOrderItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductQtyOld { get; set; }

    [Column("FAPurchaseOrderItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductQty { get; set; }

    [Column("FAPurchaseOrderItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductBasicQty { get; set; }

    [Column("FAPurchaseOrderItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemProductPakagingQty { get; set; }

    [Column("FAPurchaseOrderItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemQty1 { get; set; }

    [Column("FAPurchaseOrderItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemQty2 { get; set; }

    [Column("FAPurchaseOrderItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemQty3 { get; set; }

    [Column("FAPurchaseOrderItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemQty4 { get; set; }

    [Column("FAPurchaseOrderItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemQty5 { get; set; }

    [Column("FAPurchaseOrderItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemQty6 { get; set; }

    [Column("FAPurchaseOrderItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemPrice { get; set; }

    [Column("FAPurchaseOrderItemComment")]
    [StringLength(50)]
    public string FapurchaseOrderItemComment { get; set; }

    [Column("FAPurchaseOrderItemKalkuEKFix", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemKalkuEkfix { get; set; }

    [Column("FAPurchaseOrderItemKalkuEK", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemKalkuEk { get; set; }

    [Column("FAPurchaseOrderItemKalkuGP", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemKalkuGp { get; set; }

    [Column("FAPurchaseOrderItemKalkuVP", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemKalkuVp { get; set; }

    [Column("FAPurchaseOrderItemKalkuVK", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemKalkuVk { get; set; }

    [Column("FAPurchaseOrderItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemUnitVolumn { get; set; }

    [Column("FAPurchaseOrderItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderItemUnitWeight { get; set; }

    [Column("FAPurchaseOrderItemKalkuExcel1")]
    [StringLength(50)]
    public string FapurchaseOrderItemKalkuExcel1 { get; set; }

    [Column("FAPurchaseOrderItemKalkuExcel2")]
    [StringLength(50)]
    public string FapurchaseOrderItemKalkuExcel2 { get; set; }

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

    [Column("NEWFAPurchaseOrderItem")]
    public int? NewfapurchaseOrderItem { get; set; }

    [ForeignKey("FaproductIdcombo")]
    [InverseProperty("FapurchaseOrderItems")]
    public virtual Icproduct FaproductIdcomboNavigation { get; set; }

    [ForeignKey("FapurchaseOrderId")]
    [InverseProperty("FapurchaseOrderItems")]
    public virtual FapurchaseOrder FapurchaseOrder { get; set; }

    [InverseProperty("FapurchaseOrderItem")]
    public virtual ICollection<FapurchaseOrderItemDiscount> FapurchaseOrderItemDiscounts { get; set; } = new List<FapurchaseOrderItemDiscount>();

    [InverseProperty("FapurchaseOrderItem")]
    public virtual ICollection<FapurchaseOrderItemReceiptItem> FapurchaseOrderItemReceiptItems { get; set; } = new List<FapurchaseOrderItemReceiptItem>();

    [InverseProperty("FapurchaseOrderItem")]
    public virtual ICollection<FapurchaseOrderItemSellOrderItem> FapurchaseOrderItemSellOrderItems { get; set; } = new List<FapurchaseOrderItemSellOrderItem>();

    [ForeignKey("FastockIdcombo")]
    [InverseProperty("FapurchaseOrderItems")]
    public virtual Icstock FastockIdcomboNavigation { get; set; }

    [ForeignKey("FastockSlotIdcombo")]
    [InverseProperty("FapurchaseOrderItems")]
    public virtual IcstockSlot FastockSlotIdcomboNavigation { get; set; }

    [ForeignKey("FatextIdcombo")]
    [InverseProperty("FapurchaseOrderItems")]
    public virtual Getext FatextIdcomboNavigation { get; set; }
}
