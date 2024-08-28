using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREvaluationQuestions")]
public partial class HrevaluationQuestion
{
    [Key]
    [Column("HREvaluationQuestionID")]
    public int HrevaluationQuestionId { get; set; }

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
    [Column("HREvaluationQuestionDesc")]
    [StringLength(512)]
    public string HrevaluationQuestionDesc { get; set; }

    [InverseProperty("FkHrevaluationQuestion")]
    public virtual ICollection<HrstandardQuestion> HrstandardQuestions { get; set; } = new List<HrstandardQuestion>();
}
