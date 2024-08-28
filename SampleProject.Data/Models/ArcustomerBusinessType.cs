using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerBusinessTypes")]
public partial class ArcustomerBusinessType
{
    [Key]
    [Column("ARCustomerBusinessTypeID")]
    public int ArcustomerBusinessTypeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ARCustomerBusinessTypeNo")]
    [StringLength(64)]
    public string ArcustomerBusinessTypeNo { get; set; }

    [Column("ARCustomerBusinessTypeName")]
    [StringLength(256)]
    public string ArcustomerBusinessTypeName { get; set; }

    [Column("ARCustomerBusinessTypeAbbreviation")]
    [StringLength(50)]
    public string ArcustomerBusinessTypeAbbreviation { get; set; }

    [InverseProperty("FkArcustomerBusinessType")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();
}
