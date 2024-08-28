using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationDetailPlanCancelItems")]
public partial class MmoperationDetailPlanCancelItem
{
    [Key]
    [Column("MMOperationDetailPlanCancelItemID")]
    public int MmoperationDetailPlanCancelItemId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("FK_MMOperationDetailPlanItemID")]
    public int FkMmoperationDetailPlanItemId { get; set; }

    [Column("MMOperationDetailPlanCancelItemProductForBatchNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCancelItemProductForBatchNo { get; set; }

    [Column("MMOperationDetailPlanCancelItemSaleOrdeNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCancelItemSaleOrdeNo { get; set; }

    [Column("MMOperationDetailPlanCancelItemProductNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCancelItemProductNo { get; set; }

    [Column("MMOperationDetailPlanCancelItemProductName")]
    [StringLength(512)]
    public string MmoperationDetailPlanCancelItemProductName { get; set; }

    [Column("MMOperationDetailPlanCancelItemParentNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCancelItemParentNo { get; set; }

    [Column("MMOperationDetailPlanCancelItemParentID")]
    public int? MmoperationDetailPlanCancelItemParentId { get; set; }

    [Column("MMOperationDetailPlanCancelItemParentProductName")]
    [StringLength(512)]
    public string MmoperationDetailPlanCancelItemParentProductName { get; set; }

    [Column("MMOperationDetailPlanCancelItemBlockPerOne", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemBlockPerOne { get; set; }

    [Column("MMOperationDetailPlanCancelItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemProductQty { get; set; }

    [Column("MMOperationDetailPlanCancelItemTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemTotalBlock { get; set; }

    [Column("MMOperationDetailPlanCancelItemTotalProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemTotalProductQty { get; set; }

    [Column("MMOperationDetailPlanCancelItemRemainBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemRemainBlock { get; set; }

    [Column("MMOperationDetailPlanCancelItemRemainProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemRemainProductQty { get; set; }

    [Column("MMOperationDetailPlanCancelItemCompletedBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemCompletedBlock { get; set; }

    [Column("MMOperationDetailPlanCancelItemCompletedProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemCompletedProductQty { get; set; }

    [Column("MMOperationDetailPlanCancelItemPIProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemPiproductQty { get; set; }

    [Column("MMOperationDetailPlanCancelItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemProductHeight { get; set; }

    [Column("MMOperationDetailPlanCancelItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemProductWidth { get; set; }

    [Column("MMOperationDetailPlanCancelItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemProductLength { get; set; }

    [Column("MMOperationDetailPlanCancelItemPlanNeededTime", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanCancelItemPlanNeededTime { get; set; }

    [Column("MMOperationDetailPlanCancelItemPlanDesc")]
    [StringLength(512)]
    public string MmoperationDetailPlanCancelItemPlanDesc { get; set; }

    [Column("MMOperationDetailPlanCancelItemProductSerial")]
    [StringLength(50)]
    public string MmoperationDetailPlanCancelItemProductSerial { get; set; }

    [Column("MMOperationDetailPlanCancelItemPlanBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemPlanBlock { get; set; }

    [Column("MMOperationDetailPlanCancelItemPlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemPlanProductQty { get; set; }

    [Column("MMOperationDetailPlanCancelItemBatchProductItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemBatchProductItemProductQty { get; set; }

    [Column("MMOperationDetailPlanCancelItemProductWoodType")]
    [StringLength(50)]
    public string MmoperationDetailPlanCancelItemProductWoodType { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("FK_MMOperationDetailPlanCancelID")]
    public int? FkMmoperationDetailPlanCancelId { get; set; }

    [Column("MMOperationDetailPlanCancelItemCancelQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemCancelQty { get; set; }

    [Column("MMOperationDetailPlanCancelItemCompensateQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemCompensateQty { get; set; }

    [Column("MMOperationDetailPlanCancelItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCancelItemQty { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmoperationDetailPlanCancelItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmoperationDetailPlanCancelItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmoperationDetailPlanCancelId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual MmoperationDetailPlanCancel FkMmoperationDetailPlanCancel { get; set; }

    [ForeignKey("FkMmoperationDetailPlanItemId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual MmoperationDetailPlanItem FkMmoperationDetailPlanItem { get; set; }

    [ForeignKey("FkMmoperationDetailPlanItemChildId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual MmoperationDetailPlanItemChild FkMmoperationDetailPlanItemChild { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmoperationDetailPlanCancelItems")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }
}
