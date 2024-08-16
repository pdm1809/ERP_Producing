using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerProductGroupDiscounts")]
[Microsoft.EntityFrameworkCore.Index("FkArcustomerId", Name = "Idx_ARCustomerProductGroupDiscounts")]
public partial class ArcustomerProductGroupDiscount
{
    [Key]
    [Column("ARCustomerProductGroupDiscountID")]
    public int ArcustomerProductGroupDiscountId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("ARCustomerProductGroupDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerProductGroupDiscountPercent { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcustomerProductGroupDiscounts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArcustomerProductGroupDiscounts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
