using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GETemplates")]
public partial class Getemplate
{
    [Key]
    [Column("GETemplateID")]
    public int GetemplateId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Required]
    [Column("GETemplateNo")]
    [StringLength(50)]
    public string GetemplateNo { get; set; }

    [Required]
    [Column("GETemplateName")]
    [StringLength(50)]
    public string GetemplateName { get; set; }

    [Column("GETemplateDesc")]
    [StringLength(512)]
    public string GetemplateDesc { get; set; }

    [Column("GETemplateType")]
    [StringLength(50)]
    [Unicode(false)]
    public string GetemplateType { get; set; }
}
