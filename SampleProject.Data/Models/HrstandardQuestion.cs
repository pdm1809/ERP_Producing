using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRStandardQuestions")]
public partial class HrstandardQuestion
{
    [Key]
    [Column("HRStandardQuestionID")]
    public int HrstandardQuestionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREvaluationStandardID")]
    public int FkHrevaluationStandardId { get; set; }

    [Column("FK_HREvaluationQuestionID")]
    public int FkHrevaluationQuestionId { get; set; }

    [ForeignKey("FkHrevaluationQuestionId")]
    [InverseProperty("HrstandardQuestions")]
    public virtual HrevaluationQuestion FkHrevaluationQuestion { get; set; }

    [ForeignKey("FkHrevaluationStandardId")]
    [InverseProperty("HrstandardQuestions")]
    public virtual HrevaluationStandard FkHrevaluationStandard { get; set; }
}
