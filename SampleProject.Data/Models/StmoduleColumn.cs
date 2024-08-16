using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleColumns")]
public partial class StmoduleColumn
{
    [Key]
    [Column("STModuleColumnID")]
    public int StmoduleColumnId { get; set; }

    [Column("STModuleID")]
    public int? StmoduleId { get; set; }

    [Column("STModuleTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StmoduleTableName { get; set; }

    [Column("STModuleColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string StmoduleColumnName { get; set; }

    public bool? IsActive { get; set; }
}
