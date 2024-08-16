using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STGridResultColumnDisplays")]
public partial class StgridResultColumnDisplay
{
    [Key]
    [Column("STGridResultColumnDisplayID")]
    public int StgridResultColumnDisplayId { get; set; }

    [Required]
    [Column("STGridResultColumnName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StgridResultColumnName { get; set; }

    [Required]
    [Column("STGridResultColumnFieldName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StgridResultColumnFieldName { get; set; }

    [Required]
    [Column("STGridResultColumnCaption")]
    [StringLength(50)]
    [Unicode(false)]
    public string StgridResultColumnCaption { get; set; }

    [Column("STGridResultColumnWidth")]
    public int StgridResultColumnWidth { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("STGridResultSortOrder")]
    public int StgridResultSortOrder { get; set; }

    [Column("STGridByName")]
    [StringLength(100)]
    [Unicode(false)]
    public string StgridByName { get; set; }

    [ForeignKey("StmoduleId")]
    [InverseProperty("StgridResultColumnDisplays")]
    public virtual Stmodule Stmodule { get; set; }
}
