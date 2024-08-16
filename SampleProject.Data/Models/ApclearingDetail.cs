using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APClearingDetails")]
public partial class ApclearingDetail
{
    [Key]
    [Column("APClearingDetailID")]
    public int ApclearingDetailId { get; set; }

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

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_APPurchaseOrderPaymentTimeID")]
    public int? FkAppurchaseOrderPaymentTimeId { get; set; }

    [Column("APClearingDetailNo")]
    [StringLength(50)]
    public string ApclearingDetailNo { get; set; }

    [Column("APClearingDetailName")]
    [StringLength(256)]
    public string ApclearingDetailName { get; set; }

    [Column("APClearingDetailDesc")]
    [StringLength(512)]
    public string ApclearingDetailDesc { get; set; }

    [Column("APClearingDetailType")]
    [StringLength(50)]
    public string ApclearingDetailType { get; set; }

    [Column("APClearingDetailAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearingDetailAmount { get; set; }

    [Column("FK_APSupplierPaymentID")]
    public int? FkApsupplierPaymentId { get; set; }

    [Column("APClearingDetailSupplierPaymentNo")]
    [StringLength(50)]
    public string ApclearingDetailSupplierPaymentNo { get; set; }

    [Column("APClearingDetailTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearingDetailTotalAmount { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("FK_APPaymentProposalID")]
    public int? FkAppaymentProposalId { get; set; }

    [Column("FK_APPaymentVoucherID")]
    public int? FkAppaymentVoucherId { get; set; }

    [Column("FK_ACBankTransactionID")]
    public int? FkAcbankTransactionId { get; set; }

    [Column("APClearingDetailDate", TypeName = "datetime")]
    public DateTime? ApclearingDetailDate { get; set; }

    [ForeignKey("FkAcbankTransactionId")]
    [InverseProperty("ApclearingDetails")]
    public virtual AcbankTransaction FkAcbankTransaction { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApclearingDetails")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkAppaymentProposalId")]
    [InverseProperty("ApclearingDetails")]
    public virtual AppaymentProposal FkAppaymentProposal { get; set; }

    [ForeignKey("FkAppaymentVoucherId")]
    [InverseProperty("ApclearingDetails")]
    public virtual AppaymentVoucher FkAppaymentVoucher { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("ApclearingDetails")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkAppurchaseOrderPaymentTimeId")]
    [InverseProperty("ApclearingDetails")]
    public virtual AppurchaseOrderPaymentTime FkAppurchaseOrderPaymentTime { get; set; }

    [ForeignKey("FkApsupplierPaymentId")]
    [InverseProperty("ApclearingDetails")]
    public virtual ApsupplierPayment FkApsupplierPayment { get; set; }
}
