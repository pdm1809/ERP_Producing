using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEVATs")]
[Microsoft.EntityFrameworkCore.Index("Gevatno", Name = "Idx_GEVATs")]
public partial class Gevat
{
    [Key]
    [Column("GEVATID")]
    public int Gevatid { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("GEVATNo")]
    [StringLength(50)]
    public string Gevatno { get; set; }

    [Required]
    [Column("GEVATName")]
    [StringLength(50)]
    public string Gevatname { get; set; }

    [Column("GEVATPercentValue", TypeName = "decimal(18, 5)")]
    public decimal? GevatpercentValue { get; set; }

    [InverseProperty("FkGevat")]
    public virtual ICollection<IcproductGroup> IcproductGroups { get; set; } = new List<IcproductGroup>();

    [InverseProperty("FkGevat")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();
}
