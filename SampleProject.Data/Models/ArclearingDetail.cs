using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARClearingDetails")]
public partial class ArclearingDetail
{
    [Key]
    [Column("ARClearingDetailID")]
    public int ArclearingDetailId { get; set; }

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

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderPaymentTimeID")]
    public int? FkArsaleOrderPaymentTimeId { get; set; }

    [Column("ARClearingDetailNo")]
    [StringLength(50)]
    public string ArclearingDetailNo { get; set; }

    [Column("ARClearingDetailName")]
    [StringLength(256)]
    public string ArclearingDetailName { get; set; }

    [Column("ARClearingDetailDesc")]
    [StringLength(512)]
    public string ArclearingDetailDesc { get; set; }

    [Column("ARClearingDetailType")]
    [StringLength(50)]
    public string ArclearingDetailType { get; set; }

    [Column("ARClearingDetailAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearingDetailAmount { get; set; }

    [Column("FK_ARCustomerPaymentID")]
    public int? FkArcustomerPaymentId { get; set; }

    [Column("ARClearingDetailCustomerPaymentNo")]
    [StringLength(50)]
    public string ArclearingDetailCustomerPaymentNo { get; set; }

    [Column("ARClearingDetailTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearingDetailTotalAmount { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("FK_ARPaymentProposalID")]
    public int? FkArpaymentProposalId { get; set; }

    [Column("FK_ARReceiptVoucherID")]
    public int? FkArreceiptVoucherId { get; set; }

    [Column("FK_ACBankTransactionID")]
    public int? FkAcbankTransactionId { get; set; }

    [ForeignKey("FkAcbankTransactionId")]
    [InverseProperty("ArclearingDetails")]
    public virtual AcbankTransaction FkAcbankTransaction { get; set; }

    [ForeignKey("FkArcustomerPaymentId")]
    [InverseProperty("ArclearingDetails")]
    public virtual ArcustomerPayment FkArcustomerPayment { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArclearingDetails")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkArpaymentProposalId")]
    [InverseProperty("ArclearingDetails")]
    public virtual ArpaymentProposal FkArpaymentProposal { get; set; }

    [ForeignKey("FkArreceiptVoucherId")]
    [InverseProperty("ArclearingDetails")]
    public virtual ArreceiptVoucher FkArreceiptVoucher { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArclearingDetails")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderPaymentTimeId")]
    [InverseProperty("ArclearingDetails")]
    public virtual ArsaleOrderPaymentTime FkArsaleOrderPaymentTime { get; set; }
}
