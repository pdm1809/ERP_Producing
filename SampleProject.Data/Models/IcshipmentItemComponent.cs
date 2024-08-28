using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentItemComponents")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ICShipmentItemComponents")]
public partial class IcshipmentItemComponent
{
    [Key]
    [Column("ICShipmentItemComponentID")]
    public int IcshipmentItemComponentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICShipmentItemID")]
    public int FkIcshipmentItemId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("ICShipmentItemComponentQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentItemComponentQty { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcshipmentItemComponents")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcshipmentItemComponents")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcshipmentItemId")]
    [InverseProperty("IcshipmentItemComponents")]
    public virtual IcshipmentItem FkIcshipmentItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcshipmentItemComponents")]
    public virtual Icstock FkIcstock { get; set; }
}
