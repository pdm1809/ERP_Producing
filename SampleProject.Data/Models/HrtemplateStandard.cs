using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTemplateStandards")]
public partial class HrtemplateStandard
{
    [Key]
    [Column("HRTemplateStandardID")]
    public int HrtemplateStandardId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREvaluationTemplateID")]
    public int FkHrevaluationTemplateId { get; set; }

    [Column("FK_HREvaluationStandardID")]
    public int FkHrevaluationStandardId { get; set; }

    [ForeignKey("FkHrevaluationStandardId")]
    [InverseProperty("HrtemplateStandards")]
    public virtual HrevaluationStandard FkHrevaluationStandard { get; set; }

    [ForeignKey("FkHrevaluationTemplateId")]
    [InverseProperty("HrtemplateStandards")]
    public virtual HrevaluationTemplate FkHrevaluationTemplate { get; set; }
}
