using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductUnits")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ICProductUnits")]
public partial class IcproductUnit
{
    [Key]
    [Column("ICProductUnitID")]
    public int IcproductUnitId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Column("ICProductUnitFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcproductUnitFactor { get; set; }

    [Column("ICProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductUnitPrice { get; set; }

    [Column("ICProductUnitIsBasic")]
    public bool? IcproductUnitIsBasic { get; set; }

    [Column("ICProductUnitBarCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductUnitBarCode { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcproductUnits")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductUnits")]
    public virtual Icproduct FkIcproduct { get; set; }
}
