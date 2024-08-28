using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderItemAllocationFees")]
public partial class ArsaleOrderItemAllocationFee
{
    [Key]
    [Column("ARSaleOrderItemAllocationFeeID")]
    public int ArsaleOrderItemAllocationFeeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("ARSaleOrderItemAllocationFeeProductNo")]
    [StringLength(50)]
    public string ArsaleOrderItemAllocationFeeProductNo { get; set; }

    [Column("ARSaleOrderItemAllocationFeeProductName")]
    [StringLength(256)]
    public string ArsaleOrderItemAllocationFeeProductName { get; set; }

    [Column("ARSaleOrderItemAllocationFeeProductNoOfOldSys")]
    [StringLength(100)]
    public string ArsaleOrderItemAllocationFeeProductNoOfOldSys { get; set; }

    [Column("ARSaleOrderItemAllocationFeeFeePercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemAllocationFeeFeePercent { get; set; }

    [Column("ARSaleOrderItemAllocationFeeFeeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemAllocationFeeFeeAmount { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("ARSaleOrderItemAllocationFeeProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemAllocationFeeProductQty { get; set; }

    [Column("ARSaleOrderItemVirtualID")]
    [StringLength(50)]
    public string ArsaleOrderItemVirtualId { get; set; }

    [Column("ARSaleOrderItemAllocationFeeUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemAllocationFeeUnitPrice { get; set; }

    [Column("ARSaleOrderItemAllocationFeeTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemAllocationFeeTotalAmount { get; set; }

    [Column("ARSaleOrderItemAllocationFeeBasicPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemAllocationFeeBasicPrice { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderItemAllocationFees")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsaleOrderItemAllocationFees")]
    public virtual Icproduct FkIcproduct { get; set; }
}
