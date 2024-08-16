using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("REVINFO", Schema = "CRM_VINMUS_AUDIT")]
public partial class Revinfo
{
    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTSTMP")]
    public long? Revtstmp { get; set; }

    [InverseProperty("RevNavigation")]
    public virtual ICollection<AractivitysHistory> AractivitysHistories { get; set; } = new List<AractivitysHistory>();

    [InverseProperty("RevNavigation")]
    public virtual ICollection<ArcampaignsHistory> ArcampaignsHistories { get; set; } = new List<ArcampaignsHistory>();

    [InverseProperty("RevNavigation")]
    public virtual ICollection<ArcustomerContactGroupsHistory> ArcustomerContactGroupsHistories { get; set; } = new List<ArcustomerContactGroupsHistory>();

    [InverseProperty("RevNavigation")]
    public virtual ICollection<ArcustomerContactsHistory> ArcustomerContactsHistories { get; set; } = new List<ArcustomerContactsHistory>();

    [InverseProperty("RevNavigation")]
    public virtual ICollection<ArcustomersHistory> ArcustomersHistories { get; set; } = new List<ArcustomersHistory>();

    [InverseProperty("RevNavigation")]
    public virtual ICollection<AropportunityContactGroupsHistory> AropportunityContactGroupsHistories { get; set; } = new List<AropportunityContactGroupsHistory>();

    [InverseProperty("RevNavigation")]
    public virtual ICollection<AropportunitysHistory> AropportunitysHistories { get; set; } = new List<AropportunitysHistory>();

    [InverseProperty("RevNavigation")]
    public virtual ICollection<ArprospectCustomersHistory> ArprospectCustomersHistories { get; set; } = new List<ArprospectCustomersHistory>();

    [InverseProperty("RevNavigation")]
    public virtual ICollection<PmtaskAssignsHistory> PmtaskAssignsHistories { get; set; } = new List<PmtaskAssignsHistory>();

    [InverseProperty("RevNavigation")]
    public virtual ICollection<PmtasksHistory> PmtasksHistories { get; set; } = new List<PmtasksHistory>();
}
