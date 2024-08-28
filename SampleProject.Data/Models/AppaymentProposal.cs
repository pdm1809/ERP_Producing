using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPaymentProposals")]
public partial class AppaymentProposal
{
    [Key]
    [Column("APPaymentProposalID")]
    public int AppaymentProposalId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Required]
    [Column("APPaymentProposalNo")]
    [StringLength(50)]
    public string AppaymentProposalNo { get; set; }

    [Column("APPaymentProposalName")]
    [StringLength(100)]
    public string AppaymentProposalName { get; set; }

    [Column("APPaymentProposalDesc")]
    [StringLength(512)]
    public string AppaymentProposalDesc { get; set; }

    [Column("APPaymentProposalDate", TypeName = "datetime")]
    public DateTime? AppaymentProposalDate { get; set; }

    [Column("APPaymentProposalPayDate", TypeName = "datetime")]
    public DateTime? AppaymentProposalPayDate { get; set; }

    [Column("APPaymentProposalTypeCombo")]
    [StringLength(50)]
    public string AppaymentProposalTypeCombo { get; set; }

    [Column("APPaymentProposalStatusCombo")]
    [StringLength(50)]
    public string AppaymentProposalStatusCombo { get; set; }

    [Column("APPriority")]
    [StringLength(50)]
    public string Appriority { get; set; }

    [Column("APPaymentProposalPaymentMethodCombo")]
    [StringLength(50)]
    public string AppaymentProposalPaymentMethodCombo { get; set; }

    [Column("APPaymentProposalInvoiceNo")]
    [StringLength(50)]
    public string AppaymentProposalInvoiceNo { get; set; }

    [Column("APPaymentProposalReceiptNo")]
    [StringLength(50)]
    public string AppaymentProposalReceiptNo { get; set; }

    [Column("APPaymentProposalBookNo")]
    [StringLength(50)]
    public string AppaymentProposalBookNo { get; set; }

    [Column("APPaymentProposalRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalRemainAmount { get; set; }

    [Column("APPaymentProposalPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalPaidAmount { get; set; }

    [Column("APPaymentProposalTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalTotalAmount { get; set; }

    [Column("APPaymentProposalRemark")]
    [StringLength(512)]
    public string AppaymentProposalRemark { get; set; }

    [Column("APPaymentProposalDocAttachCombo")]
    [StringLength(50)]
    public string AppaymentProposalDocAttachCombo { get; set; }

    [Column("FK_HREmployeeAccountantID")]
    public int? FkHremployeeAccountantId { get; set; }

    [Column("FK_HREmployeeManagerID")]
    public int? FkHremployeeManagerId { get; set; }

    [Column("FK_HREmployeeHeadDepartmentID")]
    public int? FkHremployeeHeadDepartmentId { get; set; }

    [Column("APPaymentProposalCheckDate", TypeName = "datetime")]
    public DateTime? AppaymentProposalCheckDate { get; set; }

    [Column("APPaymentProposalApproveDate", TypeName = "datetime")]
    public DateTime? AppaymentProposalApproveDate { get; set; }

    [Column("APPaymentProposalConfirmDate", TypeName = "datetime")]
    public DateTime? AppaymentProposalConfirmDate { get; set; }

    [Column("APPaymentProposalApprovePaymentDate", TypeName = "datetime")]
    public DateTime? AppaymentProposalApprovePaymentDate { get; set; }

    [Column("FK_HREmployeeHeadAccountantID")]
    public int? FkHremployeeHeadAccountantId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("APPaymentProposalApproveStatus")]
    [StringLength(50)]
    public string AppaymentProposalApproveStatus { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("APAssObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApassObjectType { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    public string ApobjectType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_ACListAccountBankID")]
    public int? FkAclistAccountBankId { get; set; }

    [Column("APPaymentProposalReceiverBankName")]
    [StringLength(128)]
    public string AppaymentProposalReceiverBankName { get; set; }

    [Column("APPaymentProposalReceiverBankCode")]
    [StringLength(50)]
    public string AppaymentProposalReceiverBankCode { get; set; }

    [Column("APPaymentProposalReceiverAccount")]
    [StringLength(50)]
    public string AppaymentProposalReceiverAccount { get; set; }

    [Column("APPaymentProposalObjectReceiptName")]
    [StringLength(500)]
    public string AppaymentProposalObjectReceiptName { get; set; }

    [Column("APPaymentProposalReceiptAddress")]
    [StringLength(500)]
    public string AppaymentProposalReceiptAddress { get; set; }

    [Column("APPaymentProposalProject")]
    [StringLength(100)]
    public string AppaymentProposalProject { get; set; }

    [Column("APPaymentProposalDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalDiscountPercent { get; set; }

    [Column("APPaymentProposalDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalDiscountFix { get; set; }

    [Column("APPaymentProposalTotalPaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalTotalPaymentAmount { get; set; }

    [InverseProperty("FkAppaymentProposal")]
    public virtual ICollection<ApclearingDetail> ApclearingDetails { get; set; } = new List<ApclearingDetail>();

    [InverseProperty("FkAppaymentProposal")]
    public virtual ICollection<AppaymentProposalItem> AppaymentProposalItems { get; set; } = new List<AppaymentProposalItem>();

    [InverseProperty("FkAppaymentProposal")]
    public virtual ICollection<AppaymentProposalPayment> AppaymentProposalPayments { get; set; } = new List<AppaymentProposalPayment>();

    [InverseProperty("FkAppaymentProposal")]
    public virtual ICollection<AppaymentVoucherInvoice> AppaymentVoucherInvoices { get; set; } = new List<AppaymentVoucherInvoice>();

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AppaymentProposals")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("AppaymentProposals")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppaymentProposals")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("AppaymentProposals")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AppaymentProposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AppaymentProposals")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AppaymentProposals")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AppaymentProposals")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AppaymentProposalFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeAccountantId")]
    [InverseProperty("AppaymentProposalFkHremployeeAccountants")]
    public virtual Hremployee FkHremployeeAccountant { get; set; }

    [ForeignKey("FkHremployeeHeadAccountantId")]
    [InverseProperty("AppaymentProposalFkHremployeeHeadAccountants")]
    public virtual Hremployee FkHremployeeHeadAccountant { get; set; }

    [ForeignKey("FkHremployeeHeadDepartmentId")]
    [InverseProperty("AppaymentProposalFkHremployeeHeadDepartments")]
    public virtual Hremployee FkHremployeeHeadDepartment { get; set; }

    [ForeignKey("FkHremployeeManagerId")]
    [InverseProperty("AppaymentProposalFkHremployeeManagers")]
    public virtual Hremployee FkHremployeeManager { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("AppaymentProposals")]
    public virtual Icreceipt FkIcreceipt { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AppaymentProposals")]
    public virtual Pmproject FkPmproject { get; set; }
}
