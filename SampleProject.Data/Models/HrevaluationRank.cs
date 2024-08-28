using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREvaluationRanks")]
public partial class HrevaluationRank
{
    [Key]
    [Column("HREvaluationRankID")]
    public int HrevaluationRankId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("HREvaluationRankName")]
    [StringLength(100)]
    public string HrevaluationRankName { get; set; }

    [Column("HREvaluationRankFromValue", TypeName = "decimal(18, 5)")]
    public decimal? HrevaluationRankFromValue { get; set; }

    [Column("HREvaluationRankToValue", TypeName = "decimal(18, 5)")]
    public decimal? HrevaluationRankToValue { get; set; }

    [InverseProperty("FkHrevaluationRank")]
    public virtual ICollection<HremployeeEvaluation> HremployeeEvaluations { get; set; } = new List<HremployeeEvaluation>();

    [InverseProperty("FkHrevaluationRank")]
    public virtual ICollection<HrtemplateRank> HrtemplateRanks { get; set; } = new List<HrtemplateRank>();
}
