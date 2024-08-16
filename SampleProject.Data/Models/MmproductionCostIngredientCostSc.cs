using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostSCs")]
public partial class MmproductionCostIngredientCostSc
{
    [Key]
    [Column("MMProductionCostIngredientCostSCID")]
    public int MmproductionCostIngredientCostScid { get; set; }

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

    [Column("MMProductionCostIngredientCostSCReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostScreferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostSCReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostScreferenceType { get; set; }

    [Column("MMProductionCostIngredientCostSCBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostScbatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostSCOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostScoperationName { get; set; }

    [Column("MMProductionCostIngredientCostSCMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostScmeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostSCStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostScstockName { get; set; }

    [Column("MMProductionCostIngredientCostSCProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostScproductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostSCProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostScproductNo { get; set; }

    [Column("MMProductionCostIngredientCostSCProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostScproductName { get; set; }

    [Column("MMProductionCostIngredientCostSCProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostScproductDesc { get; set; }

    [Column("MMProductionCostIngredientCostSCProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostScproductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostSCProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostScproductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostSCProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScproductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostSCProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScproductQty { get; set; }

    [Column("MMProductionCostIngredientCostSCTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSctotalCost { get; set; }

    [Column("MMProductionCostIngredientCostSCBatchComponent")]
    public int? MmproductionCostIngredientCostScbatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostSCProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScproductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostSCWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScwoodFee { get; set; }

    [Column("MMProductionCostIngredientCostSCGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScgeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostSCDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScdirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostSCHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSchardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostSCPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScpaintFee { get; set; }

    [Column("MMProductionCostIngredientCostSCMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScmaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostSCElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScelecFee { get; set; }

    [Column("MMProductionCostIngredientCostSCDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScdepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostSCOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostScotherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostScs")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
