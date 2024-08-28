using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerContactGroups")]
public partial class ArcustomerContactGroup
{
    [Key]
    [Column("ARCustomerContactGroupID")]
    public int ArcustomerContactGroupId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerContactID")]
    public int? FkArcustomerContactId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcustomerContactGroups")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArcustomerContactId")]
    [InverseProperty("ArcustomerContactGroups")]
    public virtual ArcustomerContact FkArcustomerContact { get; set; }
}
