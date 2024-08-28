using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADTemplateToolbars")]
public partial class AdtemplateToolbar
{
    [Key]
    [Column("ADTemplateToolbarID")]
    public int AdtemplateToolbarId { get; set; }

    [Column("FK_ADTemplateID")]
    public int? FkAdtemplateId { get; set; }

    [Column("FK_STToolbarID")]
    public int? FkSttoolbarId { get; set; }
}
