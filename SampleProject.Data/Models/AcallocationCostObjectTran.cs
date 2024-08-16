using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAllocationCostObjectTrans")]
public partial class AcallocationCostObjectTran
{
    [Key]
    [Column("ACAllocationCostObjectTranID")]
    public int AcallocationCostObjectTranId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("FK_ACCostObjectItemID")]
    public int? FkAccostObjectItemId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ACAllocationCostObjectTranReferenceNo")]
    [StringLength(50)]
    public string AcallocationCostObjectTranReferenceNo { get; set; }

    [Column("ACAllocationCostObjectTranModuleName")]
    [StringLength(50)]
    public string AcallocationCostObjectTranModuleName { get; set; }

    [Column("ACAllocationCostObjectTranReferenceDate", TypeName = "datetime")]
    public DateTime? AcallocationCostObjectTranReferenceDate { get; set; }

    [Column("ACAllocationCostObjectTranYear")]
    public int? AcallocationCostObjectTranYear { get; set; }

    [Column("ACAllocationCostObjectTranPeriod")]
    public int? AcallocationCostObjectTranPeriod { get; set; }

    [Column("ACAllocationCostObjectTranDate", TypeName = "datetime")]
    public DateTime? AcallocationCostObjectTranDate { get; set; }

    [Column("FK_ACDepreciationWaitAccountID")]
    public int? FkAcdepreciationWaitAccountId { get; set; }

    [Column("FK_ACCostAccountID")]
    public int? FkAccostAccountId { get; set; }

    [Column("ACAllocationCostObjectTranCostObjectName")]
    [StringLength(50)]
    public string AcallocationCostObjectTranCostObjectName { get; set; }

    [Column("ACAllocationCostObjectTranDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcallocationCostObjectTranDepreciatedAmount { get; set; }

    [Column("ACAllocationCostObjectTranRemainedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcallocationCostObjectTranRemainedAmount { get; set; }

    [Column("ACAllocationCostObjectTranAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcallocationCostObjectTranAmount { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ACTransactionCode01Combo")]
    [StringLength(100)]
    public string ActransactionCode01Combo { get; set; }

    [Column("ACTransactionCode02Combo")]
    [StringLength(100)]
    public string ActransactionCode02Combo { get; set; }

    [Column("ACTransactionCode03Combo")]
    [StringLength(100)]
    public string ActransactionCode03Combo { get; set; }

    [Column("ACTransactionCode04Combo")]
    [StringLength(100)]
    public string ActransactionCode04Combo { get; set; }

    [Column("ACTransactionCode05Combo")]
    [StringLength(100)]
    public string ActransactionCode05Combo { get; set; }

    [Column("ACTransactionCode06Combo")]
    [StringLength(100)]
    public string ActransactionCode06Combo { get; set; }

    [Column("ACTransactionCode07Combo")]
    [StringLength(100)]
    public string ActransactionCode07Combo { get; set; }

    [Column("ACTransactionCode08Combo")]
    [StringLength(100)]
    public string ActransactionCode08Combo { get; set; }

    [Column("ACTransactionCode09Combo")]
    [StringLength(100)]
    public string ActransactionCode09Combo { get; set; }

    [Column("ACTransactionCode10Combo")]
    [StringLength(100)]
    public string ActransactionCode10Combo { get; set; }

    [ForeignKey("FkAccostAccountId")]
    [InverseProperty("AcallocationCostObjectTranFkAccostAccounts")]
    public virtual Acaccount FkAccostAccount { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccostObjectItemId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual AccostObjectItem FkAccostObjectItem { get; set; }

    [ForeignKey("FkAcdepreciationWaitAccountId")]
    [InverseProperty("AcallocationCostObjectTranFkAcdepreciationWaitAccounts")]
    public virtual Acaccount FkAcdepreciationWaitAccount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcallocationCostObjectTrans")]
    public virtual Pmproject FkPmproject { get; set; }
}
