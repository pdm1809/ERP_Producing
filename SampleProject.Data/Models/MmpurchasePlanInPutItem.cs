using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPurchasePlanInPutItems")]
public partial class MmpurchasePlanInPutItem
{
    [Key]
    [Column("MMPurchasePlanInPutItemID")]
    public int MmpurchasePlanInPutItemId { get; set; }

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

    [Column("MMPurchasePlanInPutItemPurchaseType")]
    [StringLength(50)]
    public string MmpurchasePlanInPutItemPurchaseType { get; set; }

    [Column("MMPurchasePlanInPutItemWoodPlanQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemWoodPlanQuantity { get; set; }

    [Column("MMPurchasePlanInPutItemQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemQuantity { get; set; }

    [Column("MMPurchasePlanInPutItemProductName")]
    [StringLength(512)]
    public string MmpurchasePlanInPutItemProductName { get; set; }

    [Column("MMPurchasePlanInPutItemProductDesc")]
    [StringLength(4000)]
    public string MmpurchasePlanInPutItemProductDesc { get; set; }

    [Column("MMPurchasePlanInPutItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemProductHeight { get; set; }

    [Column("MMPurchasePlanInPutItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemProductWidth { get; set; }

    [Column("MMPurchasePlanInPutItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemProductLength { get; set; }

    [Column("MMPurchasePlanInPutItemPurchaseProposalQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemPurchaseProposalQty { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("MMPurchasePlanInPutItemRoundWoodBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemRoundWoodBlock { get; set; }

    [Column("MMPurchasePlanInPutItemBPProductionNormItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemBpproductionNormItemQty { get; set; }

    [Column("MMPurchasePlanInPutItemBPItemComment")]
    [StringLength(1000)]
    public string MmpurchasePlanInPutItemBpitemComment { get; set; }

    [Column("MMPurchasePlanInPutItemBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemBlock { get; set; }

    [Column("MMPurchasePlanInPutItemComment")]
    [StringLength(1000)]
    public string MmpurchasePlanInPutItemComment { get; set; }

    [Column("MMPurchasePlanInPutItemBPQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemBpquantity { get; set; }

    [Column("MMPurchasePlanInPutItemProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemProductionNormItemBlocks { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_MMFromOperationID")]
    public int? FkMmfromOperationId { get; set; }

    [Column("FK_MMToOperationID")]
    public int? FkMmtoOperationId { get; set; }

    [Column("MMPurchasePlanInPutItemProductionNormItemTotalBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemProductionNormItemTotalBlocks { get; set; }

    [Column("MMPurchasePlanInPutItemProductionNormItemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemProductionNormItemTotalPaint { get; set; }

    [Column("MMPurchasePlanInPutItemProductSupplierNumber")]
    [StringLength(50)]
    public string MmpurchasePlanInPutItemProductSupplierNumber { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMPurchasePlanInPutItemCanceledQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemCanceledQuantity { get; set; }

    [Column("MMPurchasePlanInPutItemPurchaseOutsideQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemPurchaseOutsideQty { get; set; }

    [Column("MMPurchasePlanInPutItemOrderID")]
    public int? MmpurchasePlanInPutItemOrderId { get; set; }

    [Column("MMPurchasePlanInPutItemFreshLumberHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemFreshLumberHeight { get; set; }

    [Column("MMPurchasePlanInputItemDryLumberHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInputItemDryLumberHeight { get; set; }

    [Column("MMPurchasePlanInPutItemDryLumberBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInPutItemDryLumberBlock { get; set; }

    [Column("MMPurchasePlanInputItemFreshLumberBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanInputItemFreshLumberBlock { get; set; }

    [Column("FK_MMWoodPlanItemDetailID")]
    public int? FkMmwoodPlanItemDetailId { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmpurchasePlanInPutItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmpurchasePlanInPutItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmpurchasePlanInPutItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmpurchasePlanInPutItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmpurchasePlanInPutItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmpurchasePlanInPutItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmpurchasePlanInPutItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmfromOperationId")]
    [InverseProperty("MmpurchasePlanInPutItemFkMmfromOperations")]
    public virtual Mmoperation FkMmfromOperation { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("MmpurchasePlanInPutItems")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkMmtoOperationId")]
    [InverseProperty("MmpurchasePlanInPutItemFkMmtoOperations")]
    public virtual Mmoperation FkMmtoOperation { get; set; }
}
