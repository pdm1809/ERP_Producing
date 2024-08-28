using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldColumnPermissions")]
[Microsoft.EntityFrameworkCore.Index("StfieldColumnPermissionType", Name = "Idx_STFieldColumnPermissions")]
public partial class StfieldColumnPermission
{
    [Key]
    [Column("STFieldColumnPermissionID")]
    public int StfieldColumnPermissionId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Required]
    [Column("STModuleName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StmoduleName { get; set; }

    [Required]
    [Column("STTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string SttableName { get; set; }

    [Required]
    [Column("STColumnName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StcolumnName { get; set; }

    [Column("STFieldColumnPermissionType")]
    public byte StfieldColumnPermissionType { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("StfieldColumnPermissions")]
    public virtual AduserGroup FkAduserGroup { get; set; }
}
