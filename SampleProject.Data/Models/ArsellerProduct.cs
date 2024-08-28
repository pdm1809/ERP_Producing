using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSellerProducts")]
public partial class ArsellerProduct
{
    [Key]
    [Column("ARSellerProductID")]
    public int ArsellerProductId { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("ARSellerID")]
    public int ArsellerId { get; set; }

    [Column("ICProductID")]
    public int IcproductId { get; set; }

    [Column("ARSellerProductProvisionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerProductProvisionPercent { get; set; }

    [Column("ARSellerProductProvisionValue", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerProductProvisionValue { get; set; }

    [Column("ARSellerProductDesc")]
    [StringLength(100)]
    public string ArsellerProductDesc { get; set; }

    [ForeignKey("ArsellerId")]
    [InverseProperty("ArsellerProducts")]
    public virtual Arseller Arseller { get; set; }

    [ForeignKey("IcproductId")]
    [InverseProperty("ArsellerProducts")]
    public virtual Icproduct Icproduct { get; set; }
}
