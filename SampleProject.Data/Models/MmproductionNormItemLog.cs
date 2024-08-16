using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormItemLogs")]
public partial class MmproductionNormItemLog
{
    [Key]
    [Column("MMProductionNormItemLogID")]
    public int MmproductionNormItemLogId { get; set; }

    [Column("FK_MMProductionNormApproveLogID")]
    public int? FkMmproductionNormApproveLogId { get; set; }

    [Column("MMProductionNormItemID")]
    public int? MmproductionNormItemId { get; set; }

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

    [Column("FK_MMProductionNormID")]
    public int FkMmproductionNormId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_MMFormulaIDPaintA")]
    public int? FkMmformulaIdpaintA { get; set; }

    [Column("FK_MMFormulaIDPaintB")]
    public int? FkMmformulaIdpaintB { get; set; }

    [Column("FK_MMFormulaIDVeneer")]
    public int? FkMmformulaIdveneer { get; set; }

    [Column("FK_ICProductIDReuse")]
    public int? FkIcproductIdreuse { get; set; }

    [Column("FK_ICProductIDPack")]
    public int? FkIcproductIdpack { get; set; }

    [Column("MMProductionNormItemParentNo")]
    [StringLength(50)]
    public string MmproductionNormItemParentNo { get; set; }

    [Column("MMProductionNormItemParentID")]
    public int? MmproductionNormItemParentId { get; set; }

    [Column("MMProductionNormItemGroup")]
    [StringLength(50)]
    public string MmproductionNormItemGroup { get; set; }

    [Column("MMProductionNormItemUnit")]
    [StringLength(50)]
    public string MmproductionNormItemUnit { get; set; }

    [Column("MMProductionNormItemIsComponent")]
    public bool? MmproductionNormItemIsComponent { get; set; }

    [Column("MMProductionNormItemNo")]
    [StringLength(50)]
    public string MmproductionNormItemNo { get; set; }

    [Column("MMProductionNormItemProductName")]
    [StringLength(256)]
    public string MmproductionNormItemProductName { get; set; }

    [Column("MMProductionNormItemProductSupplierName")]
    [StringLength(50)]
    public string MmproductionNormItemProductSupplierName { get; set; }

    [Column("MMProductionNormItemProductSupplierNumber")]
    [StringLength(50)]
    public string MmproductionNormItemProductSupplierNumber { get; set; }

    [Column("MMProductionNormItemProductAttribute")]
    [StringLength(50)]
    public string MmproductionNormItemProductAttribute { get; set; }

