using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSOItemComponents")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ARSOItemComponents")]
public partial class ArsoitemComponent
{
    [Key]
    [Column("ARSOItemComponentID")]
    public int ArsoitemComponentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int FkArsaleOrderItemId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("ARSOItemComponentQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsoitemComponentQty { get; set; }

    [Column("ARSOItemComponentShippedQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsoitemComponentShippedQty { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArsoitemComponents")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsoitemComponents")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ArsoitemComponents")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArsoitemComponents")]
    public virtual Icstock FkIcstock { get; set; }
}
