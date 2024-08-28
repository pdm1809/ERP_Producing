using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADPermissions")]
public partial class Adpermission
{
    [Key]
    [Column("ADPermissionID")]
    public int AdpermissionId { get; set; }

    [Required]
    [Column("AACreatedDate")]
    [StringLength(50)]
    public string AacreatedDate { get; set; }

    [Required]
    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Required]
    [Column("AAUpdatedDate")]
    [StringLength(50)]
    public string AaupdatedDate { get; set; }

    [Required]
    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Required]
    [Column("ADPermissionDisplayName")]
    [StringLength(50)]
    public string AdpermissionDisplayName { get; set; }

    [Column("ADPermissionParentID")]
    public int AdpermissionParentId { get; set; }

    [Required]
    [Column("ADPermissionName")]
    [StringLength(50)]
    public string AdpermissionName { get; set; }

    [Required]
    [Column("ADPermissionDesc")]
    [StringLength(50)]
    public string AdpermissionDesc { get; set; }

    [Required]
    [Column("ADPermissionType")]
    [StringLength(50)]
    public string AdpermissionType { get; set; }

    [Required]
    [Column("FK_ADPermissionGroupID")]
    [StringLength(50)]
    public string FkAdpermissionGroupId { get; set; }

    [Required]
    [Column("ADPermissionCategory")]
    [StringLength(50)]
    public string AdpermissionCategory { get; set; }
}
