using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("AropportunityId", "Rev")]
[Table("AROpportunitys_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class AropportunitysHistory
{
    [Key]
    [Column("AROpportunityID")]
    public int AropportunityId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

    [Column("AROpportunityAmount", TypeName = "decimal(18, 5)")]
    public decimal? AropportunityAmount { get; set; }

    [Column("AROpportunityAssignedTo")]
    [StringLength(50)]
    public string AropportunityAssignedTo { get; set; }

    [Column("AROpportunityClassify")]
    [StringLength(100)]
    public string AropportunityClassify { get; set; }

    [Column("AROpportunityCompletionDate", TypeName = "datetime")]
    public DateTime? AropportunityCompletionDate { get; set; }

    [Column("AROpportunityContactName")]
    [StringLength(50)]
    public string AropportunityContactName { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("CreatedUserID")]
    public int? CreatedUserId { get; set; }

    [Column("AROpportunityCustomerName")]
    [StringLength(50)]
    public string AropportunityCustomerName { get; set; }

    [Column("AROpportunityDescription")]
    [StringLength(2000)]
    public string AropportunityDescription { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("AROpportunityExpectedValue", TypeName = "decimal(18, 5)")]
    public decimal? AropportunityExpectedValue { get; set; }

    [Column("AROpportunityName")]
    [StringLength(50)]
    public string AropportunityName { get; set; }

    [Column("AROpportunityPotentialSources")]
    [StringLength(100)]
    public string AropportunityPotentialSources { get; set; }

    [Column("AROpportunityProbability", TypeName = "decimal(18, 5)")]
    public decimal? AropportunityProbability { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AROpportunityStep")]
    [StringLength(100)]
    public string AropportunityStep { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("UpdatedUserID")]
    public int? UpdatedUserId { get; set; }

    [Column("ARCampaignID")]
    public int? ArcampaignId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ARCustomerResourceID")]
    public int? FkArcustomerResourceId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("AropportunitysHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
