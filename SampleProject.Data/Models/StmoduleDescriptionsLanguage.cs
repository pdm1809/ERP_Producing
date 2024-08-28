using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleDescriptionsLanguages")]
public partial class StmoduleDescriptionsLanguage
{
    [Key]
    [Column("STModuleDescriptionsLanguageID")]
    public int StmoduleDescriptionsLanguageId { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("STLanguageID")]
    public int StlanguageId { get; set; }

    [Required]
    [Column("STModuleDescriptionsLanguageDescription")]
    [StringLength(255)]
    public string StmoduleDescriptionsLanguageDescription { get; set; }
}
