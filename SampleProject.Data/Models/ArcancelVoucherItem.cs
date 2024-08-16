using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCancelVoucherItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkArcancelVoucherId", Name = "Idx_ARCancelVoucherItems")]
public partial class ArcancelVoucherItem
{
    [Key]
    [Column("ARCancelVoucherItemID")]
    public int ArcancelVoucherItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCancelVoucherID")]
    public int FkArcancelVoucherId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("ARCancelVoucherItemProductType")]
    [StringLength(50)]
    public string ArcancelVoucherItemProductType { get; set; }

    [Column("ARCancelVoucherItemProductSerialNo")]
    [StringLength(50)]
    public string ArcancelVoucherItemProductSerialNo { get; set; }

    [Column("ARCancelVoucherItemProductAttribute")]
    [StringLength(200)]
    public string ArcancelVoucherItemProductAttribute { get; set; }

    [Column("ARCancelVoucherItemProductName")]
    [StringLength(50)]
    public string ArcancelVoucherItemProductName { get; set; }

    [Column("ARCancelVoucherItemProductDesc")]
    [StringLength(512)]
    public string ArcancelVoucherItemProductDesc { get; set; }

    [Column("ARCancelVoucherItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemProductUnitPrice { get; set; }

    [Column("ARCancelVoucherItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemProductUnitCost { get; set; }

    [Column("ARCancelVoucherItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemProductDiscount { get; set; }

    [Column("ARCancelVoucherItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemProductTaxPercent { get; set; }

    [Column("ARCancelVoucherItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemProductQty { get; set; }

    [Column("ARCancelVoucherItemOrderedQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemOrderedQty { get; set; }

    [Column("ARCancelVoucherItemTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemTotalQty { get; set; }

    [Column("ARCancelVoucherItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemPrice { get; set; }

    [Column("ARCancelVoucherItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemTaxAmount { get; set; }

    [Column("ARCancelVoucherItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemDiscountAmount { get; set; }

    [Column("ARCancelVoucherItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemNetAmount { get; set; }

    [Column("ARCancelVoucherItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemTotalAmount { get; set; }

    [Column("ARCancelVoucherItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemTotalCost { get; set; }

    [Column("ARCancelVoucherItemProductSupplierNo")]
    [StringLength(50)]
    public string ArcancelVoucherItemProductSupplierNo { get; set; }

    [Column("ARCancelVoucherItemComment")]
    [StringLength(512)]
    public string ArcancelVoucherItemComment { get; set; }

    [Column("ARCancelVoucherItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ArcancelVoucherItemProductNoOfOldSys { get; set; }

    [Column("ARCancelVoucherItemProductCustomerNumber")]
    [StringLength(50)]
    public string ArcancelVoucherItemProductCustomerNumber { get; set; }

    [ForeignKey("FkArcancelVoucherId")]
    [InverseProperty("ArcancelVoucherItems")]
    public virtual ArcancelVoucher FkArcancelVoucher { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArcancelVoucherItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArcancelVoucherItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArcancelVoucherItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArcancelVoucherItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArcancelVoucherItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArcancelVoucherItems")]
    public virtual Icstock FkIcstock { get; set; }
}
