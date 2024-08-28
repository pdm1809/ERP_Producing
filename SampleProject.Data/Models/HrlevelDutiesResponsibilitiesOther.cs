using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLevelDutiesResponsibilitiesOthers")]
public partial class HrlevelDutiesResponsibilitiesOther
{
    [Key]
    [Column("HRLevelDutiesResponsibilitiesOthersID")]
    public int HrlevelDutiesResponsibilitiesOthersId { get; set; }

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

    [Column("HRLevelDutiesResponsibilitiesOtherOrder")]
    [StringLength(50)]
    public string HrlevelDutiesResponsibilitiesOtherOrder { get; set; }

    [Column("HRLevelDutiesResponsibilitiesOtherContent")]
    [StringLength(512)]
    public string HrlevelDutiesResponsibilitiesOtherContent { get; set; }

    [Column("HRLevelDutiesResponsibilitiesFrequency")]
    [StringLength(100)]
    public string HrlevelDutiesResponsibilitiesFrequency { get; set; }

    [Column("HRLevelDutiesResponsibilitiesOtherPercent")]
    [StringLength(100)]
    public string HrlevelDutiesResponsibilitiesOtherPercent { get; set; }

    [Column("HRLevelDutiesResponsibilitiesOtherEvaluationCriteria")]
    [StringLength(100)]
    public string HrlevelDutiesResponsibilitiesOtherEvaluationCriteria { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrlevelDutiesResponsibilitiesOthers")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
