using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldLanguages")]
public partial class StfieldLanguage
{
    [Key]
    [Column("STFieldLanguageID")]
    public int StfieldLanguageId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Column("STScreenID")]
    public int? StscreenId { get; set; }

    [Column("STFieldName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldName { get; set; }

    [Column("STFieldText")]
    [StringLength(255)]
    public string StfieldText { get; set; }
}
