using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("AropportunityContactGroupId", "Rev")]
[Table("AROpportunityContactGroups_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class AropportunityContactGroupsHistory
{
    [Key]
    [Column("AROpportunityContactGroupID")]
    public int AropportunityContactGroupId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerContactID")]
    public int? FkArcustomerContactId { get; set; }

    [Column("FK_AROpportunityID")]
    public long? FkAropportunityId { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("AropportunityContactGroupsHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
