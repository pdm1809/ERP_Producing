using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeEvaluations")]
[Microsoft.EntityFrameworkCore.Index("FkHremployeeId", "HremployeeEvaluationType", Name = "Idx_HREmployeeEvaluations")]
public partial class HremployeeEvaluation
{
    [Key]
    [Column("HREmployeeEvaluationID")]
    public int HremployeeEvaluationId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREvaluationID")]
    public int FkHrevaluationId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HREvaluationRankID")]
    public int? FkHrevaluationRankId { get; set; }

    [Column("FK_HRTemplateRankID")]
    public int? FkHrtemplateRankId { get; set; }

    [Required]
    [Column("HREmployeeEvaluationType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeEvaluationType { get; set; }

    [Column("HREmployeeEvaluationResult", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeEvaluationResult { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeEvaluations")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrevaluationId")]
    [InverseProperty("HremployeeEvaluations")]
    public virtual Hrevaluation FkHrevaluation { get; set; }

    [ForeignKey("FkHrevaluationRankId")]
    [InverseProperty("HremployeeEvaluations")]
    public virtual HrevaluationRank FkHrevaluationRank { get; set; }

    [ForeignKey("FkHrtemplateRankId")]
    [InverseProperty("HremployeeEvaluations")]
    public virtual HrtemplateRank FkHrtemplateRank { get; set; }
}
