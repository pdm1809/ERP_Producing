using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCalculatorProductionNormItemMaterials")]
public partial class MmcalculatorProductionNormItemMaterial
{
    [Key]
    [Column("MMCalculatorProductionNormItemMaterialID")]
    public int MmcalculatorProductionNormItemMaterialId { get; set; }

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

    [Column("FK_MMCalculatorProductionNormCostID")]
    public int? FkMmcalculatorProductionNormCostId { get; set; }

    [Column("FK_ICProductMaterialID")]
    public int? FkIcproductMaterialId { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialHeigth", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialHeigth { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialLengthMin", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialLengthMin { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialLengthMax", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialLengthMax { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialWidthMin", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialWidthMin { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialWidthMax", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialWidthMax { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialDepreciationQty", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialDepreciationQty { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialUnitCost", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialUnitCost { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialTotalCost", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialTotalCost { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialDepreciationFactor", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialDepreciationFactor { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? MmcalculatorProductionNormItemMaterialWoodQty { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialNo")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemMaterialNo { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialName")]
    [StringLength(256)]
    public string MmcalculatorProductionNormItemMaterialName { get; set; }

    [Column("MMCalculatorProductionNormItemMaterialDesc")]
    [StringLength(512)]
    public string MmcalculatorProductionNormItemMaterialDesc { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmcalculatorProductionNormItemMaterials")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductMaterialId")]
    [InverseProperty("MmcalculatorProductionNormItemMaterials")]
    public virtual Icproduct FkIcproductMaterial { get; set; }

    [ForeignKey("FkMmcalculatorProductionNormCostId")]
    [InverseProperty("MmcalculatorProductionNormItemMaterials")]
    public virtual MmcalculatorProductionNormCost FkMmcalculatorProductionNormCost { get; set; }
}
