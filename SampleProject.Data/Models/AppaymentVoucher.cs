using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPaymentVouchers")]
[Microsoft.EntityFrameworkCore.Index("AppaymentVoucherNo", "AppaymentVoucherDate", "FkBrbranchId", "FkAcobjectId", "ApobjectType", "AppaymentVoucherType", Name = "Idx_APPaymentVouchers")]
public partial class AppaymentVoucher
{
    [Key]
    [Column("APPaymentVoucherID")]
    public int AppaymentVoucherId { get; set; }

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
    public int FkAcobjectId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Required]
    [Column("APPaymentVoucherNo")]
    [StringLength(50)]
    public string AppaymentVoucherNo { get; set; }

    [Column("APPaymentVoucherName")]
    [StringLength(100)]
    public string AppaymentVoucherName { get; set; }

    [Column("APPaymentVoucherDesc")]
    [StringLength(512)]
    public string AppaymentVoucherDesc { get; set; }

    [Column("APPaymentVoucherType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentVoucherType { get; set; }

    [Column("APPaymentVoucherDate", TypeName = "datetime")]
    public DateTime? AppaymentVoucherDate { get; set; }

    [Column("APPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentMethodCombo { get; set; }

    [Column("APPaymentVoucherTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherTotalAmount { get; set; }

    [Column("APPaymentVoucherExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherExchangeRate { get; set; }

    [Column("APPaymentVoucherExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherExchangeAmount { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApobjectType { get; set; }

    [Column("APPaymentVoucherReceiverName")]
    [StringLength(100)]
    public string AppaymentVoucherReceiverName { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("APPaymentVoucherTransferredDate", TypeName = "datetime")]
    public DateTime? AppaymentVoucherTransferredDate { get; set; }

    [Column("APPaymentVoucherBankAccount")]
    [StringLength(50)]
    public string AppaymentVoucherBankAccount { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("APPaymentVoucherAddress")]
    [StringLength(512)]
    public string AppaymentVoucherAddress { get; set; }

    [Column("APPaymentVoucherFormNo")]
    [StringLength(50)]
    public string AppaymentVoucherFormNo { get; set; }

    [Column("APPaymentVoucherSymbol")]
    [StringLength(50)]
    public string AppaymentVoucherSymbol { get; set; }

    [Column("APPaymentVoucherVoucherNo")]
    [StringLength(50)]
    public string AppaymentVoucherVoucherNo { get; set; }

    [Column("APPaymentVoucherObjectTaxNumber")]
    [StringLength(50)]
    public string AppaymentVoucherObjectTaxNumber { get; set; }

    [Column("APInputVATDocumentType")]
    [StringLength(1000)]
    public string ApinputVatdocumentType { get; set; }

    [Column("APInputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string ApinputVatinvoiceNoCombo { get; set; }

    [Column("APPaymentVoucherInvoiceDate", TypeName = "datetime")]
    public DateTime? AppaymentVoucherInvoiceDate { get; set; }

    [Column("FK_ACLoanReceiptID")]
    public int? FkAcloanReceiptId { get; set; }

    [Column("FK_CSCashFundID")]
    public int? FkCscashFundId { get; set; }

    [Column("APPaymentVoucherPurpose")]
    [StringLength(50)]
    public string AppaymentVoucherPurpose { get; set; }

    [Column("APPaymentVoucherStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentVoucherStatus { get; set; }

    [Column("FK_ACLoanReceiptPaymentPlanID")]
    public int? FkAcloanReceiptPaymentPlanId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("FK_HREmployeeApprovedID")]
    public int? FkHremployeeApprovedId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("APPaymentVoucherPostedStatus")]
    [StringLength(64)]
    public string AppaymentVoucherPostedStatus { get; set; }

    [Column("APPaymentVoucherReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentVoucherReference { get; set; }

    [Column("APPaymentVoucherExchangeRateDiffFee", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherExchangeRateDiffFee { get; set; }

    [InverseProperty("FkAppaymentVoucher")]
    public virtual ICollection<ApclearingDetail> ApclearingDetails { get; set; } = new List<ApclearingDetail>();

    [InverseProperty("FkAppaymentVoucher")]
    public virtual ICollection<AppaymentVoucherInvoice> AppaymentVoucherInvoices { get; set; } = new List<AppaymentVoucherInvoice>();

    [InverseProperty("FkAppaymentVoucher")]
    public virtual ICollection<AppaymentVoucherItemDetail> AppaymentVoucherItemDetails { get; set; } = new List<AppaymentVoucherItemDetail>();

    [InverseProperty("FkAppaymentVoucher")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [ForeignKey("FkAcloanReceiptId")]
    [InverseProperty("AppaymentVouchers")]
    public virtual AcloanReceipt FkAcloanReceipt { get; set; }

    [ForeignKey("FkAcloanReceiptPaymentPlanId")]
    [InverseProperty("AppaymentVouchers")]
    public virtual AcloanReceiptPaymentPlan FkAcloanReceiptPaymentPlan { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AppaymentVouchers")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AppaymentVouchers")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscashFundId")]
    [InverseProperty("AppaymentVouchers")]
    public virtual CscashFund FkCscashFund { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("AppaymentVouchers")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AppaymentVouchers")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AppaymentVoucherFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("AppaymentVoucherFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [ForeignKey("FkHremployeeCompletedId")]
    [InverseProperty("AppaymentVoucherFkHremployeeCompleteds")]
    public virtual Hremployee FkHremployeeCompleted { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AppaymentVouchers")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkAppaymentVoucher")]
    public virtual ICollection<HradvanceRequestPaymentTime> HradvanceRequestPaymentTimes { get; set; } = new List<HradvanceRequestPaymentTime>();
}
