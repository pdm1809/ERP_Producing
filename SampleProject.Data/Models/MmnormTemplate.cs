using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMNormTemplates")]
public partial class MmnormTemplate
{
    [Key]
    [Column("MMNormTemplateID")]
    public int MmnormTemplateId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Required]
    [Column("MMNormTemplateNo")]
    [StringLength(50)]
    public string MmnormTemplateNo { get; set; }

    [Column("MMNormTemplateDate", TypeName = "datetime")]
    public DateTime? MmnormTemplateDate { get; set; }

    [Column("MMNormTemplateDesc")]
    [StringLength(512)]
    public string MmnormTemplateDesc { get; set; }

    [Column("MMNormTemplateType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmnormTemplateType { get; set; }

    [Column("MMNormTemplateIsStruct")]
    public bool? MmnormTemplateIsStruct { get; set; }

    [Column("MMNormTemplateStatus")]
    [StringLength(50)]
    public string MmnormTemplateStatus { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmnormTemplates")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkMmnormTemplate")]
    public virtual ICollection<MmnormTemplateItem> MmnormTemplateItems { get; set; } = new List<MmnormTemplateItem>();

    [InverseProperty("FkMmnormTemplate")]
    public virtual ICollection<MmnormTemplateProduct> MmnormTemplateProducts { get; set; } = new List<MmnormTemplateProduct>();
}
