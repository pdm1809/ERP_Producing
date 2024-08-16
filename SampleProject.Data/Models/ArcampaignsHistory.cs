using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("ArcampaignId", "Rev")]
[Table("ARCampaigns_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class ArcampaignsHistory
{
    [Key]
    [Column("ARCampaignID")]
    public int ArcampaignId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

    [Column("ARCampaignActualResults", TypeName = "decimal(18, 5)")]
    public decimal? ArcampaignActualResults { get; set; }

    [Column("ARCampaignActualRevenue", TypeName = "decimal(18, 5)")]
    public decimal? ArcampaignActualRevenue { get; set; }

    [Column("ARCampaignAssignedTo")]
    [StringLength(50)]
    public string ArcampaignAssignedTo { get; set; }

    [Column("ARCampaignBudget", TypeName = "decimal(18, 5)")]
    public decimal? ArcampaignBudget { get; set; }

    [Column("ARCampaignObject")]
    [StringLength(200)]
    public string ArcampaignObject { get; set; }

    [Column("ARCampaignStatus")]
    [StringLength(100)]
    public string ArcampaignStatus { get; set; }

    [Column("ARCampaignCompletionDate", TypeName = "datetime")]
    public DateTime? ArcampaignCompletionDate { get; set; }

    [Column("ARCampaignActualCosts", TypeName = "decimal(18, 5)")]
    public decimal? ArcampaignActualCosts { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("CreatedUserID")]
    public int? CreatedUserId { get; set; }

    [Column("ARCampaignDescription")]
    [StringLength(2000)]
    public string ArcampaignDescription { get; set; }

    [Column("ARCampaignDonor")]
    [StringLength(100)]
    public string ArcampaignDonor { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ARCampaignExpectedNumber")]
    public int? ArcampaignExpectedNumber { get; set; }

    [Column("ARCampaignExpectedResults", TypeName = "decimal(18, 5)")]
    public decimal? ArcampaignExpectedResults { get; set; }

    [Column("ARCampaignExpectedRevenue", TypeName = "decimal(18, 5)")]
    public decimal? ArcampaignExpectedRevenue { get; set; }

    [Column("ARCampaignGoals")]
    [StringLength(200)]
    public string ArcampaignGoals { get; set; }

    [Column("ARCampaignName")]
    [StringLength(50)]
    public string ArcampaignName { get; set; }

    [Column("ARCampaignStartDate", TypeName = "datetime")]
    public DateTime? ArcampaignStartDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARCampaignType")]
    [StringLength(100)]
    public string ArcampaignType { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("UpdatedUserID")]
    public int? UpdatedUserId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("ArcampaignsHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
