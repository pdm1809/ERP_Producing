using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostLRs")]
public partial class MmproductionCostIngredientCostLr
{
    [Key]
    [Column("MMProductionCostIngredientCostLRID")]
    public int MmproductionCostIngredientCostLrid { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_MMProductionCostID")]
    public int FkMmproductionCostId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductIDForBatch")]
    public int? FkIcproductIdforBatch { get; set; }

    [Column("MMProductionCostIngredientCostLRReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostLrreferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostLRReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostLrreferenceType { get; set; }

    [Column("MMProductionCostIngredientCostLRBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostLrbatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostLROperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostLroperationName { get; set; }

    [Column("MMProductionCostIngredientCostLRMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostLrmeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostLRStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostLrstockName { get; set; }

    [Column("MMProductionCostIngredientCostLRProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostLrproductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostLRProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostLrproductNo { get; set; }

    [Column("MMProductionCostIngredientCostLRProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostLrproductName { get; set; }

    [Column("MMProductionCostIngredientCostLRProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostLrproductDesc { get; set; }

    [Column("MMProductionCostIngredientCostLRProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostLrproductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostLRProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostLrproductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostLRProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrproductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostLRProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrproductQty { get; set; }

    [Column("MMProductionCostIngredientCostLRTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrtotalCost { get; set; }

    [Column("MMProductionCostIngredientCostLRBatchComponent")]
    public int? MmproductionCostIngredientCostLrbatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostLRProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrproductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostLRWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrwoodFee { get; set; }

    [Column("MMProductionCostIngredientCostLRGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrgeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostLRDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrdirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostLRHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrhardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostLRPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrpaintFee { get; set; }

    [Column("MMProductionCostIngredientCostLRMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrmaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostLRElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrelecFee { get; set; }

    [Column("MMProductionCostIngredientCostLRDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrdepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostLROtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostLrotherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostLrs")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
