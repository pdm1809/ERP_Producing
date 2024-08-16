using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCancelSaleForecastItems")]
public partial class ArcancelSaleForecastItem
{
    [Key]
    [Column("ARCancelSaleForecastItemID")]
    public int ArcancelSaleForecastItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCancelSaleForecastID")]
    public int FkArcancelSaleForecastId { get; set; }

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

    [Column("FK_ARSaleForecastID")]
    public int? FkArsaleForecastId { get; set; }

    [Column("FK_ARSaleForecastItemID")]
    public int? FkArsaleForecastItemId { get; set; }

    [Column("ARCancelSaleForecastItemProductType")]
    [StringLength(50)]
    public string ArcancelSaleForecastItemProductType { get; set; }

    [Column("ARCancelSaleForecastItemProductSerialNo")]
    [StringLength(50)]
    public string ArcancelSaleForecastItemProductSerialNo { get; set; }

    [Column("ARCancelSaleForecastItemProductAttribute")]
    [StringLength(200)]
    public string ArcancelSaleForecastItemProductAttribute { get; set; }

    [Column("ARCancelSaleForecastItemProductName")]
    [StringLength(50)]
    public string ArcancelSaleForecastItemProductName { get; set; }

    [Column("ARCancelSaleForecastItemProductDesc")]
    [StringLength(512)]
    public string ArcancelSaleForecastItemProductDesc { get; set; }

    [Column("ARCancelSaleForecastItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemProductUnitPrice { get; set; }

    [Column("ARCancelSaleForecastItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemProductUnitCost { get; set; }

    [Column("ARCancelSaleForecastItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemProductDiscount { get; set; }

    [Column("ARCancelSaleForecastItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemProductTaxPercent { get; set; }

    [Column("ARCancelSaleForecastItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemProductQty { get; set; }

    [Column("ARCancelSaleForecastItemSaleForecastQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemSaleForecastQty { get; set; }

    [Column("ARCancelSaleForecastItemTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemTotalQty { get; set; }

    [Column("ARCancelSaleForecastItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemPrice { get; set; }

    [Column("ARCancelSaleForecastItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemTaxAmount { get; set; }

    [Column("ARCancelSaleForecastItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemDiscountAmount { get; set; }

    [Column("ARCancelSaleForecastItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemNetAmount { get; set; }

    [Column("ARCancelSaleForecastItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemTotalAmount { get; set; }

    [Column("ARCancelSaleForecastItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastItemTotalCost { get; set; }

    [Column("ARCancelSaleForecastItemProductSupplierNo")]
    [StringLength(50)]
    public string ArcancelSaleForecastItemProductSupplierNo { get; set; }

    [Column("ARCancelSaleForecastItemComment")]
    [StringLength(512)]
    public string ArcancelSaleForecastItemComment { get; set; }

    [Column("ARCancelSaleForecastItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ArcancelSaleForecastItemProductNoOfOldSys { get; set; }

    [Column("ARCancelSaleForecastItemProductCustomerNumber")]
    [StringLength(50)]
    public string ArcancelSaleForecastItemProductCustomerNumber { get; set; }

    [ForeignKey("FkArcancelSaleForecastId")]
    [InverseProperty("ArcancelSaleForecastItems")]
    public virtual ArcancelSaleForecast FkArcancelSaleForecast { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArcancelSaleForecastItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArcancelSaleForecastItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArcancelSaleForecastItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArcancelSaleForecastItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArcancelSaleForecastItems")]
    public virtual Icstock FkIcstock { get; set; }
}
