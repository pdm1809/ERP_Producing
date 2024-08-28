using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STToolbarLanguages")]
public partial class SttoolbarLanguage
{
    [Key]
    [Column("STToolbarLanguageID")]
    public int SttoolbarLanguageId { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Required]
    [Column("STToolbarName")]
    [StringLength(100)]
    public string SttoolbarName { get; set; }

    [Required]
    [Column("STToolbarCaption")]
    [StringLength(100)]
    public string SttoolbarCaption { get; set; }
}
