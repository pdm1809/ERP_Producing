using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductItemMaterialLogs")]
public partial class IcproductItemMaterialLog
{
    [Key]
    [Column("ICProductItemMaterialLogID")]
    public int IcproductItemMaterialLogId { get; set; }

    [Column("FK_MMProductionNormApproveLogID")]
    public int? FkMmproductionNormApproveLogId { get; set; }

    [Column("ICProductItemMaterialID")]
    public int? IcproductItemMaterialId { get; set; }

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

    [Column("FK_ICProductCarcassID")]
    public int? FkIcproductCarcassId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductMaterialID")]
    public int? FkIcproductMaterialId { get; set; }

    [Column("ICProductItemMaterialLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialLength { get; set; }

    [Column("ICProductItemMaterialWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialWidth { get; set; }

    [Column("ICProductItemMaterialHeigth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialHeigth { get; set; }

    [Column("ICProductItemMaterialQty", TypeName = "decimal(18, 6)")]
    public decimal? IcproductItemMaterialQty { get; set; }

    [Column("ICProductItemMaterialWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? IcproductItemMaterialWoodQty { get; set; }

    [Column("ICProductItemMaterialDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialDepreciationRate { get; set; }

    [Column("ICProductItemMaterialDepreciationQty", TypeName = "decimal(18, 6)")]
    public decimal? IcproductItemMaterialDepreciationQty { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_MMFormulaID")]
    public int? FkMmformulaId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }
}
