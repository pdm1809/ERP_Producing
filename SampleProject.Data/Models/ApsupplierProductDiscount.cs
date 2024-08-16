using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierProductDiscounts")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkApsupplierId", Name = "Idx_APSupplierProductDiscounts")]
public partial class ApsupplierProductDiscount
{
    [Key]
    [Column("APSupplierProductDiscountID")]
    public int ApsupplierProductDiscountId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APSupplierID")]
    public int FkApsupplierId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("APSupplierProductDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierProductDiscountPercent { get; set; }

    [Column("APSupplierProductDiscountValue", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierProductDiscountValue { get; set; }

    [Column("APSupplierProductDiscountFromQuantity", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierProductDiscountFromQuantity { get; set; }

    [Column("APSupplierProductDiscountToQuantity", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierProductDiscountToQuantity { get; set; }

    [Column("APSupplierProductDiscountFromDate", TypeName = "datetime")]
    public DateTime? ApsupplierProductDiscountFromDate { get; set; }

    [Column("APSupplierProductDiscountToDate", TypeName = "datetime")]
    public DateTime? ApsupplierProductDiscountToDate { get; set; }

    [Column("APSupplierProductDiscountDesc")]
    [StringLength(100)]
    public string ApsupplierProductDiscountDesc { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApsupplierProductDiscounts")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApsupplierProductDiscounts")]
    public virtual Icproduct FkIcproduct { get; set; }
}
