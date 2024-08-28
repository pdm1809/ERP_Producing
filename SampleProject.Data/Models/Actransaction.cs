using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACTransactions")]
public partial class Actransaction
{
    [Key]
    [Column("ACTransactionID")]
    public int ActransactionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("ACTransactionReferenceID")]
    public int? ActransactionReferenceId { get; set; }

    [Column("ACTransactionReferenceNo")]
    [StringLength(50)]
    public string ActransactionReferenceNo { get; set; }

    [Column("ACTransactionModuleName")]
    [StringLength(50)]
    public string ActransactionModuleName { get; set; }

    [Column("ACTransactionModuleType")]
    [StringLength(50)]
    public string ActransactionModuleType { get; set; }

    [Required]
    [Column("ACTransactionNo")]
    [StringLength(50)]
    public string ActransactionNo { get; set; }

    [Column("ACTransactionName")]
    [StringLength(512)]
    public string ActransactionName { get; set; }

    [Column("ACTransactionDate", TypeName = "datetime")]
    public DateTime ActransactionDate { get; set; }

    [Required]
    [Column("ACTransactionPostingNo")]
    [StringLength(50)]
    public string ActransactionPostingNo { get; set; }

    [Column("ACTransactionPostingDate", TypeName = "datetime")]
    public DateTime ActransactionPostingDate { get; set; }

    [Column("ACTransactionPostingGroup")]
    public int? ActransactionPostingGroup { get; set; }

    [Column("ACTransactionStatus")]
    [StringLength(50)]
    public string ActransactionStatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("ACObjectRepName")]
    [StringLength(512)]
    public string AcobjectRepName { get; set; }

    [Column("ACTransactionDesc")]
    [StringLength(1024)]
    public string ActransactionDesc { get; set; }

    [Column("ACTransactionDetailDesc")]
    [StringLength(1024)]
    public string ActransactionDetailDesc { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("ACTransactionExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ActransactionExchangeRate { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("ACTransactionDebitAmount", TypeName = "decimal(18, 5)")]
    public decimal? ActransactionDebitAmount { get; set; }

    [Column("ACTransactionDebitExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ActransactionDebitExchangeAmount { get; set; }

    [Column("ACTransactionCreditAmount", TypeName = "decimal(18, 5)")]
    public decimal? ActransactionCreditAmount { get; set; }

    [Column("ACTransactionCreditExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ActransactionCreditExchangeAmount { get; set; }

    public bool? IsPosted { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ACTransactionReceiptLotNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ActransactionReceiptLotNo { get; set; }

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

    [Column("ACTransactionCode01Combo")]
    [StringLength(256)]
    public string ActransactionCode01Combo { get; set; }

    [Column("ACTransactionCode02Combo")]
    [StringLength(256)]
    public string ActransactionCode02Combo { get; set; }

    [Column("ACTransactionCode03Combo")]
    [StringLength(256)]
    public string ActransactionCode03Combo { get; set; }

    [Column("ACTransactionCode04Combo")]
    [StringLength(256)]
    public string ActransactionCode04Combo { get; set; }

    [Column("ACTransactionCode05Combo")]
    [StringLength(256)]
    public string ActransactionCode05Combo { get; set; }

    [Column("ACTransactionCode06Combo")]
    [StringLength(256)]
    public string ActransactionCode06Combo { get; set; }

    [Column("ACTransactionCode07Combo")]
    [StringLength(256)]
    public string ActransactionCode07Combo { get; set; }

    [Column("ACTransactionCode08Combo")]
    [StringLength(256)]
    public string ActransactionCode08Combo { get; set; }

    [Column("ACTransactionCode09Combo")]
    [StringLength(256)]
    public string ActransactionCode09Combo { get; set; }

    [Column("ACTransactionCode10Combo")]
    [StringLength(256)]
    public string ActransactionCode10Combo { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("ActransactionFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcoffsetAccountId")]
    [InverseProperty("ActransactionFkAcoffsetAccounts")]
    public virtual Acaccount FkAcoffsetAccount { get; set; }
}
