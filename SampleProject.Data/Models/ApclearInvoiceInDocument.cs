using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APClearInvoiceInDocuments")]
public partial class ApclearInvoiceInDocument
{
    [Key]
    [Column("APClearInvoiceInDocumentID")]
    public int ApclearInvoiceInDocumentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("APClearInvoiceInDocumentNo")]
    [StringLength(50)]
    public string ApclearInvoiceInDocumentNo { get; set; }

    [Column("FK_APClearInvoiceInID")]
    public int? FkApclearInvoiceInId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("APClearInvoiceInDocumentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInDocumentExchangeRate { get; set; }

    [Column("APClearInvoiceInDocumentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInDocumentAmount { get; set; }

    [Column("APClearInvoiceInDocumentExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInDocumentExchangeAmount { get; set; }

    [Column("APClearInvoiceInDocumentAllocatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInDocumentAllocatedAmount { get; set; }

    [Column("APClearInvoiceInDocumentExchangeAllocatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInDocumentExchangeAllocatedAmount { get; set; }

    [Column("APClearInvoiceInDocumentRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInDocumentRemainAmount { get; set; }

    [Column("APClearInvoiceInDocumentAllocationAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInDocumentAllocationAmount { get; set; }

    [Column("APClearInvoiceInDocumentReferenceID")]
    public int? ApclearInvoiceInDocumentReferenceId { get; set; }

    [Column("APClearInvoiceInDocumentReferenceModuleName")]
    [StringLength(128)]
    public string ApclearInvoiceInDocumentReferenceModuleName { get; set; }

    [ForeignKey("FkApclearInvoiceInId")]
    [InverseProperty("ApclearInvoiceInDocuments")]
    public virtual ApclearInvoiceIn FkApclearInvoiceIn { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApclearInvoiceInDocuments")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