    [Column("MMProductionNormItemQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemQuantity { get; set; }

    [Column("MMProductionNormItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductLength { get; set; }

    [Column("MMProductionNormItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductHeight { get; set; }

    [Column("MMProductionNormItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductWidth { get; set; }

    [Column("MMProductionNormItemSortOrder")]
    public int? MmproductionNormItemSortOrder { get; set; }

    [Column("MMProductionNormItemProductSizeAndPacking")]
    [StringLength(512)]
    public string MmproductionNormItemProductSizeAndPacking { get; set; }

    [Column("MMProductionNormItemProductWoodType")]
    [StringLength(50)]
    public string MmproductionNormItemProductWoodType { get; set; }

    [Column("MMProductionNormItemProductJoinery")]
    [StringLength(50)]
    public string MmproductionNormItemProductJoinery { get; set; }

    [Column("MMProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemBlocks { get; set; }

    [Column("MMProductionNormItemMDFBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemMdfblocks { get; set; }

    [Column("MMProductionNormItemVeneer", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemVeneer { get; set; }

    [Column("MMProductionNormItemPlywood", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPlywood { get; set; }

    [Column("MMProductionNormItemPaintA", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPaintA { get; set; }

    [Column("MMProductionNormItemPaintB", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPaintB { get; set; }

    [Column("MMProductionNormItemTotalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemTotalQuantity { get; set; }

    [Column("MMProductionNormItemTotalWoodConsumable", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemTotalWoodConsumable { get; set; }

    [Column("MMProductionNormItemParentOrderName")]
    [StringLength(256)]
    public string MmproductionNormItemParentOrderName { get; set; }

    [Column("MMProductionNormItemAcreage", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemAcreage { get; set; }

    [Column("MMProductionNormItemDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemDepreciationRate { get; set; }

    [Column("MMProductionNormItemActualDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemActualDepreciationRate { get; set; }

    [Column("MMProductionNormItemIsReuse")]
    public bool? MmproductionNormItemIsReuse { get; set; }

    [Column("MMProductionNormItemNeededTime", TypeName = "datetime")]
    public DateTime? MmproductionNormItemNeededTime { get; set; }

    [Column("MMProductionNormItemPackagingGW", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPackagingGw { get; set; }

    [Column("MMProductionNormItemPackagingNW", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPackagingNw { get; set; }

    [Column("FK_ICProductWoodIngredientID")]
    public int? FkIcproductWoodIngredientId { get; set; }

    [Column("MMProductionNormItemWoodBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemWoodBlocks { get; set; }

    [Column("FK_ICProductAttributeSpecialityID")]
    public int? FkIcproductAttributeSpecialityId { get; set; }

    [Column("MMProductionNormItemComment")]
    [StringLength(512)]
    public string MmproductionNormItemComment { get; set; }

    [Column("MMProductionNormItemProductDesc")]
    [StringLength(512)]
    public string MmproductionNormItemProductDesc { get; set; }

    [Column("MMProductionNormItemPaintMixRatio")]
    [StringLength(512)]
    public string MmproductionNormItemPaintMixRatio { get; set; }

    [Column("MMProductionNormItemProductOverallDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductOverallDimensionHeight { get; set; }

    [Column("MMProductionNormItemProductOverallDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductOverallDimensionWidth { get; set; }

    [Column("MMProductionNormItemProductOverallDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductOverallDimensionLength { get; set; }

    [Column("MMProductionNormItemProductWeightPerVolume")]
    [StringLength(512)]
    public string MmproductionNormItemProductWeightPerVolume { get; set; }

    [Column("MMProductionNormItemProductInsideDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductInsideDimensionHeight { get; set; }

    [Column("MMProductionNormItemProductInsideDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductInsideDimensionWidth { get; set; }

    [Column("MMProductionNormItemProductInsideDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductInsideDimensionLength { get; set; }

    [Column("FK_ICProdAttPackingMaterialSpecialityID")]
    public int? FkIcprodAttPackingMaterialSpecialityId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSizeID")]
    public int? FkIcprodAttPackingMaterialSizeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    public int? FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("MMProductionNormItemBlockPerOne", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemBlockPerOne { get; set; }

    [Column("MMProductionNormItemPaintPerOne", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPaintPerOne { get; set; }

    [Column("MMProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPaint { get; set; }

    [Column("FK_MMPaintProcessesID")]
    public int? FkMmpaintProcessesId { get; set; }

    [Column("FK_MMPaintProcessesItemID")]
    public int? FkMmpaintProcessesItemId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductItemID")]
    public int? FkIcproductItemId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_MMProcessID")]
    public int? FkMmprocessId { get; set; }

    [Column("MMHardwareOperationType")]
    [StringLength(50)]
    public string MmhardwareOperationType { get; set; }

    [Column("MMProductionNormItemProductMarketHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductMarketHeight { get; set; }

    [Column("MMProductionNormItemProductMarketLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductMarketLength { get; set; }

    [Column("MMProductionNormItemProductMarketWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemProductMarketWidth { get; set; }

    [Column("MMProductionNormItemDiffFactor", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemDiffFactor { get; set; }

    [Column("FK_MMProductionNormItemRefID")]
    public int? FkMmproductionNormItemRefId { get; set; }

    [Column("FK_MMFormulaIDPaintC")]
    public int? FkMmformulaIdpaintC { get; set; }

    [Column("MMProductionNormItemPaintC", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemPaintC { get; set; }

    [Column("MMProductionNormItemIsCarton")]
    public bool? MmproductionNormItemIsCarton { get; set; }

    [Column("FK_MMSemiProductID")]
    public int? FkMmsemiProductId { get; set; }

    [Column("MMProductionNormItemResourceType")]
    [StringLength(50)]
    public string MmproductionNormItemResourceType { get; set; }
}
