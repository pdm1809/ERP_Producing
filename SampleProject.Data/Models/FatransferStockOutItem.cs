using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FATransferStockOutItems")]
public partial class FatransferStockOutItem
{
    [Key]
    [Column("FATransferStockOutItemID")]
    public int FatransferStockOutItemId { get; set; }

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

    [Column("FATransferID")]
    public int? FatransferId { get; set; }

    [Column("FATextIDCombo")]
    public int? FatextIdcombo { get; set; }

    [Column("FAProductIDCombo")]
    public int? FaproductIdcombo { get; set; }

    [Column("FAStockIDCombo")]
    public int? FastockIdcombo { get; set; }

    [Column("FAStockSlotIDCombo")]
    public int? FastockSlotIdcombo { get; set; }

    [Column("FATransferStockOutItemProductType")]
    [StringLength(50)]
    public string FatransferStockOutItemProductType { get; set; }

    [Column("FATransferStockOutItemTypeCombo")]
    [StringLength(20)]
    public string FatransferStockOutItemTypeCombo { get; set; }

    [Column("FATransferStockOutItemSortOrder")]
    public int? FatransferStockOutItemSortOrder { get; set; }

    [Column("FATransferStockOutItemProductDesc", TypeName = "ntext")]
    public string FatransferStockOutItemProductDesc { get; set; }

    [Column("FATransferStockOutItemProductDescOri")]
    [StringLength(500)]
    public string FatransferStockOutItemProductDescOri { get; set; }

    [Column("FASellerOrderItemSerieNumberCheck")]
    public bool? FasellerOrderItemSerieNumberCheck { get; set; }

    [Column("FATransferStockOutItemProductSellUnit")]
    [StringLength(50)]
    public string FatransferStockOutItemProductSellUnit { get; set; }

    [Column("FATransferStockOutItemProductBasicUnit")]
    [StringLength(50)]
    public string FatransferStockOutItemProductBasicUnit { get; set; }

    [Column("FATransferStockOutItemProductPackagingUnit")]
    [StringLength(50)]
    public string FatransferStockOutItemProductPackagingUnit { get; set; }

    [Column("FATransferStockOutItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductSellFactor { get; set; }

    [Column("FATransferStockOutItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductPackagingFactor { get; set; }

    [Column("FATransferStockOutItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductUnitPrice { get; set; }

    [Column("FATransferStockOutItemProductUnitBuyingPrice", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductUnitBuyingPrice { get; set; }

    [Column("FATransferStockOutItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductGroupDiscount { get; set; }

    [Column("FATransferStockOutItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductDiscount { get; set; }

    [Column("FATransferStockOutItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductTaxPercent { get; set; }

    [Column("FATransferStockOutItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductQtyOld { get; set; }

    [Column("FATransferStockOutItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductQty { get; set; }

    [Column("FATransferStockOutItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductBasicQty { get; set; }

    [Column("FATransferStockOutItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemProductPakagingQty { get; set; }

    [Column("FATransferStockOutItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemQty1 { get; set; }

    [Column("FATransferStockOutItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemQty2 { get; set; }

    [Column("FATransferStockOutItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemQty3 { get; set; }

    [Column("FATransferStockOutItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemQty4 { get; set; }

    [Column("FATransferStockOutItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemQty5 { get; set; }

    [Column("FATransferStockOutItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemQty6 { get; set; }

    [Column("FATransferStockOutItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemPrice { get; set; }

    [Column("FATransferStockOutItemComment")]
    [StringLength(50)]
    public string FatransferStockOutItemComment { get; set; }

    [Column("FATransferStockOutItemCalcuEKFix", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemCalcuEkfix { get; set; }

    [Column("FATransferStockOutItemCalcuEK", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemCalcuEk { get; set; }

    [Column("FATransferStockOutItemCalcuGP", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemCalcuGp { get; set; }

    [Column("FATransferStockOutItemCalcuVP", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemCalcuVp { get; set; }

    [Column("FATransferStockOutItemCalcuVK", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemCalcuVk { get; set; }

    [Column("FATransferStockOutItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemUnitVolumn { get; set; }

    [Column("FATransferStockOutItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockOutItemUnitWeight { get; set; }

    [Column("FATransferStockOutItemCalcuExcel1")]
    [StringLength(50)]
    public string FatransferStockOutItemCalcuExcel1 { get; set; }

    [Column("FATransferStockOutItemCalcuExcel2")]
    [StringLength(50)]
    public string FatransferStockOutItemCalcuExcel2 { get; set; }

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

    [Column("NEWFATransferStockOutItem")]
    public int? NewfatransferStockOutItem { get; set; }

    [ForeignKey("FaproductIdcombo")]
    [InverseProperty("FatransferStockOutItems")]
    public virtual Icproduct FaproductIdcomboNavigation { get; set; }

    [ForeignKey("FastockIdcombo")]
    [InverseProperty("FatransferStockOutItems")]
    public virtual Icstock FastockIdcomboNavigation { get; set; }

    [ForeignKey("FastockSlotIdcombo")]
    [InverseProperty("FatransferStockOutItems")]
    public virtual IcstockSlot FastockSlotIdcomboNavigation { get; set; }

    [ForeignKey("FatextIdcombo")]
    [InverseProperty("FatransferStockOutItems")]
    public virtual Getext FatextIdcomboNavigation { get; set; }

    [ForeignKey("FatransferId")]
    [InverseProperty("FatransferStockOutItems")]
    public virtual Fatransfer Fatransfer { get; set; }

    [InverseProperty("FatransferStockOutItem")]
    public virtual ICollection<FatransferStockOutItemTransferStockInItem> FatransferStockOutItemTransferStockInItems { get; set; } = new List<FatransferStockOutItemTransferStockInItem>();
}
