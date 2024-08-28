using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADObjectModulePermissions")]
public partial class AdobjectModulePermission
{
    [Key]
    [Column("ADObjectModulePermissionID")]
    public int AdobjectModulePermissionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Required]
    [Column("ADObjectModulePermissionModuleName")]
    [StringLength(50)]
    public string AdobjectModulePermissionModuleName { get; set; }

    [Column("ADObjectModulePermissionObjectID")]
    public int AdobjectModulePermissionObjectId { get; set; }

    [Required]
    [Column("ADObjectModulePermissionObjectType")]
    [StringLength(512)]
    public string AdobjectModulePermissionObjectType { get; set; }

    [Required]
    [Column("ADObjectModulePermissionToControl")]
    [StringLength(512)]
    public string AdobjectModulePermissionToControl { get; set; }

    [Required]
    [Column("ADObjectModulePermissionConditionType")]
    [StringLength(50)]
    public string AdobjectModulePermissionConditionType { get; set; }
}
