using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceTemplates")]
public partial class ArinvoiceTemplate
{
    [Key]
    [Column("ARInvoiceTemplateID")]
    public int ArinvoiceTemplateId { get; set; }

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

    [Column("FK_ARInvoiceID")]
    public int FkArinvoiceId { get; set; }

    [Column("ARInvoiceTemplateName")]
    [StringLength(256)]
    public string ArinvoiceTemplateName { get; set; }

    [Column("ARInvoiceTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceTemplateStatus { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArinvoiceTemplates")]
    public virtual Arinvoice FkArinvoice { get; set; }
}
