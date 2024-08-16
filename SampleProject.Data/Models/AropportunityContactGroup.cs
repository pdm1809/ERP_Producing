using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AROpportunityContactGroups")]
public partial class AropportunityContactGroup
{
    [Key]
    [Column("AROpportunityContactGroupID")]
    public int AropportunityContactGroupId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerContactID")]
    public int? FkArcustomerContactId { get; set; }

    [Column("FK_AROpportunityID")]
    public int? FkAropportunityId { get; set; }

    [ForeignKey("FkArcustomerContactId")]
    [InverseProperty("AropportunityContactGroups")]
    public virtual ArcustomerContact FkArcustomerContact { get; set; }

    [ForeignKey("FkAropportunityId")]
    [InverseProperty("AropportunityContactGroups")]
    public virtual Aropportunity FkAropportunity { get; set; }
}
