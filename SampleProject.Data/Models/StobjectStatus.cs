using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STObjectStatus")]
public partial class StobjectStatus
{
    [Key]
    [Column("STObjectStatusID")]
    public int StobjectStatusId { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Required]
    [Column("STObjectStatusName")]
    [StringLength(255)]
    [Unicode(false)]
    public string StobjectStatusName { get; set; }

    [ForeignKey("StmoduleId")]
    [InverseProperty("StobjectStatuses")]
    public virtual Stmodule Stmodule { get; set; }
}
