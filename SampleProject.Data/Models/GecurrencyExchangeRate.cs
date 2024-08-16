using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GECurrencyExchangeRates")]
public partial class GecurrencyExchangeRate
{
    [Key]
    [Column("GECurrencyExchangeRateID")]
    public int GecurrencyExchangeRateId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("GECurrencyExchangeRateExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? GecurrencyExchangeRateExchangeRate { get; set; }

    [Column("GECurrencyExchangeRateDate", TypeName = "datetime")]
    public DateTime? GecurrencyExchangeRateDate { get; set; }

    [Column("GECurrencyExchangeRateIsVisible")]
    public bool? GecurrencyExchangeRateIsVisible { get; set; }

    [Column("GECurrencyExchangeRateTransferExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? GecurrencyExchangeRateTransferExchangeRate { get; set; }

    [Column("GECurrencyExchangeRatePlanExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? GecurrencyExchangeRatePlanExchangeRate { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("GecurrencyExchangeRates")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
