using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleCompletePermissions")]
public partial class StmoduleCompletePermission
{
    [Key]
    [Column("STModuleCompletePermissionID")]
    public int StmoduleCompletePermissionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_STModuleID")]
    public int? FkStmoduleId { get; set; }

    [Column("STSchemaTableName")]
    [StringLength(100)]
    [Unicode(false)]
    public string StschemaTableName { get; set; }
}
