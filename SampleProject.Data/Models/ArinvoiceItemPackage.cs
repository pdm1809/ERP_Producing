using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceItemPackages")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ARInvoiceItemPackages")]
public partial class ArinvoiceItemPackage
{
    [Key]
    [Column("ARInvoiceItemPackageID")]
    public int ArinvoiceItemPackageId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARInvoiceItemID")]
    public int FkArinvoiceItemId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICPackageID")]
    public int FkIcpackageId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ARInvoiceItemPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemPackageQty { get; set; }

    [ForeignKey("FkArinvoiceItemId")]
    [InverseProperty("ArinvoiceItemPackages")]
    public virtual ArinvoiceItem FkArinvoiceItem { get; set; }

    [ForeignKey("FkIcpackageId")]
    [InverseProperty("ArinvoiceItemPackages")]
    public virtual Icpackage FkIcpackage { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArinvoiceItemPackages")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArinvoiceItemPackages")]
    public virtual Icstock FkIcstock { get; set; }
}
