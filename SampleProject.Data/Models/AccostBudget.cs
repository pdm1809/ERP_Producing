using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACCostBudgets")]
public partial class AccostBudget
{
    [Key]
    [Column("ACCostBudgetID")]
    public int AccostBudgetId { get; set; }

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
    [Column("ACCostBudgetNo")]
    [StringLength(50)]
    public string AccostBudgetNo { get; set; }

    [Column("ACCostBudgetDate", TypeName = "datetime")]
    public DateTime? AccostBudgetDate { get; set; }

    [Column("ACCostBudgetDesc")]
    [StringLength(512)]
    public string AccostBudgetDesc { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACCostBudgetExchangeRate", TypeName = "decimal(18, 0)")]
    public decimal? AccostBudgetExchangeRate { get; set; }

    [Column("ACCostBudgetStatus")]
    [StringLength(50)]
    public string AccostBudgetStatus { get; set; }

    [Column("ACCostBudgetType")]
    [StringLength(64)]
    public string AccostBudgetType { get; set; }

    [InverseProperty("FkAccostBudget")]
    public virtual ICollection<AccostBudgetDetail> AccostBudgetDetails { get; set; } = new List<AccostBudgetDetail>();

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AccostBudgets")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
