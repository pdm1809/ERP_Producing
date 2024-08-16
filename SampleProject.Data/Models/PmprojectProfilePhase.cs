using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectProfilePhases")]
[Microsoft.EntityFrameworkCore.Index("PmprojectProfilePhaseNo", "FkPmprojectProfileId", Name = "Idx_PMProjectProfilePhases")]
public partial class PmprojectProfilePhase
{
    [Key]
    [Column("PMProjectProfilePhaseID")]
    public int PmprojectProfilePhaseId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("PMProjectProfilePhaseNo")]
    [StringLength(50)]
    public string PmprojectProfilePhaseNo { get; set; }

    [Column("PMProjectProfilePhaseName")]
    [StringLength(50)]
    public string PmprojectProfilePhaseName { get; set; }

    [Column("PMProjectProfilePhaseDesc")]
    [StringLength(255)]
    public string PmprojectProfilePhaseDesc { get; set; }

    [Column("PMProjectProfilePhaseRemark")]
    [StringLength(500)]
    public string PmprojectProfilePhaseRemark { get; set; }

    [Column("FK_PMProjectProfileID")]
    public int FkPmprojectProfileId { get; set; }

    [Column("FK_PMPhaseTypeID")]
    public int FkPmphaseTypeId { get; set; }

    [Column("PMProjectProfilePhaseEstimatedTotalDays")]
    public int? PmprojectProfilePhaseEstimatedTotalDays { get; set; }

    [Column("PMProjectProfilePhaseActualTotalDays")]
    public int? PmprojectProfilePhaseActualTotalDays { get; set; }

    [Column("PMProjectProfilePhaseEstimatedTotalHours")]
    public int? PmprojectProfilePhaseEstimatedTotalHours { get; set; }

    [Column("PMProjectProfilePhaseActualTotalHours")]
    public int? PmprojectProfilePhaseActualTotalHours { get; set; }

    [Column("PMProjectProfilePhaseEstimatedExtendDays")]
    public int? PmprojectProfilePhaseEstimatedExtendDays { get; set; }

    [Column("PMProjectProfilePhaseActualExtendDays")]
    public int? PmprojectProfilePhaseActualExtendDays { get; set; }

    [Column("PMProjectProfilePhaseEstimatedExtendHours")]
    public int? PmprojectProfilePhaseEstimatedExtendHours { get; set; }

    [Column("PMProjectProfilePhaseActualExtendHours")]
    public int? PmprojectProfilePhaseActualExtendHours { get; set; }

    [Column("PMProjectProfilePhaseEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseEstimatedTotalCost { get; set; }

    [Column("PMProjectProfilePhaseActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseActualTotalCost { get; set; }
}
