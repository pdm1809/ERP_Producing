using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostSons")]
public partial class MmproductionCostIngredientCostSon
{
    [Key]
    [Column("MMProductionCostIngredientCostSonID")]
    public int MmproductionCostIngredientCostSonId { get; set; }

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

    [Column("MMProductionCostIngredientCostSonReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostSonReferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostSonReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostSonReferenceType { get; set; }

    [Column("MMProductionCostIngredientCostSonBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostSonBatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostSonOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostSonOperationName { get; set; }

    [Column("MMProductionCostIngredientCostSonMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostSonMeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostSonStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostSonStockName { get; set; }

    [Column("MMProductionCostIngredientCostSonProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostSonProductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostSonProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostSonProductNo { get; set; }

    [Column("MMProductionCostIngredientCostSonProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostSonProductName { get; set; }

    [Column("MMProductionCostIngredientCostSonProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostSonProductDesc { get; set; }

    [Column("MMProductionCostIngredientCostSonProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostSonProductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostSonProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostSonProductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostSonProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonProductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostSonProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonProductQty { get; set; }

    [Column("MMProductionCostIngredientCostSonTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonTotalCost { get; set; }

    [Column("MMProductionCostIngredientCostSonBatchComponent")]
    public int? MmproductionCostIngredientCostSonBatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostSonProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonProductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostSonWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonWoodFee { get; set; }

    [Column("MMProductionCostIngredientCostSonGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonGeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostSonDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonDirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostSonHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonHardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostSonPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonPaintFee { get; set; }

    [Column("MMProductionCostIngredientCostSonMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonMaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostSonElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonElecFee { get; set; }

    [Column("MMProductionCostIngredientCostSonDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonDepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostSonOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostSonOtherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostSons")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
