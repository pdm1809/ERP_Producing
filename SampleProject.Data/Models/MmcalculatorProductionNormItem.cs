using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCalculatorProductionNormItems")]
public partial class MmcalculatorProductionNormItem
{
    [Key]
    [Column("MMCalculatorProductionNormItemID")]
    public int MmcalculatorProductionNormItemId { get; set; }

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

    [Column("FK_MMCalculatorProductionNormCostID")]
    public int? FkMmcalculatorProductionNormCostId { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

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

    [Column("MMCalculatorProductionNormItemParentNo")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemParentNo { get; set; }

    [Column("MMCalculatorProductionNormItemParentID")]
    public int? MmcalculatorProductionNormItemParentId { get; set; }

    [Column("MMCalculatorProductionNormItemGroup")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemGroup { get; set; }

    [Column("MMCalculatorProductionNormItemUnit")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemUnit { get; set; }

    [Column("MMCalculatorProductionNormItemIsComponent")]
    public bool? MmcalculatorProductionNormItemIsComponent { get; set; }

    [Column("MMCalculatorProductionNormItemNo")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemNo { get; set; }

    [Column("MMCalculatorProductionNormItemProductName")]
    [StringLength(256)]
    public string MmcalculatorProductionNormItemProductName { get; set; }

    [Column("MMCalculatorProductionNormItemProductSupplierName")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemProductSupplierName { get; set; }

    [Column("MMCalculatorProductionNormItemProductSupplierNumber")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemProductSupplierNumber { get; set; }

    [Column("MMCalculatorProductionNormItemProductAttribute")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemProductAttribute { get; set; }

    [Column("MMCalculatorProductionNormItemQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemQuantity { get; set; }

    [Column("MMCalculatorProductionNormItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductLength { get; set; }

    [Column("MMCalculatorProductionNormItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductHeight { get; set; }

    [Column("MMCalculatorProductionNormItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductWidth { get; set; }

    [Column("MMCalculatorProductionNormItemSortOrder")]
    public int? MmcalculatorProductionNormItemSortOrder { get; set; }

    [Column("MMCalculatorProductionNormItemProductSizeAndPacking")]
    [StringLength(512)]
    public string MmcalculatorProductionNormItemProductSizeAndPacking { get; set; }

    [Column("MMCalculatorProductionNormItemProductWoodType")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemProductWoodType { get; set; }

    [Column("MMCalculatorProductionNormItemProductJoinery")]
    [StringLength(50)]
    public string MmcalculatorProductionNormItemProductJoinery { get; set; }

    [Column("MMCalculatorProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemBlocks { get; set; }

    [Column("MMCalculatorProductionNormItemMDFBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemMdfblocks { get; set; }

    [Column("MMCalculatorProductionNormItemVeneer", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemVeneer { get; set; }

    [Column("MMCalculatorProductionNormItemPlywood", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemPlywood { get; set; }

    [Column("MMCalculatorProductionNormItemPaintA", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemPaintA { get; set; }

    [Column("MMCalculatorProductionNormItemPaintB", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemPaintB { get; set; }

    [Column("MMCalculatorProductionNormItemTotalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemTotalQuantity { get; set; }

    [Column("MMCalculatorProductionNormItemTotalWoodConsumable", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemTotalWoodConsumable { get; set; }

    [Column("MMCalculatorProductionNormItemParentOrderName")]
    [StringLength(256)]
    public string MmcalculatorProductionNormItemParentOrderName { get; set; }

    [Column("MMCalculatorProductionNormItemAcreage", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemAcreage { get; set; }

    [Column("MMCalculatorProductionNormItemDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemDepreciationRate { get; set; }

    [Column("MMCalculatorProductionNormItemActualDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemActualDepreciationRate { get; set; }

    [Column("MMCalculatorProductionNormItemIsReuse")]
    public bool? MmcalculatorProductionNormItemIsReuse { get; set; }

    [Column("MMCalculatorProductionNormItemNeededTime", TypeName = "datetime")]
    public DateTime? MmcalculatorProductionNormItemNeededTime { get; set; }

    [Column("MMCalculatorProductionNormItemPackagingGW", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemPackagingGw { get; set; }

    [Column("MMCalculatorProductionNormItemPackagingNW", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemPackagingNw { get; set; }

    [Column("FK_ICProductWoodIngredientID")]
    public int? FkIcproductWoodIngredientId { get; set; }

    [Column("MMCalculatorProductionNormItemWoodBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemWoodBlocks { get; set; }

    [Column("FK_ICProductAttributeSpecialityID")]
    public int? FkIcproductAttributeSpecialityId { get; set; }

    [Column("MMCalculatorProductionNormItemComment")]
    [StringLength(512)]
    public string MmcalculatorProductionNormItemComment { get; set; }

    [Column("MMCalculatorProductionNormItemProductDesc")]
    [StringLength(512)]
    public string MmcalculatorProductionNormItemProductDesc { get; set; }

    [Column("MMCalculatorProductionNormItemPaintMixRatio")]
    [StringLength(512)]
    public string MmcalculatorProductionNormItemPaintMixRatio { get; set; }

    [Column("MMCalculatorProductionNormItemProductOverallDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductOverallDimensionHeight { get; set; }

    [Column("MMCalculatorProductionNormItemProductOverallDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductOverallDimensionWidth { get; set; }

    [Column("MMCalculatorProductionNormItemProductOverallDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductOverallDimensionLength { get; set; }

    [Column("MMCalculatorProductionNormItemProductWeightPerVolume")]
    [StringLength(512)]
    public string MmcalculatorProductionNormItemProductWeightPerVolume { get; set; }

    [Column("MMCalculatorProductionNormItemProductInsideDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductInsideDimensionHeight { get; set; }

    [Column("MMCalculatorProductionNormItemProductInsideDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductInsideDimensionWidth { get; set; }

    [Column("MMCalculatorProductionNormItemProductInsideDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductInsideDimensionLength { get; set; }

    [Column("FK_ICProdAttPackingMaterialSpecialityID")]
    public int? FkIcprodAttPackingMaterialSpecialityId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSizeID")]
    public int? FkIcprodAttPackingMaterialSizeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    public int? FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("MMCalculatorProductionNormItemBlockPerOne", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemBlockPerOne { get; set; }

    [Column("MMCalculatorProductionNormItemPaintPerOne", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemPaintPerOne { get; set; }

    [Column("MMCalculatorProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemPaint { get; set; }

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

    [Column("MMCalculatorProductionNormItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemProductUnitCost { get; set; }

    [Column("MMCalculatorProductionNormItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormItemTotalCost { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmcalculatorProductionNormItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmcalculatorProductionNormItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmcalculatorProductionNormItems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }
}
