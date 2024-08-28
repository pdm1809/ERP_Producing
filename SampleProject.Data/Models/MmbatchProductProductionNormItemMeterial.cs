using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductProductionNormItemMeterials")]
public partial class MmbatchProductProductionNormItemMeterial
{
    [Key]
    [Column("MMBatchProductProductionNormItemMeterialID")]
    public int MmbatchProductProductionNormItemMeterialId { get; set; }

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

    [Column("FK_MMFormulaID")]
    public int? FkMmformulaId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialLength", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemMeterialLength { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemMeterialWidth { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialHeigth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemMeterialHeigth { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialDesc")]
    [StringLength(524)]
    public string MmbatchProductProductionNormItemMeterialDesc { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialWoodBlocks", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemMeterialWoodBlocks { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialConsumable", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemMeterialConsumable { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialWaste", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemMeterialWaste { get; set; }

    [Column("FK_ICProductItemMaterialID")]
    public int? FkIcproductItemMaterialId { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemMeterialDepreciationRate { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialDepreciationQty", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemMeterialDepreciationQty { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialQty", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemMeterialQty { get; set; }

    [Column("FK_MMProductionNormApproveLogID")]
    public int? FkMmproductionNormApproveLogId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialIsGrain")]
    public bool? MmbatchProductProductionNormItemMeterialIsGrain { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialType")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemMeterialType { get; set; }

    [Column("MMBatchProductProductionNormItemMeterialQtyPerOne", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemMeterialQtyPerOne { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmbatchProductProductionNormItemMeterials")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmbatchProductProductionNormItemMeterialFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAlternativeId")]
    [InverseProperty("MmbatchProductProductionNormItemMeterialFkIcproductAlternatives")]
    public virtual Icproduct FkIcproductAlternative { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductProductionNormItemMeterials")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmbatchProductProductionNormItemMeterials")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmbatchProductProductionNormItemMeterials")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmformulaId")]
    [InverseProperty("MmbatchProductProductionNormItemMeterials")]
    public virtual Mmformula FkMmformula { get; set; }
}
