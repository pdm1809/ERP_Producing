using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationDetailPlanItemChilds")]
public partial class MmoperationDetailPlanItemChild
{
    [Key]
    [Column("MMOperationDetailPlanItemChildID")]
    public int MmoperationDetailPlanItemChildId { get; set; }

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

    [Column("FK_MMOperationDetailPlanItemID")]
    public int FkMmoperationDetailPlanItemId { get; set; }

    [Column("MMOperationDetailPlanItemChildProductForBatchNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemChildProductForBatchNo { get; set; }

    [Column("MMOperationDetailPlanItemChildSaleOrdeNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemChildSaleOrdeNo { get; set; }

    [Column("MMOperationDetailPlanItemChildProductNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemChildProductNo { get; set; }

    [Column("MMOperationDetailPlanItemChildProductName")]
    [StringLength(512)]
    public string MmoperationDetailPlanItemChildProductName { get; set; }

    [Column("MMOperationDetailPlanItemChildParentNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemChildParentNo { get; set; }

    [Column("MMOperationDetailPlanItemChildParentID")]
    public int? MmoperationDetailPlanItemChildParentId { get; set; }

    [Column("MMOperationDetailPlanItemChildParentProductName")]
    [StringLength(512)]
    public string MmoperationDetailPlanItemChildParentProductName { get; set; }

    [Column("MMOperationDetailPlanItemChildBlockPerOne", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildBlockPerOne { get; set; }

    [Column("MMOperationDetailPlanItemChildProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildProductQty { get; set; }

    [Column("MMOperationDetailPlanItemChildTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildTotalBlock { get; set; }

    [Column("MMOperationDetailPlanItemChildTotalProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildTotalProductQty { get; set; }

    [Column("MMOperationDetailPlanItemChildRemainBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildRemainBlock { get; set; }

    [Column("MMOperationDetailPlanItemChildRemainProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildRemainProductQty { get; set; }

    [Column("MMOperationDetailPlanItemChildCompletedBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildCompletedBlock { get; set; }

    [Column("MMOperationDetailPlanItemChildCompletedProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildCompletedProductQty { get; set; }

    [Column("MMOperationDetailPlanItemChildPIProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildPiproductQty { get; set; }

    [Column("MMOperationDetailPlanItemChildProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildProductHeight { get; set; }

    [Column("MMOperationDetailPlanItemChildProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildProductWidth { get; set; }

    [Column("MMOperationDetailPlanItemChildProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildProductLength { get; set; }

    [Column("MMOperationDetailPlanItemChildPlanNeededTime", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanItemChildPlanNeededTime { get; set; }

    [Column("MMOperationDetailPlanItemChildPlanDesc")]
    [StringLength(512)]
    public string MmoperationDetailPlanItemChildPlanDesc { get; set; }

    [Column("MMOperationDetailPlanItemChildProductSerial")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemChildProductSerial { get; set; }

    [Column("MMOperationDetailPlanItemChildPlanBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildPlanBlock { get; set; }

    [Column("MMOperationDetailPlanItemChildPlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildPlanProductQty { get; set; }

    [Column("MMOperationDetailPlanItemChildBatchProductItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildBatchProductItemProductQty { get; set; }

    [Column("MMOperationDetailPlanItemChildProductWoodType")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemChildProductWoodType { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("MMOperationDetailPlanItemChildCancelQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildCancelQty { get; set; }

    [Column("MMOperationDetailPlanItemChildCompensateQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildCompensateQty { get; set; }

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int? FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("MMOperationDetailPlanItemChildBarcode")]
    [StringLength(500)]
    public string MmoperationDetailPlanItemChildBarcode { get; set; }

    [Column("MMOperationDetailPlanItemChildExecutionFromDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanItemChildExecutionFromDate { get; set; }

    [Column("MMOperationDetailPlanItemChildExecutionToDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanItemChildExecutionToDate { get; set; }

    [Column("MMOperationDetailPlanItemChildComment")]
    [StringLength(512)]
    public string MmoperationDetailPlanItemChildComment { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("MMOperationDetailPlanItemChildStatus")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemChildStatus { get; set; }

    [Column("MMOperationDetailPlanItemChildAbstract")]
    [StringLength(524)]
    public string MmoperationDetailPlanItemChildAbstract { get; set; }

    [Column("MMOperationDetailPlanItemChildStatusLog")]
    [StringLength(1000)]
    public string MmoperationDetailPlanItemChildStatusLog { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("MMOperationDetailPlanItemChildCapacity", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildCapacity { get; set; }

    [Column("MMOperationDetailPlanItemChildPayroll", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildPayroll { get; set; }

    [Column("MMOperationDetailPlanItemChildPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildPrice { get; set; }

    [Column("MMOperationDetailPlanItemChildPlanFinishedDate", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildPlanFinishedDate { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmoperationDetailPlanItemChildren")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmoperationDetailPlanItemChildFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmoperationDetailPlanItemChildFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmoperationDetailPlanItemChildren")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmoperationDetailPlanItemChildren")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmoperationDetailPlanItemChildren")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmoperationDetailPlanItemChildren")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [InverseProperty("FkMmoperationDetailPlanItemChild")]
    public virtual ICollection<MmjobTicketItem> MmjobTicketItems { get; set; } = new List<MmjobTicketItem>();

    [InverseProperty("FkMmoperationDetailPlanItemChild")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkMmoperationDetailPlanItemChild")]
    public virtual ICollection<MmoperationDetailPlanItemChildDateDetail> MmoperationDetailPlanItemChildDateDetails { get; set; } = new List<MmoperationDetailPlanItemChildDateDetail>();

    [InverseProperty("FkMmoperationDetailPlanItemChild")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();
}
