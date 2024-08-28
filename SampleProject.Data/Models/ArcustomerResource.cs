using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerResources")]
public partial class ArcustomerResource
{
    [Key]
    [Column("ARCustomerResourceID")]
    public int ArcustomerResourceId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("ARCustomerResourceNo")]
    [StringLength(128)]
    public string ArcustomerResourceNo { get; set; }

    [Column("ARCustomerResourceName")]
    [StringLength(128)]
    public string ArcustomerResourceName { get; set; }

    [Column("ARCustomerResourceDesc")]
    [StringLength(256)]
    public string ArcustomerResourceDesc { get; set; }

    [InverseProperty("FkArcustomerResource")]
    public virtual ICollection<ArcustomerContact> ArcustomerContacts { get; set; } = new List<ArcustomerContact>();

    [InverseProperty("FkArcustomerResource")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkArcustomerResource")]
    public virtual ICollection<Aropportunity> Aropportunities { get; set; } = new List<Aropportunity>();

    [InverseProperty("FkArcustomerResource")]
    public virtual ICollection<ArprospectCustomer> ArprospectCustomers { get; set; } = new List<ArprospectCustomer>();
}
