using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceItemComponents")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ARInvoiceItemComponents")]
public partial class ArinvoiceItemComponent
{
    [Key]
    [Column("ARInvoiceItemComponentID")]
    public int ArinvoiceItemComponentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARInvoiceItemID")]
    public int FkArinvoiceItemId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("ARInvoiceItemComponentQty", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemComponentQty { get; set; }

    [ForeignKey("FkArinvoiceItemId")]
    [InverseProperty("ArinvoiceItemComponents")]
    public virtual ArinvoiceItem FkArinvoiceItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArinvoiceItemComponents")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ArinvoiceItemComponents")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArinvoiceItemComponents")]
    public virtual Icstock FkIcstock { get; set; }
}
