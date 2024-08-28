using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APInvoiceInTransactions")]
public partial class ApinvoiceInTransaction
{
    [Key]
    [Column("APInvoiceInTransactionID")]
    public int ApinvoiceInTransactionId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(128)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(128)]
    public string AaupdatedUser { get; set; }

    [Column("FK_BRBRanchID")]
    public int? FkBrbranchId { get; set; }

    [Column("APInvoiceInTransactionReferenceID")]
    public int? ApinvoiceInTransactionReferenceId { get; set; }

    [Column("APInvoiceInTransactionReferenceNo")]
    [StringLength(128)]
    public string ApinvoiceInTransactionReferenceNo { get; set; }

    [Column("APInvoiceInTransactionReferenceDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInTransactionReferenceDate { get; set; }

    [Column("APInvoiceInTransactionDesc")]
    [StringLength(512)]
    public string ApinvoiceInTransactionDesc { get; set; }

    [Column("APInvoiceInTransactionModuleName")]
    [StringLength(128)]
    public string ApinvoiceInTransactionModuleName { get; set; }

    [Column("APInvoiceInTransactionType")]
    [StringLength(128)]
    public string ApinvoiceInTransactionType { get; set; }

    [Column("APInvoiceInTransactionOrigin")]
    [StringLength(128)]
    public string ApinvoiceInTransactionOrigin { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(128)]
    public string ArobjectType { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("APPurchaseOrderNo")]
    [StringLength(128)]
    public string AppurchaseOrderNo { get; set; }

    [Column("FK_APPurchaseOrderPaymentTimeID")]
    public int? FkAppurchaseOrderPaymentTimeId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("APInvoiceInNo")]
    [StringLength(128)]
    public string ApinvoiceInNo { get; set; }

    [Column("APInvoiceInSymbol")]
    [StringLength(128)]
    public string ApinvoiceInSymbol { get; set; }

    [Column("APInvoiceInDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInDate { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("APInvoiceInTransactionEndDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInTransactionEndDate { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("APInvoiceInTransactionExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInTransactionExchangeRate { get; set; }

    [Column("APPurchaseOrderAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderAmount { get; set; }

    [Column("APPurchaseOrderAmountExchange", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderAmountExchange { get; set; }

    [Column("APInvoiceInAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInAmount { get; set; }

    [Column("APInvoiceInAmountExchange", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInAmountExchange { get; set; }

    [Column("APPurchaseOrderPaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderPaymentAmount { get; set; }

    [Column("APPurchaseOrderPaymentAmountExchange", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderPaymentAmountExchange { get; set; }

    [Column("APInvoiceInPaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInPaymentAmount { get; set; }

    [Column("APInvoiceInPaymentAmountExchange", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInPaymentAmountExchange { get; set; }

    [Column("APInvoiceInTransactionMethod")]
    [StringLength(128)]
    public string ApinvoiceInTransactionMethod { get; set; }

    [Column("APInvoiceInTransactionStatus")]
    [StringLength(128)]
    public string ApinvoiceInTransactionStatus { get; set; }

    [Column("APInvoiceInTransactionPaymentType")]
    [StringLength(256)]
    public string ApinvoiceInTransactionPaymentType { get; set; }

    [Column("APInvoiceInVatNo")]
    [StringLength(50)]
    public string ApinvoiceInVatNo { get; set; }

    [Column("FK_APPurchaseContractID")]
    public int? FkAppurchaseContractId { get; set; }

    [Column("APInvoiceInTransactionPaymentID")]
    public int? ApinvoiceInTransactionPaymentId { get; set; }

    [Column("APInvoiceInTransactionPaymentNo")]
    [StringLength(128)]
    public string ApinvoiceInTransactionPaymentNo { get; set; }

    [Column("APInvoiceInTransactionPaymentModuleName")]
    [StringLength(128)]
    public string ApinvoiceInTransactionPaymentModuleName { get; set; }

    [ForeignKey("FkAppurchaseContractId")]
    [InverseProperty("ApinvoiceInTransactions")]
    public virtual AppurchaseContract FkAppurchaseContract { get; set; }
}
