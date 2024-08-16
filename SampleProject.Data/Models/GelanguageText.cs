using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GELanguageText")]
public partial class GelanguageText
{
    [Key]
    [Column("GETextID")]
    public int GetextId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Required]
    [Column("GETextSearch")]
    [StringLength(50)]
    public string GetextSearch { get; set; }

    [Required]
    [Column("GELanguageTextTargetColumn")]
    [StringLength(50)]
    public string GelanguageTextTargetColumn { get; set; }

    [Column("GELanguageTextTargetID")]
    public int GelanguageTextTargetId { get; set; }

    [Column("GELanguageTextDesc")]
    [StringLength(500)]
    public string GelanguageTextDesc { get; set; }
}
