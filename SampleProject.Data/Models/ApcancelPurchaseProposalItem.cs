using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APCancelPurchaseProposalItems")]
public partial class ApcancelPurchaseProposalItem
{
    [Key]
    [Column("APCancelPurchaseProposalItemID")]
    public int ApcancelPurchaseProposalItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_APCancelPurchaseProposalID")]
    public int FkApcancelPurchaseProposalId { get; set; }

    [Column("FK_APProposalItemID")]
    public int? FkApproposalItemId { get; set; }

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

    [Column("FK_MMPurchasePlanID")]
    public int? FkMmpurchasePlanId { get; set; }

    [Column("FK_MMPurchasePlanItemID")]
    public int? FkMmpurchasePlanItemId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMAllocationProposalID")]
    public int? FkMmallocationProposalId { get; set; }

    [Column("FK_MMAllocationProposalItemID")]
    public int? FkMmallocationProposalItemId { get; set; }

    [Column("FK_MMFromOperationID")]
    public int? FkMmfromOperationId { get; set; }

    [Column("FK_MMToOperationID")]
    public int? FkMmtoOperationId { get; set; }

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

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("APCancelPurchaseProposalItemProductType")]
    [StringLength(50)]
    public string ApcancelPurchaseProposalItemProductType { get; set; }

    [Column("APCancelPurchaseProposalItemSortOrder")]
    public int? ApcancelPurchaseProposalItemSortOrder { get; set; }

    [Column("APCancelPurchaseProposalItemProductSerialNo")]
    [StringLength(50)]
    public string ApcancelPurchaseProposalItemProductSerialNo { get; set; }

    [Column("APCancelPurchaseProposalItemProductAttribute")]
    [StringLength(200)]
    public string ApcancelPurchaseProposalItemProductAttribute { get; set; }

    [Column("APCancelPurchaseProposalItemProductName")]
    [StringLength(50)]
    public string ApcancelPurchaseProposalItemProductName { get; set; }

    [Column("APCancelPurchaseProposalItemProductDesc", TypeName = "ntext")]
    public string ApcancelPurchaseProposalItemProductDesc { get; set; }

    [Column("APCancelPurchaseProposalItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductUnitPrice { get; set; }

    [Column("APCancelPurchaseProposalItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductUnitCost { get; set; }

    [Column("APCancelPurchaseProposalItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductDiscount { get; set; }

    [Column("APCancelPurchaseProposalItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductTaxPercent { get; set; }

    [Column("APCancelPurchaseProposalItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductQtyOld { get; set; }

    [Column("APCancelPurchaseProposalItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductQty { get; set; }

    [Column("APCancelPurchaseProposalItemPurchasedQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemPurchasedQty { get; set; }

    [Column("APCancelPurchaseProposalItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemQty1 { get; set; }

    [Column("APCancelPurchaseProposalItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemQty2 { get; set; }

    [Column("APCancelPurchaseProposalItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemQty3 { get; set; }

    [Column("APCancelPurchaseProposalItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemQty4 { get; set; }

    [Column("APCancelPurchaseProposalItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemQty5 { get; set; }

    [Column("APCancelPurchaseProposalItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemQty6 { get; set; }

    [Column("APCancelPurchaseProposalItemComment")]
    [StringLength(1000)]
    public string ApcancelPurchaseProposalItemComment { get; set; }

    [Column("APCancelPurchaseProposalItemExtCost", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemExtCost { get; set; }

    [Column("APCancelPurchaseProposalItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemTaxAmount { get; set; }

    [Column("APCancelPurchaseProposalItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemTotalCost { get; set; }

    [Column("APCancelPurchaseProposalItemType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApcancelPurchaseProposalItemType { get; set; }

    [Column("APCancelPurchaseProposalItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApcancelPurchaseProposalItemStatus { get; set; }

    [Column("APCancelPurchaseProposalItemProductSupplierNo")]
    [StringLength(50)]
    public string ApcancelPurchaseProposalItemProductSupplierNo { get; set; }

    [Column("APPriority")]
    [StringLength(50)]
    public string Appriority { get; set; }

    [Column("APCancelPurchaseProposalItemNeedTime", TypeName = "datetime")]
    public DateTime? ApcancelPurchaseProposalItemNeedTime { get; set; }

    [Column("APCancelPurchaseProposalItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductHeight { get; set; }

    [Column("APCancelPurchaseProposalItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductWidth { get; set; }

    [Column("APCancelPurchaseProposalItemProductLenght", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductLenght { get; set; }

    [Column("APCancelPurchaseProposalItemProductWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductWidthMax { get; set; }

    [Column("APCancelPurchaseProposalItemProductLenghtMax", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductLenghtMax { get; set; }

    [Column("APCancelPurchaseProposalItemPurchaseOrderQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemPurchaseOrderQty { get; set; }

    [Column("APCancelPurchaseProposalItemCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemCanceledQty { get; set; }

    [Column("APCancelPurchaseProposalItemProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductionNormItemPaint { get; set; }

    [Column("APCancelPurchaseProposalItemProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductionNormItemBlocks { get; set; }

    [Column("APCancelPurchaseProposalItemProductionNormItemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductionNormItemTotalPaint { get; set; }

    [Column("APCancelPurchaseProposalItemProductionNormItemTotalBlocks", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductionNormItemTotalBlocks { get; set; }

    [Column("APCancelPurchaseProposalItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductPerimeter { get; set; }

    [Column("APCancelPurchaseProposalItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemWoodQty { get; set; }

    [Column("APCancelPurchaseProposalItemInsideDemensionWitdh", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemInsideDemensionWitdh { get; set; }

    [Column("APCancelPurchaseProposalItemInsideDemensionLength", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemInsideDemensionLength { get; set; }

    [Column("APCancelPurchaseProposalItemInsideDemensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemInsideDemensionHeight { get; set; }

    [Column("APCancelPurchaseProposalItemOverallDemensionWitdh", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemOverallDemensionWitdh { get; set; }

    [Column("APCancelPurchaseProposalItemOverallDemensionLength", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemOverallDemensionLength { get; set; }

    [Column("APCancelPurchaseProposalItemOverallDemensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemOverallDemensionHeight { get; set; }

    [Column("APCancelPurchaseProposalItemProductSizeAndPacking")]
    [StringLength(256)]
    public string ApcancelPurchaseProposalItemProductSizeAndPacking { get; set; }

    [Column("APPurchaseOrderItemServiceToDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderItemServiceToDate { get; set; }

    [Column("APPurchaseOrderItemServiceFromDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderItemServiceFromDate { get; set; }

    [Column("FK_APProposalID")]
    public int? FkApproposalId { get; set; }

    [Column("APCancelPurchaseProposalItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductFactor { get; set; }

    [Column("APCancelPurchaseProposalItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalItemProductExchangeQty { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkApcancelPurchaseProposalId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual ApcancelPurchaseProposal FkApcancelPurchaseProposal { get; set; }

    [ForeignKey("FkApproposalId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual Approposal FkApproposal { get; set; }

    [ForeignKey("FkApproposalItemId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual ApproposalItem FkApproposalItem { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcprodAttPackingMaterialWeightPerVolumeId")]
    [InverseProperty("ApcancelPurchaseProposalItemFkIcprodAttPackingMaterialWeightPerVolumes")]
    public virtual IcproductAttribute FkIcprodAttPackingMaterialWeightPerVolume { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApcancelPurchaseProposalItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("ApcancelPurchaseProposalItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ApcancelPurchaseProposalItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("ApcancelPurchaseProposalItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("ApcancelPurchaseProposalItemFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("ApcancelPurchaseProposalItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("FkMmallocationProposalItemId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual MmallocationProposalItem FkMmallocationProposalItem { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmfromOperationId")]
    [InverseProperty("ApcancelPurchaseProposalItemFkMmfromOperations")]
    public virtual Mmoperation FkMmfromOperation { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkMmpurchasePlanItemId")]
    [InverseProperty("ApcancelPurchaseProposalItems")]
    public virtual MmpurchasePlanItem FkMmpurchasePlanItem { get; set; }

    [ForeignKey("FkMmtoOperationId")]
    [InverseProperty("ApcancelPurchaseProposalItemFkMmtoOperations")]
    public virtual Mmoperation FkMmtoOperation { get; set; }
}
