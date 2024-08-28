using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleStatus")]
public partial class StmoduleStatus
{
    [Key]
    [Column("STModuleStatusID")]
    public int StmoduleStatusId { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("STUserID")]
    public int StuserId { get; set; }

    /// <summary>
    /// Open
    /// Close
    /// Hide
    /// </summary>
    [Required]
    [Column("STModuleStatusStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string StmoduleStatusStatus { get; set; }

    [Column("STModuleStatusCurrentObjectID")]
    public int StmoduleStatusCurrentObjectId { get; set; }

    [ForeignKey("StmoduleId")]
    [InverseProperty("StmoduleStatuses")]
    public virtual Stmodule Stmodule { get; set; }

    [InverseProperty("StmoduleStatus")]
    public virtual ICollection<StmoduleSearchField> StmoduleSearchFields { get; set; } = new List<StmoduleSearchField>();

    [ForeignKey("StuserId")]
    [InverseProperty("StmoduleStatuses")]
    public virtual Aduser Stuser { get; set; }
}
