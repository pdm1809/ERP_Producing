using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerPaymentTimePayments")]
public partial class ArcustomerPaymentTimePayment
{
    [Key]
    [Column("ARCustomerPaymentTimePaymentID")]
    public int ArcustomerPaymentTimePaymentId { get; set; }

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

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("ARCustomerPaymentTimePaymentDesc")]
    [StringLength(512)]
    public string ArcustomerPaymentTimePaymentDesc { get; set; }

    [Column("ARCustomerPaymentTimePaymentDate", TypeName = "datetime")]
    public DateTime? ArcustomerPaymentTimePaymentDate { get; set; }

    [Column("ARCustomerPaymentTimePaymentRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentTimePaymentRemainAmount { get; set; }

    [Column("ARCustomerPaymentTimePaymentPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentTimePaymentPaidAmount { get; set; }

    [Column("ARCustomerPaymentTimePaymentTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentTimePaymentTotalAmount { get; set; }

    [Column("ARCustomerPaymentTimePaymentBookNo")]
    [StringLength(512)]
    public string ArcustomerPaymentTimePaymentBookNo { get; set; }

    [Column("ARCustomerPaymentTimePaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentTimePaymentPercent { get; set; }

    [Column("ARCustomerPaymentTimePaymentType")]
    [StringLength(50)]
    public string ArcustomerPaymentTimePaymentType { get; set; }

    [Column("FK_ARCustomerPaymentID")]
    public int? FkArcustomerPaymentId { get; set; }

    [Column("ARCustomerPaymentTimePaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentTimePaymentAmount { get; set; }

    [Column("ARCustomerPaymentTimePaymentPaymentTimeName")]
    [StringLength(50)]
    public string ArcustomerPaymentTimePaymentPaymentTimeName { get; set; }

    [Column("ARCustomerPaymentTimePaymentDepositPerInvoice", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentTimePaymentDepositPerInvoice { get; set; }

    [Column("FK_ARSaleOrderPaymentTimeID")]
    public int? FkArsaleOrderPaymentTimeId { get; set; }

    [Column("ARCustomerPaymentTimePaymentSaleOrderNo")]
    [StringLength(50)]
    public string ArcustomerPaymentTimePaymentSaleOrderNo { get; set; }

    [Column("ARCustomerPaymentTimePaymentInvoiceNo")]
    [StringLength(50)]
    public string ArcustomerPaymentTimePaymentInvoiceNo { get; set; }

    [Column("ARCustomerPaymentTimePaymentHTT", TypeName = "datetime")]
    public DateTime? ArcustomerPaymentTimePaymentHtt { get; set; }

    [Column("FK_ARPaymentProposalID")]
    public int? FkArpaymentProposalId { get; set; }

    [Column("FK_ARPaymentProposalItemID")]
    public int? FkArpaymentProposalItemId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("ARCustomerPaymentTimePaymentPONo")]
    [StringLength(50)]
    public string ArcustomerPaymentTimePaymentPono { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("ARCustomerPaymentTimePaymentBankFeeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentTimePaymentBankFeeAmount { get; set; }

    [ForeignKey("FkArcustomerPaymentId")]
    [InverseProperty("ArcustomerPaymentTimePayments")]
    public virtual ArcustomerPayment FkArcustomerPayment { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArcustomerPaymentTimePayments")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkArpaymentProposalId")]
    [InverseProperty("ArcustomerPaymentTimePayments")]
    public virtual ArpaymentProposal FkArpaymentProposal { get; set; }

    [ForeignKey("FkArpaymentProposalItemId")]
    [InverseProperty("ArcustomerPaymentTimePayments")]
    public virtual ArpaymentProposalItem FkArpaymentProposalItem { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArcustomerPaymentTimePayments")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArcustomerPaymentTimePayments")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }
}
