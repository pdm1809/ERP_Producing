using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACRevenueBudgets")]
public partial class AcrevenueBudget
{
    [Key]
    [Column("ACRevenueBudgetID")]
    public int AcrevenueBudgetId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Required]
    [Column("ACRevenueBudgetNo")]
    [StringLength(50)]
    public string AcrevenueBudgetNo { get; set; }

    [Column("ACRevenueBudgetDate", TypeName = "datetime")]
    public DateTime? AcrevenueBudgetDate { get; set; }

    [Column("ACRevenueBudgetDesc")]
    [StringLength(512)]
    public string AcrevenueBudgetDesc { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACRevenueBudgetExchangeRate", TypeName = "decimal(18, 0)")]
    public decimal? AcrevenueBudgetExchangeRate { get; set; }

    [Column("ACRevenueBudgetStatus")]
    [StringLength(50)]
    public string AcrevenueBudgetStatus { get; set; }

    [Column("ACRevenueBudgetType")]
    [StringLength(64)]
    public string AcrevenueBudgetType { get; set; }

    [InverseProperty("FkAcrevenueBudget")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; } = new List<AcrevenueBudgetDetail>();

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcrevenueBudgets")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
