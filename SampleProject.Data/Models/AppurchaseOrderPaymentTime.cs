using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPurchaseOrderPaymentTimes")]
public partial class AppurchaseOrderPaymentTime
{
    [Key]
    [Column("APPurchaseOrderPaymentTimeID")]
    public int AppurchaseOrderPaymentTimeId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Required]
    [Column("APPurchaseOrderPaymentTimeName")]
    [StringLength(100)]
    public string AppurchaseOrderPaymentTimeName { get; set; }

    [Column("APPurchaseOrderPaymentTimeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderPaymentTimeAmount { get; set; }

    [Column("APPurchaseOrderPaymentTimeDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderPaymentTimeDate { get; set; }

    [Required]
    [Column("APPaymentMethodCombo")]
    [StringLength(50)]
    public string AppaymentMethodCombo { get; set; }

    [Column("APPurchaseOrderPaymentTimeRemark")]
    [StringLength(512)]
    public string AppurchaseOrderPaymentTimeRemark { get; set; }

    [Column("APPurchaseOrderPaymentTimeStatus")]
    [StringLength(50)]
    public string AppurchaseOrderPaymentTimeStatus { get; set; }

    [Column("FK_GEPaymentTermID")]
    public int FkGepaymentTermId { get; set; }

    [Column("ARSaleOrderPaymentTimeDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentTimeDepositBalance { get; set; }

    [Column("ARSaleOrderPaymentTimeBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentTimeBalanceDue { get; set; }

    [Column("ARSaleOrderPaymentTimeDueDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderPaymentTimeDueDate { get; set; }

    [Column("APPurchaseOrderPaymentTimePaymentType")]
    [StringLength(50)]
    public string AppurchaseOrderPaymentTimePaymentType { get; set; }

    [Column("APPurchaseOrderPaymentTimeReceiptDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderPaymentTimeReceiptDate { get; set; }

    [Column("APPurchaseOrderPaymentTimeRealTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderPaymentTimeRealTotalAmount { get; set; }

    [Column("APPurchaseOrderPaymentTimePaymentTimepoint")]
    [StringLength(100)]
    public string AppurchaseOrderPaymentTimePaymentTimepoint { get; set; }

    [Column("APPurchaseOrderPaymentTimePaymentTermItemDay")]
    public int? AppurchaseOrderPaymentTimePaymentTermItemDay { get; set; }

    [Column("APPurchaseOrderPaymentTimePaymentTermItemPercentPayment", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderPaymentTimePaymentTermItemPercentPayment { get; set; }

    [Column("APPurchaseOrderPaymentTimePaymentTermItemPaymentType")]
    [StringLength(50)]
    public string AppurchaseOrderPaymentTimePaymentTermItemPaymentType { get; set; }

    [Column("APPurchaseOrderPaymentTimePaymentTermItemType")]
    [StringLength(50)]
    public string AppurchaseOrderPaymentTimePaymentTermItemType { get; set; }

    [Column("FK_GEPaymentTermItemID")]
    public int? FkGepaymentTermItemId { get; set; }

    [Column("APPurchaseOrderPaymentTimeCanceledAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderPaymentTimeCanceledAmount { get; set; }

    [InverseProperty("FkAppurchaseOrderPaymentTime")]
    public virtual ICollection<ApclearingDetail> ApclearingDetails { get; set; } = new List<ApclearingDetail>();

    [InverseProperty("FkAppurchaseOrderPaymentTime")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkAppurchaseOrderPaymentTime")]
    public virtual ICollection<AppaymentProposalItem> AppaymentProposalItems { get; set; } = new List<AppaymentProposalItem>();

    [InverseProperty("FkAppurchaseOrderPaymentTime")]
    public virtual ICollection<AppaymentProposalPayment> AppaymentProposalPayments { get; set; } = new List<AppaymentProposalPayment>();

    [InverseProperty("FkAppurchaseOrderPaymentTime")]
    public virtual ICollection<AppaymentVoucherInvoice> AppaymentVoucherInvoices { get; set; } = new List<AppaymentVoucherInvoice>();

    [InverseProperty("FkAppurchaseOrderPaymentTime")]
    public virtual ICollection<AppopaymentTimeInvoiceInDetail> AppopaymentTimeInvoiceInDetails { get; set; } = new List<AppopaymentTimeInvoiceInDetail>();

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppurchaseOrderPaymentTimes")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("AppurchaseOrderPaymentTimes")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }

    [ForeignKey("FkGepaymentTermItemId")]
    [InverseProperty("AppurchaseOrderPaymentTimes")]
    public virtual GepaymentTermItem FkGepaymentTermItem { get; set; }
}
