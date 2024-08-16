using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPriceCalculationMethods")]
public partial class IcpriceCalculationMethod
{
    [Key]
    [Column("ICPriceCalculationMethodID")]
    public int IcpriceCalculationMethodId { get; set; }

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

    [Column("ICPriceCalculationMethodNo")]
    [StringLength(64)]
    public string IcpriceCalculationMethodNo { get; set; }

    [Column("ICPriceCalculationMethodName")]
    [StringLength(256)]
    public string IcpriceCalculationMethodName { get; set; }

    [Column("ICPriceCalculationMethodMethod")]
    [StringLength(64)]
    public string IcpriceCalculationMethodMethod { get; set; }

    [Column("ICPriceCalculationMethodIsStock")]
    public bool? IcpriceCalculationMethodIsStock { get; set; }

    [Column("ICPriceCalculationMethodIsBranch")]
    public bool? IcpriceCalculationMethodIsBranch { get; set; }

    [Column("ICPriceCalculationMethodIsDefault")]
    public bool? IcpriceCalculationMethodIsDefault { get; set; }

    [InverseProperty("FkIcpriceCalculationMethod")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();
}
