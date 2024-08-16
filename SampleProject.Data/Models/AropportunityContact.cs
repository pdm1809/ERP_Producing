using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AROpportunityContacts")]
public partial class AropportunityContact
{
    [Key]
    [Column("AROpportunityContactID")]
    public long AropportunityContactId { get; set; }

    [Column("AACreatedDate")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("FK_AROpportunityID")]
    public long? FkAropportunityId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AAUpdatedDate")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ARCustomerContactID")]
    public int? FkArcustomerContactId { get; set; }

    [ForeignKey("FkArcustomerContactId")]
    [InverseProperty("AropportunityContacts")]
    public virtual ArcustomerContact FkArcustomerContact { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AropportunityContacts")]
    public virtual Brbranch FkBrbranch { get; set; }
}
