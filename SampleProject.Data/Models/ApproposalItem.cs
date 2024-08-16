using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APProposalItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkApproposalId", Name = "Idx_APProposalItems")]
public partial class ApproposalItem
{
    [Key]
    [Column("APProposalItemID")]
    public int ApproposalItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APProposalID")]
    public int FkApproposalId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("APProposalItemProductType")]
    [StringLength(50)]
    public string ApproposalItemProductType { get; set; }

    [Column("APProposalItemSortOrder")]
    public int? ApproposalItemSortOrder { get; set; }

    [Column("APProposalItemProductSerialNo")]
    [StringLength(50)]
    public string ApproposalItemProductSerialNo { get; set; }

    [Column("APProposalItemProductAttribute")]
    [StringLength(200)]
    public string ApproposalItemProductAttribute { get; set; }

    [Column("APProposalItemProductName")]
    [StringLength(50)]
    public string ApproposalItemProductName { get; set; }

    [Column("APProposalItemProductDesc")]
    [StringLength(2048)]
    public string ApproposalItemProductDesc { get; set; }

    [Column("APProposalItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductUnitPrice { get; set; }

    [Column("APProposalItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductUnitCost { get; set; }

    [Column("APProposalItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductDiscount { get; set; }

    [Column("APProposalItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductTaxPercent { get; set; }

    [Column("APProposalItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductQtyOld { get; set; }

    [Column("APProposalItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? ApproposalItemProductQty { get; set; }

    [Column("APProposalItemPurchasedQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemPurchasedQty { get; set; }

    [Column("APProposalItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemQty1 { get; set; }

    [Column("APProposalItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemQty2 { get; set; }

    [Column("APProposalItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemQty3 { get; set; }

    [Column("APProposalItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemQty4 { get; set; }

    [Column("APProposalItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemQty5 { get; set; }

    [Column("APProposalItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemQty6 { get; set; }

    [Column("APProposalItemComment")]
    [StringLength(1000)]
    public string ApproposalItemComment { get; set; }

    [Column("APProposalItemExtCost", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemExtCost { get; set; }

    [Column("APProposalItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTaxAmount { get; set; }

    [Column("APProposalItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalCost { get; set; }

    [Column("APPurchaseProposalItemType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseProposalItemType { get; set; }

    [Column("APPurchaseProposalItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseProposalItemStatus { get; set; }

    [Column("APProposalItemProductSupplierNo")]
    [StringLength(50)]
    public string ApproposalItemProductSupplierNo { get; set; }

    [Column("FK_MMPurchasePlanID")]
    public int? FkMmpurchasePlanId { get; set; }

    [Column("FK_MMPurchasePlanItemID")]
    public int? FkMmpurchasePlanItemId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("APPriority")]
    [StringLength(50)]
    public string Appriority { get; set; }

    [Column("APProposalItemNeedTime", TypeName = "datetime")]
    public DateTime? ApproposalItemNeedTime { get; set; }

    [Column("APProposalItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductHeight { get; set; }

    [Column("APProposalItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductWidth { get; set; }

    [Column("APProposalItemProductLenght", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductLenght { get; set; }

    [Column("APProposalItemProductWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductWidthMax { get; set; }

    [Column("APProposalItemProductLenghtMax", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductLenghtMax { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("APProposalItemPurchaseOrderQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemPurchaseOrderQty { get; set; }

    [Column("APProposalItemCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemCanceledQty { get; set; }

    [Column("FK_MMAllocationProposalID")]
    public int? FkMmallocationProposalId { get; set; }

    [Column("FK_MMAllocationProposalItemID")]
    public int? FkMmallocationProposalItemId { get; set; }

    [Column("FK_MMFromOperationID")]
    public int? FkMmfromOperationId { get; set; }

    [Column("FK_MMToOperationID")]
    public int? FkMmtoOperationId { get; set; }

    [Column("APProposalItemProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductionNormItemPaint { get; set; }

    [Column("APProposalItemProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductionNormItemBlocks { get; set; }

    [Column("APProposalItemProductionNormItemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductionNormItemTotalPaint { get; set; }

    [Column("APProposalItemProductionNormItemTotalBlocks", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductionNormItemTotalBlocks { get; set; }

    [Column("APProposalItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductPerimeter { get; set; }

    [Column("APProposalItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemWoodQty { get; set; }

    [Column("APProposalItemInsideDemensionWitdh", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemInsideDemensionWitdh { get; set; }

    [Column("APProposalItemInsideDemensionLength", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemInsideDemensionLength { get; set; }

    [Column("APProposalItemInsideDemensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemInsideDemensionHeight { get; set; }

    [Column("APProposalItemOverallDemensionWitdh", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemOverallDemensionWitdh { get; set; }

    [Column("APProposalItemOverallDemensionLength", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemOverallDemensionLength { get; set; }

    [Column("APProposalItemOverallDemensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemOverallDemensionHeight { get; set; }

    [Column("APProposalItemProductSizeAndPacking")]
    [StringLength(256)]
    public string ApproposalItemProductSizeAndPacking { get; set; }

    [Column("FK_ICProdAttPackingMaterialSpecialityID")]
    public int? FkIcprodAttPackingMaterialSpecialityId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSizeID")]
    public int? FkIcprodAttPackingMaterialSizeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    public int? FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("APPurchaseOrderItemServiceToDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderItemServiceToDate { get; set; }

    [Column("APPurchaseOrderItemServiceFromDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderItemServiceFromDate { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("APProposalItemNeedToTime", TypeName = "datetime")]
    public DateTime? ApproposalItemNeedToTime { get; set; }

    [Column("APProposalItemProductQtySter", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductQtySter { get; set; }

    [Column("APProposalItemProductUnitCostSter", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductUnitCostSter { get; set; }

    [Column("APProposalItemTotalCostSter", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalCostSter { get; set; }

    [Column("APProposalItemPurchaseOrderWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemPurchaseOrderWoodQty { get; set; }

    [Column("APProposalItemCanceledWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemCanceledWoodQty { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("APPurchaseProposalItemReasonUnapproved")]
    [StringLength(1000)]
    public string AppurchaseProposalItemReasonUnapproved { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    public string ApobjectType { get; set; }

    [Column("FK_MMBatchProductInputItemID")]
    public int? FkMmbatchProductInputItemId { get; set; }

    [Column("APProposalItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemProductFactor { get; set; }

    [Column("APProposalItemProductExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? ApproposalItemProductExchangeQty { get; set; }

    [Column("FK_MMBatchProductItemOutSourcingID")]
    public int? FkMmbatchProductItemOutSourcingId { get; set; }

    [Column("APProposalItemOperation")]
    [StringLength(1024)]
    public string ApproposalItemOperation { get; set; }

    [Column("FK_ICMeasureUnitBeforeChangeID")]
    public int? FkIcmeasureUnitBeforeChangeId { get; set; }

    [Column("APProposalItemNormQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemNormQty { get; set; }

    [Column("APProposalItemCode01Combo")]
    [StringLength(2048)]
    [Unicode(false)]
    public string ApproposalItemCode01Combo { get; set; }

    [Column("APProposalItemCode02Combo")]
    [StringLength(2048)]
    [Unicode(false)]
    public string ApproposalItemCode02Combo { get; set; }

    [Column("APProposalItemCode03Combo")]
    [StringLength(2048)]
    [Unicode(false)]
    public string ApproposalItemCode03Combo { get; set; }

    [Column("APProposalItemCode04Combo")]
    [StringLength(2048)]
    [Unicode(false)]
    public string ApproposalItemCode04Combo { get; set; }

    [Column("APProposalItemCode05Combo")]
    [StringLength(2048)]
    [Unicode(false)]
    public string ApproposalItemCode05Combo { get; set; }

    [Column("APProposalItemAverageUsageQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemAverageUsageQty { get; set; }

    [Column("APProposalItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ApproposalItemProductNoOfOldSys { get; set; }

    [InverseProperty("FkApproposalItem")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [ForeignKey("FkAcassetId")]
    [InverseProperty("ApproposalItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkApproposalId")]
    [InverseProperty("ApproposalItems")]
    public virtual Approposal FkApproposal { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApproposalItems")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ApproposalItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApproposalItems")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ApproposalItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ApproposalItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcprodAttPackingMaterialWeightPerVolumeId")]
    [InverseProperty("ApproposalItemFkIcprodAttPackingMaterialWeightPerVolumes")]
    public virtual IcproductAttribute FkIcprodAttPackingMaterialWeightPerVolume { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApproposalItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("ApproposalItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ApproposalItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("ApproposalItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("ApproposalItemFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("ApproposalItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ApproposalItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("ApproposalItems")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("FkMmallocationProposalItemId")]
    [InverseProperty("ApproposalItems")]
    public virtual MmallocationProposalItem FkMmallocationProposalItem { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ApproposalItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductInputItemId")]
    [InverseProperty("ApproposalItems")]
    public virtual MmbatchProductInputItem FkMmbatchProductInputItem { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("ApproposalItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("ApproposalItems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmfromOperationId")]
    [InverseProperty("ApproposalItemFkMmfromOperations")]
    public virtual Mmoperation FkMmfromOperation { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("ApproposalItems")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkMmpurchasePlanItemId")]
    [InverseProperty("ApproposalItems")]
    public virtual MmpurchasePlanItem FkMmpurchasePlanItem { get; set; }

    [ForeignKey("FkMmtoOperationId")]
    [InverseProperty("ApproposalItemFkMmtoOperations")]
    public virtual Mmoperation FkMmtoOperation { get; set; }
}
