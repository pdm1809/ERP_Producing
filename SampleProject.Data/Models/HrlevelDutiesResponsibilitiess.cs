using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLevelDutiesResponsibilitiess")]
public partial class HrlevelDutiesResponsibilitiess
{
    [Key]
    [Column("HRLevelDutiesResponsibilitiessID")]
    public int HrlevelDutiesResponsibilitiessId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("HRLevelDutiesResponsibilitiesOrder")]
    [StringLength(50)]
    public string HrlevelDutiesResponsibilitiesOrder { get; set; }

    [Column("HRLevelDutiesResponsibilitiesContent")]
    [StringLength(512)]
    public string HrlevelDutiesResponsibilitiesContent { get; set; }

    [Column("HRLevelDutiesResponsibilitiesFrequency")]
    [StringLength(100)]
    public string HrlevelDutiesResponsibilitiesFrequency { get; set; }

    [Column("HRLevelDutiesResponsibilitiesPercent")]
    [StringLength(100)]
    public string HrlevelDutiesResponsibilitiesPercent { get; set; }

    [Column("HRLevelDutiesResponsibilitiesEvaluationCriteria")]
    [StringLength(100)]
    public string HrlevelDutiesResponsibilitiesEvaluationCriteria { get; set; }

    [Column("HRLevelDutiesResponsibilitiesType")]
    [StringLength(50)]
    public string HrlevelDutiesResponsibilitiesType { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrlevelDutiesResponsibilitiesses")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
