using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class VarinvoiceVatOutsForReport
{
    [Column("ARInvoiceReferenceID")]
    public int? ArinvoiceReferenceId { get; set; }

    [Column("ARInvoiceReferenceNo")]
    [StringLength(50)]
    public string ArinvoiceReferenceNo { get; set; }

    [Column("ARInvoiceReferenceDate", TypeName = "datetime")]
    public DateTime? ArinvoiceReferenceDate { get; set; }

    [Required]
    [Column("ARInvoiceModuleName")]
    [StringLength(15)]
    [Unicode(false)]
    public string ArinvoiceModuleName { get; set; }

    [Column("AROutputVATDocumentType")]
    [StringLength(1000)]
    public string AroutputVatdocumentType { get; set; }

    [Column("AROutputVATInvoiceNoCombo")]
    [StringLength(128)]
    public string AroutputVatinvoiceNoCombo { get; set; }

    [Column("ARInvoiceVATFormNo")]
    [StringLength(128)]
    public string ArinvoiceVatformNo { get; set; }

    [Column("ARInvoiceVATInvoiceNo")]
    [StringLength(128)]
    public string ArinvoiceVatinvoiceNo { get; set; }

    [Column("ARInvoiceVATSymbol")]
    [StringLength(128)]
    public string ArinvoiceVatsymbol { get; set; }

    [Column("ARInvoiceDate", TypeName = "datetime")]
    public DateTime? ArinvoiceDate { get; set; }

    [Column("ARObjectType")]
    [StringLength(128)]
    public string ArobjectType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARInvoiceSOContactName")]
    [StringLength(4000)]
    public string ArinvoiceSocontactName { get; set; }

    [Column("ARInvoiceVATPaymentContactInformation")]
    [StringLength(4000)]
    public string ArinvoiceVatpaymentContactInformation { get; set; }

    [Column("ARInvoiceInvoiceAddressLine3")]
    [StringLength(200)]
    public string ArinvoiceInvoiceAddressLine3 { get; set; }

    [Column("ARInvoiceTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceTaxNumber { get; set; }

    [Column("ARInvoiceComment")]
    [StringLength(512)]
    public string ArinvoiceComment { get; set; }

    [Column("ARInvoiceDesc")]
    [StringLength(1000)]
    public string ArinvoiceDesc { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ARInvoiceExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceExchangeRate { get; set; }

    [Column("ARInvoiceItemProductName")]
    [StringLength(512)]
    public string ArinvoiceItemProductName { get; set; }

    [Column("ARInvoiceNetAmount1", TypeName = "decimal(38, 10)")]
    public decimal? ArinvoiceNetAmount1 { get; set; }

    [Column("ARInvoiceTaxAmount1", TypeName = "decimal(38, 5)")]
    public decimal? ArinvoiceTaxAmount1 { get; set; }

    [Column("ARInvoiceNetAmount", TypeName = "decimal(38, 6)")]
    public decimal? ArinvoiceNetAmount { get; set; }

    [Column("ARInvoiceTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceTaxPercent { get; set; }

    [Column("ARInvoiceTaxAmount", TypeName = "decimal(38, 10)")]
    public decimal? ArinvoiceTaxAmount { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }
}
