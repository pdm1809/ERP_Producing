using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADReportTemplates")]
public partial class AdreportTemplate
{
    [Key]
    [Column("ADReportTemplateID")]
    public int AdreportTemplateId { get; set; }

    [Column("FK_ADReportID")]
    public int? FkAdreportId { get; set; }

    [Column("FK_ADTemplateID")]
    public int? FkAdtemplateId { get; set; }
}
