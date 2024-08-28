using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerDiscounts")]
[Microsoft.EntityFrameworkCore.Index("FkArcustomerId", Name = "Idx_ARCustomerDiscounts")]
public partial class ArcustomerDiscount
{
    [Key]
    [Column("ARCustomerDiscountID")]
    public int ArcustomerDiscountId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("FK_ADDiscountID")]
    public int FkAddiscountId { get; set; }

    [ForeignKey("FkAddiscountId")]
    [InverseProperty("ArcustomerDiscounts")]
    public virtual Addiscount FkAddiscount { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcustomerDiscounts")]
    public virtual Arcustomer FkArcustomer { get; set; }
}
