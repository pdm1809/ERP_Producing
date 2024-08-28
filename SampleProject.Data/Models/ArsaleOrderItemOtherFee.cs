using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderItemOtherFees")]
public partial class ArsaleOrderItemOtherFee
{
    [Key]
    [Column("ARSaleOrderItemOtherFeeID")]
    public int ArsaleOrderItemOtherFeeId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("ARSaleOrderItemOtherFeeName")]
    [StringLength(512)]
    public string ArsaleOrderItemOtherFeeName { get; set; }

    [Column("ARSaleOrderItemOtherFeeQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemOtherFeeQty { get; set; }

    [Column("ARSaleOrderItemOtherFeeUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemOtherFeeUnitPrice { get; set; }

    [Column("ARSaleOrderItemOtherFeeTotalPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemOtherFeeTotalPrice { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderItemOtherFees")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }
}
