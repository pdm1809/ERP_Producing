using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARClearInvoiceDocuments")]
public partial class ArclearInvoiceDocument
{
    [Key]
    [Column("ARClearInvoiceDocumentID")]
    public int ArclearInvoiceDocumentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARClearInvoiceDocumentNo")]
    [StringLength(50)]
    public string ArclearInvoiceDocumentNo { get; set; }

    [Column("FK_ARClearInvoiceID")]
    public int? FkArclearInvoiceId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ARClearInvoiceDocumentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceDocumentExchangeRate { get; set; }

    [Column("ARClearInvoiceDocumentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceDocumentAmount { get; set; }

    [Column("ARClearInvoiceDocumentExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceDocumentExchangeAmount { get; set; }

    [Column("ARClearInvoiceDocumentAllocatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceDocumentAllocatedAmount { get; set; }

    [Column("ARClearInvoiceDocumentExchangeAllocatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceDocumentExchangeAllocatedAmount { get; set; }

    [Column("ARClearInvoiceDocumentRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceDocumentRemainAmount { get; set; }

    [Column("ARClearInvoiceDocumentAllocationAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceDocumentAllocationAmount { get; set; }

    [Column("ARClearInvoiceDocumentReferenceID")]
    public int? ArclearInvoiceDocumentReferenceId { get; set; }

    [Column("ARClearInvoiceDocumentReferenceModuleName")]
    [StringLength(128)]
    public string ArclearInvoiceDocumentReferenceModuleName { get; set; }

    [ForeignKey("FkArclearInvoiceId")]
    [InverseProperty("ArclearInvoiceDocuments")]
    public virtual ArclearInvoice FkArclearInvoice { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArclearInvoiceDocuments")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
