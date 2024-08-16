using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARClearInvoiceInvoices")]
public partial class ArclearInvoiceInvoice
{
    [Key]
    [Column("ARClearInvoiceInvoiceID")]
    public int ArclearInvoiceInvoiceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARClearInvoiceInvoiceNo")]
    [StringLength(50)]
    public string ArclearInvoiceInvoiceNo { get; set; }

    [Column("ARClearInvoiceInvoiceDate", TypeName = "datetime")]
    public DateTime? ArclearInvoiceInvoiceDate { get; set; }

    [Column("ARClearInvoiceInvoiceNumber")]
    [StringLength(50)]
    public string ArclearInvoiceInvoiceNumber { get; set; }

    [Column("ARClearInvoiceInvoiceInvoiceDate", TypeName = "datetime")]
    public DateTime? ArclearInvoiceInvoiceInvoiceDate { get; set; }

    [Column("FK_ARClearInvoiceID")]
    public int? FkArclearInvoiceId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ARClearInvoiceInvoiceExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceInvoiceExchangeRate { get; set; }

    [Column("ARClearInvoiceInvoiceAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceInvoiceAmount { get; set; }

    [Column("ARClearInvoiceInvoicePaintAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceInvoicePaintAmount { get; set; }

    [Column("ARClearInvoiceInvoiceExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceInvoiceExchangeAmount { get; set; }

    [Column("ARClearInvoiceInvoiceAllocationAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceInvoiceAllocationAmount { get; set; }

    [Column("ARClearInvoiceInvoiceExchangeAllocationAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceInvoiceExchangeAllocationAmount { get; set; }

    [Column("ARClearInvoiceInvoiceRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceInvoiceRemainAmount { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("ARClearInvoiceInvoiceRateVariance", TypeName = "decimal(18, 5)")]
    public decimal? ArclearInvoiceInvoiceRateVariance { get; set; }

    [ForeignKey("FkArclearInvoiceId")]
    [InverseProperty("ArclearInvoiceInvoices")]
    public virtual ArclearInvoice FkArclearInvoice { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArclearInvoiceInvoices")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArclearInvoiceInvoices")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
