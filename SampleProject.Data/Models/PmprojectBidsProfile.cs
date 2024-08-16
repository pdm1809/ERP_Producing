using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectBidsProfiles")]
public partial class PmprojectBidsProfile
{
    [Key]
    [Column("PMProjectBidsProfileID")]
    public int PmprojectBidsProfileId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("PMProjectProfileNo")]
    [StringLength(50)]
    public string PmprojectProfileNo { get; set; }

    [Column("PMProjectProfileName")]
    [StringLength(50)]
    public string PmprojectProfileName { get; set; }

    [Column("PMProjectProfileDesc")]
    [StringLength(255)]
    public string PmprojectProfileDesc { get; set; }

    [Column("PMProjectProfileRemark")]
    [StringLength(500)]
    public string PmprojectProfileRemark { get; set; }

    [Column("PMProjectProfileInfo", TypeName = "ntext")]
    public string PmprojectProfileInfo { get; set; }

    [Column("PMProjectProfileActiveCheck")]
    public bool? PmprojectProfileActiveCheck { get; set; }

    [Column("PMProjectProfileMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode01Combo { get; set; }

    [Column("PMProjectProfileMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode02Combo { get; set; }

    [Column("PMProjectProfileMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode03Combo { get; set; }

    [Column("PMProjectProfileMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode04Combo { get; set; }

    [Column("PMProjectProfileMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode05Combo { get; set; }

    [Column("PMProjectProfileMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode06Combo { get; set; }

    [Column("PMProjectProfileMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode07Combo { get; set; }

    [Column("PMProjectProfileMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode08Combo { get; set; }

    [Column("PMProjectProfileMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode09Combo { get; set; }

    [Column("PMProjectProfileMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode10Combo { get; set; }

    [Column("PMProjectProfileMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode11Combo { get; set; }

    [Column("PMProjectProfileMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectProfileMatchCode12Combo { get; set; }

    [Column("PMProjectProfileTotalEstimatedDays")]
    public int? PmprojectProfileTotalEstimatedDays { get; set; }

    [Column("PMProjectProfileTotalActualDays")]
    public int? PmprojectProfileTotalActualDays { get; set; }

    [Column("PMProjectProfileTotalEstimatedHours")]
    public int? PmprojectProfileTotalEstimatedHours { get; set; }

    [Column("PMProjectProfileTotalActualHours")]
    public int? PmprojectProfileTotalActualHours { get; set; }

    [Column("PMProjectProfileEstimatedExtendDays")]
    public int? PmprojectProfileEstimatedExtendDays { get; set; }

    [Column("PMProjectProfileActualExtendDays")]
    public int? PmprojectProfileActualExtendDays { get; set; }

    [Column("PMProjectProfileEstimatedExtendHours")]
    public int? PmprojectProfileEstimatedExtendHours { get; set; }

    [Column("PMProjectProfileActualExtendHours")]
    public int? PmprojectProfileActualExtendHours { get; set; }

    [Column("PMProjectProfileEstimatedTotalCost", TypeName = "decimal(18, 0)")]
    public decimal? PmprojectProfileEstimatedTotalCost { get; set; }

    [Column("PMProjectProfileActualTotalCost", TypeName = "decimal(18, 0)")]
    public decimal? PmprojectProfileActualTotalCost { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmprojectBidsProfiles")]
    public virtual Pmproject FkPmproject { get; set; }
}
