using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREvaluations")]
[Microsoft.EntityFrameworkCore.Index("HrevaluationNo", Name = "Idx_HREvaluations")]
public partial class Hrevaluation
{
    [Key]
    [Column("HREvaluationID")]
    public int HrevaluationId { get; set; }

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

    [Column("FK_HREvaluationTemplateID")]
    public int FkHrevaluationTemplateId { get; set; }

    [Required]
    [Column("HREvaluationNo")]
    [StringLength(50)]
    public string HrevaluationNo { get; set; }

    [Required]
    [Column("HREvaluationName")]
    [StringLength(100)]
    public string HrevaluationName { get; set; }

    [Column("HREvaluationDesc")]
    [StringLength(512)]
    public string HrevaluationDesc { get; set; }

    [Column("HREvaluationFromDate", TypeName = "datetime")]
    public DateTime? HrevaluationFromDate { get; set; }

    [Column("HREvaluationToDate", TypeName = "datetime")]
    public DateTime? HrevaluationToDate { get; set; }

    [Required]
    [Column("HREvaluationStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrevaluationStatus { get; set; }

    [ForeignKey("FkHrevaluationTemplateId")]
    [InverseProperty("Hrevaluations")]
    public virtual HrevaluationTemplate FkHrevaluationTemplate { get; set; }

    [InverseProperty("FkHrevaluation")]
    public virtual ICollection<HremployeeEvaluation> HremployeeEvaluations { get; set; } = new List<HremployeeEvaluation>();

    [InverseProperty("FkHrevaluation")]
    public virtual ICollection<HrevaluationDetail> HrevaluationDetails { get; set; } = new List<HrevaluationDetail>();
}
