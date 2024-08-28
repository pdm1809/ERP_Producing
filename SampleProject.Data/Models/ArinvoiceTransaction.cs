using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceTransactions")]
public partial class ArinvoiceTransaction
{
    [Key]
    [Column("ARInvoiceTransactionID")]
    public int ArinvoiceTransactionId { get; set; }

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

    [Column("ARInvoiceTransactionReferenceID")]
    public int? ArinvoiceTransactionReferenceId { get; set; }

    [Column("ARInvoiceTransactionReferenceNo")]
    [StringLength(128)]
    public string ArinvoiceTransactionReferenceNo { get; set; }

    [Column("ARInvoiceTransactionReferenceDate", TypeName = "datetime")]
    public DateTime? ArinvoiceTransactionReferenceDate { get; set; }

    [Column("ARInvoiceTransactionDesc")]
    [StringLength(512)]
    public string ArinvoiceTransactionDesc { get; set; }

    [Column("ARInvoiceTransactionModuleName")]
    [StringLength(128)]
    public string ArinvoiceTransactionModuleName { get; set; }

    [Column("ARInvoiceTransactionType")]
    [StringLength(128)]
    public string ArinvoiceTransactionType { get; set; }

    [Column("ARInvoiceTransactionOrigin")]
    [StringLength(128)]
    public string ArinvoiceTransactionOrigin { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(128)]
    public string ArobjectType { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("ARSaleOrderNo")]
    [StringLength(128)]
    public string ArsaleOrderNo { get; set; }

    [Column("FK_ARSaleOrderPaymentTimeID")]
    public int? FkArsaleOrderPaymentTimeId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("ARInvoiceNo")]
    [StringLength(128)]
    public string ArinvoiceNo { get; set; }

    [Column("ARInvoiceSymbol")]
    [StringLength(128)]
    public string ArinvoiceSymbol { get; set; }

    [Column("ARInvoiceDate", TypeName = "datetime")]
    public DateTime? ArinvoiceDate { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("ARInvoiceTransactionEndDate", TypeName = "datetime")]
    public DateTime? ArinvoiceTransactionEndDate { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ARInvoiceTransactionExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceTransactionExchangeRate { get; set; }

    [Column("ARSaleOrderAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderAmount { get; set; }

    [Column("ARSaleOrderAmountExchange", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderAmountExchange { get; set; }

    [Column("ARInvoiceAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceAmount { get; set; }

    [Column("ARInvoiceAmountExchange", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceAmountExchange { get; set; }

    [Column("ARSaleOrderPaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentAmount { get; set; }

    [Column("ARSaleOrderPaymentAmountExchange", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentAmountExchange { get; set; }

    [Column("ARInvoicePaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoicePaymentAmount { get; set; }

    [Column("ARInvoicePaymentAmountExchange", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoicePaymentAmountExchange { get; set; }

    [Column("ARInvoiceTransactionMethod")]
    [StringLength(128)]
    public string ArinvoiceTransactionMethod { get; set; }

    [Column("ARInvoiceTransactionStatus")]
    [StringLength(128)]
    public string ArinvoiceTransactionStatus { get; set; }

    [Column("ARInvoiceTransactionPaymentType")]
    [StringLength(256)]
    public string ArinvoiceTransactionPaymentType { get; set; }

    [Column("ARInvoiceVatNo")]
    [StringLength(50)]
    public string ArinvoiceVatNo { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("ARInvoiceTransactionPaymentID")]
    public int? ArinvoiceTransactionPaymentId { get; set; }

    [Column("ARInvoiceTransactionPaymentNo")]
    [StringLength(128)]
    public string ArinvoiceTransactionPaymentNo { get; set; }

    [Column("ARInvoiceTransactionPaymentModuleName")]
    [StringLength(128)]
    public string ArinvoiceTransactionPaymentModuleName { get; set; }

    [Column("ARInvoiceTransactionSalesChannel")]
    [StringLength(50)]
    public string ArinvoiceTransactionSalesChannel { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArinvoiceTransactions")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArinvoiceTransactions")]
    public virtual Brbranch FkBrbranch { get; set; }
}
