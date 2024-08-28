using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCampaigns")]
public partial class Arcampaign
{
    [Key]
    [Column("ARCampaignID")]
    public int ArcampaignId { get; set; }

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

    [Required]
    [Column("ARCampaignName")]
    [StringLength(50)]
    public string ArcampaignName { get; set; }

    [Column("REV")]
    public int? Rev { get; set; }

    [Column("REVTYPE")]
    public int? Revtype { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARCampaignNumber")]
    [StringLength(100)]
    [Unicode(false)]
    public string ArcampaignNumber { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [InverseProperty("Arcampaign")]
    public virtual ICollection<Aropportunity> Aropportunities { get; set; } = new List<Aropportunity>();

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("Arcampaigns")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Arcampaigns")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Arcampaigns")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("Arcampaigns")]
    public virtual Hrgroup FkHrgroup { get; set; }
}
