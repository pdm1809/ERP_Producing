using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostDDSons")]
public partial class MmproductionCostIngredientCostDdson
{
    [Key]
    [Column("MMProductionCostIngredientCostDDSonID")]
    public int MmproductionCostIngredientCostDdsonId { get; set; }

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

    [Column("MMProductionCostIngredientCostDDSonReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdsonReferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostDDSonReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdsonReferenceType { get; set; }

    [Column("MMProductionCostIngredientCostDDSonBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdsonBatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDSonOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdsonOperationName { get; set; }

    [Column("MMProductionCostIngredientCostDDSonMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdsonMeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostDDSonStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdsonStockName { get; set; }

    [Column("MMProductionCostIngredientCostDDSonProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdsonProductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostDDSonProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdsonProductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDSonProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdsonProductName { get; set; }

    [Column("MMProductionCostIngredientCostDDSonProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostDdsonProductDesc { get; set; }

    [Column("MMProductionCostIngredientCostDDSonProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdsonProductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostDDSonProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostDdsonProductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostDDSonProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonProductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostDDSonProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonProductQty { get; set; }

    [Column("MMProductionCostIngredientCostDDSonTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonTotalCost { get; set; }

    [Column("MMProductionCostIngredientCostDDSonBatchComponent")]
    public int? MmproductionCostIngredientCostDdsonBatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostDDSonProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonProductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostDDSonWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonWoodFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSonGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonGeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSonDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonDirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSonHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonHardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSonPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonPaintFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSonMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonMaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSonElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonElecFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSonDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonDepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSonOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsonOtherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostDdsons")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
