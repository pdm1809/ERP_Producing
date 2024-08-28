using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectTemplateRelationships")]
public partial class PmprojectTemplateRelationship
{
    [Key]
    [Column("PMProjectTemplateRelationshipID")]
    public int PmprojectTemplateRelationshipId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_PMPhaseTypeID")]
    public int? FkPmphaseTypeId { get; set; }

    [Column("PMProjectTemplateRelationshipIsApproved")]
    public bool? PmprojectTemplateRelationshipIsApproved { get; set; }

    [ForeignKey("FkPmphaseTypeId")]
    [InverseProperty("PmprojectTemplateRelationships")]
    public virtual PmphaseType FkPmphaseType { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmprojectTemplateRelationships")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("PmprojectTemplateRelationships")]
    public virtual Pmtemplate FkPmtemplate { get; set; }
}
