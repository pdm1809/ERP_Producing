using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACLoanReceipts")]
public partial class AcloanReceipt
{
    [Key]
    [Column("ACLoanReceiptID")]
    public int AcloanReceiptId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ACLoanAgreementID")]
    public int FkAcloanAgreementId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int FkCscompanyBankId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Required]
    [Column("ACLoanReceiptNo")]
    [StringLength(50)]
    public string AcloanReceiptNo { get; set; }

    [Column("ACLoanReceiptContent")]
    [StringLength(512)]
    public string AcloanReceiptContent { get; set; }

    [Column("ACLoanReceiptDate", TypeName = "datetime")]
    public DateTime? AcloanReceiptDate { get; set; }

    [Column("ACLoanReceiptDeadline", TypeName = "datetime")]
    public DateTime? AcloanReceiptDeadline { get; set; }

    [Column("ACLoanReceiptInterestRate", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptInterestRate { get; set; }

    [Column("ACLoanReceiptOverdueInterestRate", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptOverdueInterestRate { get; set; }

    [Column("ACLoanReceiptAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptAmount { get; set; }

    [Column("ACLoanReceiptPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaidAmount { get; set; }

    [Column("ACLoanReceiptRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptRemainAmount { get; set; }

    [Column("ACLoanReceiptExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptExchangeRate { get; set; }

    [Column("ACLoanReceiptExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptExchangeAmount { get; set; }

    [Column("FK_ACLoanReceiptTypeID")]
    public int? FkAcloanReceiptTypeId { get; set; }

    [Column("ACLoanReceiptProfitMethod")]
    [StringLength(64)]
    public string AcloanReceiptProfitMethod { get; set; }

    [Column("ACLoanReceiptLimit")]
    public int? AcloanReceiptLimit { get; set; }

    [Column("ACLoanReceiptPaymentForMonth", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaymentForMonth { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ACLoanReceiptOpeningPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptOpeningPaidAmount { get; set; }

    [Column("ACLoanReceiptPaidExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaidExchangeAmount { get; set; }

    [Column("ACLoanReceiptNoOfBank")]
    [StringLength(100)]
    public string AcloanReceiptNoOfBank { get; set; }

    [InverseProperty("FkAcloanReceipt")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkAcloanReceipt")]
    public virtual ICollection<AcbankTransaction> AcbankTransactions { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkAcloanReceipt")]
    public virtual ICollection<AcloanReceiptInterestRateChange> AcloanReceiptInterestRateChanges { get; set; } = new List<AcloanReceiptInterestRateChange>();

    [InverseProperty("FkAcloanReceipt")]
    public virtual ICollection<AcloanReceiptItem> AcloanReceiptItems { get; set; } = new List<AcloanReceiptItem>();

    [InverseProperty("FkAcloanReceipt")]
    public virtual ICollection<AcloanReceiptPayDoc> AcloanReceiptPayDocs { get; set; } = new List<AcloanReceiptPayDoc>();

    [InverseProperty("FkAcloanReceipt")]
    public virtual ICollection<AcloanReceiptPaymentPlan> AcloanReceiptPaymentPlans { get; set; } = new List<AcloanReceiptPaymentPlan>();

    [InverseProperty("FkAcloanReceipt")]
    public virtual ICollection<AppaymentVoucher> AppaymentVouchers { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkAcloanReceipt")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPayments { get; set; } = new List<ApsupplierPayment>();

    [ForeignKey("FkAcloanAgreementId")]
    [InverseProperty("AcloanReceipts")]
    public virtual AcloanAgreement FkAcloanAgreement { get; set; }

    [ForeignKey("FkAcloanReceiptTypeId")]
    [InverseProperty("AcloanReceipts")]
    public virtual AcloanReceiptType FkAcloanReceiptType { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcloanReceipts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("AcloanReceipts")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcloanReceipts")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcloanReceipts")]
    public virtual Pmproject FkPmproject { get; set; }
}
