using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADReportLanguages")]
public partial class AdreportLanguage
{
    [Key]
    [Column("ADReportLanguageID")]
    public int AdreportLanguageId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GELanguageID")]
    public int FkGelanguageId { get; set; }

    [Required]
    [Column("ADReportNo")]
    [StringLength(50)]
    public string AdreportNo { get; set; }

    [Column("ADReportLanguageDesc")]
    [StringLength(512)]
    public string AdreportLanguageDesc { get; set; }

    [Column("ADReportSection")]
    [StringLength(50)]
    public string AdreportSection { get; set; }
}
