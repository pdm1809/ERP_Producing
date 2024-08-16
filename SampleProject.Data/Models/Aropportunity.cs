using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AROpportunitys")]
public partial class Aropportunity
{
    [Key]
    [Column("AROpportunityID")]
    public int AropportunityId { get; set; }

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

    [Required]
    [Column("AROpportunityName")]
    [StringLength(50)]
    public string AropportunityName { get; set; }

    [Column("AROpportunityPotentialSources")]
    [StringLength(100)]
    public string AropportunityPotentialSources { get; set; }

    [Column("AROpportunityProbability", TypeName = "decimal(18, 5)")]
    public decimal? AropportunityProbability { get; set; }

    [Column("REV")]
    public int? Rev { get; set; }

    [Column("REVTYPE")]
    public int? Revtype { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARCampaignID")]
    public int? ArcampaignId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    public bool IsShare { get; set; }

    [Column("FK_ARCustomerResourceID")]
    public int? FkArcustomerResourceId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("ArcampaignId")]
    [InverseProperty("Aropportunities")]
    public virtual Arcampaign Arcampaign { get; set; }

    [InverseProperty("FkAropportunity")]
    public virtual ICollection<AropportunityContactGroup> AropportunityContactGroups { get; set; } = new List<AropportunityContactGroup>();

    [InverseProperty("FkAropportunity")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkAropportunity")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkAropportunity")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("Aropportunities")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Aropportunities")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArcustomerResourceId")]
    [InverseProperty("Aropportunities")]
    public virtual ArcustomerResource FkArcustomerResource { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Aropportunities")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Aropportunities")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("Aropportunities")]
    public virtual Hrgroup FkHrgroup { get; set; }
}
