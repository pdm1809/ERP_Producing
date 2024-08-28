using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRKPIRegistrationItemTargets")]
public partial class HrkpiregistrationItemTarget
{
    [Key]
    [Column("HRKPIRegistrationItemTargetID")]
    public int HrkpiregistrationItemTargetId { get; set; }

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

    [Column("HRKPIRegistrationItemTargetName")]
    [StringLength(256)]
    public string HrkpiregistrationItemTargetName { get; set; }

    [Column("FK_HRKPIID")]
    public int? FkHrkpiid { get; set; }

    [Column("FK_HRKPIRegistrationID")]
    public int? FkHrkpiregistrationId { get; set; }

    [Column("HRKPIRegistrationItemTargetToTalWeightBonus", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiregistrationItemTargetToTalWeightBonus { get; set; }

    [Column("HRKPIRegistrationItemTargetTotalTarget", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiregistrationItemTargetTotalTarget { get; set; }

    [ForeignKey("FkHrkpiid")]
    [InverseProperty("HrkpiregistrationItemTargets")]
    public virtual Hrkpi FkHrkpi { get; set; }

    [ForeignKey("FkHrkpiregistrationId")]
    [InverseProperty("HrkpiregistrationItemTargets")]
    public virtual Hrkpiregistration FkHrkpiregistration { get; set; }
}
