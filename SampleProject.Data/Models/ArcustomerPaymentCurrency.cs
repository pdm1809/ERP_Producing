using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerPaymentCurrencys")]
public partial class ArcustomerPaymentCurrency
{
    [Key]
    [Column("ARCustomerPaymentCurrencyID")]
    public int ArcustomerPaymentCurrencyId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerPaymentDetailID")]
    public int FkArcustomerPaymentDetailId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("ARCustomerPaymentCurrencyAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentCurrencyAmount { get; set; }

    [Column("ARCustomerPaymentCurrencyExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentCurrencyExchangeRate { get; set; }

    [Column("ARCustomerPaymentCurrencyExchangeWay")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerPaymentCurrencyExchangeWay { get; set; }

    [Column("ARCustomerPaymentCurrencyExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentCurrencyExchangeAmount { get; set; }

    [ForeignKey("FkArcustomerPaymentDetailId")]
    [InverseProperty("ArcustomerPaymentCurrencies")]
    public virtual ArcustomerPaymentDetail FkArcustomerPaymentDetail { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArcustomerPaymentCurrencies")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
