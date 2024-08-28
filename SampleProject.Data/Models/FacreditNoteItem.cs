using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FACreditNoteItems")]
public partial class FacreditNoteItem
{
    [Key]
    [Column("FACreditNoteItemID")]
    public int FacreditNoteItemId { get; set; }

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

    [Column("FACreditNoteID")]
    public int? FacreditNoteId { get; set; }

    [Column("FATextIDCombo")]
    public int? FatextIdcombo { get; set; }

    [Column("FAProductIDCombo")]
    public int? FaproductIdcombo { get; set; }

    [Column("FAStockIDCombo")]
    public int? FastockIdcombo { get; set; }

    [Column("FAStockSlotIDCombo")]
    public int? FastockSlotIdcombo { get; set; }

    [Column("FACreditNoteItemProductType")]
    [StringLength(50)]
    public string FacreditNoteItemProductType { get; set; }

    [Column("FACreditNoteItemTypeCombo")]
    [StringLength(20)]
    public string FacreditNoteItemTypeCombo { get; set; }

    [Column("FACreditNoteItemSortOrder")]
    public int? FacreditNoteItemSortOrder { get; set; }

    [Column("FACreditNoteItemProductDesc", TypeName = "ntext")]
    public string FacreditNoteItemProductDesc { get; set; }

    [Column("FACreditNoteItemProductDescOri")]
    [StringLength(500)]
    public string FacreditNoteItemProductDescOri { get; set; }

    [Column("FASellerOrderItemSerieNumberCheck")]
    public bool? FasellerOrderItemSerieNumberCheck { get; set; }

    [Column("FACreditNoteItemProductSellUnit")]
    [StringLength(50)]
    public string FacreditNoteItemProductSellUnit { get; set; }

    [Column("FACreditNoteItemProductBasicUnit")]
    [StringLength(50)]
    public string FacreditNoteItemProductBasicUnit { get; set; }

    [Column("FACreditNoteItemProductPackagingUnit")]
    [StringLength(50)]
    public string FacreditNoteItemProductPackagingUnit { get; set; }

    [Column("FACreditNoteItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductSellFactor { get; set; }

    [Column("FACreditNoteItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductPackagingFactor { get; set; }

    [Column("FACreditNoteItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductUnitPrice { get; set; }

    [Column("FACreditNoteItemProductUnitBuyingPrice", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductUnitBuyingPrice { get; set; }

    [Column("FACreditNoteItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductGroupDiscount { get; set; }

    [Column("FACreditNoteItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductDiscount { get; set; }

    [Column("FACreditNoteItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductTaxPercent { get; set; }

    [Column("FACreditNoteItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductQtyOld { get; set; }

    [Column("FACreditNoteItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductQty { get; set; }

    [Column("FACreditNoteItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductBasicQty { get; set; }

    [Column("FACreditNoteItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemProductPakagingQty { get; set; }

    [Column("FACreditNoteItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemQty1 { get; set; }

    [Column("FACreditNoteItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemQty2 { get; set; }

    [Column("FACreditNoteItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemQty3 { get; set; }

    [Column("FACreditNoteItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemQty4 { get; set; }

    [Column("FACreditNoteItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemQty5 { get; set; }

    [Column("FACreditNoteItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemQty6 { get; set; }

    [Column("FACreditNoteItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemPrice { get; set; }

    [Column("FACreditNoteItemComment")]
    [StringLength(50)]
    public string FacreditNoteItemComment { get; set; }

    [Column("FACreditNoteItemKalkuEKFix", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemKalkuEkfix { get; set; }

    [Column("FACreditNoteItemKalkuEK", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemKalkuEk { get; set; }

    [Column("FACreditNoteItemKalkuGP", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemKalkuGp { get; set; }

    [Column("FACreditNoteItemKalkuVP", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemKalkuVp { get; set; }

    [Column("FACreditNoteItemKalkuVK", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemKalkuVk { get; set; }

    [Column("FACreditNoteItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemUnitVolumn { get; set; }

    [Column("FACreditNoteItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteItemUnitWeight { get; set; }

    [Column("FACreditNoteItemKalkuExcel1")]
    [StringLength(50)]
    public string FacreditNoteItemKalkuExcel1 { get; set; }

    [Column("FACreditNoteItemKalkuExcel2")]
    [StringLength(50)]
    public string FacreditNoteItemKalkuExcel2 { get; set; }

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

    [Column("NEWFACreditNoteItem")]
    public int? NewfacreditNoteItem { get; set; }

    [ForeignKey("FacreditNoteId")]
    [InverseProperty("FacreditNoteItems")]
    public virtual FacreditNote FacreditNote { get; set; }

    [InverseProperty("FacreditNoteItem")]
    public virtual ICollection<FacreditNoteItemDiscount> FacreditNoteItemDiscounts { get; set; } = new List<FacreditNoteItemDiscount>();

    [InverseProperty("FacreditNoteItem")]
    public virtual ICollection<FainvoiceItemCreditNoteItem> FainvoiceItemCreditNoteItems { get; set; } = new List<FainvoiceItemCreditNoteItem>();

    [ForeignKey("FaproductIdcombo")]
    [InverseProperty("FacreditNoteItems")]
    public virtual Icproduct FaproductIdcomboNavigation { get; set; }

    [InverseProperty("FacreditNoteItem")]
    public virtual ICollection<FareceiptItemCreditNoteItem> FareceiptItemCreditNoteItems { get; set; } = new List<FareceiptItemCreditNoteItem>();

    [ForeignKey("FastockIdcombo")]
    [InverseProperty("FacreditNoteItems")]
    public virtual Icstock FastockIdcomboNavigation { get; set; }

    [ForeignKey("FastockSlotIdcombo")]
    [InverseProperty("FacreditNoteItems")]
    public virtual IcstockSlot FastockSlotIdcomboNavigation { get; set; }

    [ForeignKey("FatextIdcombo")]
    [InverseProperty("FacreditNoteItems")]
    public virtual Getext FatextIdcomboNavigation { get; set; }
}
