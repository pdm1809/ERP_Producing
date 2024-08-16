using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormItemMeterials")]
public partial class MmproductionNormItemMeterial
{
    [Key]
    [Column("MMProductionNormItemMeterialID")]
    public int MmproductionNormItemMeterialId { get; set; }

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

    [Column("FK_ICProductAlternativeID")]
    public int? FkIcproductAlternativeId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

    [Column("FK_MMFormulaID")]
    public int? FkMmformulaId { get; set; }

    [Column("MMProductionNormItemMeterialLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemMeterialLength { get; set; }

    [Column("MMProductionNormItemMeterialWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemMeterialWidth { get; set; }

    [Column("MMProductionNormItemMeterialHeigth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemMeterialHeigth { get; set; }

    [Column("MMProductionNormItemMeterialDesc")]
    [StringLength(524)]
    public string MmproductionNormItemMeterialDesc { get; set; }

    [Column("MMProductionNormItemMeterialWoodBlocks", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionNormItemMeterialWoodBlocks { get; set; }

    [Column("MMProductionNormItemMeterialConsumable", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemMeterialConsumable { get; set; }

    [Column("MMProductionNormItemMeterialWaste", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemMeterialWaste { get; set; }

    [Column("MMProductionNormItemMeterialWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionNormItemMeterialWoodQty { get; set; }

    [Column("MMProductionNormItemMeterialQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionNormItemMeterialQty { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmproductionNormItemMeterials")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionNormItemMeterialFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAlternativeId")]
    [InverseProperty("MmproductionNormItemMeterialFkIcproductAlternatives")]
    public virtual Icproduct FkIcproductAlternative { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmproductionNormItemMeterials")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }
}
