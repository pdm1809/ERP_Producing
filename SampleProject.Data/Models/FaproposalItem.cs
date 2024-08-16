using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAProposalItems")]
public partial class FaproposalItem
{
    [Key]
    [Column("FAProposalItemID")]
    public int FaproposalItemId { get; set; }

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

    [Column("FAProposalID")]
    public int? FaproposalId { get; set; }

    [Column("FATextIDCombo")]
    public int? FatextIdcombo { get; set; }

    [Column("FAProductIDCombo")]
    public int? FaproductIdcombo { get; set; }

    [Column("FAStockIDCombo")]
    public int? FastockIdcombo { get; set; }

    [Column("FAStockSlotIDCombo")]
    public int? FastockSlotIdcombo { get; set; }

    [Column("FAProposalItemProductType")]
    [StringLength(50)]
    public string FaproposalItemProductType { get; set; }

    [Column("FAProposalItemTypeCombo")]
    [StringLength(20)]
    public string FaproposalItemTypeCombo { get; set; }

    [Column("FAProposalItemSortOrder")]
    public int? FaproposalItemSortOrder { get; set; }

    [Column("FAProposalItemProductDesc", TypeName = "ntext")]
    public string FaproposalItemProductDesc { get; set; }

    [Column("FAProposalItemProductDescOri")]
    [StringLength(500)]
    public string FaproposalItemProductDescOri { get; set; }

    [Column("FASellerOrderItemSerieNumberCheck")]
    public bool? FasellerOrderItemSerieNumberCheck { get; set; }

    [Column("FAProposalItemProductSellUnit")]
    [StringLength(50)]
    public string FaproposalItemProductSellUnit { get; set; }

    [Column("FAProposalItemProductBasicUnit")]
    [StringLength(50)]
    public string FaproposalItemProductBasicUnit { get; set; }

    [Column("FAProposalItemProductPackagingUnit")]
    [StringLength(50)]
    public string FaproposalItemProductPackagingUnit { get; set; }

    [Column("FAProposalItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductSellFactor { get; set; }

    [Column("FAProposalItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductPackagingFactor { get; set; }

    [Column("FAProposalItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductUnitPrice { get; set; }

    [Column("FAProposalItemProductUnitBuyingPrice", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductUnitBuyingPrice { get; set; }

    [Column("FAProposalItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductGroupDiscount { get; set; }

    [Column("FAProposalItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductDiscount { get; set; }

    [Column("FAProposalItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductTaxPercent { get; set; }

    [Column("FAProposalItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductQtyOld { get; set; }

    [Column("FAProposalItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductQty { get; set; }

    [Column("FAProposalItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductBasicQty { get; set; }

    [Column("FAProposalItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemProductPakagingQty { get; set; }

    [Column("FAProposalItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemQty1 { get; set; }

    [Column("FAProposalItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemQty2 { get; set; }

    [Column("FAProposalItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemQty3 { get; set; }

    [Column("FAProposalItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemQty4 { get; set; }

    [Column("FAProposalItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemQty5 { get; set; }

    [Column("FAProposalItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemQty6 { get; set; }

    [Column("FAProposalItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemPrice { get; set; }

    [Column("FAProposalItemComment")]
    [StringLength(50)]
    public string FaproposalItemComment { get; set; }

    [Column("FAProposalItemKalkuEKFix", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemKalkuEkfix { get; set; }

    [Column("FAProposalItemKalkuEK", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemKalkuEk { get; set; }

    [Column("FAProposalItemKalkuGP", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemKalkuGp { get; set; }

    [Column("FAProposalItemKalkuVP", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemKalkuVp { get; set; }

    [Column("FAProposalItemKalkuVK", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemKalkuVk { get; set; }

    [Column("FAProposalItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemUnitVolumn { get; set; }

    [Column("FAProposalItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalItemUnitWeight { get; set; }

    [Column("FAProposalItemKalkuExcel1")]
    [StringLength(50)]
    public string FaproposalItemKalkuExcel1 { get; set; }

    [Column("FAProposalItemKalkuExcel2")]
    [StringLength(50)]
    public string FaproposalItemKalkuExcel2 { get; set; }

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

    [Column("NEWFAProposalItem")]
    public int? NewfaproposalItem { get; set; }

    [ForeignKey("FaproductIdcombo")]
    [InverseProperty("FaproposalItems")]
    public virtual Icproduct FaproductIdcomboNavigation { get; set; }

    [ForeignKey("FaproposalId")]
    [InverseProperty("FaproposalItems")]
    public virtual Oeproposal Faproposal { get; set; }

    [InverseProperty("FaproposalItem")]
    public virtual ICollection<FaproposalItemDiscount> FaproposalItemDiscounts { get; set; } = new List<FaproposalItemDiscount>();

    [InverseProperty("FaproposalItem")]
    public virtual ICollection<FaproposalItemSellOrderItem> FaproposalItemSellOrderItems { get; set; } = new List<FaproposalItemSellOrderItem>();

    [ForeignKey("FastockIdcombo")]
    [InverseProperty("FaproposalItems")]
    public virtual Icstock FastockIdcomboNavigation { get; set; }

    [ForeignKey("FastockSlotIdcombo")]
    [InverseProperty("FaproposalItems")]
    public virtual IcstockSlot FastockSlotIdcomboNavigation { get; set; }

    [ForeignKey("FatextIdcombo")]
    [InverseProperty("FaproposalItems")]
    public virtual Getext FatextIdcomboNavigation { get; set; }
}
