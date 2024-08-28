using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACSalaryDocumentTypePayRollDetails")]
public partial class AcsalaryDocumentTypePayRollDetail
{
    [Key]
    [Column("ACSalaryDocumentTypePayRollDetailID")]
    public int AcsalaryDocumentTypePayRollDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACSalaryDocumentTypeID")]
    public int? FkAcsalaryDocumentTypeId { get; set; }

    [Required]
    [Column("ACSalaryDocumentTypePayRollDetailName")]
    [StringLength(255)]
    [Unicode(false)]
    public string AcsalaryDocumentTypePayRollDetailName { get; set; }

    [Required]
    [Column("ACSalaryDocumentTypePayRollDetailCalculateType")]
    [StringLength(255)]
    public string AcsalaryDocumentTypePayRollDetailCalculateType { get; set; }

    [ForeignKey("FkAcsalaryDocumentTypeId")]
    [InverseProperty("AcsalaryDocumentTypePayRollDetails")]
    public virtual AcsalaryDocumentType FkAcsalaryDocumentType { get; set; }
}
