using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleDescriptions")]
public partial class StmoduleDescription
{
    [Key]
    [Column("STModuleDescriptionID")]
    public int StmoduleDescriptionId { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("STLanguageID")]
    public int StlanguageId { get; set; }

    [Required]
    [Column("STModuleDescriptionDescription")]
    [StringLength(255)]
    public string StmoduleDescriptionDescription { get; set; }

    [ForeignKey("StlanguageId")]
    [InverseProperty("StmoduleDescriptions")]
    public virtual Gelanguage Stlanguage { get; set; }

    [ForeignKey("StmoduleId")]
    [InverseProperty("StmoduleDescriptions")]
    public virtual Stmodule Stmodule { get; set; }
}
