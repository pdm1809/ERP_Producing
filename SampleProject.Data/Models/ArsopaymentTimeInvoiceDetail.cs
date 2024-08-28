using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSOPaymentTimeInvoiceDetails")]
public partial class ArsopaymentTimeInvoiceDetail
{
    [Key]
    [Column("ARSOPaymentTimeInvoiceDetailID")]
    public int ArsopaymentTimeInvoiceDetailId { get; set; }

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

    [Column("ARSOPaymentTimeInvoiceDetailAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailAmount { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailDate", TypeName = "datetime")]
    public DateTime? ArsopaymentTimeInvoiceDetailDate { get; set; }

    [Column("FK_ARSaleOrderPaymentTimeID")]
    public int? FkArsaleOrderPaymentTimeId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("ARInvoiceNo")]
    [StringLength(50)]
    public string ArinvoiceNo { get; set; }

    [Column("ARSaleOrderNo")]
    [StringLength(50)]
    public string ArsaleOrderNo { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailEndDate", TypeName = "datetime")]
    public DateTime? ArsopaymentTimeInvoiceDetailEndDate { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailBalanceDue { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailDepositAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailDepositAmount { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailPaidAmount { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailReceiptVoucherNo")]
    [StringLength(50)]
    public string ArsopaymentTimeInvoiceDetailReceiptVoucherNo { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailRequiredAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailRequiredAmount { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailClearingDepositAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailClearingDepositAmount { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailPaymentType")]
    [StringLength(50)]
    public string ArsopaymentTimeInvoiceDetailPaymentType { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailCancelAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailCancelAmount { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailCancelNo")]
    [StringLength(50)]
    public string ArsopaymentTimeInvoiceDetailCancelNo { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailSaleReturnAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailSaleReturnAmount { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailSaleReturnNo")]
    [StringLength(50)]
    public string ArsopaymentTimeInvoiceDetailSaleReturnNo { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailIsClearing")]
    public bool? ArsopaymentTimeInvoiceDetailIsClearing { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailExchangeRate { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailUsedAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailUsedAmount { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailDocumentType")]
    [StringLength(50)]
    public string ArsopaymentTimeInvoiceDetailDocumentType { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailDebitDocumentNo")]
    [StringLength(50)]
    public string ArsopaymentTimeInvoiceDetailDebitDocumentNo { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailCreditDocumentNo")]
    [StringLength(50)]
    public string ArsopaymentTimeInvoiceDetailCreditDocumentNo { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailGuaranteeName")]
    [StringLength(256)]
    public string ArsopaymentTimeInvoiceDetailGuaranteeName { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailGuaranteeFromDate", TypeName = "datetime")]
    public DateTime? ArsopaymentTimeInvoiceDetailGuaranteeFromDate { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailGuaranteeToDate", TypeName = "datetime")]
    public DateTime? ArsopaymentTimeInvoiceDetailGuaranteeToDate { get; set; }

    [Column("ARSOPaymentTimeInvoiceDetailGuaranteeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsopaymentTimeInvoiceDetailGuaranteeAmount { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("ArsopaymentTimeInvoiceDetailFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("ArsopaymentTimeInvoiceDetailFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArsopaymentTimeInvoiceDetails")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsopaymentTimeInvoiceDetails")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderPaymentTimeId")]
    [InverseProperty("ArsopaymentTimeInvoiceDetails")]
    public virtual ArsaleOrderPaymentTime FkArsaleOrderPaymentTime { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArsopaymentTimeInvoiceDetails")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArsopaymentTimeInvoiceDetails")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
