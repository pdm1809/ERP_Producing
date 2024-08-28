using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPaymentProposalItems")]
public partial class AppaymentProposalItem
{
    [Key]
    [Column("APPaymentProposalItemID")]
    public int AppaymentProposalItemId { get; set; }

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

    [Column("APPaymentProposalItemDesc")]
    [StringLength(512)]
    public string AppaymentProposalItemDesc { get; set; }

    [Column("APPaymentProposalItemDate", TypeName = "datetime")]
    public DateTime? AppaymentProposalItemDate { get; set; }

    [Column("APPaymentProposalItemRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalItemRemainAmount { get; set; }

    [Column("APPaymentProposalItemPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalItemPaidAmount { get; set; }

    [Column("APPaymentProposalItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalItemTotalAmount { get; set; }

    [Column("APPaymentProposalItemBookNo")]
    [StringLength(50)]
    public string AppaymentProposalItemBookNo { get; set; }

    [Column("FK_APPaymentProposalID")]
    public int? FkAppaymentProposalId { get; set; }

    [Column("FK_APPurchaseOrderPaymentTimeID")]
    public int? FkAppurchaseOrderPaymentTimeId { get; set; }

    [Column("APPaymentProposalItemType")]
    [StringLength(50)]
    public string AppaymentProposalItemType { get; set; }

    [Column("APPaymentProposalItemApproveStatus")]
    [StringLength(50)]
    public string AppaymentProposalItemApproveStatus { get; set; }

    [Column("APPaymentProposalItemPaymentTimeName")]
    [StringLength(50)]
    public string AppaymentProposalItemPaymentTimeName { get; set; }

    [Column("APPaymentProposalItemProposalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalItemProposalAmount { get; set; }

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("APPaymentProposalItemDepositAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalItemDepositAmount { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("APPaymentProposalItemPurchaseOrderNo")]
    [StringLength(50)]
    public string AppaymentProposalItemPurchaseOrderNo { get; set; }

    [Column("APPaymentProposalItemInvoiceInNo")]
    [StringLength(50)]
    public string AppaymentProposalItemInvoiceInNo { get; set; }

    [Column("ARSaleOrderPaymentTimeDueDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderPaymentTimeDueDate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApobjectType { get; set; }

    [Column("APPaymentProposalItemRemark")]
    [StringLength(500)]
    public string AppaymentProposalItemRemark { get; set; }

    [Column("APPaymentProposalItemTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalItemTaxPercent { get; set; }

    [Column("APPaymentProposalItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalItemTaxAmount { get; set; }

    [Column("APPaymentProposalItemDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentProposalItemDiscountFix { get; set; }

    [ForeignKey("FkAppaymentProposalId")]
    [InverseProperty("AppaymentProposalItems")]
    public virtual AppaymentProposal FkAppaymentProposal { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppaymentProposalItems")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkAppurchaseOrderPaymentTimeId")]
    [InverseProperty("AppaymentProposalItems")]
    public virtual AppurchaseOrderPaymentTime FkAppurchaseOrderPaymentTime { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AppaymentProposalItems")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("AppaymentProposalItems")]
    public virtual Icreceipt FkIcreceipt { get; set; }
}
