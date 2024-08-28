using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREvaluationStandards")]
public partial class HrevaluationStandard
{
    [Key]
    [Column("HREvaluationStandardID")]
    public int HrevaluationStandardId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("HREvaluationStandardName")]
    [StringLength(100)]
    public string HrevaluationStandardName { get; set; }

    [Column("HREvaluationStandardDesc")]
    [StringLength(512)]
    public string HrevaluationStandardDesc { get; set; }

    [Column("HREvaluationStandardParentID")]
    public int? HrevaluationStandardParentId { get; set; }

    [InverseProperty("FkHrevaluationStandard")]
    public virtual ICollection<HrevaluationDetail> HrevaluationDetails { get; set; } = new List<HrevaluationDetail>();

    [ForeignKey("HrevaluationStandardParentId")]
    [InverseProperty("InverseHrevaluationStandardParent")]
    public virtual HrevaluationStandard HrevaluationStandardParent { get; set; }

    [InverseProperty("FkHrevaluationStandard")]
    public virtual ICollection<HrstandardQuestion> HrstandardQuestions { get; set; } = new List<HrstandardQuestion>();

    [InverseProperty("FkHrevaluationStandard")]
    public virtual ICollection<HrtemplateStandard> HrtemplateStandards { get; set; } = new List<HrtemplateStandard>();

    [InverseProperty("HrevaluationStandardParent")]
    public virtual ICollection<HrevaluationStandard> InverseHrevaluationStandardParent { get; set; } = new List<HrevaluationStandard>();
}
