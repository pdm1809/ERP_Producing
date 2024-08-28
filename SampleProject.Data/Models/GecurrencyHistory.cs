using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GECurrencyHistory")]
public partial class GecurrencyHistory
{
    [Key]
    [Column("GECurrencyHistoryID")]
    public int GecurrencyHistoryId { get; set; }

    [Required]
    [Column("GECurrencyHistoryIDString")]
    [StringLength(50)]
    [Unicode(false)]
    public string GecurrencyHistoryIdstring { get; set; }

    [Column("GECurrencyID")]
    public int GecurrencyId { get; set; }

    [Column("GECurrencyHistoryInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string GecurrencyHistoryInformation { get; set; }

    [Column("GECurrencyHistoryValue", TypeName = "decimal(18, 5)")]
    public decimal? GecurrencyHistoryValue { get; set; }

    [Column("GECurrencyHistoryValue1", TypeName = "decimal(18, 5)")]
    public decimal? GecurrencyHistoryValue1 { get; set; }

    [Column("GECurrencyHistoryDateFrom", TypeName = "datetime")]
    public DateTime? GecurrencyHistoryDateFrom { get; set; }

    [Column("GECurrencyHistoryDateUntil", TypeName = "datetime")]
    public DateTime? GecurrencyHistoryDateUntil { get; set; }

    [Column("GECurrencyHistoryValueFix", TypeName = "decimal(18, 5)")]
    public decimal? GecurrencyHistoryValueFix { get; set; }

    [ForeignKey("GecurrencyId")]
    [InverseProperty("GecurrencyHistories")]
    public virtual Gecurrency Gecurrency { get; set; }
}
