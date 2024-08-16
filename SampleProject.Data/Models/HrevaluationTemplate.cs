using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREvaluationTemplates")]
[Microsoft.EntityFrameworkCore.Index("HrevaluationTemplateNo", Name = "Idx_HREvaluationTemplates")]
public partial class HrevaluationTemplate
{
    [Key]
    [Column("HREvaluationTemplateID")]
    public int HrevaluationTemplateId { get; set; }

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
    [Column("HREvaluationTemplateNo")]
    [StringLength(50)]
    public string HrevaluationTemplateNo { get; set; }

    [Required]
    [Column("HREvaluationTemplateName")]
    [StringLength(100)]
    public string HrevaluationTemplateName { get; set; }

    [Column("HREvaluationTemplateDesc")]
    [StringLength(512)]
    public string HrevaluationTemplateDesc { get; set; }

    [InverseProperty("FkHrevaluationTemplate")]
    public virtual ICollection<Hrevaluation> Hrevaluations { get; set; } = new List<Hrevaluation>();

    [InverseProperty("FkHrevaluationTemplate")]
    public virtual ICollection<HrtemplateRank> HrtemplateRanks { get; set; } = new List<HrtemplateRank>();

    [InverseProperty("FkHrevaluationTemplate")]
    public virtual ICollection<HrtemplateStandard> HrtemplateStandards { get; set; } = new List<HrtemplateStandard>();
}
