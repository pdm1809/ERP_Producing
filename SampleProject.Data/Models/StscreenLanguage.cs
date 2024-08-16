using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STScreenLanguages")]
public partial class StscreenLanguage
{
    [Key]
    [Column("STScreenLanguageID")]
    public int StscreenLanguageId { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Column("STScreeNumber")]
    [StringLength(100)]
    [Unicode(false)]
    public string StscreeNumber { get; set; }

    [Column("STScreenText")]
    [StringLength(255)]
    public string StscreenText { get; set; }
}
