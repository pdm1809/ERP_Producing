using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderTemplates")]
public partial class ArsaleOrderTemplate
{
    [Key]
    [Column("ARSaleOrderTemplateID")]
    public int ArsaleOrderTemplateId { get; set; }

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

    [Column("FK_ARSaleOrderID")]
    public int FkArsaleOrderId { get; set; }

    [Column("ARSaleOrderTemplateName")]
    [StringLength(256)]
    public string ArsaleOrderTemplateName { get; set; }

    [Column("ARSaleOrderTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderTemplateStatus { get; set; }

    [Column("ARSaleOrderTemplateFileGUID")]
    [StringLength(256)]
    public string ArsaleOrderTemplateFileGuid { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderTemplates")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }
}
