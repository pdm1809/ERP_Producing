using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICAdjustmentItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcstockId", "FkIcadjustmentId", Name = "Idx_ICAdjustmentItems")]
public partial class IcadjustmentItem
{
    [Key]
    [Column("ICAdjustmentItemID")]
    public int IcadjustmentItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICAdjustmentID")]
    public int FkIcadjustmentId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("ICAdjustmentItemProductSerialNo")]
    [StringLength(50)]
    public string IcadjustmentItemProductSerialNo { get; set; }

    [Column("ICAdjustmentItemProductAttribute")]
    [StringLength(200)]
    public string IcadjustmentItemProductAttribute { get; set; }

    [Column("ICAdjustmentItemProductType")]
    [StringLength(50)]
    public string IcadjustmentItemProductType { get; set; }

    [Column("ICAdjustmentItemSortOrder")]
    public int? IcadjustmentItemSortOrder { get; set; }

    [Column("ICAdjustmentItemProductName")]
    [StringLength(50)]
    public string IcadjustmentItemProductName { get; set; }

    [Column("ICAdjustmentItemProductDesc", TypeName = "ntext")]
    public string IcadjustmentItemProductDesc { get; set; }

    [Column("ICAdjustmentItemProductSellUnit")]
    [StringLength(50)]
    public string IcadjustmentItemProductSellUnit { get; set; }

    [Column("ICAdjustmentItemProductBasicUnit")]
    [StringLength(50)]
    public string IcadjustmentItemProductBasicUnit { get; set; }

    [Column("ICAdjustmentItemProductPackagingUnit")]
    [StringLength(50)]
    public string IcadjustmentItemProductPackagingUnit { get; set; }

    [Column("ICAdjustmentItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductSellFactor { get; set; }

    [Column("ICAdjustmentItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductPackagingFactor { get; set; }

    [Column("ICAdjustmentItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductUnitPrice { get; set; }

    [Column("ICAdjustmentItemProductInternalUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductInternalUnitPrice { get; set; }

    [Column("ICAdjustmentItemProductOldUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductOldUnitCost { get; set; }

    [Column("ICAdjustmentItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductUnitCost { get; set; }

    [Column("ICAdjustmentItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductGroupDiscount { get; set; }

    [Column("ICAdjustmentItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductDiscount { get; set; }

    [Column("ICAdjustmentItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductTaxPercent { get; set; }

    [Column("ICAdjustmentItemProductOldQty", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductOldQty { get; set; }

    [Column("ICAdjustmentItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductQty { get; set; }

    [Column("ICAdjustmentItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductBasicQty { get; set; }

    [Column("ICAdjustmentItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemProductPakagingQty { get; set; }

    [Column("ICAdjustmentItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemQty1 { get; set; }

    [Column("ICAdjustmentItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemQty2 { get; set; }

    [Column("ICAdjustmentItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemQty3 { get; set; }

    [Column("ICAdjustmentItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemQty4 { get; set; }

    [Column("ICAdjustmentItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemQty5 { get; set; }

    [Column("ICAdjustmentItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemQty6 { get; set; }

    [Column("ICAdjustmentItemComment")]
    [StringLength(50)]
    public string IcadjustmentItemComment { get; set; }

    [Column("ICAdjustmentItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemUnitVolumn { get; set; }

    [Column("ICAdjustmentItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemUnitWeight { get; set; }

    [Column("ICAdjustmentItemDiffTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcadjustmentItemDiffTotalCost { get; set; }

    [ForeignKey("FkIcadjustmentId")]
    [InverseProperty("IcadjustmentItems")]
    public virtual Icadjustment FkIcadjustment { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcadjustmentItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcadjustmentItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcadjustmentItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcadjustmentItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("IcadjustmentItems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }
}
