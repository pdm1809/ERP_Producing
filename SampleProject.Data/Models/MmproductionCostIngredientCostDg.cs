using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostDGs")]
public partial class MmproductionCostIngredientCostDg
{
    [Key]
    [Column("MMProductionCostIngredientCostDGID")]
    public int MmproductionCostIngredientCostDgid { get; set; }

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

    [Column("MMProductionCostIngredientCostDGReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDgreferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostDGReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDgreferenceType { get; set; }

    [Column("MMProductionCostIngredientCostDGBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDgbatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostDGOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDgoperationName { get; set; }

    [Column("MMProductionCostIngredientCostDGMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDgmeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostDGStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDgstockName { get; set; }

    [Column("MMProductionCostIngredientCostDGProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDgproductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostDGProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDgproductNo { get; set; }

    [Column("MMProductionCostIngredientCostDGProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDgproductName { get; set; }

    [Column("MMProductionCostIngredientCostDGProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostDgproductDesc { get; set; }

    [Column("MMProductionCostIngredientCostDGProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDgproductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostDGProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostDgproductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostDGProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgproductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostDGProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgproductQty { get; set; }

    [Column("MMProductionCostIngredientCostDGTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgtotalCost { get; set; }

    [Column("MMProductionCostIngredientCostDGBatchComponent")]
    public int? MmproductionCostIngredientCostDgbatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostDGProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgproductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostDGWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgwoodFee { get; set; }

    [Column("MMProductionCostIngredientCostDGGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDggeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostDGDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgdirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostDGHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDghardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostDGPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgpaintFee { get; set; }

    [Column("MMProductionCostIngredientCostDGMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgmaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostDGElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgelecFee { get; set; }

    [Column("MMProductionCostIngredientCostDGDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgdepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostDGOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDgotherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostDgs")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
