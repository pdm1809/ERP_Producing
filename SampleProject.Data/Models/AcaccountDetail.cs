using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAccountDetails")]
[Microsoft.EntityFrameworkCore.Index("FkAcobjectId", "AcobjectType", Name = "Idx_ACAccountDetails")]
public partial class AcaccountDetail
{
    [Key]
    [Column("ACAccountDetailID")]
    public int AcaccountDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACAccountID")]
    public int FkAcaccountId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("ACAccountDetailExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountDetailExchangeRate { get; set; }

    [Column("ACAccountDetailInitialBalanceByCurrency", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountDetailInitialBalanceByCurrency { get; set; }

    [Column("ACAccountDetailInitialBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountDetailInitialBalance { get; set; }

    [Column("ACAccountDetailDate", TypeName = "datetime")]
    public DateTime? AcaccountDetailDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ACDocumentDebitAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentDebitAmount { get; set; }

    [Column("ACDocumentDebitExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentDebitExchangeAmount { get; set; }

    [Column("ACDocumentCreditAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentCreditAmount { get; set; }

    [Column("ACDocumentCreditExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentCreditExchangeAmount { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICReceiptItemLotNo")]
    public int? IcreceiptItemLotNo { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

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

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_ACLoanReceiptID")]
    public int? FkAcloanReceiptId { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcaccountDetails")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcaccountDetails")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("AcaccountDetails")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcaccountDetails")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
