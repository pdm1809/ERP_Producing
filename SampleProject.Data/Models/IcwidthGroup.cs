using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICWidthGroups")]
public partial class IcwidthGroup
{
    [Key]
    [Column("ICWidthGroupID")]
    public int IcwidthGroupId { get; set; }

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

    [Column("ICWidthGroupName")]
    [StringLength(100)]
    public string IcwidthGroupName { get; set; }

    [Column("ICWidthGroupMinValue", TypeName = "decimal(18, 5)")]
    public decimal? IcwidthGroupMinValue { get; set; }

    [Column("ICWidthGroupMaxValue", TypeName = "decimal(18, 5)")]
    public decimal? IcwidthGroupMaxValue { get; set; }

    [InverseProperty("FkIcwidthGroup")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();
}
