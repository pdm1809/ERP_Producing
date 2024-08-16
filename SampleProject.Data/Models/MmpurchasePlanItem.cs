using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPurchasePlanItems")]
public partial class MmpurchasePlanItem
{
    [Key]
    [Column("MMPurchasePlanItemID")]
    public int MmpurchasePlanItemId { get; set; }

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

    [Column("MMPurchasePlanItemPurchaseType")]
    [StringLength(50)]
    public string MmpurchasePlanItemPurchaseType { get; set; }

    [Column("MMPurchasePlanItemWoodPlanQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemWoodPlanQuantity { get; set; }

    [Column("MMPurchasePlanItemQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemQuantity { get; set; }

    [Column("MMPurchasePlanItemProductName")]
    [StringLength(512)]
    public string MmpurchasePlanItemProductName { get; set; }

    [Column("MMPurchasePlanItemProductDesc")]
    [StringLength(1024)]
    public string MmpurchasePlanItemProductDesc { get; set; }

    [Column("MMPurchasePlanItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemProductHeight { get; set; }

    [Column("MMPurchasePlanItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemProductWidth { get; set; }

    [Column("MMPurchasePlanItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemProductLength { get; set; }

    [Column("MMPurchasePlanItemNeededTime", TypeName = "datetime")]
    public DateTime? MmpurchasePlanItemNeededTime { get; set; }

    [Column("MMPurchasePlanItemFreshLumberBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemFreshLumberBlock { get; set; }

    [Column("MMPurchasePlanItemFreshLumberHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemFreshLumberHeight { get; set; }

    [Column("MMPurchasePlanItemDryLumberBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemDryLumberBlock { get; set; }

    [Column("MMPurchasePlanItemDryLumberHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemDryLumberHeight { get; set; }

    [Column("MMPurchasePlanItemPurchaseProposalQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemPurchaseProposalQty { get; set; }

    [Column("MMPriority")]
    [StringLength(50)]
    [Unicode(false)]
    public string Mmpriority { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("MMPurchasePlanItemRoundWoodBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemRoundWoodBlock { get; set; }

    [Column("MMPurchasePlanItemBPProductionNormItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemBpproductionNormItemQty { get; set; }

    [Column("FK_MMWoodPlanID")]
    public int? FkMmwoodPlanId { get; set; }

    [Column("FK_MMWoodPlanItemDetailID")]
    public int? FkMmwoodPlanItemDetailId { get; set; }

    [Column("FK_ICOriginalProductID")]
    public int? FkIcoriginalProductId { get; set; }

    [Column("FK_ICOriginalProductAttributeWoodTypeID")]
    public int? FkIcoriginalProductAttributeWoodTypeId { get; set; }

    [Column("MMPurchasePlanItemOriginalProductName")]
    [StringLength(512)]
    public string MmpurchasePlanItemOriginalProductName { get; set; }

    [Column("MMPurchasePlanItemOriginalProductDesc")]
    [StringLength(1024)]
    public string MmpurchasePlanItemOriginalProductDesc { get; set; }

    [Column("MMPurchasePlanItemOriginalProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemOriginalProductHeight { get; set; }

    [Column("MMPurchasePlanItemOriginalProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemOriginalProductWidth { get; set; }

    [Column("MMPurchasePlanItemOriginalProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemOriginalProductLength { get; set; }

    [Column("MMPurchasePlanItemBPItemComment")]
    [StringLength(1000)]
    public string MmpurchasePlanItemBpitemComment { get; set; }

    [Column("MMPurchasePlanItemProductJoinery")]
    [StringLength(50)]
    public string MmpurchasePlanItemProductJoinery { get; set; }

    [Column("MMPurchasePlanItemBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemBlock { get; set; }

    [Column("MMPurchasePlanItemComment")]
    [StringLength(1000)]
    public string MmpurchasePlanItemComment { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("MMPurchasePlanItemBPQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemBpquantity { get; set; }

    [Column("FK_ICBPMeasureUnitID")]
    public int? FkIcbpmeasureUnitId { get; set; }

    [Column("MMPurchasePlanItemProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemProductionNormItemBlocks { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("MMPurchasePlanItemProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemProductionNormItemPaint { get; set; }

    [Column("FK_MMFromOperationID")]
    public int? FkMmfromOperationId { get; set; }

    [Column("FK_MMToOperationID")]
    public int? FkMmtoOperationId { get; set; }

    [Column("MMPurchasePlanItemProductionNormItemTotalBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemProductionNormItemTotalBlocks { get; set; }

    [Column("MMPurchasePlanItemProductionNormItemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemProductionNormItemTotalPaint { get; set; }

    [Column("MMPurchasePlanItemProductSupplierNumber")]
    [StringLength(50)]
    public string MmpurchasePlanItemProductSupplierNumber { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMPurchasePlanItemCanceledQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemCanceledQuantity { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("FK_MMOperationDetailPlanItemID")]
    public int? FkMmoperationDetailPlanItemId { get; set; }

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int? FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("MMPurchasePlanItemPurchaseOutsideQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemPurchaseOutsideQty { get; set; }

    [Column("MMPurchasePlanItemAllocatedQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemAllocatedQty { get; set; }

    [Column("MMPurchasePlanItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemProductFactor { get; set; }

    [Column("MMPurchasePlanItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemProductExchangeQty { get; set; }

    [Column("MMPurchasePlanItemStatus")]
    [StringLength(50)]
    public string MmpurchasePlanItemStatus { get; set; }

    [InverseProperty("FkMmpurchasePlanItem")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkMmpurchasePlanItem")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("MmpurchasePlanItems")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkIcbpmeasureUnitId")]
    [InverseProperty("MmpurchasePlanItemFkIcbpmeasureUnits")]
    public virtual IcmeasureUnit FkIcbpmeasureUnit { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmpurchasePlanItemFkIcmeasureUnits")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmpurchasePlanItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmpurchasePlanItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmpurchasePlanItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmpurchasePlanItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmpurchasePlanItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmpurchasePlanItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmpurchasePlanItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmpurchasePlanItems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmfromOperationId")]
    [InverseProperty("MmpurchasePlanItemFkMmfromOperations")]
    public virtual Mmoperation FkMmfromOperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmpurchasePlanItems")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("MmpurchasePlanItems")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkMmtoOperationId")]
    [InverseProperty("MmpurchasePlanItemFkMmtoOperations")]
    public virtual Mmoperation FkMmtoOperation { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmpurchasePlanItems")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [ForeignKey("FkMmwoodPlanItemDetailId")]
    [InverseProperty("MmpurchasePlanItems")]
    public virtual MmwoodPlanItemDetail FkMmwoodPlanItemDetail { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmpurchasePlanItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmpurchasePlanItem")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; } = new List<MmcanceledPurchasePlanItem>();
}
