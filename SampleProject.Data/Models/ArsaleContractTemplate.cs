using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleContractTemplates")]
public partial class ArsaleContractTemplate
{
    [Key]
    [Column("ARSaleContractTemplateID")]
    public int ArsaleContractTemplateId { get; set; }

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

    [Column("FK_ARSaleContractID")]
    public int FkArsaleContractId { get; set; }

    [Column("ARSaleContractTemplateName")]
    [StringLength(256)]
    public string ArsaleContractTemplateName { get; set; }

    [Column("ARSaleContractTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleContractTemplateStatus { get; set; }

    [Column("ARSaleContractTemplateFileGUID")]
    [StringLength(256)]
    public string ArsaleContractTemplateFileGuid { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArsaleContractTemplates")]
    public virtual ArsaleContract FkArsaleContract { get; set; }
}
