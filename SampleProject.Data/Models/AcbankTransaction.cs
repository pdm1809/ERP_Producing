using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBankTransactions")]
[Microsoft.EntityFrameworkCore.Index("AcbankTransactionNo", "AcbankTransactionDate", "FkBrbranchId", "FkAcobjectId", "AcobjectType", "AcbankTransactionReference", "AcbankTransactionType", Name = "Idx_ACBankTransactions")]
public partial class AcbankTransaction
{
    [Key]
    [Column("ACBankTransactionID")]
    public int AcbankTransactionId { get; set; }

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

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ACBankTransactionNo")]
    [StringLength(50)]
    public string AcbankTransactionNo { get; set; }

    [Column("ACBankTransactionDesc")]
    [StringLength(512)]
    public string AcbankTransactionDesc { get; set; }

    [Column("ACBankTransactionDate", TypeName = "datetime")]
    public DateTime? AcbankTransactionDate { get; set; }

    [Column("ACBankTransactionType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcbankTransactionType { get; set; }

    [Column("ACBankTransactionExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionExchangeRate { get; set; }

    [Column("ACBankTransactionSenderName")]
    [StringLength(100)]
    public string AcbankTransactionSenderName { get; set; }

    [Column("ACBankTransactionSenderBankName")]
    [StringLength(100)]
    public string AcbankTransactionSenderBankName { get; set; }

    [Column("ACBankTransactionSenderAccount")]
    [StringLength(50)]
    public string AcbankTransactionSenderAccount { get; set; }

    [Column("ACBankTransactionReceiverName")]
    [StringLength(100)]
    public string AcbankTransactionReceiverName { get; set; }

    [Column("ACBankTransactionReceiverIDNumber")]
    [StringLength(50)]
    public string AcbankTransactionReceiverIdnumber { get; set; }

    [Column("ACBankTransactionReceiverIDDate", TypeName = "datetime")]
    public DateTime? AcbankTransactionReceiverIddate { get; set; }

    [Column("ACBankTransactionReceiverIDPlace")]
    [StringLength(100)]
    public string AcbankTransactionReceiverIdplace { get; set; }

    [Column("ACBankTransactionReceiverContactAddress")]
    [StringLength(256)]
    public string AcbankTransactionReceiverContactAddress { get; set; }

    [Column("ACBankTransactionReceiverBankName")]
    [StringLength(100)]
    public string AcbankTransactionReceiverBankName { get; set; }

    [Column("ACBankTransactionReceiverAccount")]
    [StringLength(50)]
    public string AcbankTransactionReceiverAccount { get; set; }

    [Column("ACBankTransactionTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionTotalAmount { get; set; }

    [Column("ACBankTransactionExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionExchangeAmount { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("ACBankTransactionReference")]
    [StringLength(50)]
    public string AcbankTransactionReference { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ACBankTransactionTransferredDate", TypeName = "datetime")]
    public DateTime? AcbankTransactionTransferredDate { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("APInputVATDocumentType")]
    [StringLength(50)]
    public string ApinputVatdocumentType { get; set; }

    [Column("APInputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string ApinputVatinvoiceNoCombo { get; set; }

    [Column("ACBankTransactionFormNo")]
    [StringLength(50)]
    public string AcbankTransactionFormNo { get; set; }

    [Column("ACBankTransactionSymbol")]
    [StringLength(50)]
    public string AcbankTransactionSymbol { get; set; }

    [Column("ACBankTransactionVoucherNo")]
    [StringLength(50)]
    public string AcbankTransactionVoucherNo { get; set; }

    [Column("ACBankTransactionObjectTaxNumber")]
    [StringLength(50)]
    public string AcbankTransactionObjectTaxNumber { get; set; }

    [Column("ACBankTransactionInvoiceDate", TypeName = "datetime")]
    public DateTime? AcbankTransactionInvoiceDate { get; set; }

    [Column("FK_ACLoanReceiptID")]
    public int? FkAcloanReceiptId { get; set; }

    [Column("ACBankTransactionReceiverBankCode")]
    [StringLength(50)]
    public string AcbankTransactionReceiverBankCode { get; set; }

    [Column("FK_CSCashFundID")]
    public int? FkCscashFundId { get; set; }

    [Column("FK_ToCSCompanyBankID")]
    public int? FkToCscompanyBankId { get; set; }

    [Column("FK_ToCSCashFundID")]
    public int? FkToCscashFundId { get; set; }

    [Column("ACBankTransactionFromType")]
    [StringLength(50)]
    public string AcbankTransactionFromType { get; set; }

    [Column("ACBankTransactionToType")]
    [StringLength(50)]
    public string AcbankTransactionToType { get; set; }

    [Column("ACBankTransactionCreateFrom")]
    [StringLength(50)]
    public string AcbankTransactionCreateFrom { get; set; }

    [Column("FK_ACLoanReceiptPaymentPlanID")]
    public int? FkAcloanReceiptPaymentPlanId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ARSaleOrderSaleAgreement")]
    [StringLength(250)]
    public string ArsaleOrderSaleAgreement { get; set; }

    [Column("ACBankTransactionStatus")]
    [StringLength(128)]
    public string AcbankTransactionStatus { get; set; }

    [Column("FK_HREmployeeApprovedID")]
    public int? FkHremployeeApprovedId { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(50)]
    public string SttoolbarActionName { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("FK_ACAccountDepositID")]
    public int? FkAcaccountDepositId { get; set; }

    [Column("ACBankTransactionPostedStatus")]
    [StringLength(50)]
    public string AcbankTransactionPostedStatus { get; set; }

    [Column("FK_ACListAccountBankID")]
    public int? FkAclistAccountBankId { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("ACBankTransactionExchangeRateDiffFee", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionExchangeRateDiffFee { get; set; }

    [InverseProperty("FkAcbankTransaction")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkAcbankTransaction")]
    public virtual ICollection<ApclearingDetail> ApclearingDetails { get; set; } = new List<ApclearingDetail>();

    [InverseProperty("FkAcbankTransaction")]
    public virtual ICollection<ArclearingDetail> ArclearingDetails { get; set; } = new List<ArclearingDetail>();

    [ForeignKey("FkAclistAccountBankId")]
    [InverseProperty("AcbankTransactions")]
    public virtual AclistAccountBank FkAclistAccountBank { get; set; }

    [ForeignKey("FkAcloanReceiptId")]
    [InverseProperty("AcbankTransactions")]
    public virtual AcloanReceipt FkAcloanReceipt { get; set; }

    [ForeignKey("FkAcloanReceiptPaymentPlanId")]
    [InverseProperty("AcbankTransactions")]
    public virtual AcloanReceiptPaymentPlan FkAcloanReceiptPaymentPlan { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcbankTransactions")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("AcbankTransactions")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcbankTransactions")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscashFundId")]
    [InverseProperty("AcbankTransactionFkCscashFunds")]
    public virtual CscashFund FkCscashFund { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("AcbankTransactionFkCscompanyBanks")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcbankTransactions")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AcbankTransactionFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("AcbankTransactionFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [ForeignKey("FkHremployeeCompletedId")]
    [InverseProperty("AcbankTransactionFkHremployeeCompleteds")]
    public virtual Hremployee FkHremployeeCompleted { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcbankTransactions")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkToCscashFundId")]
    [InverseProperty("AcbankTransactionFkToCscashFunds")]
    public virtual CscashFund FkToCscashFund { get; set; }

    [ForeignKey("FkToCscompanyBankId")]
    [InverseProperty("AcbankTransactionFkToCscompanyBanks")]
    public virtual CscompanyBank FkToCscompanyBank { get; set; }

    [InverseProperty("FkAcbankTransaction")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkAcbankTransaction")]
    public virtual ICollection<HradvanceRequestPaymentTime> HradvanceRequestPaymentTimes { get; set; } = new List<HradvanceRequestPaymentTime>();
}
