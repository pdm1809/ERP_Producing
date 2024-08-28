using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADCriterias")]
[Microsoft.EntityFrameworkCore.Index("AdcriteriaNo", Name = "Idx_ADCriterias")]
public partial class Adcriteria
{
    [Key]
    [Column("ADCriteriaID")]
    public int AdcriteriaId { get; set; }

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

    [Required]
    [Column("ADCriteriaNo")]
    [StringLength(50)]
    public string AdcriteriaNo { get; set; }

    [Required]
    [Column("ADCriteriaName")]
    [StringLength(50)]
    public string AdcriteriaName { get; set; }

    [Column("ADCriteriaDesc")]
    [StringLength(512)]
    public string AdcriteriaDesc { get; set; }

    [Column("FK_STModuleID")]
    public int FkStmoduleId { get; set; }

    [Column("FK_ADUserID")]
    public int FkAduserId { get; set; }

    [Column("ADCriteriaQueryString", TypeName = "ntext")]
    public string AdcriteriaQueryString { get; set; }

    [ForeignKey("FkAduserId")]
    [InverseProperty("Adcriteria")]
    public virtual Aduser FkAduser { get; set; }

    [ForeignKey("FkStmoduleId")]
    [InverseProperty("Adcriteria")]
    public virtual Stmodule FkStmodule { get; set; }
}
