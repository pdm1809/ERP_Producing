using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICTransferItemPackages")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcstockId", Name = "Idx_ICTransferItemPackages")]
public partial class IctransferItemPackage
{
    [Key]
    [Column("ICTransferItemPackageID")]
    public int IctransferItemPackageId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICTransferItemID")]
    public int FkIctransferItemId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICPackageID")]
    public int FkIcpackageId { get; set; }

    [Column("ICTransferItemPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IctransferItemPackageQty { get; set; }

    [ForeignKey("FkIcpackageId")]
    [InverseProperty("IctransferItemPackages")]
    public virtual Icpackage FkIcpackage { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IctransferItemPackages")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IctransferItemPackages")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIctransferItemId")]
    [InverseProperty("IctransferItemPackages")]
    public virtual IctransferItem FkIctransferItem { get; set; }
}
