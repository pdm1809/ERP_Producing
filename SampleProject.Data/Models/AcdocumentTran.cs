using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACDocumentTrans")]
public partial class AcdocumentTran
{
    [Key]
    [Column("ACDocumentTranID")]
    public int AcdocumentTranId { get; set; }

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

    [Column("ACDocumentTranReferenceID")]
    public int? AcdocumentTranReferenceId { get; set; }

    [Column("ACDocumentTranReferenceNo")]
    [StringLength(50)]
    public string AcdocumentTranReferenceNo { get; set; }

    [Column("ACDocumentTranModuleName")]
    [StringLength(50)]
    public string AcdocumentTranModuleName { get; set; }

    [Column("ACDocumentTranModuleType")]
    [StringLength(50)]
    public string AcdocumentTranModuleType { get; set; }

    [Required]
    [Column("ACDocumentTranNo")]
    [StringLength(50)]
    public string AcdocumentTranNo { get; set; }

    [Column("ACDocumentTranName")]
    [StringLength(100)]
    public string AcdocumentTranName { get; set; }

    [Column("ACDocumentTranDate", TypeName = "datetime")]
    public DateTime AcdocumentTranDate { get; set; }

    [Required]
    [Column("ACDocumentTranPostingNo")]
    [StringLength(50)]
    public string AcdocumentTranPostingNo { get; set; }

    [Column("ACDocumentTranPostingDate", TypeName = "datetime")]
    public DateTime AcdocumentTranPostingDate { get; set; }

    [Column("ACDocumentTranPostingGroup")]
    public int? AcdocumentTranPostingGroup { get; set; }

    [Column("ACDocumentTranStatus")]
    [StringLength(50)]
    public string AcdocumentTranStatus { get; set; }

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

    [Column("ACDocumentTranDesc")]
    [StringLength(1024)]
    public string AcdocumentTranDesc { get; set; }

    [Column("ACDocumentTranDetailDesc")]
    [StringLength(1024)]
    public string AcdocumentTranDetailDesc { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("ACDocumentTranExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentTranExchangeRate { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("ACDocumentTranExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentTranExchangeAmount { get; set; }

    [Column("ACDocumentTranDebitAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentTranDebitAmount { get; set; }

    [Column("ACDocumentTranDebitExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentTranDebitExchangeAmount { get; set; }

    [Column("ACDocumentTranCreditAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentTranCreditAmount { get; set; }

    [Column("ACDocumentTranCreditExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentTranCreditExchangeAmount { get; set; }

    public bool? IsPosted { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ACDocumentTranReceiptLotNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcdocumentTranReceiptLotNo { get; set; }

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

    [Column("ACDocumentTranCode01Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode01Combo { get; set; }

    [Column("ACDocumentTranCode02Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode02Combo { get; set; }

    [Column("ACDocumentTranCode03Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode03Combo { get; set; }

    [Column("ACDocumentTranCode04Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode04Combo { get; set; }

    [Column("ACDocumentTranCode05Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode05Combo { get; set; }

    [Column("ACDocumentTranCode06Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode06Combo { get; set; }

    [Column("ACDocumentTranCode07Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode07Combo { get; set; }

    [Column("ACDocumentTranCode08Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode08Combo { get; set; }

    [Column("ACDocumentTranCode09Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode09Combo { get; set; }

    [Column("ACDocumentTranCode10Combo")]
    [StringLength(256)]
    public string AcdocumentTranCode10Combo { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcdocumentTranFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcoffsetAccountId")]
    [InverseProperty("AcdocumentTranFkAcoffsetAccounts")]
    public virtual Acaccount FkAcoffsetAccount { get; set; }
}
