using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReturnShippingItems")]
public partial class IcreturnShippingItem
{
    [Key]
    [Column("ICReturnShippingItemID")]
    public int IcreturnShippingItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICReturnShippingID")]
    public int FkIcreturnShippingId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("ICReturnShippingItemProductSerialNo")]
    [StringLength(50)]
    public string IcreturnShippingItemProductSerialNo { get; set; }

    [Column("ICReturnShippingItemProductAttribute")]
    [StringLength(200)]
    public string IcreturnShippingItemProductAttribute { get; set; }

    [Column("ICReturnShippingItemProductType")]
    [StringLength(50)]
    public string IcreturnShippingItemProductType { get; set; }

    [Column("ICReturnShippingItemSortOrder")]
    public int? IcreturnShippingItemSortOrder { get; set; }

    [Column("ICReturnShippingItemProductName")]
    [StringLength(50)]
    public string IcreturnShippingItemProductName { get; set; }

    [Column("ICReturnShippingItemProductDesc", TypeName = "ntext")]
    public string IcreturnShippingItemProductDesc { get; set; }

    [Column("ICReturnShippingItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemProductUnitPrice { get; set; }

    [Column("ICReturnShippingItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemProductUnitCost { get; set; }

    [Column("ICReturnShippingItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemProductDiscount { get; set; }

    [Column("ICReturnShippingItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemProductTaxPercent { get; set; }

    [Column("ICReturnShippingItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemProductQty { get; set; }

    [Column("ICReturnShippingItemComment")]
    [StringLength(50)]
    public string IcreturnShippingItemComment { get; set; }

    [Column("ICReturnShippingItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemPrice { get; set; }

    [Column("ICReturnShippingItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemTaxAmount { get; set; }

    [Column("ICReturnShippingItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemDiscountAmount { get; set; }

    [Column("ICReturnShippingItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemNetAmount { get; set; }

    [Column("ICReturnShippingItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemTotalAmount { get; set; }

    [Column("ICReturnShippingItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemTotalCost { get; set; }

    [Column("ICReturnShippingItemProductSupplierNo")]
    [StringLength(50)]
    public string IcreturnShippingItemProductSupplierNo { get; set; }

    [Column("FK_ICShipmentItemID")]
    public int? FkIcshipmentItemId { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [Column("ICReturnShippingItemProductQtyReturn", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemProductQtyReturn { get; set; }

    [Column("ICReturnShippingItemProductQtyReturnOld", TypeName = "decimal(18, 5)")]
    public decimal? IcreturnShippingItemProductQtyReturnOld { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcreturnShippingItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcreturnShippingItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcreturnShippingItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcreturnShippingItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcreturnShippingItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcreturnShippingId")]
    [InverseProperty("IcreturnShippingItems")]
    public virtual IcreturnShipping FkIcreturnShipping { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("IcreturnShippingItems")]
    public virtual Icshipment FkIcshipment { get; set; }

    [ForeignKey("FkIcshipmentItemId")]
    [InverseProperty("IcreturnShippingItems")]
    public virtual IcshipmentItem FkIcshipmentItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcreturnShippingItems")]
    public virtual Icstock FkIcstock { get; set; }
}
