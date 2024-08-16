using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APProposalItemTotals")]
public partial class ApproposalItemTotal
{
    [Key]
    [Column("APProposalItemTotalID")]
    public int ApproposalItemTotalId { get; set; }

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

    [Column("APProposalItemTotalProductType")]
    [StringLength(50)]
    public string ApproposalItemTotalProductType { get; set; }

    [Column("APProposalItemTotalSortOrder")]
    public int? ApproposalItemTotalSortOrder { get; set; }

    [Column("APProposalItemTotalProductSerialNo")]
    [StringLength(50)]
    public string ApproposalItemTotalProductSerialNo { get; set; }

    [Column("APProposalItemTotalProductAttribute")]
    [StringLength(200)]
    public string ApproposalItemTotalProductAttribute { get; set; }

    [Column("APProposalItemTotalProductName")]
    [StringLength(50)]
    public string ApproposalItemTotalProductName { get; set; }

    [Column("APProposalItemTotalProductDesc")]
    [StringLength(4000)]
    public string ApproposalItemTotalProductDesc { get; set; }

    [Column("APProposalItemTotalProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductUnitPrice { get; set; }

    [Column("APProposalItemTotalProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductUnitCost { get; set; }

    [Column("APProposalItemTotalProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductDiscount { get; set; }

    [Column("APProposalItemTotalProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductTaxPercent { get; set; }

    [Column("APProposalItemTotalProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductQtyOld { get; set; }

    [Column("APProposalItemTotalProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductQty { get; set; }

    [Column("APProposalItemTotalPurchasedQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalPurchasedQty { get; set; }

    [Column("APProposalItemTotalQty1", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalQty1 { get; set; }

    [Column("APProposalItemTotalQty2", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalQty2 { get; set; }

    [Column("APProposalItemTotalQty3", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalQty3 { get; set; }

    [Column("APProposalItemTotalQty4", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalQty4 { get; set; }

    [Column("APProposalItemTotalQty5", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalQty5 { get; set; }

    [Column("APProposalItemTotalQty6", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalQty6 { get; set; }

    [Column("APProposalItemTotalComment")]
    [StringLength(1000)]
    public string ApproposalItemTotalComment { get; set; }

    [Column("APProposalItemTotalExtCost", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalExtCost { get; set; }

    [Column("APProposalItemTotalTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalTaxAmount { get; set; }

    [Column("APProposalItemTotalTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalTotalCost { get; set; }

    [Column("APPurchaseProposalItemType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseProposalItemType { get; set; }

    [Column("APPurchaseProposalItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseProposalItemStatus { get; set; }

    [Column("APProposalItemTotalProductSupplierNo")]
    [StringLength(50)]
    public string ApproposalItemTotalProductSupplierNo { get; set; }

    [Column("FK_MMPurchasePlanID")]
    public int? FkMmpurchasePlanId { get; set; }

    [Column("FK_MMPurchasePlanItemTotalID")]
    public int? FkMmpurchasePlanItemTotalId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("APPriority")]
    [StringLength(50)]
    public string Appriority { get; set; }

    [Column("APProposalItemTotalNeedTime", TypeName = "datetime")]
    public DateTime? ApproposalItemTotalNeedTime { get; set; }

    [Column("APProposalItemTotalProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductHeight { get; set; }

    [Column("APProposalItemTotalProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductWidth { get; set; }

    [Column("APProposalItemTotalProductLenght", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductLenght { get; set; }

    [Column("APProposalItemTotalProductWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductWidthMax { get; set; }

    [Column("APProposalItemTotalProductLenghtMax", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductLenghtMax { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("APProposalItemTotalPurchaseOrderQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalPurchaseOrderQty { get; set; }

    [Column("APProposalItemTotalCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalCanceledQty { get; set; }

    [Column("FK_MMAllocationProposalID")]
    public int? FkMmallocationProposalId { get; set; }

    [Column("FK_MMAllocationProposalItemID")]
    public int? FkMmallocationProposalItemId { get; set; }

    [Column("FK_MMFromOperationID")]
    public int? FkMmfromOperationId { get; set; }

    [Column("FK_MMToOperationID")]
    public int? FkMmtoOperationId { get; set; }

    [Column("APProposalItemTotalProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductionNormItemPaint { get; set; }

    [Column("APProposalItemTotalProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductionNormItemBlocks { get; set; }

    [Column("APProposalItemTotalProductionNormItemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductionNormItemTotalPaint { get; set; }

    [Column("APProposalItemTotalProductionNormItemTotalBlocks", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductionNormItemTotalBlocks { get; set; }

    [Column("APProposalItemTotalProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductPerimeter { get; set; }

    [Column("APProposalItemTotalWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalWoodQty { get; set; }

    [Column("APProposalItemTotalInsideDemensionWitdh", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalInsideDemensionWitdh { get; set; }

    [Column("APProposalItemTotalInsideDemensionLength", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalInsideDemensionLength { get; set; }

    [Column("APProposalItemTotalInsideDemensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalInsideDemensionHeight { get; set; }

    [Column("APProposalItemTotalOverallDemensionWitdh", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalOverallDemensionWitdh { get; set; }

    [Column("APProposalItemTotalOverallDemensionLength", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalOverallDemensionLength { get; set; }

    [Column("APProposalItemTotalOverallDemensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalOverallDemensionHeight { get; set; }

    [Column("APProposalItemTotalProductSizeAndPacking")]
    [StringLength(256)]
    public string ApproposalItemTotalProductSizeAndPacking { get; set; }

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

    [Column("APProposalItemTotalNeedToTime", TypeName = "datetime")]
    public DateTime? ApproposalItemTotalNeedToTime { get; set; }

    [Column("APProposalItemTotalProductQtySter", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductQtySter { get; set; }

    [Column("APProposalItemTotalProductUnitCostSter", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalProductUnitCostSter { get; set; }

    [Column("APProposalItemTotalTotalCostSter", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalTotalCostSter { get; set; }

    [Column("APProposalItemTotalPurchaseOrderWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalPurchaseOrderWoodQty { get; set; }

    [Column("APProposalItemTotalCanceledWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalItemTotalCanceledWoodQty { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkApproposalId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual Approposal FkApproposal { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcprodAttPackingMaterialWeightPerVolumeId")]
    [InverseProperty("ApproposalItemTotalFkIcprodAttPackingMaterialWeightPerVolumes")]
    public virtual IcproductAttribute FkIcprodAttPackingMaterialWeightPerVolume { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApproposalItemTotalFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("ApproposalItemTotalFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ApproposalItemTotalFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("ApproposalItemTotalFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("ApproposalItemTotalFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("ApproposalItemTotalFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("FkMmallocationProposalItemId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual MmallocationProposalItem FkMmallocationProposalItem { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmfromOperationId")]
    [InverseProperty("ApproposalItemTotalFkMmfromOperations")]
    public virtual Mmoperation FkMmfromOperation { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkMmpurchasePlanItemTotalId")]
    [InverseProperty("ApproposalItemTotals")]
    public virtual MmpurchasePlanItemTotal FkMmpurchasePlanItemTotal { get; set; }

    [ForeignKey("FkMmtoOperationId")]
    [InverseProperty("ApproposalItemTotalFkMmtoOperations")]
    public virtual Mmoperation FkMmtoOperation { get; set; }
}
