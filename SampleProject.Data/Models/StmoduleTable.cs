using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleTables")]
[Microsoft.EntityFrameworkCore.Index("StmoduleTableType", Name = "Idx_STModuleTables")]
public partial class StmoduleTable
{
    [Key]
    [Column("STModuleTableID")]
    public int StmoduleTableId { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Required]
    [Column("STModuleTableName")]
    [StringLength(255)]
    [Unicode(false)]
    public string StmoduleTableName { get; set; }

    /// <summary>
    /// 0:Table
    /// 1:View
    /// </summary>
    [Column("STModuleTableType")]
    public int StmoduleTableType { get; set; }

    [Column("STModuleTableLevelIndex")]
    public int? StmoduleTableLevelIndex { get; set; }

    [ForeignKey("StmoduleId")]
    [InverseProperty("StmoduleTables")]
    public virtual Stmodule Stmodule { get; set; }
}
