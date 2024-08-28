using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCosts")]
public partial class MmproductionCostIngredientCost
{
    [Key]
    [Column("MMProductionCostIngredientCostID")]
    public int MmproductionCostIngredientCostId { get; set; }

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

    [Column("MMProductionCostIngredientCostReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostReferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostReferenceType { get; set; }

    [Column("MMProductionCostIngredientCostBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostBatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostOperationName { get; set; }

    [Column("MMProductionCostIngredientCostMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostMeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostStockName { get; set; }

    [Column("MMProductionCostIngredientCostProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostProductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostProductNo { get; set; }

    [Column("MMProductionCostIngredientCostProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostProductName { get; set; }

    [Column("MMProductionCostIngredientCostProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostProductDesc { get; set; }

    [Column("MMProductionCostIngredientCostProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostProductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostProductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostProductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostProductQty { get; set; }

    [Column("MMProductionCostIngredientCostTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTotalCost { get; set; }

    [Column("MMProductionCostIngredientCostBatchComponent")]
    public int? MmproductionCostIngredientCostBatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostProductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostWoodFee { get; set; }

    [Column("MMProductionCostIngredientCostGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostGeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostHardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostPaintFee { get; set; }

    [Column("MMProductionCostIngredientCostMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostMaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostElecFee { get; set; }

    [Column("MMProductionCostIngredientCostDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostOtherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCosts")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
