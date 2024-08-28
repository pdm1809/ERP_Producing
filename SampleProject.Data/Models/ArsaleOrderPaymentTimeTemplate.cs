using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderPaymentTimeTemplates")]
public partial class ArsaleOrderPaymentTimeTemplate
{
    [Key]
    [Column("ARSaleOrderPaymentTimeTemplateID")]
    public int ArsaleOrderPaymentTimeTemplateId { get; set; }

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

    [Column("FK_ARSaleOrderPaymentTimeID")]
    public int FkArsaleOrderPaymentTimeId { get; set; }

    [Column("ARSaleOrderPaymentTimeTemplateName")]
    [StringLength(256)]
    public string ArsaleOrderPaymentTimeTemplateName { get; set; }

    [Column("ARSaleOrderPaymentTimeTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderPaymentTimeTemplateStatus { get; set; }

    [Column("ARSaleOrderPaymentTimeTemplateFileGUID")]
    [StringLength(256)]
    public string ArsaleOrderPaymentTimeTemplateFileGuid { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [ForeignKey("FkArsaleOrderPaymentTimeId")]
    [InverseProperty("ArsaleOrderPaymentTimeTemplates")]
    public virtual ArsaleOrderPaymentTime FkArsaleOrderPaymentTime { get; set; }
}
