using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleFunctionParameters")]
[Microsoft.EntityFrameworkCore.Index("StmoduleFunctionParameterType", Name = "Idx_STModuleFunctionParameters")]
public partial class StmoduleFunctionParameter
{
    [Key]
    [Column("STModuleFunctionParameterID")]
    public int StmoduleFunctionParameterId { get; set; }

    [Column("STModuleFunctionID")]
    public int StmoduleFunctionId { get; set; }

    [Required]
    [Column("STModuleFunctionParameterType")]
    [StringLength(255)]
    [Unicode(false)]
    public string StmoduleFunctionParameterType { get; set; }

    [Required]
    [Column("STModuleFunctionParameterName")]
    [StringLength(255)]
    [Unicode(false)]
    public string StmoduleFunctionParameterName { get; set; }

    [ForeignKey("StmoduleFunctionId")]
    [InverseProperty("StmoduleFunctionParameters")]
    public virtual StmoduleFunction StmoduleFunction { get; set; }

    [InverseProperty("StmoduleFunctionParameter")]
    public virtual ICollection<StmoduleFunctionParameterValue> StmoduleFunctionParameterValues { get; set; } = new List<StmoduleFunctionParameterValue>();
}
