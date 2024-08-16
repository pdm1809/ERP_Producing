using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerInfoContacts")]
public partial class ArcustomerInfoContact
{
    [Key]
    [Column("ARCustomerInfoContactID")]
    public int ArcustomerInfoContactId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("ARCustomerInfoContactSupplierAddress")]
    [StringLength(512)]
    public string ArcustomerInfoContactSupplierAddress { get; set; }

    [Column("ARCustomerInfoContactSupplierPhone")]
    [StringLength(50)]
    public string ArcustomerInfoContactSupplierPhone { get; set; }

    [Column("ARCustomerInfoContactCheck")]
    public bool? ArcustomerInfoContactCheck { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ARCustomerInfoContactSupplierName")]
    [StringLength(100)]
    public string ArcustomerInfoContactSupplierName { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("ARCustomerInfoContactCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerInfoContactCommissionPercent { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcustomerInfoContacts")]
    public virtual Arcustomer FkArcustomer { get; set; }
}
