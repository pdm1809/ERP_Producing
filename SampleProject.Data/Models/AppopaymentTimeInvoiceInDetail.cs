using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPOPaymentTimeInvoiceInDetails")]
public partial class AppopaymentTimeInvoiceInDetail
{
    [Key]
    [Column("APPOPaymentTimeInvoiceInDetailID")]
    public int AppopaymentTimeInvoiceInDetailId { get; set; }

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

    [Column("APPOPaymentTimeInvoiceInDetailAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppopaymentTimeInvoiceInDetailAmount { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailDate", TypeName = "datetime")]
    public DateTime? AppopaymentTimeInvoiceInDetailDate { get; set; }

    [Column("FK_APPurchaseOrderPaymentTimeID")]
    public int? FkAppurchaseOrderPaymentTimeId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("APInvoiceInNo")]
    [StringLength(50)]
    public string ApinvoiceInNo { get; set; }

    [Column("APPurchaseOrderNo")]
    [StringLength(50)]
    public string AppurchaseOrderNo { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailEndDate", TypeName = "datetime")]
    public DateTime? AppopaymentTimeInvoiceInDetailEndDate { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? AppopaymentTimeInvoiceInDetailBalanceDue { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailDepositAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppopaymentTimeInvoiceInDetailDepositAmount { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppopaymentTimeInvoiceInDetailPaidAmount { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailRequiredAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppopaymentTimeInvoiceInDetailRequiredAmount { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailClearingDepositAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppopaymentTimeInvoiceInDetailClearingDepositAmount { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailPaymentType")]
    [StringLength(50)]
    public string AppopaymentTimeInvoiceInDetailPaymentType { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailCancelAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppopaymentTimeInvoiceInDetailCancelAmount { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailIsClearing")]
    public bool? AppopaymentTimeInvoiceInDetailIsClearing { get; set; }

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailDebitDocumentNo")]
    [StringLength(50)]
    public string AppopaymentTimeInvoiceInDetailDebitDocumentNo { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailCreditDocumentNo")]
    [StringLength(50)]
    public string AppopaymentTimeInvoiceInDetailCreditDocumentNo { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailDocumentType")]
    [StringLength(50)]
    public string AppopaymentTimeInvoiceInDetailDocumentType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    public string ApobjectType { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailUsedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppopaymentTimeInvoiceInDetailUsedAmount { get; set; }

    [Column("APPOPaymentTimeInvoiceInDetailExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AppopaymentTimeInvoiceInDetailExchangeRate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AppopaymentTimeInvoiceInDetailFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AppopaymentTimeInvoiceInDetailFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AppopaymentTimeInvoiceInDetails")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("AppopaymentTimeInvoiceInDetails")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppopaymentTimeInvoiceInDetails")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkAppurchaseOrderPaymentTimeId")]
    [InverseProperty("AppopaymentTimeInvoiceInDetails")]
    public virtual AppurchaseOrderPaymentTime FkAppurchaseOrderPaymentTime { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AppopaymentTimeInvoiceInDetails")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AppopaymentTimeInvoiceInDetails")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
