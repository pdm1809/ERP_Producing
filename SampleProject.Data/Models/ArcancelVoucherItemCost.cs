using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCancelVoucherItemCosts")]
public partial class ArcancelVoucherItemCost
{
    [Key]
    [Column("ARCancelVoucherItemCostID")]
    public int ArcancelVoucherItemCostId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ARCancelVoucherID")]
    public int? FkArcancelVoucherId { get; set; }

    [Column("FK_ARSaleOrderItemWorkID")]
    public int? FkArsaleOrderItemWorkId { get; set; }

    [Column("ARCancelVoucherItemCostProductNo")]
    [StringLength(50)]
    public string ArcancelVoucherItemCostProductNo { get; set; }

    [Column("ARCancelVoucherItemCostProductName")]
    [StringLength(256)]
    public string ArcancelVoucherItemCostProductName { get; set; }

    [Column("ARCancelVoucherItemCostProductDesc")]
    [StringLength(512)]
    public string ArcancelVoucherItemCostProductDesc { get; set; }

    [Column("ARCancelVoucherItemCostProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemCostProductQty { get; set; }

    [Column("ARCancelVoucherItemCostProductCancelQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemCostProductCancelQty { get; set; }

    [Column("ARCancelVoucherItemCostProductCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemCostProductCanceledQty { get; set; }

    [Column("ARCancelVoucherItemCostProductType")]
    [StringLength(50)]
    public string ArcancelVoucherItemCostProductType { get; set; }

    [Column("ARCancelVoucherItemCostProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemCostProductUnitPrice { get; set; }

    [Column("ARCancelVoucherItemCostTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemCostTotalAmount { get; set; }

    [Column("ARCancelVoucherItemCostSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemCostSubTotalAmount { get; set; }

    [Column("ARCancelVoucherItemCostComment")]
    [StringLength(256)]
    public string ArcancelVoucherItemCostComment { get; set; }

    [Column("ARCancelVoucherItemCostDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemCostDiscountAmount { get; set; }

    [Column("ARCancelVoucherItemCostDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherItemCostDiscountPercent { get; set; }

    [Column("ARCancelVoucherItemCostStatus")]
    [StringLength(50)]
    public string ArcancelVoucherItemCostStatus { get; set; }

    [Column("ARCancelVoucherItemCostIsCharge")]
    public bool? ArcancelVoucherItemCostIsCharge { get; set; }

    [ForeignKey("FkArcancelVoucherId")]
    [InverseProperty("ArcancelVoucherItemCosts")]
    public virtual ArcancelVoucher FkArcancelVoucher { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArcancelVoucherItemCosts")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArcancelVoucherItemCosts")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkArsaleOrderItemWorkId")]
    [InverseProperty("ArcancelVoucherItemCosts")]
    public virtual ArsaleOrderItemWork FkArsaleOrderItemWork { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArcancelVoucherItemCosts")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArcancelVoucherItemCosts")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArcancelVoucherItemCosts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArcancelVoucherItemCosts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
