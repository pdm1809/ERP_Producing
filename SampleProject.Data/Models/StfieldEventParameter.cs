using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldEventParameters")]
public partial class StfieldEventParameter
{
    [Key]
    [Column("STFieldEventParameterID")]
    public int StfieldEventParameterId { get; set; }

    [Column("STFieldEventID")]
    public int StfieldEventId { get; set; }

    [Required]
    [Column("STFieldEventParameterName")]
    [StringLength(500)]
    [Unicode(false)]
    public string StfieldEventParameterName { get; set; }

    [Required]
    [Column("STFieldEventParameterValue")]
    [StringLength(500)]
    [Unicode(false)]
    public string StfieldEventParameterValue { get; set; }

    [ForeignKey("StfieldEventId")]
    [InverseProperty("StfieldEventParameters")]
    public virtual StfieldEvent StfieldEvent { get; set; }
}
