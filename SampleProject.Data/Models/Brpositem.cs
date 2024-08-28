using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("BRPOSItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkBrposid", Name = "Idx_BRPOSItems")]
public partial class Brpositem
{
    [Key]
    [Column("BRPOSItemID")]
    public int BrpositemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AAIsCalculated")]
    public bool? AaisCalculated { get; set; }

    [Column("FK_BRPOSID")]
    public int FkBrposid { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("BRPOSItemProductSerialNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrpositemProductSerialNo { get; set; }

    [Column("BRPOSItemProductAttribute")]
    [StringLength(200)]
    public string BrpositemProductAttribute { get; set; }

    [Column("BRPOSItemProductType")]
    [StringLength(50)]
    public string BrpositemProductType { get; set; }

    [Column("BRPOSItemSortOrder")]
    public int? BrpositemSortOrder { get; set; }

    [Column("BRPOSItemProductName")]
    [StringLength(50)]
    public string BrpositemProductName { get; set; }

    [Column("BRPOSItemProductDesc", TypeName = "ntext")]
    public string BrpositemProductDesc { get; set; }

    [Column("BRPOSItemProductSellUnit")]
    [StringLength(50)]
    public string BrpositemProductSellUnit { get; set; }

    [Column("BRPOSItemProductBasicUnit")]
    [StringLength(50)]
    public string BrpositemProductBasicUnit { get; set; }

    [Column("BRPOSItemProductPackagingUnit")]
    [StringLength(50)]
    public string BrpositemProductPackagingUnit { get; set; }

    [Column("BRPOSItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductSellFactor { get; set; }

    [Column("BRPOSItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductPackagingFactor { get; set; }

    [Column("BRPOSItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductUnitPrice { get; set; }

    [Column("BRPOSItemProductInternalUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductInternalUnitPrice { get; set; }

    [Column("BRPOSItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductUnitCost { get; set; }

    [Column("BRPOSItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductGroupDiscount { get; set; }

    [Column("BRPOSItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductDiscount { get; set; }

    [Column("BRPOSItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductTaxPercent { get; set; }

    [Column("BRPOSItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductQtyOld { get; set; }

    [Column("BRPOSItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductQty { get; set; }

    [Column("BRPOSItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductBasicQty { get; set; }

    [Column("BRPOSItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemProductPakagingQty { get; set; }

    [Column("BRPOSItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemQty1 { get; set; }

    [Column("BRPOSItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemQty2 { get; set; }

    [Column("BRPOSItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemQty3 { get; set; }

    [Column("BRPOSItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemQty4 { get; set; }

    [Column("BRPOSItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemQty5 { get; set; }

    [Column("BRPOSItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemQty6 { get; set; }

    [Column("BRPOSItemComment")]
    [StringLength(50)]
    public string BrpositemComment { get; set; }

    [Column("BRPOSItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemUnitVolumn { get; set; }

    [Column("BRPOSItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemUnitWeight { get; set; }

    [Column("BRPOSItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemPrice { get; set; }

    [Column("BRPOSItemInternalPrice", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemInternalPrice { get; set; }

    [Column("BRPOSItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemTaxAmount { get; set; }

    [Column("BRPOSItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemDiscountAmount { get; set; }

    [Column("BRPOSItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemNetAmount { get; set; }

    [Column("BRPOSItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemTotalAmount { get; set; }

    [Column("BRPOSItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? BrpositemTotalCost { get; set; }

    [ForeignKey("FkBrposid")]
    [InverseProperty("Brpositems")]
    public virtual Brposs FkBrpos { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("Brpositems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("Brpositems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("Brpositems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("Brpositems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("Brpositems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }
}
