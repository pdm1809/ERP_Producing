using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AAColumnAliasLanguages")]
public partial class AacolumnAliasLanguage
{
    [Key]
    [Column("AAColumnAliasLanguagesID")]
    public int AacolumnAliasLanguagesId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Required]
    [Column("AAColumnAliasLanguagesName")]
    [StringLength(255)]
    [Unicode(false)]
    public string AacolumnAliasLanguagesName { get; set; }

    [Required]
    [Column("AAColumnAliasLanguagesCaption")]
    [StringLength(255)]
    public string AacolumnAliasLanguagesCaption { get; set; }

    [Required]
    [Column("AATableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string AatableName { get; set; }
}
