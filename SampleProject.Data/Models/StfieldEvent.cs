using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldEvents")]
public partial class StfieldEvent
{
    [Key]
    [Column("STFieldEventID")]
    public int StfieldEventId { get; set; }

    [Column("STFieldID")]
    public int StfieldId { get; set; }

    [Required]
    [Column("STFieldEventName")]
    [StringLength(500)]
    [Unicode(false)]
    public string StfieldEventName { get; set; }

    [Required]
    [Column("STFieldEventDelegateFunctionName")]
    [StringLength(500)]
    [Unicode(false)]
    public string StfieldEventDelegateFunctionName { get; set; }

    [Required]
    [Column("STFieldEventDelegateFunctionFullName")]
    [StringLength(500)]
    [Unicode(false)]
    public string StfieldEventDelegateFunctionFullName { get; set; }

    [Required]
    [Column("STFieldEventDelegateFunctionClass")]
    [StringLength(500)]
    [Unicode(false)]
    public string StfieldEventDelegateFunctionClass { get; set; }

    [ForeignKey("StfieldId")]
    [InverseProperty("StfieldEvents")]
    public virtual Stfield Stfield { get; set; }

    [InverseProperty("StfieldEvent")]
    public virtual ICollection<StfieldEventFunction> StfieldEventFunctions { get; set; } = new List<StfieldEventFunction>();

    [InverseProperty("StfieldEvent")]
    public virtual ICollection<StfieldEventParameter> StfieldEventParameters { get; set; } = new List<StfieldEventParameter>();
}
