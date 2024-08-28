using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCanceledPurchasePlanItems")]
public partial class MmcanceledPurchasePlanItem
{
    [Key]
    [Column("MMCanceledPurchasePlanItemID")]
    public int MmcanceledPurchasePlanItemId { get; set; }

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

    [Column("FK_MMPurchasePlanID")]
    public int? FkMmpurchasePlanId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_MMPurchasePlanItemID")]
    public int? FkMmpurchasePlanItemId { get; set; }

    [Column("FK_MMCanceledPurchasePlanID")]
    public int? FkMmcanceledPurchasePlanId { get; set; }

    [Column("MMCanceledPurchasePlanItemPurchaseType")]
    [StringLength(50)]
    public string MmcanceledPurchasePlanItemPurchaseType { get; set; }

    [Column("MMCanceledPurchasePlanItemWoodPlanQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemWoodPlanQuantity { get; set; }

    [Column("MMCanceledPurchasePlanItemQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemQuantity { get; set; }

    [Column("MMCanceledPurchasePlanItemProductName")]
    [StringLength(512)]
    public string MmcanceledPurchasePlanItemProductName { get; set; }

    [Column("MMCanceledPurchasePlanItemProductDesc")]
    [StringLength(1024)]
    public string MmcanceledPurchasePlanItemProductDesc { get; set; }

    [Column("MMCanceledPurchasePlanItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemProductHeight { get; set; }

    [Column("MMCanceledPurchasePlanItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemProductWidth { get; set; }

    [Column("MMCanceledPurchasePlanItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemProductLength { get; set; }

    [Column("MMCanceledPurchasePlanItemNeededTime", TypeName = "datetime")]
    public DateTime? MmcanceledPurchasePlanItemNeededTime { get; set; }

    [Column("MMCanceledPurchasePlanItemFreshLumberBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemFreshLumberBlock { get; set; }

    [Column("MMCanceledPurchasePlanItemFreshLumberHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemFreshLumberHeight { get; set; }

    [Column("MMCanceledPurchasePlanItemDryLumberBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemDryLumberBlock { get; set; }

    [Column("MMCanceledPurchasePlanItemDryLumberHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemDryLumberHeight { get; set; }

    [Column("MMCanceledPurchasePlanItemPurchaseProposalQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemPurchaseProposalQty { get; set; }

    [Column("MMPriority")]
    [StringLength(50)]
    [Unicode(false)]
    public string Mmpriority { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("MMCanceledPurchasePlanItemRoundWoodBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemRoundWoodBlock { get; set; }

    [Column("MMCanceledPurchasePlanItemBPProductionNormItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemBpproductionNormItemQty { get; set; }

    [Column("FK_MMWoodPlanID")]
    public int? FkMmwoodPlanId { get; set; }

    [Column("FK_MMWoodPlanItemDetailID")]
    public int? FkMmwoodPlanItemDetailId { get; set; }

    [Column("FK_ICOriginalProductID")]
    public int? FkIcoriginalProductId { get; set; }

    [Column("FK_ICOriginalProductAttributeWoodTypeID")]
    public int? FkIcoriginalProductAttributeWoodTypeId { get; set; }

    [Column("MMCanceledPurchasePlanItemOriginalProductName")]
    [StringLength(512)]
    public string MmcanceledPurchasePlanItemOriginalProductName { get; set; }

    [Column("MMCanceledPurchasePlanItemOriginalProductDesc")]
    [StringLength(1024)]
    public string MmcanceledPurchasePlanItemOriginalProductDesc { get; set; }

    [Column("MMCanceledPurchasePlanItemOriginalProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemOriginalProductHeight { get; set; }

    [Column("MMCanceledPurchasePlanItemOriginalProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemOriginalProductWidth { get; set; }

    [Column("MMCanceledPurchasePlanItemOriginalProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemOriginalProductLength { get; set; }

    [Column("MMCanceledPurchasePlanItemBPItemComment")]
    [StringLength(1000)]
    public string MmcanceledPurchasePlanItemBpitemComment { get; set; }

    [Column("MMCanceledPurchasePlanItemProductJoinery")]
    [StringLength(50)]
    public string MmcanceledPurchasePlanItemProductJoinery { get; set; }

    [Column("MMCanceledPurchasePlanItemBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemBlock { get; set; }

    [Column("MMCanceledPurchasePlanItemComment")]
    [StringLength(1000)]
    public string MmcanceledPurchasePlanItemComment { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("MMCanceledPurchasePlanItemBPQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemBpquantity { get; set; }

    [Column("FK_ICBPMeasureUnitID")]
    public int? FkIcbpmeasureUnitId { get; set; }

    [Column("MMCanceledPurchasePlanItemProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemProductionNormItemBlocks { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("MMCanceledPurchasePlanItemProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemProductionNormItemPaint { get; set; }

    [Column("FK_MMFromOperationID")]
    public int? FkMmfromOperationId { get; set; }

    [Column("FK_MMToOperationID")]
    public int? FkMmtoOperationId { get; set; }

    [Column("MMCanceledPurchasePlanItemProductionNormItemTotalBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemProductionNormItemTotalBlocks { get; set; }

    [Column("MMCanceledPurchasePlanItemProductionNormItemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanItemProductionNormItemTotalPaint { get; set; }

    [Column("MMCanceledPurchasePlanItemProductSupplierNumber")]
    [StringLength(50)]
    public string MmcanceledPurchasePlanItemProductSupplierNumber { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("MmcanceledPurchasePlanItems")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkIcbpmeasureUnitId")]
    [InverseProperty("MmcanceledPurchasePlanItemFkIcbpmeasureUnits")]
    public virtual IcmeasureUnit FkIcbpmeasureUnit { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmcanceledPurchasePlanItemFkIcmeasureUnits")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmcanceledPurchasePlanItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmcanceledPurchasePlanItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmcanceledPurchasePlanItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmcanceledPurchasePlanItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmcanceledPurchasePlanItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmcanceledPurchasePlanItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmcanceledPurchasePlanItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmcanceledPurchasePlanItems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmcanceledPurchasePlanId")]
    [InverseProperty("MmcanceledPurchasePlanItems")]
    public virtual MmcanceledPurchasePlan FkMmcanceledPurchasePlan { get; set; }

    [ForeignKey("FkMmfromOperationId")]
    [InverseProperty("MmcanceledPurchasePlanItemFkMmfromOperations")]
    public virtual Mmoperation FkMmfromOperation { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("MmcanceledPurchasePlanItems")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkMmpurchasePlanItemId")]
    [InverseProperty("MmcanceledPurchasePlanItems")]
    public virtual MmpurchasePlanItem FkMmpurchasePlanItem { get; set; }

    [ForeignKey("FkMmtoOperationId")]
    [InverseProperty("MmcanceledPurchasePlanItemFkMmtoOperations")]
    public virtual Mmoperation FkMmtoOperation { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmcanceledPurchasePlanItems")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [ForeignKey("FkMmwoodPlanItemDetailId")]
    [InverseProperty("MmcanceledPurchasePlanItems")]
    public virtual MmwoodPlanItemDetail FkMmwoodPlanItemDetail { get; set; }
}
