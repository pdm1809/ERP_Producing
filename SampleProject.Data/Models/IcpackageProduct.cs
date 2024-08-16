using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPackageProducts")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ICPackageProducts")]
public partial class IcpackageProduct
{
    [Key]
    [Column("ICPackageProductID")]
    public int IcpackageProductId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICPackageID")]
    public int FkIcpackageId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICPackageProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcpackageProductQty { get; set; }

    [ForeignKey("FkIcpackageId")]
    [InverseProperty("IcpackageProducts")]
    public virtual Icpackage FkIcpackage { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcpackageProducts")]
    public virtual Icproduct FkIcproduct { get; set; }
}
