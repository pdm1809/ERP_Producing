using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTemplateRanks")]
public partial class HrtemplateRank
{
    [Key]
    [Column("HRTemplateRankID")]
    public int HrtemplateRankId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREvaluationTemplateID")]
    public int FkHrevaluationTemplateId { get; set; }

    [Column("FK_HREvaluationRankID")]
    public int FkHrevaluationRankId { get; set; }

    [Column("HRTemplateRankFromValue", TypeName = "decimal(18, 5)")]
    public decimal? HrtemplateRankFromValue { get; set; }

    [Column("HRTemplateRankToValue", TypeName = "decimal(18, 5)")]
    public decimal? HrtemplateRankToValue { get; set; }

    [ForeignKey("FkHrevaluationRankId")]
    [InverseProperty("HrtemplateRanks")]
    public virtual HrevaluationRank FkHrevaluationRank { get; set; }

    [ForeignKey("FkHrevaluationTemplateId")]
    [InverseProperty("HrtemplateRanks")]
    public virtual HrevaluationTemplate FkHrevaluationTemplate { get; set; }

    [InverseProperty("FkHrtemplateRank")]
    public virtual ICollection<HremployeeEvaluation> HremployeeEvaluations { get; set; } = new List<HremployeeEvaluation>();
}
