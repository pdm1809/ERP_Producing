using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARAdjustSaleOrderQuantityItems")]
public partial class AradjustSaleOrderQuantityItem
{
    [Key]
    [Column("ARAdjustSaleOrderQuantityItemID")]
    public int AradjustSaleOrderQuantityItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_ARAdjustSaleOrderQuantityID")]
    public int FkAradjustSaleOrderQuantityId { get; set; }

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

    [Column("ARAdjustSaleOrderQuantityItemProductType")]
    [StringLength(50)]
    public string AradjustSaleOrderQuantityItemProductType { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductSerialNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AradjustSaleOrderQuantityItemProductSerialNo { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductAttribute")]
    [StringLength(200)]
    public string AradjustSaleOrderQuantityItemProductAttribute { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductName")]
    [StringLength(50)]
    public string AradjustSaleOrderQuantityItemProductName { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductDesc")]
    [StringLength(512)]
    public string AradjustSaleOrderQuantityItemProductDesc { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemProductUnitPrice { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemProductUnitCost { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemProductDiscount { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemProductTaxPercent { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemProductQty { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemOrderedQty", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemOrderedQty { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemTotalQty { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemPrice { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemTaxAmount { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemDiscountAmount { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemNetAmount { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemTotalAmount { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemTotalCost { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductSupplierNo")]
    [StringLength(50)]
    public string AradjustSaleOrderQuantityItemProductSupplierNo { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemComment")]
    [StringLength(512)]
    public string AradjustSaleOrderQuantityItemComment { get; set; }

    [Column("ARAdjustSaleOrderQuantityItemProductOldQty", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityItemProductOldQty { get; set; }

    [ForeignKey("FkAradjustSaleOrderQuantityId")]
    [InverseProperty("AradjustSaleOrderQuantityItems")]
    public virtual AradjustSaleOrderQuantity FkAradjustSaleOrderQuantity { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("AradjustSaleOrderQuantityItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("AradjustSaleOrderQuantityItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AradjustSaleOrderQuantityItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("AradjustSaleOrderQuantityItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("AradjustSaleOrderQuantityItems")]
    public virtual Icstock FkIcstock { get; set; }
}
