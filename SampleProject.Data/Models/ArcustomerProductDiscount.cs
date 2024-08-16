using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerProductDiscounts")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkArcustomerId", Name = "Idx_ARCustomerProductDiscounts")]
public partial class ArcustomerProductDiscount
{
    [Key]
    [Column("ARCustomerProductDiscountID")]
    public int ArcustomerProductDiscountId { get; set; }

    [Column("ARCustomerProductDiscountName")]
    [StringLength(50)]
    public string ArcustomerProductDiscountName { get; set; }

    [Column("ARCustomerProductDiscountDesc")]
    [StringLength(100)]
    public string ArcustomerProductDiscountDesc { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ARCustomerProductDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerProductDiscountPercent { get; set; }

    [Column("ARCustomerProductDiscountValue", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerProductDiscountValue { get; set; }

    [Column("ARCustomerProductDiscountFromQuantity", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerProductDiscountFromQuantity { get; set; }

    [Column("ARCustomerProductDiscountToQuantity", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerProductDiscountToQuantity { get; set; }

    [Column("ARCustomerProductDiscountFromDate", TypeName = "datetime")]
    public DateTime? ArcustomerProductDiscountFromDate { get; set; }

    [Column("ARCustomerProductDiscountToDate", TypeName = "datetime")]
    public DateTime? ArcustomerProductDiscountToDate { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcustomerProductDiscounts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArcustomerProductDiscounts")]
    public virtual Icproduct FkIcproduct { get; set; }
}
