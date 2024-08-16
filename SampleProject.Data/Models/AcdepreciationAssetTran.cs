using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACDepreciationAssetTrans")]
public partial class AcdepreciationAssetTran
{
    [Key]
    [Column("ACDepreciationAssetTranID")]
    public int AcdepreciationAssetTranId { get; set; }

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

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ACAdjustIncreaseOrDecreaseAssetID")]
    public int? FkAcadjustIncreaseOrDecreaseAssetId { get; set; }

    [Column("ACDepreciationAssetTranYear")]
    public int? AcdepreciationAssetTranYear { get; set; }

    [Column("ACDepreciationAssetTranPeriod")]
    public int? AcdepreciationAssetTranPeriod { get; set; }

    [Column("ACDepreciationAssetTranDate", TypeName = "datetime")]
    public DateTime? AcdepreciationAssetTranDate { get; set; }

    [Column("ACDepreciationAssetTranIsEdit")]
    public bool? AcdepreciationAssetTranIsEdit { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACDepreciationAccountID")]
    public int? FkAcdepreciationAccountId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("ACDepreciationAssetTranOriginalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdepreciationAssetTranOriginalAmount { get; set; }

    [Column("ACDepreciationAssetTranDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdepreciationAssetTranDepreciatedAmount { get; set; }

    [Column("ACDepreciationAssetTranRemainedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdepreciationAssetTranRemainedAmount { get; set; }

    [Column("ACDepreciationAssetTranAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdepreciationAssetTranAmount { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

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

    [Column("ACDepreciationAssetTranAdjustType")]
    [StringLength(50)]
    public string AcdepreciationAssetTranAdjustType { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcdepreciationAssetTranFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcadjustIncreaseOrDecreaseAssetId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual AcadjustIncreaseOrDecreaseAsset FkAcadjustIncreaseOrDecreaseAsset { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdepreciationAccountId")]
    [InverseProperty("AcdepreciationAssetTranFkAcdepreciationAccounts")]
    public virtual Acaccount FkAcdepreciationAccount { get; set; }

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("AcdepreciationAssetTranFkAcdepreciationCostAccounts")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcdepreciationAssetTrans")]
    public virtual Pmproject FkPmproject { get; set; }
}
