using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostDDLRs")]
public partial class MmproductionCostIngredientCostDdlr
{
    [Key]
    [Column("MMProductionCostIngredientCostDDLRID")]
    public int MmproductionCostIngredientCostDdlrid { get; set; }

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

    [Column("MMProductionCostIngredientCostDDLRReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdlrreferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostDDLRReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdlrreferenceType { get; set; }

    [Column("MMProductionCostIngredientCostDDLRBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdlrbatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDLROperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdlroperationName { get; set; }

    [Column("MMProductionCostIngredientCostDDLRMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdlrmeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostDDLRStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdlrstockName { get; set; }

    [Column("MMProductionCostIngredientCostDDLRProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdlrproductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostDDLRProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdlrproductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDLRProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdlrproductName { get; set; }

    [Column("MMProductionCostIngredientCostDDLRProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostDdlrproductDesc { get; set; }

    [Column("MMProductionCostIngredientCostDDLRProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdlrproductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostDDLRProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostDdlrproductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostDDLRProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrproductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostDDLRProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrproductQty { get; set; }

    [Column("MMProductionCostIngredientCostDDLRTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrtotalCost { get; set; }

    [Column("MMProductionCostIngredientCostDDLRBatchComponent")]
    public int? MmproductionCostIngredientCostDdlrbatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostDDLRProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrproductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostDDLRWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrwoodFee { get; set; }

    [Column("MMProductionCostIngredientCostDDLRGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrgeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostDDLRDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrdirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostDDLRHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrhardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostDDLRPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrpaintFee { get; set; }

    [Column("MMProductionCostIngredientCostDDLRMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrmaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostDDLRElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrelecFee { get; set; }

    [Column("MMProductionCostIngredientCostDDLRDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrdepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostDDLROtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdlrotherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostDdlrs")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
