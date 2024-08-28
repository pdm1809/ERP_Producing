using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleForecastTemplates")]
public partial class ArsaleForecastTemplate
{
    [Key]
    [Column("ARSaleForecastTemplateID")]
    public int ArsaleForecastTemplateId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleForecastID")]
    public int FkArsaleForecastId { get; set; }

    [Column("ARSaleForecastTemplateName")]
    [StringLength(256)]
    public string ArsaleForecastTemplateName { get; set; }

    [Column("ARSaleForecastTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastTemplateStatus { get; set; }

    [ForeignKey("FkArsaleForecastId")]
    [InverseProperty("ArsaleForecastTemplates")]
    public virtual ArsaleForecast FkArsaleForecast { get; set; }
}
