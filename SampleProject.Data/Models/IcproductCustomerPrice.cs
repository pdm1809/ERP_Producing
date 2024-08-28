using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductCustomerPrices")]
public partial class IcproductCustomerPrice
{
    [Key]
    [Column("ICProductCustomerPriceID")]
    public long IcproductCustomerPriceId { get; set; }

    [Column("ICProductCustomerPriceToDate")]
    public DateTime? IcproductCustomerPriceToDate { get; set; }

    [Column("ICProductCustomerPriceProductUnitPrice")]
    [StringLength(255)]
    [Unicode(false)]
    public string IcproductCustomerPriceProductUnitPrice { get; set; }

    [Column("AAStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("IcproductCustomerPrices")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductCustomerPrices")]
    public virtual Icproduct FkIcproduct { get; set; }
}
