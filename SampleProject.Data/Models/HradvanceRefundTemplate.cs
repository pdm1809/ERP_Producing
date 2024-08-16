using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAdvanceRefundTemplates")]
public partial class HradvanceRefundTemplate
{
    [Key]
    [Column("HRAdvanceRefundTemplateID")]
    public int HradvanceRefundTemplateId { get; set; }

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

    [Column("FK_HRAdvanceRefundID")]
    public int FkHradvanceRefundId { get; set; }

    [Column("HRAdvanceRefundTemplateName")]
    [StringLength(256)]
    public string HradvanceRefundTemplateName { get; set; }

    [Column("HRAdvanceRefundTemplateFileGUID")]
    [StringLength(256)]
    public string HradvanceRefundTemplateFileGuid { get; set; }

    [ForeignKey("FkHradvanceRefundId")]
    [InverseProperty("HradvanceRefundTemplates")]
    public virtual HradvanceRefund FkHradvanceRefund { get; set; }
}
