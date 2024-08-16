using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAllocationEquipmentTrans")]
public partial class AcallocationEquipmentTran
{
    [Key]
    [Column("ACAllocationEquipmentTranID")]
    public int AcallocationEquipmentTranId { get; set; }

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
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductIdentifiedEquipmentID")]
    public int? FkIcproductIdentifiedEquipmentId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ACAllocationEquipmentTranYear")]
    public int? AcallocationEquipmentTranYear { get; set; }

    [Column("ACAllocationEquipmentTranPeriod")]
    public int? AcallocationEquipmentTranPeriod { get; set; }

    [Column("ACAllocationEquipmentTranDate", TypeName = "datetime")]
    public DateTime? AcallocationEquipmentTranDate { get; set; }

    [Column("ACAllocationEquipmentTranIsEdit")]
    public bool? AcallocationEquipmentTranIsEdit { get; set; }

    [Column("FK_ACAllocationAccountID")]
    public int? FkAcallocationAccountId { get; set; }

    [Column("FK_ACAllocationCostAccountID")]
    public int? FkAcallocationCostAccountId { get; set; }

    [Column("ACAllocationEquipmentTranOriginalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcallocationEquipmentTranOriginalAmount { get; set; }

    [Column("ACAllocationEquipmentTranDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcallocationEquipmentTranDepreciatedAmount { get; set; }

    [Column("ACAllocationEquipmentTranRemainedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcallocationEquipmentTranRemainedAmount { get; set; }

    [Column("ACAllocationEquipmentTranQty", TypeName = "decimal(18, 5)")]
    public decimal? AcallocationEquipmentTranQty { get; set; }

    [Column("ACAllocationEquipmentTranAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcallocationEquipmentTranAmount { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

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

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("ACAllocationEquipmentTranAdjustType")]
    [StringLength(50)]
    public string AcallocationEquipmentTranAdjustType { get; set; }

    [ForeignKey("FkAcallocationAccountId")]
    [InverseProperty("AcallocationEquipmentTranFkAcallocationAccounts")]
    public virtual Acaccount FkAcallocationAccount { get; set; }

    [ForeignKey("FkAcallocationCostAccountId")]
    [InverseProperty("AcallocationEquipmentTranFkAcallocationCostAccounts")]
    public virtual Acaccount FkAcallocationCostAccount { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductIdentifiedEquipmentId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual IcproductIdentifiedEquipment FkIcproductIdentifiedEquipment { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcallocationEquipmentTrans")]
    public virtual Pmproject FkPmproject { get; set; }
}
