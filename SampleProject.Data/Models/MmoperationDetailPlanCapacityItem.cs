using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationDetailPlanCapacityItems")]
public partial class MmoperationDetailPlanCapacityItem
{
    [Key]
    [Column("MMOperationDetailPlanCapacityItemID")]
    public int MmoperationDetailPlanCapacityItemId { get; set; }

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

    [Column("FK_MMOperationDetailPlanCapacityID")]
    public int FkMmoperationDetailPlanCapacityId { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProductForBatchNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCapacityItemProductForBatchNo { get; set; }

    [Column("MMOperationDetailPlanCapacityItemSaleOrdeNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCapacityItemSaleOrdeNo { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProductNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCapacityItemProductNo { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProductName")]
    [StringLength(512)]
    public string MmoperationDetailPlanCapacityItemProductName { get; set; }

    [Column("MMOperationDetailPlanCapacityItemParentNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCapacityItemParentNo { get; set; }

    [Column("MMOperationDetailPlanCapacityItemParentID")]
    public int? MmoperationDetailPlanCapacityItemParentId { get; set; }

    [Column("MMOperationDetailPlanCapacityItemParentProductName")]
    [StringLength(512)]
    public string MmoperationDetailPlanCapacityItemParentProductName { get; set; }

    [Column("MMOperationDetailPlanCapacityItemBlockPerOne", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemBlockPerOne { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemProductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityItemTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemTotalBlock { get; set; }

    [Column("MMOperationDetailPlanCapacityItemTotalProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemTotalProductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityItemRemainBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemRemainBlock { get; set; }

    [Column("MMOperationDetailPlanCapacityItemRemainProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemRemainProductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityItemCompletedBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemCompletedBlock { get; set; }

    [Column("MMOperationDetailPlanCapacityItemCompletedProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemCompletedProductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityItemPIProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemPiproductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemProductHeight { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemProductWidth { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemProductLength { get; set; }

    [Column("MMOperationDetailPlanCapacityItemPlanNeededTime", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanCapacityItemPlanNeededTime { get; set; }

    [Column("MMOperationDetailPlanCapacityItemPlanDesc")]
    [StringLength(512)]
    public string MmoperationDetailPlanCapacityItemPlanDesc { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProductSerial")]
    [StringLength(50)]
    public string MmoperationDetailPlanCapacityItemProductSerial { get; set; }

    [Column("MMOperationDetailPlanCapacityItemPlanBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemPlanBlock { get; set; }

    [Column("MMOperationDetailPlanCapacityItemPlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemPlanProductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityItemCapacityBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemCapacityBlock { get; set; }

    [Column("MMOperationDetailPlanCapacityItemCapacityProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemCapacityProductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProductWoodType")]
    [StringLength(50)]
    public string MmoperationDetailPlanCapacityItemProductWoodType { get; set; }

    [Column("MMOperationDetailPlanItemChildRemainProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildRemainProductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityItemDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanCapacityItemDate { get; set; }

    [Column("MMOperationDetailPlanCapacityItemFailProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemFailProductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityItemProcessTime", TypeName = "decimal(18, 0)")]
    public decimal? MmoperationDetailPlanCapacityItemProcessTime { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_HREmployeeGiveID")]
    public int? FkHremployeeGiveId { get; set; }

    [Column("FK_HREmployeeTakeID")]
    public int? FkHremployeeTakeId { get; set; }

    [Column("FK_HREmployeeQCID")]
    public int? FkHremployeeQcid { get; set; }

    [Column("FK_HRToDepartmentRoomGroupItemID")]
    public int? FkHrtoDepartmentRoomGroupItemId { get; set; }

    [Column("MMOperationDetailPlanCapacityItemIsBeginOperation")]
    public bool? MmoperationDetailPlanCapacityItemIsBeginOperation { get; set; }

    [Column("MMOperationDetailPlanCapacityItemHasReceipt")]
    public bool? MmoperationDetailPlanCapacityItemHasReceipt { get; set; }

    [Column("MMOperationDetailPlanCapacityItemComment")]
    [StringLength(512)]
    public string MmoperationDetailPlanCapacityItemComment { get; set; }

    [Column("MMOperationDetailPlanCapacityItemParentProductDesc")]
    [StringLength(512)]
    public string MmoperationDetailPlanCapacityItemParentProductDesc { get; set; }

    [Column("FK_MMJobTicketItemID")]
    public int? FkMmjobTicketItemId { get; set; }

    [Column("MMOperationDetailPlanCapacityItemFromTime", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanCapacityItemFromTime { get; set; }

    [Column("MMOperationDetailPlanCapacityItemToTime", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanCapacityItemToTime { get; set; }

    [Column("MMOperationDetailPlanCapacityItemLossTime", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityItemLossTime { get; set; }

    [Column("MMOperationDetailPlanCapacityItemAbstract")]
    [StringLength(524)]
    public string MmoperationDetailPlanCapacityItemAbstract { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmoperationDetailPlanCapacityItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("MmoperationDetailPlanCapacityItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeGiveId")]
    [InverseProperty("MmoperationDetailPlanCapacityItemFkHremployeeGives")]
    public virtual Hremployee FkHremployeeGive { get; set; }

    [ForeignKey("FkHremployeeQcid")]
    [InverseProperty("MmoperationDetailPlanCapacityItemFkHremployeeQcs")]
    public virtual Hremployee FkHremployeeQc { get; set; }

    [ForeignKey("FkHremployeeTakeId")]
    [InverseProperty("MmoperationDetailPlanCapacityItemFkHremployeeTakes")]
    public virtual Hremployee FkHremployeeTake { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmoperationDetailPlanCapacityItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmoperationDetailPlanCapacityItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmoperationDetailPlanCapacityItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmoperationDetailPlanCapacityItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmoperationDetailPlanCapacityItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmoperationDetailPlanCapacityItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
