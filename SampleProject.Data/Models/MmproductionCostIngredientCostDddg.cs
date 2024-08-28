using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostDDDGs")]
public partial class MmproductionCostIngredientCostDddg
{
    [Key]
    [Column("MMProductionCostIngredientCostDDDGID")]
    public int MmproductionCostIngredientCostDddgid { get; set; }

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

    [Column("MMProductionCostIngredientCostDDDGReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDddgreferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostDDDGReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDddgreferenceType { get; set; }

    [Column("MMProductionCostIngredientCostDDDGBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDddgbatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDDGOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDddgoperationName { get; set; }

    [Column("MMProductionCostIngredientCostDDDGMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDddgmeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostDDDGStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDddgstockName { get; set; }

    [Column("MMProductionCostIngredientCostDDDGProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDddgproductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostDDDGProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDddgproductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDDGProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDddgproductName { get; set; }

    [Column("MMProductionCostIngredientCostDDDGProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostDddgproductDesc { get; set; }

    [Column("MMProductionCostIngredientCostDDDGProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDddgproductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostDDDGProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostDddgproductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostDDDGProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgproductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostDDDGProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgproductQty { get; set; }

    [Column("MMProductionCostIngredientCostDDDGTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgtotalCost { get; set; }

    [Column("MMProductionCostIngredientCostDDDGBatchComponent")]
    public int? MmproductionCostIngredientCostDddgbatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostDDDGProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgproductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostDDDGWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgwoodFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDGGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddggeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDGDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgdirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDGHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddghardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDGPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgpaintFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDGMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgmaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDGElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgelecFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDGDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgdepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDGOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddgotherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostDddgs")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
