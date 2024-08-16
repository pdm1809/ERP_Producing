using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPaymentProposalPayments")]
public partial class AppaymentProposalPayment
{
    [Key]
    [Column("APPaymentProposalPaymentID")]
    public int AppaymentProposalPaymentId { get; set; }

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

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("APPaymentProposalPaymentDesc")]
    [StringLength(512)]
    public string AppaymentProposalPaymentDesc { get; set; }

    [Column("APPaymentProposalPaymentDate", TypeName = "datetime")]
    public DateTime? AppaymentProposalPaymentDate { get; set; }

    [Column("APPaymentProposalPaymentRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalPaymentRemainAmount { get; set; }

    [Column("APPaymentProposalPaymentPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalPaymentPaidAmount { get; set; }

    [Column("APPaymentProposalPaymentTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalPaymentTotalAmount { get; set; }

    [Column("APPaymentProposalPaymentBookNo")]
    [StringLength(50)]
    public string AppaymentProposalPaymentBookNo { get; set; }

    [Column("FK_APPaymentProposalID")]
    public int? FkAppaymentProposalId { get; set; }

    [Column("FK_APPaymentProposalItemID")]
    public int? FkAppaymentProposalItemId { get; set; }

    [Column("APPaymentProposalPaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalPaymentPercent { get; set; }

    [Column("FK_APPurchaseOrderPaymentTimeID")]
    public int? FkAppurchaseOrderPaymentTimeId { get; set; }

    [Column("APPaymentProposalPaymentType")]
    [StringLength(50)]
    public string AppaymentProposalPaymentType { get; set; }

    [Column("APPaymentProposalPaymentApproveStatus")]
    [StringLength(50)]
    public string AppaymentProposalPaymentApproveStatus { get; set; }

    [Column("FK_APSupplierPaymentID")]
    public int? FkApsupplierPaymentId { get; set; }

    [Column("APPaymentProposalPaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalPaymentAmount { get; set; }

    [Column("APPaymentProposalPaymentPaymentTimeName")]
    [StringLength(50)]
    public string AppaymentProposalPaymentPaymentTimeName { get; set; }

    [Column("APPaymentProposalPaymentDepositAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalPaymentDepositAmount { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("APPaymentProposalPaymentPurchaseOrderNo")]
    [StringLength(50)]
    public string AppaymentProposalPaymentPurchaseOrderNo { get; set; }

    [Column("APPaymentProposalPaymentInvoiceInNo")]
    [StringLength(50)]
    public string AppaymentProposalPaymentInvoiceInNo { get; set; }

    [Column("APPaymentProposalPaymentHTT", TypeName = "datetime")]
    public DateTime? AppaymentProposalPaymentHtt { get; set; }

    [Column("APPurchaseOrderPaymentTimeType")]
    [StringLength(50)]
    public string AppurchaseOrderPaymentTimeType { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("APPaymentProposalPaymentFee", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalPaymentFee { get; set; }

    [Column("APPaymentProposalPaymentDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalPaymentDiscountFix { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("AppaymentProposalPayments")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AppaymentProposalPaymentFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AppaymentProposalPaymentFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAppaymentProposalId")]
    [InverseProperty("AppaymentProposalPayments")]
    public virtual AppaymentProposal FkAppaymentProposal { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppaymentProposalPayments")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkAppurchaseOrderPaymentTimeId")]
    [InverseProperty("AppaymentProposalPayments")]
    public virtual AppurchaseOrderPaymentTime FkAppurchaseOrderPaymentTime { get; set; }

    [ForeignKey("FkApsupplierPaymentId")]
    [InverseProperty("AppaymentProposalPayments")]
    public virtual ApsupplierPayment FkApsupplierPayment { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("AppaymentProposalPayments")]
    public virtual Icreceipt FkIcreceipt { get; set; }
}
