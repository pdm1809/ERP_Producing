using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRKPIEvaluationItemTargets")]
public partial class HrkpievaluationItemTarget
{
    [Key]
    [Column("HRKPIEvaluationItemTargetID")]
    public int HrkpievaluationItemTargetId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("HRKPIEvaluationItemTargetName")]
    [StringLength(256)]
    public string HrkpievaluationItemTargetName { get; set; }

    [Column("FK_HRKPIID")]
    public int? FkHrkpiid { get; set; }

    [Column("FK_HRKPIEvaluationID")]
    public int? FkHrkpievaluationId { get; set; }

    [Column("HRKPIEvaluationItemTargetToTalWeightBonus", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemTargetToTalWeightBonus { get; set; }

    [Column("HRKPIEvaluationItemTargetTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemTargetTotalAmount { get; set; }

    [Column("HRKPIEvaluationItemTargetTotalTarget", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemTargetTotalTarget { get; set; }

    [Column("HRKPIEvaluationItemTargetTotalResult", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemTargetTotalResult { get; set; }

    [ForeignKey("FkHrkpiid")]
    [InverseProperty("HrkpievaluationItemTargets")]
    public virtual Hrkpi FkHrkpi { get; set; }

    [ForeignKey("FkHrkpievaluationId")]
    [InverseProperty("HrkpievaluationItemTargets")]
    public virtual Hrkpievaluation FkHrkpievaluation { get; set; }
}
