using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInventoryPackages")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcstockId", Name = "Idx_ICInventoryPackages")]
public partial class IcinventoryPackage
{
    [Key]
    [Column("ICInventoryPackageID")]
    public int IcinventoryPackageId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICPackageID")]
    public int FkIcpackageId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICInventoryPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryPackageQty { get; set; }

    [ForeignKey("FkIcpackageId")]
    [InverseProperty("IcinventoryPackages")]
    public virtual Icpackage FkIcpackage { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcinventoryPackages")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcinventoryPackages")]
    public virtual Icstock FkIcstock { get; set; }
}
