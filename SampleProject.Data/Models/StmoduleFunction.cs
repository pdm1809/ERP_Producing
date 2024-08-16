using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleFunctions")]
[Microsoft.EntityFrameworkCore.Index("StmoduleFunctionType", Name = "Idx_STModuleFunctions")]
public partial class StmoduleFunction
{
    [Key]
    [Column("STModuleFunctionID")]
    public int StmoduleFunctionId { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Required]
    [Column("STModuleFunctionName")]
    [StringLength(255)]
    [Unicode(false)]
    public string StmoduleFunctionName { get; set; }

    [Required]
    [Column("STModuleFunctionFullName")]
    [StringLength(500)]
    [Unicode(false)]
    public string StmoduleFunctionFullName { get; set; }

    [Required]
    [Column("STModuleFunctionReturnType")]
    [StringLength(255)]
    [Unicode(false)]
    public string StmoduleFunctionReturnType { get; set; }

    [Required]
    [Column("STModuleFunctionClass")]
    [StringLength(255)]
    [Unicode(false)]
    public string StmoduleFunctionClass { get; set; }

    [Column("STModuleFunctionSummary")]
    [StringLength(500)]
    [Unicode(false)]
    public string StmoduleFunctionSummary { get; set; }

    [Column("STModuleFunctionType")]
    [StringLength(255)]
    [Unicode(false)]
    public string StmoduleFunctionType { get; set; }

    [ForeignKey("StmoduleId")]
    [InverseProperty("StmoduleFunctions")]
    public virtual Stmodule Stmodule { get; set; }

    [InverseProperty("StmoduleFunction")]
    public virtual ICollection<StmoduleFunctionParameter> StmoduleFunctionParameters { get; set; } = new List<StmoduleFunctionParameter>();
}
