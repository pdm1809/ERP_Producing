using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerProductNumbers")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkArcustomerId", Name = "Idx_ARCustomerProductNumbers")]
public partial class ArcustomerProductNumber
{
    [Key]
    [Column("ARCustomerProductNumberID")]
    public int ArcustomerProductNumberId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Required]
    [Column("ARCustomerProductNumber")]
    [StringLength(50)]
    public string ArcustomerProductNumber1 { get; set; }

    [Column("ARCustomerProductNumberDesc")]
    [StringLength(255)]
    public string ArcustomerProductNumberDesc { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcustomerProductNumbers")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArcustomerProductNumbers")]
    public virtual Icproduct FkIcproduct { get; set; }
}
