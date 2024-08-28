using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeIdentityCardTemplates")]
public partial class HremployeeIdentityCardTemplate
{
    [Key]
    [Column("HREmployeeIdentityCardTemplateID")]
    public int HremployeeIdentityCardTemplateId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_GETemplateID")]
    public int? FkGetemplateId { get; set; }

    [Column("HREmployeeIdentityCardTemplateName")]
    [StringLength(256)]
    public string HremployeeIdentityCardTemplateName { get; set; }

    [Column("HREmployeeIdentityCardTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeIdentityCardTemplateStatus { get; set; }

    [Column("HREmployeeIdentityCardTemplateFileGUID")]
    [StringLength(256)]
    public string HremployeeIdentityCardTemplateFileGuid { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeIdentityCardTemplates")]
    public virtual Hremployee FkHremployee { get; set; }
}
