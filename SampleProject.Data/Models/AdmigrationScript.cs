using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ADMigrationScripts")]
public partial class AdmigrationScript
{
    [Column("ADMigrationScriptID")]
    public int AdmigrationScriptId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ADMigrationScriptName")]
    [StringLength(256)]
    public string AdmigrationScriptName { get; set; }

    [Column("ADMigrationScriptAuthor")]
    [StringLength(256)]
    public string AdmigrationScriptAuthor { get; set; }

    [Column("ADMigrationScriptDesc")]
    [StringLength(256)]
    public string AdmigrationScriptDesc { get; set; }

    [Column("ADMigrationScriptScript", TypeName = "ntext")]
    public string AdmigrationScriptScript { get; set; }
}
