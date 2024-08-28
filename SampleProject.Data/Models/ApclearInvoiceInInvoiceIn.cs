using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APClearInvoiceInInvoiceIns")]
public partial class ApclearInvoiceInInvoiceIn
{
    [Key]
    [Column("APClearInvoiceInInvoiceInID")]
    public int ApclearInvoiceInInvoiceInId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("APClearInvoiceInInvoiceInNo")]
    [StringLength(50)]
    public string ApclearInvoiceInInvoiceInNo { get; set; }

    [Column("APClearInvoiceInInvoiceInDate", TypeName = "datetime")]
    public DateTime? ApclearInvoiceInInvoiceInDate { get; set; }

    [Column("APClearInvoiceInInvoiceInNumber")]
    [StringLength(50)]
    public string ApclearInvoiceInInvoiceInNumber { get; set; }

    [Column("APClearInvoiceInInvoiceInInvoiceDate", TypeName = "datetime")]
    public DateTime? ApclearInvoiceInInvoiceInInvoiceDate { get; set; }

    [Column("FK_APClearInvoiceInID")]
    public int? FkApclearInvoiceInId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("APClearInvoiceInInvoiceInExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInInvoiceInExchangeRate { get; set; }

    [Column("APClearInvoiceInInvoiceInAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInInvoiceInAmount { get; set; }

    [Column("APClearInvoiceInInvoiceInPaintAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInInvoiceInPaintAmount { get; set; }

    [Column("APClearInvoiceInInvoiceInExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInInvoiceInExchangeAmount { get; set; }

    [Column("APClearInvoiceInInvoiceInAllocationAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInInvoiceInAllocationAmount { get; set; }

    [Column("APClearInvoiceInInvoiceInExchangeAllocationAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInInvoiceInExchangeAllocationAmount { get; set; }

    [Column("APClearInvoiceInInvoiceInRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInInvoiceInRemainAmount { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("APClearInvoiceInInvoiceInRateVariance", TypeName = "decimal(18, 5)")]
    public decimal? ApclearInvoiceInInvoiceInRateVariance { get; set; }

    [ForeignKey("FkApclearInvoiceInId")]
    [InverseProperty("ApclearInvoiceInInvoiceIns")]
    public virtual ApclearInvoiceIn FkApclearInvoiceIn { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApclearInvoiceInInvoiceIns")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApclearInvoiceInInvoiceIns")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
