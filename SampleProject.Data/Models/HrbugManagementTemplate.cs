using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRBugManagementTemplates")]
public partial class HrbugManagementTemplate
{
    [Key]
    [Column("HRBugManagementTemplateID")]
    public int HrbugManagementTemplateId { get; set; }

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

    [Column("FK_HRBugManagementID")]
    public int FkHrbugManagementId { get; set; }

    [Column("HRBugManagementTemplateName")]
    [StringLength(256)]
    public string HrbugManagementTemplateName { get; set; }

    [Column("HRBugManagementTemplateNameDisplay")]
    [StringLength(256)]
    public string HrbugManagementTemplateNameDisplay { get; set; }

    [Column("HRBugManagementTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrbugManagementTemplateStatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkHrbugManagementId")]
    [InverseProperty("HrbugManagementTemplates")]
    public virtual HrbugManagement FkHrbugManagement { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrbugManagementTemplates")]
    public virtual Hremployee FkHremployee { get; set; }
}
