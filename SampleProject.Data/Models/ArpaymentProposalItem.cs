using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARPaymentProposalItems")]
public partial class ArpaymentProposalItem
{
    [Key]
    [Column("ARPaymentProposalItemID")]
    public int ArpaymentProposalItemId { get; set; }

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

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("ARPaymentProposalItemDesc")]
    [StringLength(512)]
    public string ArpaymentProposalItemDesc { get; set; }

    [Column("ARPaymentProposalItemDate", TypeName = "datetime")]
    public DateTime? ArpaymentProposalItemDate { get; set; }

    [Column("ARPaymentProposalItemRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpaymentProposalItemRemainAmount { get; set; }

    [Column("ARPaymentProposalItemPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpaymentProposalItemPaidAmount { get; set; }

    [Column("ARPaymentProposalItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpaymentProposalItemTotalAmount { get; set; }

    [Column("ARPaymentProposalItemBookNo")]
    [StringLength(50)]
    public string ArpaymentProposalItemBookNo { get; set; }

    [Column("FK_ARPaymentProposalID")]
    public int? FkArpaymentProposalId { get; set; }

    [Column("FK_ARSaleOrderPaymentTimeID")]
    public int? FkArsaleOrderPaymentTimeId { get; set; }

    [Column("ARPaymentProposalItemType")]
    [StringLength(50)]
    public string ArpaymentProposalItemType { get; set; }

    [Column("ARPaymentProposalItemApproveStatus")]
    [StringLength(50)]
    public string ArpaymentProposalItemApproveStatus { get; set; }

    [Column("ARPaymentProposalItemPaymentTimeName")]
    [StringLength(50)]
    public string ArpaymentProposalItemPaymentTimeName { get; set; }

    [Column("ARPaymentProposalItemProposalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpaymentProposalItemProposalAmount { get; set; }

    [Column("ARPaymentProposalItemDepositAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpaymentProposalItemDepositAmount { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ARPaymentProposalItemSaleOrderNo")]
    [StringLength(50)]
    public string ArpaymentProposalItemSaleOrderNo { get; set; }

    [Column("ARPaymentProposalItemInvoiceNo")]
    [StringLength(50)]
    public string ArpaymentProposalItemInvoiceNo { get; set; }

    [Column("ARSaleOrderPaymentTimeDueDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderPaymentTimeDueDate { get; set; }

    [Column("ARPaymentProposalItemGuaranteeName")]
    [StringLength(256)]
    public string ArpaymentProposalItemGuaranteeName { get; set; }

    [Column("ARPaymentProposalItemGuaranteeFromDate", TypeName = "datetime")]
    public DateTime? ArpaymentProposalItemGuaranteeFromDate { get; set; }

    [Column("ARPaymentProposalItemGuaranteeToDate", TypeName = "datetime")]
    public DateTime? ArpaymentProposalItemGuaranteeToDate { get; set; }

    [Column("ARPaymentProposalItemGuaranteeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpaymentProposalItemGuaranteeAmount { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [InverseProperty("FkArpaymentProposalItem")]
    public virtual ICollection<ArcustomerPaymentTimePayment> ArcustomerPaymentTimePayments { get; set; } = new List<ArcustomerPaymentTimePayment>();

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArpaymentProposalItems")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkArpaymentProposalId")]
    [InverseProperty("ArpaymentProposalItems")]
    public virtual ArpaymentProposal FkArpaymentProposal { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArpaymentProposalItems")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArpaymentProposalItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderPaymentTimeId")]
    [InverseProperty("ArpaymentProposalItems")]
    public virtual ArsaleOrderPaymentTime FkArsaleOrderPaymentTime { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArpaymentProposalItems")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("ArpaymentProposalItems")]
    public virtual Icreceipt FkIcreceipt { get; set; }
}
