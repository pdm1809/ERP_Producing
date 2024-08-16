using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleSearchFields")]
public partial class StmoduleSearchField
{
    [Key]
    [Column("STModuleSearchFieldID")]
    public int StmoduleSearchFieldId { get; set; }

    [Column("STModuleStatusID")]
    public int StmoduleStatusId { get; set; }

    [Required]
    [Column("STModuleSearchFieldName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StmoduleSearchFieldName { get; set; }

    [Column("STModuleSearchFieldValue")]
    [StringLength(255)]
    public string StmoduleSearchFieldValue { get; set; }

    [ForeignKey("StmoduleStatusId")]
    [InverseProperty("StmoduleSearchFields")]
    public virtual StmoduleStatus StmoduleStatus { get; set; }
}
