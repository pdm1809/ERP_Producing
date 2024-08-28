using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRCandidateTemplates")]
public partial class HrcandidateTemplate
{
    [Key]
    [Column("HRCandidateTemplateID")]
    public int HrcandidateTemplateId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRCandidateID")]
    public int FkHrcandidateId { get; set; }

    [Column("FK_GETemplateID")]
    public int? FkGetemplateId { get; set; }

    [Column("HRCandidateTemplateName")]
    [StringLength(256)]
    public string HrcandidateTemplateName { get; set; }

    [Column("HRCandidateTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrcandidateTemplateStatus { get; set; }

    [Column("HRCandidateTemplateFileGUID")]
    [StringLength(256)]
    public string HrcandidateTemplateFileGuid { get; set; }

    [ForeignKey("FkHrcandidateId")]
    [InverseProperty("HrcandidateTemplates")]
    public virtual Hrcandidate FkHrcandidate { get; set; }
}
