using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FATransferStockInItems")]
public partial class FatransferStockInItem
{
    [Key]
    [Column("FATransferStockInItemID")]
    public int FatransferStockInItemId { get; set; }

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

    [Column("FATransferStockInItemProductType")]
    [StringLength(50)]
    public string FatransferStockInItemProductType { get; set; }

    [Column("FATransferStockInItemTypeCombo")]
    [StringLength(20)]
    public string FatransferStockInItemTypeCombo { get; set; }

    [Column("FATransferStockInItemSortOrder")]
    public int? FatransferStockInItemSortOrder { get; set; }

    [Column("FATransferStockInItemProductDesc", TypeName = "ntext")]
    public string FatransferStockInItemProductDesc { get; set; }

    [Column("FATransferStockInItemProductDescOri")]
    [StringLength(500)]
    public string FatransferStockInItemProductDescOri { get; set; }

    [Column("FASellerOrderItemSerieNumberCheck")]
    public bool? FasellerOrderItemSerieNumberCheck { get; set; }

    [Column("FATransferStockInItemProductSellUnit")]
    [StringLength(50)]
    public string FatransferStockInItemProductSellUnit { get; set; }

    [Column("FATransferStockInItemProductBasicUnit")]
    [StringLength(50)]
    public string FatransferStockInItemProductBasicUnit { get; set; }

    [Column("FATransferStockInItemProductPackagingUnit")]
    [StringLength(50)]
    public string FatransferStockInItemProductPackagingUnit { get; set; }

    [Column("FATransferStockInItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductSellFactor { get; set; }

    [Column("FATransferStockInItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductPackagingFactor { get; set; }

    [Column("FATransferStockInItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductUnitPrice { get; set; }

    [Column("FATransferStockInItemProductUnitBuyingPrice", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductUnitBuyingPrice { get; set; }

    [Column("FATransferStockInItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductGroupDiscount { get; set; }

    [Column("FATransferStockInItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductDiscount { get; set; }

    [Column("FATransferStockInItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductTaxPercent { get; set; }

    [Column("FATransferStockInItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductQtyOld { get; set; }

    [Column("FATransferStockInItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductQty { get; set; }

    [Column("FATransferStockInItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductBasicQty { get; set; }

    [Column("FATransferStockInItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemProductPakagingQty { get; set; }

    [Column("FATransferStockInItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemQty1 { get; set; }

    [Column("FATransferStockInItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemQty2 { get; set; }

    [Column("FATransferStockInItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemQty3 { get; set; }

    [Column("FATransferStockInItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemQty4 { get; set; }

    [Column("FATransferStockInItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemQty5 { get; set; }

    [Column("FATransferStockInItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemQty6 { get; set; }

    [Column("FATransferStockInItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemPrice { get; set; }

    [Column("FATransferStockInItemComment")]
    [StringLength(50)]
    public string FatransferStockInItemComment { get; set; }

    [Column("FATransferStockInItemCalcuEKFix", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemCalcuEkfix { get; set; }

    [Column("FATransferStockInItemCalcuEK", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemCalcuEk { get; set; }

    [Column("FATransferStockInItemCalcuGP", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemCalcuGp { get; set; }

    [Column("FATransferStockInItemCalcuVP", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemCalcuVp { get; set; }

    [Column("FATransferStockInItemCalcuVK", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemCalcuVk { get; set; }

    [Column("FATransferStockInItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemUnitVolumn { get; set; }

    [Column("FATransferStockInItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? FatransferStockInItemUnitWeight { get; set; }

    [Column("FATransferStockInItemCalcuExcel1")]
    [StringLength(50)]
    public string FatransferStockInItemCalcuExcel1 { get; set; }

    [Column("FATransferStockInItemCalcuExcel2")]
    [StringLength(50)]
    public string FatransferStockInItemCalcuExcel2 { get; set; }

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

    [Column("NEWFATransferStockInItem")]
    public int? NewfatransferStockInItem { get; set; }

    [ForeignKey("FaproductIdcombo")]
    [InverseProperty("FatransferStockInItems")]
    public virtual Icproduct FaproductIdcomboNavigation { get; set; }

    [ForeignKey("FastockIdcombo")]
    [InverseProperty("FatransferStockInItems")]
    public virtual Icstock FastockIdcomboNavigation { get; set; }

    [ForeignKey("FastockSlotIdcombo")]
    [InverseProperty("FatransferStockInItems")]
    public virtual IcstockSlot FastockSlotIdcomboNavigation { get; set; }

    [ForeignKey("FatextIdcombo")]
    [InverseProperty("FatransferStockInItems")]
    public virtual Getext FatextIdcomboNavigation { get; set; }

    [ForeignKey("FatransferId")]
    [InverseProperty("FatransferStockInItems")]
    public virtual Fatransfer Fatransfer { get; set; }

    [InverseProperty("FatransferStockInItem")]
    public virtual ICollection<FatransferStockOutItemTransferStockInItem> FatransferStockOutItemTransferStockInItems { get; set; } = new List<FatransferStockOutItemTransferStockInItem>();
}
