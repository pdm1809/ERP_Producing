using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STScreenPermissions")]
[Microsoft.EntityFrameworkCore.Index("StscreenPermissionType", Name = "Idx_STScreenPermissions")]
public partial class StscreenPermission
{
    [Key]
    [Column("STScreenPermissionID")]
    public int StscreenPermissionId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Required]
    [Column("STModuleName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StmoduleName { get; set; }

    [Required]
    [Column("STScreenName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StscreenName { get; set; }

    [Column("STScreenPermissionType")]
    public byte StscreenPermissionType { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("StscreenPermissions")]
    public virtual AduserGroup FkAduserGroup { get; set; }
}
