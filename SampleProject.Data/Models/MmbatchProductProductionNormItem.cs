using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductProductionNormItems")]
public partial class MmbatchProductProductionNormItem
{
    [Key]
    [Column("MMBatchProductProductionNormItemID")]
    public int MmbatchProductProductionNormItemId { get; set; }

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

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

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

    [Column("MMBatchProductProductionNormItemParentNo")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemParentNo { get; set; }

    [Column("MMBatchProductProductionNormItemParentID")]
    public int? MmbatchProductProductionNormItemParentId { get; set; }

    [Column("MMBatchProductProductionNormItemGroup")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemGroup { get; set; }

    [Column("MMBatchProductProductionNormItemUnit")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemUnit { get; set; }

    [Column("MMBatchProductProductionNormItemIsComponent")]
    public bool? MmbatchProductProductionNormItemIsComponent { get; set; }

    [Column("MMBatchProductProductionNormItemNo")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemNo { get; set; }

    [Column("MMBatchProductProductionNormItemProductName")]
    [StringLength(256)]
    public string MmbatchProductProductionNormItemProductName { get; set; }

    [Column("MMBatchProductProductionNormItemProductSupplierName")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemProductSupplierName { get; set; }

    [Column("MMBatchProductProductionNormItemProductSupplierNumber")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemProductSupplierNumber { get; set; }

    [Column("MMBatchProductProductionNormItemProductAttribute")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemProductAttribute { get; set; }

    [Column("MMBatchProductProductionNormItemQuantity", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemQuantity { get; set; }

    [Column("MMBatchProductProductionNormItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemProductLength { get; set; }

    [Column("MMBatchProductProductionNormItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemProductHeight { get; set; }

    [Column("MMBatchProductProductionNormItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemProductWidth { get; set; }

    [Column("MMBatchProductProductionNormItemSortOrder")]
    public int? MmbatchProductProductionNormItemSortOrder { get; set; }

    [Column("MMBatchProductProductionNormItemProductSizeAndPacking")]
    [StringLength(512)]
    public string MmbatchProductProductionNormItemProductSizeAndPacking { get; set; }

    [Column("MMBatchProductProductionNormItemProductWoodType")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemProductWoodType { get; set; }

    [Column("MMBatchProductProductionNormItemProductJoinery")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemProductJoinery { get; set; }

    [Column("MMBatchProductProductionNormItemBlocks", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemBlocks { get; set; }

    [Column("MMBatchProductProductionNormItemMDFBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemMdfblocks { get; set; }

    [Column("MMBatchProductProductionNormItemVeneer", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemVeneer { get; set; }

    [Column("MMBatchProductProductionNormItemPlywood", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemPlywood { get; set; }

    [Column("MMBatchProductProductionNormItemPaintA", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemPaintA { get; set; }

    [Column("MMBatchProductProductionNormItemPaintB", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemPaintB { get; set; }

    [Column("MMBatchProductProductionNormItemTotalQuantity", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemTotalQuantity { get; set; }

    [Column("MMBatchProductProductionNormItemTotalWoodConsumable", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemTotalWoodConsumable { get; set; }

    [Column("MMBatchProductProductionNormItemParentOrderName")]
    [StringLength(256)]
    public string MmbatchProductProductionNormItemParentOrderName { get; set; }

    [Column("MMBatchProductProductionNormItemAcreage", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemAcreage { get; set; }

    [Column("MMBatchProductProductionNormItemDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemDepreciationRate { get; set; }

    [Column("MMBatchProductProductionNormItemActualDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemActualDepreciationRate { get; set; }

    [Column("MMBatchProductProductionNormItemIsReuse")]
    public bool? MmbatchProductProductionNormItemIsReuse { get; set; }

    [Column("MMBatchProductProductionNormItemVeneerKey")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmbatchProductProductionNormItemVeneerKey { get; set; }

    [Column("MMBatchProductProductionNormItemHardwareAssembleQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemHardwareAssembleQuantity { get; set; }

    [Column("MMBatchProductProductionNormItemHardwareAllocationQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemHardwareAllocationQuantity { get; set; }

    [Column("MMBatchProductProductionNormItemPaintAKey")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmbatchProductProductionNormItemPaintAkey { get; set; }

    [Column("MMBatchProductProductionNormItemPaintBKey")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmbatchProductProductionNormItemPaintBkey { get; set; }

    [Column("MMBatchProductProductionNormItemNeededTime", TypeName = "datetime")]
    public DateTime? MmbatchProductProductionNormItemNeededTime { get; set; }

    [Column("MMBatchProductProductionNormItemPackagingGW", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemPackagingGw { get; set; }

    [Column("MMBatchProductProductionNormItemPackagingNW", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemPackagingNw { get; set; }

    [Column("MMBatchProductProductionNormItemPackagingAllocationTotalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemPackagingAllocationTotalQuantity { get; set; }

    [Column("MMBatchProductProductionNormItemSerialNo")]
    [StringLength(256)]
    public string MmbatchProductProductionNormItemSerialNo { get; set; }

    [Column("FK_ICProductWoodIngredientID")]
    public int? FkIcproductWoodIngredientId { get; set; }

    [Column("MMBatchProductProductionNormItemWoodBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemWoodBlocks { get; set; }

    [Column("FK_ICProductAttributeSpecialityID")]
    public int? FkIcproductAttributeSpecialityId { get; set; }

    [Column("MMBatchProductProductionNormItemComment")]
    [StringLength(512)]
    public string MmbatchProductProductionNormItemComment { get; set; }

    [Column("MMBatchProductProductionNormItemProductDesc")]
    [StringLength(512)]
    public string MmbatchProductProductionNormItemProductDesc { get; set; }

    [Column("MMBatchProductProductionNormItemPaintMixRatio")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemPaintMixRatio { get; set; }

    [Column("MMBatchProductProductionNormItemProductOverallDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemProductOverallDimensionHeight { get; set; }

    [Column("MMBatchProductProductionNormItemProductOverallDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemProductOverallDimensionWidth { get; set; }

    [Column("MMBatchProductProductionNormItemProductOverallDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemProductOverallDimensionLength { get; set; }

    [Column("MMBatchProductProductionNormItemProductWeightPerVolume")]
    [StringLength(512)]
    public string MmbatchProductProductionNormItemProductWeightPerVolume { get; set; }

    [Column("MMBatchProductProductionNormItemProductInsideDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemProductInsideDimensionHeight { get; set; }

    [Column("MMBatchProductProductionNormItemProductInsideDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemProductInsideDimensionWidth { get; set; }

    [Column("MMBatchProductProductionNormItemProductInsideDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemProductInsideDimensionLength { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("MMBatchProductProductionNormItemResourceType")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemResourceType { get; set; }

    [Column("MMBatchProductProductionNormItemModifiedStatus")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemModifiedStatus { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSpecialityID")]
    public int? FkIcprodAttPackingMaterialSpecialityId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSizeID")]
    public int? FkIcprodAttPackingMaterialSizeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    public int? FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [Column("MMBatchProductProductionNormItemBlockPerOne", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemBlockPerOne { get; set; }

    [Column("MMBatchProductProductionNormItemQuantityPerOne", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemQuantityPerOne { get; set; }

    [Column("MMBatchProductProductionNormItemImage")]
    [StringLength(512)]
    public string MmbatchProductProductionNormItemImage { get; set; }

    [Column("MMBatchProductProductionNormItemFrontCNCImage")]
    [StringLength(512)]
    public string MmbatchProductProductionNormItemFrontCncimage { get; set; }

    [Column("MMBatchProductProductionNormItemBacksideCNCImage")]
    [StringLength(512)]
    public string MmbatchProductProductionNormItemBacksideCncimage { get; set; }

    [Column("MMBatchProductProductionNormItemIsBurnishing")]
    public bool? MmbatchProductProductionNormItemIsBurnishing { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_MMProductionNormApproveLogID")]
    public int? FkMmproductionNormApproveLogId { get; set; }

    [Column("MMBatchProductProductionNormItemBarcode")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemBarcode { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMBPSemiProductID")]
    public int? FkMmbpsemiProductId { get; set; }

    [Column("MMBatchProductProductionNormItemExecuteType")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemExecuteType { get; set; }

    [Column("MMBatchProductProductionNormItemSerial")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemSerial { get; set; }

    [Column("MMBatchProductProductionNormItemDiameter", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemDiameter { get; set; }

    [Column("MMBatchProductProductionNormItemDepth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemDepth { get; set; }

    [Column("MMBatchProductProductionNormItemQuantitative", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemQuantitative { get; set; }

    [Column("MMBatchProductProductionNormItemRef")]
    public int? MmbatchProductProductionNormItemRef { get; set; }

    [Column("MMBatchProductProductionNormItemType")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemType { get; set; }

    [Column("MMBatchProductProductionNormItemPaintC", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductProductionNormItemPaintC { get; set; }

    [Column("MMBatchProductProductionNormItemColorDesc")]
    [StringLength(524)]
    public string MmbatchProductProductionNormItemColorDesc { get; set; }

    [Column("MMBatchProductProductionNormItemOtherColor")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemOtherColor { get; set; }

    [Column("MMBatchProductProductionNormItemComplexityType")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemComplexityType { get; set; }

    [Column("FK_MMFormulaIDPaintC")]
    public int? FkMmformulaIdpaintC { get; set; }

    [Column("MMBatchProductProductionNormItemCode01Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode01Combo { get; set; }

    [Column("MMBatchProductProductionNormItemCode02Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode02Combo { get; set; }

    [Column("MMBatchProductProductionNormItemCode03Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode03Combo { get; set; }

    [Column("MMBatchProductProductionNormItemCode04Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode04Combo { get; set; }

    [Column("MMBatchProductProductionNormItemCode05Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode05Combo { get; set; }

    [Column("MMBatchProductProductionNormItemCode06Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode06Combo { get; set; }

    [Column("MMBatchProductProductionNormItemCode07Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode07Combo { get; set; }

    [Column("MMBatchProductProductionNormItemCode08Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode08Combo { get; set; }

    [Column("MMBatchProductProductionNormItemCode09Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode09Combo { get; set; }

    [Column("MMBatchProductProductionNormItemCode10Combo")]
    [StringLength(100)]
    public string MmbatchProductProductionNormItemCode10Combo { get; set; }

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductProductionNormItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmbatchProductProductionNormItems")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmbatchProductCompletionPercentage> MmbatchProductCompletionPercentages { get; set; } = new List<MmbatchProductCompletionPercentage>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmbatchProductItemOperationInfo> MmbatchProductItemOperationInfos { get; set; } = new List<MmbatchProductItemOperationInfo>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmbatchProductProductionNormItemEquipment> MmbatchProductProductionNormItemEquipments { get; set; } = new List<MmbatchProductProductionNormItemEquipment>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmbatchProductProductionNormItemHardware> MmbatchProductProductionNormItemHardwares { get; set; } = new List<MmbatchProductProductionNormItemHardware>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmbatchProductProductionNormItemMeterial> MmbatchProductProductionNormItemMeterials { get; set; } = new List<MmbatchProductProductionNormItemMeterial>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmbatchProductProductionNormItemPaint> MmbatchProductProductionNormItemPaints { get; set; } = new List<MmbatchProductProductionNormItemPaint>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmcalculatorProductionNormItem> MmcalculatorProductionNormItems { get; set; } = new List<MmcalculatorProductionNormItem>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmchangeBominformationItem> MmchangeBominformationItems { get; set; } = new List<MmchangeBominformationItem>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetails { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmoperationDetailPlanItemChild> MmoperationDetailPlanItemChildren { get; set; } = new List<MmoperationDetailPlanItemChild>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItems { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkMmbatchProductProductionNormItem")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItems { get; set; } = new List<MmwoodPlanItem>();
}
