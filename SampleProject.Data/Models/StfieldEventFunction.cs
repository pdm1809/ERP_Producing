using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldEventFunctions")]
public partial class StfieldEventFunction
{
    [Key]
    [Column("STFieldEventFunctionID")]
    public int StfieldEventFunctionId { get; set; }

    [Column("STFieldEventID")]
    public int StfieldEventId { get; set; }

    [Required]
    [Column("STFieldEventFunctionName")]
    [StringLength(255)]
    [Unicode(false)]
    public string StfieldEventFunctionName { get; set; }

    [Required]
    [Column("STFieldEventFunctionFullName")]
    [StringLength(500)]
    [Unicode(false)]
    public string StfieldEventFunctionFullName { get; set; }

    [Required]
    [Column("STFieldEventFunctionClass")]
    [StringLength(255)]
    [Unicode(false)]
    public string StfieldEventFunctionClass { get; set; }

    [Column("STFieldEventFunctionSortOrder")]
    public int StfieldEventFunctionSortOrder { get; set; }

    [ForeignKey("StfieldEventId")]
    [InverseProperty("StfieldEventFunctions")]
    public virtual StfieldEvent StfieldEvent { get; set; }

    [InverseProperty("StfieldEventFunction")]
    public virtual ICollection<StfieldEventFunctionParameter> StfieldEventFunctionParameters { get; set; } = new List<StfieldEventFunctionParameter>();
}
