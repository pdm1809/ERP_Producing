using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADTemplates")]
public partial class Adtemplate
{
    [Key]
    [Column("ADTemplateID")]
    public int AdtemplateId { get; set; }

    [Column("ADTemplateNo")]
    [StringLength(50)]
    public string AdtemplateNo { get; set; }

    [Column("ADTemplateName")]
    [StringLength(100)]
    public string AdtemplateName { get; set; }

    [Column("ADTemplateDesc")]
    [StringLength(512)]
    public string AdtemplateDesc { get; set; }

    [Column("ADTemplateStoreProc")]
    [StringLength(256)]
    public string AdtemplateStoreProc { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADTemplateDataSource")]
    [StringLength(100)]
    public string AdtemplateDataSource { get; set; }

    [Column("ADTemplateAutoLoad")]
    public bool? AdtemplateAutoLoad { get; set; }

    [Column("ADTemplatePrintStoreProc")]
    [StringLength(512)]
    public string AdtemplatePrintStoreProc { get; set; }

    [InverseProperty("FkAdtemplate")]
    public virtual ICollection<AdtemplateParam> AdtemplateParams { get; set; } = new List<AdtemplateParam>();
}
