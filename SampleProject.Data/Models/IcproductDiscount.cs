using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductDiscounts")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ICProductDiscounts")]
public partial class IcproductDiscount
{
    [Key]
    [Column("ICProductDiscountID")]
    public int IcproductDiscountId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICProductDiscountQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDiscountQuantity { get; set; }

    [Column("ICProductDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDiscountPercent { get; set; }

    [Column("ICProductDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDiscountAmount { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductDiscounts")]
    public virtual Icproduct FkIcproduct { get; set; }
}
