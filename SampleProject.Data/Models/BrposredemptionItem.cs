using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("BRPOSRedemptionItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_BRPOSRedemptionItems")]
public partial class BrposredemptionItem
{
    [Key]
    [Column("BRPOSRedemptionItemID")]
    public int BrposredemptionItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_BRPOSID")]
    public int FkBrposid { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("BRPOSRedemptionItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposredemptionItemStatus { get; set; }

    [Column("BRPOSRedemptionItemProductNo")]
    [StringLength(50)]
    public string BrposredemptionItemProductNo { get; set; }

    [Column("BRPOSRedemptionItemProductSerialNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposredemptionItemProductSerialNo { get; set; }

    [Column("BRPOSRedemptionItemProductType")]
    [StringLength(50)]
    public string BrposredemptionItemProductType { get; set; }

    [Column("BRPOSRedemptionItemSortOrder")]
    public int? BrposredemptionItemSortOrder { get; set; }

    [Column("BRPOSRedemptionItemProductDesc", TypeName = "ntext")]
    public string BrposredemptionItemProductDesc { get; set; }

    [Column("BRPOSRedemptionItemProductSellUnit")]
    [StringLength(50)]
    public string BrposredemptionItemProductSellUnit { get; set; }

    [Column("BRPOSRedemptionItemProductBasicUnit")]
    [StringLength(50)]
    public string BrposredemptionItemProductBasicUnit { get; set; }

    [Column("BRPOSRedemptionItemProductPackagingUnit")]
    [StringLength(50)]
    public string BrposredemptionItemProductPackagingUnit { get; set; }

    [Column("BRPOSRedemptionItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemProductSellFactor { get; set; }

    [Column("BRPOSRedemptionItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemProductPackagingFactor { get; set; }

    [Column("BRPOSRedemptionItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemProductUnitPrice { get; set; }

    [Column("BRPOSRedemptionItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemProductQty { get; set; }

    [Column("BRPOSRedemptionItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemQty1 { get; set; }

    [Column("BRPOSRedemptionItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemQty2 { get; set; }

    [Column("BRPOSRedemptionItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemQty3 { get; set; }

    [Column("BRPOSRedemptionItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemQty4 { get; set; }

    [Column("BRPOSRedemptionItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemQty5 { get; set; }

    [Column("BRPOSRedemptionItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemQty6 { get; set; }

    [Column("BRPOSRedemptionItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemUnitVolumn { get; set; }

    [Column("BRPOSRedemptionItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemUnitWeight { get; set; }

    [Column("BRPOSRedemptionItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? BrposredemptionItemPrice { get; set; }

    [ForeignKey("FkBrposid")]
    [InverseProperty("BrposredemptionItems")]
    public virtual Brposs FkBrpos { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("BrposredemptionItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("BrposredemptionItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("BrposredemptionItems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }
}
