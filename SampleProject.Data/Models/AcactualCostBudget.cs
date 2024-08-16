using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACActualCostBudgets")]
public partial class AcactualCostBudget
{
    [Key]
    [Column("ACActualCostBudgetID")]
    public int AcactualCostBudgetId { get; set; }

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
    [Column("ACActualCostBudgetNo")]
    [StringLength(50)]
    public string AcactualCostBudgetNo { get; set; }

    [Column("ACActualCostBudgetDate", TypeName = "datetime")]
    public DateTime? AcactualCostBudgetDate { get; set; }

    [Column("ACActualCostBudgetDesc")]
    [StringLength(512)]
    public string AcactualCostBudgetDesc { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACActualCostBudgetExchangeRate", TypeName = "decimal(18, 0)")]
    public decimal? AcactualCostBudgetExchangeRate { get; set; }

    [Column("ACActualCostBudgetStatus")]
    [StringLength(50)]
    public string AcactualCostBudgetStatus { get; set; }

    [InverseProperty("FkAcactualCostBudget")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcactualCostBudgets")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
