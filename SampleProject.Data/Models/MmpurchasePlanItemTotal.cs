using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPurchasePlanItemTotals")]
public partial class MmpurchasePlanItemTotal
{
    [Key]
    [Column("MMPurchasePlanItemTotalID")]
    public int MmpurchasePlanItemTotalId { get; set; }

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

    [Column("MMPurchasePlanItemTotalPurchaseType")]
    [StringLength(50)]
    public string MmpurchasePlanItemTotalPurchaseType { get; set; }

    [Column("MMPurchasePlanItemTotalWoodPlanQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalWoodPlanQuantity { get; set; }

    [Column("MMPurchasePlanItemTotalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalQuantity { get; set; }

    [Column("MMPurchasePlanItemTotalProductName")]
    [StringLength(512)]
    public string MmpurchasePlanItemTotalProductName { get; set; }

    [Column("MMPurchasePlanItemTotalProductDesc")]
    [StringLength(4000)]
    public string MmpurchasePlanItemTotalProductDesc { get; set; }

    [Column("MMPurchasePlanItemTotalProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalProductHeight { get; set; }

    [Column("MMPurchasePlanItemTotalProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalProductWidth { get; set; }

    [Column("MMPurchasePlanItemTotalProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalProductLength { get; set; }

    [Column("MMPurchasePlanItemTotalNeededTime", TypeName = "datetime")]
    public DateTime? MmpurchasePlanItemTotalNeededTime { get; set; }

    [Column("MMPurchasePlanItemTotalFreshLumberBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalFreshLumberBlock { get; set; }

    [Column("MMPurchasePlanItemTotalFreshLumberHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalFreshLumberHeight { get; set; }

    [Column("MMPurchasePlanItemTotalDryLumberBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalDryLumberBlock { get; set; }

    [Column("MMPurchasePlanItemTotalDryLumberHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalDryLumberHeight { get; set; }

    [Column("MMPurchasePlanItemTotalPurchaseProposalQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalPurchaseProposalQty { get; set; }

    [Column("MMPriority")]
    [StringLength(50)]
    [Unicode(false)]
    public string Mmpriority { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("MMPurchasePlanItemTotalRoundWoodBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalRoundWoodBlock { get; set; }

    [Column("MMPurchasePlanItemTotalBPProductionNormItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalBpproductionNormItemQty { get; set; }

    [Column("FK_MMWoodPlanID")]
    public int? FkMmwoodPlanId { get; set; }

    [Column("FK_MMWoodPlanItemDetailID")]
    public int? FkMmwoodPlanItemDetailId { get; set; }

    [Column("FK_ICOriginalProductID")]
    public int? FkIcoriginalProductId { get; set; }

    [Column("FK_ICOriginalProductAttributeWoodTypeID")]
    public int? FkIcoriginalProductAttributeWoodTypeId { get; set; }

    [Column("MMPurchasePlanItemTotalOriginalProductName")]
    [StringLength(512)]
    public string MmpurchasePlanItemTotalOriginalProductName { get; set; }

    [Column("MMPurchasePlanItemTotalOriginalProductDesc")]
    [StringLength(1024)]
    public string MmpurchasePlanItemTotalOriginalProductDesc { get; set; }

    [Column("MMPurchasePlanItemTotalOriginalProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalOriginalProductHeight { get; set; }

    [Column("MMPurchasePlanItemTotalOriginalProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalOriginalProductWidth { get; set; }

    [Column("MMPurchasePlanItemTotalOriginalProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalOriginalProductLength { get; set; }

    [Column("MMPurchasePlanItemTotalBPItemComment")]
    [StringLength(1000)]
    public string MmpurchasePlanItemTotalBpitemComment { get; set; }

    [Column("MMPurchasePlanItemTotalProductJoinery")]
    [StringLength(50)]
    public string MmpurchasePlanItemTotalProductJoinery { get; set; }

    [Column("MMPurchasePlanItemTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalBlock { get; set; }

    [Column("MMPurchasePlanItemTotalComment")]
    [StringLength(1000)]
    public string MmpurchasePlanItemTotalComment { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("MMPurchasePlanItemTotalBPQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalBpquantity { get; set; }

    [Column("FK_ICBPMeasureUnitID")]
    public int? FkIcbpmeasureUnitId { get; set; }

    [Column("MMPurchasePlanItemTotalProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalProductionNormItemBlocks { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("MMPurchasePlanItemTotalProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalProductionNormItemPaint { get; set; }

    [Column("FK_MMFromOperationID")]
    public int? FkMmfromOperationId { get; set; }

    [Column("FK_MMToOperationID")]
    public int? FkMmtoOperationId { get; set; }

    [Column("MMPurchasePlanItemTotalProductionNormItemTotalBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalProductionNormItemTotalBlocks { get; set; }

    [Column("MMPurchasePlanItemTotalProductionNormItemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalProductionNormItemTotalPaint { get; set; }

    [Column("MMPurchasePlanItemTotalProductSupplierNumber")]
    [StringLength(50)]
    public string MmpurchasePlanItemTotalProductSupplierNumber { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("FK_MMOperationDetailPlanItemID")]
    public int? FkMmoperationDetailPlanItemId { get; set; }

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int? FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("MMPurchasePlanItemTotalCanceledQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalCanceledQuantity { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("MMPurchasePlanItemTotalPurchaseOutsideQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanItemTotalPurchaseOutsideQty { get; set; }

    [InverseProperty("FkMmpurchasePlanItemTotal")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcbpmeasureUnitId")]
    [InverseProperty("MmpurchasePlanItemTotalFkIcbpmeasureUnits")]
    public virtual IcmeasureUnit FkIcbpmeasureUnit { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmpurchasePlanItemTotalFkIcmeasureUnits")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmpurchasePlanItemTotalFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmpurchasePlanItemTotalFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmpurchasePlanItemTotalFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmpurchasePlanItemTotalFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmpurchasePlanItemTotalFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmfromOperationId")]
    [InverseProperty("MmpurchasePlanItemTotalFkMmfromOperations")]
    public virtual Mmoperation FkMmfromOperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmoperationDetailPlanItemId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmoperationDetailPlanItem FkMmoperationDetailPlanItem { get; set; }

    [ForeignKey("FkMmoperationDetailPlanItemChildId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmoperationDetailPlanItemChild FkMmoperationDetailPlanItemChild { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkMmtoOperationId")]
    [InverseProperty("MmpurchasePlanItemTotalFkMmtoOperations")]
    public virtual Mmoperation FkMmtoOperation { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [ForeignKey("FkMmwoodPlanItemDetailId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmwoodPlanItemDetail FkMmwoodPlanItemDetail { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmpurchasePlanItemTotals")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
