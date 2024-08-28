using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductMeasureUnits")]
public partial class IcproductMeasureUnit
{
    [Key]
    [Column("ICProductMeasureUnitID")]
    public int IcproductMeasureUnitId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICProductMeasureUnitFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcproductMeasureUnitFactor { get; set; }

    [Column("ICProductMeasureUnitIsEdit")]
    public bool? IcproductMeasureUnitIsEdit { get; set; }

    [Column("ICProductMeasureUnitFormula")]
    [StringLength(512)]
    [Unicode(false)]
    public string IcproductMeasureUnitFormula { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcproductMeasureUnits")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductMeasureUnits")]
    public virtual Icproduct FkIcproduct { get; set; }
}
