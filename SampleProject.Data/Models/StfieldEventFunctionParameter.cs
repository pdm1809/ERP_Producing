using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldEventFunctionParameters")]
[Microsoft.EntityFrameworkCore.Index("StfieldEventFunctionParameterType", Name = "Idx_STFieldEventFunctionParameters")]
public partial class StfieldEventFunctionParameter
{
    [Key]
    [Column("STFieldEventFunctionParameterID")]
    public int StfieldEventFunctionParameterId { get; set; }

    [Column("STFieldEventFunctionID")]
    public int StfieldEventFunctionId { get; set; }

    [Required]
    [Column("STFieldEventFunctionParameterName")]
    [StringLength(500)]
    [Unicode(false)]
    public string StfieldEventFunctionParameterName { get; set; }

    [Required]
    [Column("STFieldEventFunctionParameterValue")]
    [StringLength(500)]
    [Unicode(false)]
    public string StfieldEventFunctionParameterValue { get; set; }

    [Required]
    [Column("STFieldEventFunctionParameterType")]
    [StringLength(255)]
    [Unicode(false)]
    public string StfieldEventFunctionParameterType { get; set; }

    [ForeignKey("StfieldEventFunctionId")]
    [InverseProperty("StfieldEventFunctionParameters")]
    public virtual StfieldEventFunction StfieldEventFunction { get; set; }
}
