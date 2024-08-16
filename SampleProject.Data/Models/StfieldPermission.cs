using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldPermissions")]
[Microsoft.EntityFrameworkCore.Index("StfieldPermissionType", Name = "Idx_STFieldPermissions")]
public partial class StfieldPermission
{
    [Key]
    [Column("STFieldPermissionID")]
    public int StfieldPermissionId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Required]
    [Column("STModuleName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StmoduleName { get; set; }

    [Column("STFieldName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldName { get; set; }

    [Column("STToolbarName")]
    [StringLength(50)]
    public string SttoolbarName { get; set; }

    [Column("STScreenName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StscreenName { get; set; }

    [Column("STFieldPermissionType")]
    public byte StfieldPermissionType { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("StfieldPermissions")]
    public virtual AduserGroup FkAduserGroup { get; set; }
}
