using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STToolbarFunctionParameters")]
[Microsoft.EntityFrameworkCore.Index("SttoolbarFunctionParameterType", Name = "Idx_STToolbarFunctionParameters")]
public partial class SttoolbarFunctionParameter
{
    [Key]
    [Column("STToolbarFunctionParameterID")]
    public int SttoolbarFunctionParameterId { get; set; }

    [Required]
    [Column("STToolbarFunctionParameterIDString")]
    [StringLength(50)]
    [Unicode(false)]
    public string SttoolbarFunctionParameterIdstring { get; set; }

    [Column("STToolbarFunctionID")]
    public int SttoolbarFunctionId { get; set; }

    [Required]
    [Column("STToolbarFunctionParameterName")]
    [StringLength(500)]
    [Unicode(false)]
    public string SttoolbarFunctionParameterName { get; set; }

    [Required]
    [Column("STToolbarFunctionParameterValue")]
    [StringLength(500)]
    [Unicode(false)]
    public string SttoolbarFunctionParameterValue { get; set; }

    [Required]
    [Column("STToolbarFunctionParameterType")]
    [StringLength(500)]
    [Unicode(false)]
    public string SttoolbarFunctionParameterType { get; set; }

    [ForeignKey("SttoolbarFunctionId")]
    [InverseProperty("SttoolbarFunctionParameters")]
    public virtual SttoolbarFunction SttoolbarFunction { get; set; }
}
