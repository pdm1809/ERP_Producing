using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class VapinvoiceInVatInsForReportsTt06
{
    [Column("APInvoiceInReferenceID")]
    public int ApinvoiceInReferenceId { get; set; }

    [Required]
    [Column("APInvoiceInReferenceNo")]
    [StringLength(50)]
    public string ApinvoiceInReferenceNo { get; set; }

    [Column("APInvoiceInReferenceDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInReferenceDate { get; set; }

    [Required]
    [Column("APInvoiceInModuleName")]
    [StringLength(29)]
    [Unicode(false)]
    public string ApinvoiceInModuleName { get; set; }

    [Column("APInputVATDocumentType")]
    [StringLength(1000)]
    public string ApinputVatdocumentType { get; set; }

    [Column("APInputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string ApinputVatinvoiceNoCombo { get; set; }

    [Column("APInvoiceInVATFormNo")]
    [StringLength(128)]
    public string ApinvoiceInVatformNo { get; set; }

    [Column("APInvoiceInSupplierNo")]
    [StringLength(128)]
    public string ApinvoiceInSupplierNo { get; set; }

    [Column("APInvoiceInVATSymbol")]
    [StringLength(128)]
    public string ApinvoiceInVatsymbol { get; set; }

    [Column("APInvoiceInSupplierDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInSupplierDate { get; set; }

    [StringLength(128)]
    public string ObjectType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Required]
    [Column("APInvoiceInContactVatName")]
    [StringLength(1)]
    [Unicode(false)]
    public string ApinvoiceInContactVatName { get; set; }

    [Column("ACObjectName")]
    [StringLength(4000)]
    public string AcobjectName { get; set; }

    [Column("APInvoiceInInvoiceAddressLine3")]
    [StringLength(512)]
    public string ApinvoiceInInvoiceAddressLine3 { get; set; }

    [Column("APInvoiceInTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInTaxNumber { get; set; }

    [Column("APInvoiceInComment", TypeName = "ntext")]
    public string ApinvoiceInComment { get; set; }

    [Column("APInvoiceInDesc", TypeName = "ntext")]
    public string ApinvoiceInDesc { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("APInvoiceInExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInExchangeRate { get; set; }

    [Column("APInvoiceInItemProductDesc", TypeName = "ntext")]
    public string ApinvoiceInItemProductDesc { get; set; }

    [Column("APInvoiceInNetAmount", TypeName = "decimal(38, 10)")]
    public decimal? ApinvoiceInNetAmount { get; set; }

    [Column("APInvoiceInNetAmountByCurrency", TypeName = "decimal(19, 5)")]
    public decimal? ApinvoiceInNetAmountByCurrency { get; set; }

    [Column("APInvoiceInTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInTaxPercent { get; set; }

    [Column("APInvoiceInTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInTaxAmount { get; set; }
}
