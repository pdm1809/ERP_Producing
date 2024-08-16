using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPaymentVoucherInvoices")]
public partial class AppaymentVoucherInvoice
{
    [Key]
    [Column("APPaymentVoucherInvoiceID")]
    public int AppaymentVoucherInvoiceId { get; set; }

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

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_APPaymentProposalID")]
    public int? FkAppaymentProposalId { get; set; }

    [Column("FK_APPaymentProposalItemID")]
    public int? FkAppaymentProposalItemId { get; set; }

    [Column("FK_APPurchaseOrderPaymentTimeID")]
    public int? FkAppurchaseOrderPaymentTimeId { get; set; }

    [Column("FK_APPaymentVoucherID")]
    public int? FkAppaymentVoucherId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("APPaymentVoucherInvoiceDesc")]
    [StringLength(512)]
    public string AppaymentVoucherInvoiceDesc { get; set; }

    [Column("APPaymentVoucherInvoiceDate", TypeName = "datetime")]
    public DateTime? AppaymentVoucherInvoiceDate { get; set; }

    [Column("APPaymentVoucherInvoiceRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherInvoiceRemainAmount { get; set; }

    [Column("APPaymentVoucherInvoicePaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherInvoicePaidAmount { get; set; }

    [Column("APPaymentVoucherInvoiceTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherInvoiceTotalAmount { get; set; }

    [Column("APPaymentVoucherInvoiceBookNo")]
    [StringLength(50)]
    public string AppaymentVoucherInvoiceBookNo { get; set; }

    [Column("APPaymentVoucherInvoicePercent", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherInvoicePercent { get; set; }

    [Column("APPaymentVoucherInvoiceType")]
    [StringLength(50)]
    public string AppaymentVoucherInvoiceType { get; set; }

    [Column("APPaymentVoucherInvoiceApproveStatus")]
    [StringLength(50)]
    public string AppaymentVoucherInvoiceApproveStatus { get; set; }

    [Column("APPaymentVoucherInvoiceAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherInvoiceAmount { get; set; }

    [Column("APPaymentVoucherInvoicePaymentTimeName")]
    [StringLength(50)]
    public string AppaymentVoucherInvoicePaymentTimeName { get; set; }

    [Column("APPaymentVoucherInvoiceDepositAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherInvoiceDepositAmount { get; set; }

    [Column("APPaymentVoucherInvoiceHTT", TypeName = "datetime")]
    public DateTime? AppaymentVoucherInvoiceHtt { get; set; }

    [Column("APPaymentVoucherInvoicePurchaseOrderNo")]
    [StringLength(50)]
    public string AppaymentVoucherInvoicePurchaseOrderNo { get; set; }

    [Column("APPaymentVoucherInvoiceInvoiceInNo")]
    [StringLength(50)]
    public string AppaymentVoucherInvoiceInvoiceInNo { get; set; }

    [Column("APPurchaseOrderPaymentTimeType")]
    [StringLength(50)]
    public string AppurchaseOrderPaymentTimeType { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("AppaymentVoucherInvoices")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("AppaymentVoucherInvoices")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkAppaymentProposalId")]
    [InverseProperty("AppaymentVoucherInvoices")]
    public virtual AppaymentProposal FkAppaymentProposal { get; set; }

    [ForeignKey("FkAppaymentVoucherId")]
    [InverseProperty("AppaymentVoucherInvoices")]
    public virtual AppaymentVoucher FkAppaymentVoucher { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppaymentVoucherInvoices")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkAppurchaseOrderPaymentTimeId")]
    [InverseProperty("AppaymentVoucherInvoices")]
    public virtual AppurchaseOrderPaymentTime FkAppurchaseOrderPaymentTime { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("AppaymentVoucherInvoices")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("AppaymentVoucherInvoices")]
    public virtual Icreceipt FkIcreceipt { get; set; }
}
