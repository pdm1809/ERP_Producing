using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCreditNoteItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkArcreditNoteId", Name = "Idx_ARCreditNoteItems")]
public partial class ArcreditNoteItem
{
    [Key]
    [Column("ARCreditNoteItemID")]
    public int ArcreditNoteItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCreditNoteID")]
    public int? FkArcreditNoteId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("ARCreditNoteItemProductType")]
    [StringLength(50)]
    public string ArcreditNoteItemProductType { get; set; }

    [Column("ARCreditNoteItemProductSerialNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcreditNoteItemProductSerialNo { get; set; }

    [Column("ARCreditNoteItemSortOrder")]
    public int? ArcreditNoteItemSortOrder { get; set; }

    [Column("ARCreditNoteItemProductDesc", TypeName = "ntext")]
    public string ArcreditNoteItemProductDesc { get; set; }

    [Column("ARCreditNoteItemProductSellUnit")]
    [StringLength(50)]
    public string ArcreditNoteItemProductSellUnit { get; set; }

    [Column("ARCreditNoteItemProductBasicUnit")]
    [StringLength(50)]
    public string ArcreditNoteItemProductBasicUnit { get; set; }

    [Column("ARCreditNoteItemProductPackagingUnit")]
    [StringLength(50)]
    public string ArcreditNoteItemProductPackagingUnit { get; set; }

    [Column("ARCreditNoteItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductSellFactor { get; set; }

    [Column("ARCreditNoteItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductPackagingFactor { get; set; }

    [Column("ARCreditNoteItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductUnitPrice { get; set; }

    [Column("ARCreditNoteItemProductInternalUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductInternalUnitPrice { get; set; }

    [Column("ARCreditNoteItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductUnitCost { get; set; }

    [Column("ARCreditNoteItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductGroupDiscount { get; set; }

    [Column("ARCreditNoteItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductDiscount { get; set; }

    [Column("ARCreditNoteItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductTaxPercent { get; set; }

    [Column("ARCreditNoteItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductQtyOld { get; set; }

    [Column("ARCreditNoteItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductQty { get; set; }

    [Column("ARCreditNoteItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductBasicQty { get; set; }

    [Column("ARCreditNoteItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemProductPakagingQty { get; set; }

    [Column("ARCreditNoteItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemQty1 { get; set; }

    [Column("ARCreditNoteItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemQty2 { get; set; }

    [Column("ARCreditNoteItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemQty3 { get; set; }

    [Column("ARCreditNoteItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemQty4 { get; set; }

    [Column("ARCreditNoteItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemQty5 { get; set; }

    [Column("ARCreditNoteItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemQty6 { get; set; }

    [Column("ARCreditNoteItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemPrice { get; set; }

    [Column("ARCreditNoteItemInternalPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemInternalPrice { get; set; }

    [Column("ARCreditNoteItemComment")]
    [StringLength(50)]
    public string ArcreditNoteItemComment { get; set; }

    [Column("ARCreditNoteItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemUnitVolumn { get; set; }

    [Column("ARCreditNoteItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemUnitWeight { get; set; }

    [Column("ARCreditNoteItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemTaxAmount { get; set; }

    [Column("ARCreditNoteItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemDiscountAmount { get; set; }

    [Column("ARCreditNoteItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemNetAmount { get; set; }

    [Column("ARCreditNoteItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemTotalAmount { get; set; }

    [Column("ARCreditNoteItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArcreditNoteItemTotalCost { get; set; }

    [InverseProperty("FkArcreditNoteItem")]
    public virtual ICollection<ArcreditNoteItemInvoiceItem> ArcreditNoteItemInvoiceItems { get; set; } = new List<ArcreditNoteItemInvoiceItem>();

    [ForeignKey("FkArcreditNoteId")]
    [InverseProperty("ArcreditNoteItems")]
    public virtual ArcreditNote FkArcreditNote { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArcreditNoteItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArcreditNoteItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("ArcreditNoteItems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }
}
