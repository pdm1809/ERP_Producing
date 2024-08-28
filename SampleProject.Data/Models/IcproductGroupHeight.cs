using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductGroupHeights")]
public partial class IcproductGroupHeight
{
    [Key]
    [Column("ICProductGroupHeightID")]
    public int IcproductGroupHeightId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ICProductGroupHeightName")]
    [StringLength(256)]
    public string IcproductGroupHeightName { get; set; }

    [Required]
    [Column("ICProductGroupHeightDesc")]
    [StringLength(512)]
    public string IcproductGroupHeightDesc { get; set; }

    [Column("ICProductGroupHeightMinValue", TypeName = "decimal(18, 5)")]
    public decimal? IcproductGroupHeightMinValue { get; set; }

    [Column("ICProductGroupHeightMaxValue", TypeName = "decimal(18, 5)")]
    public decimal? IcproductGroupHeightMaxValue { get; set; }

    [InverseProperty("FkIcproductGroupHeight")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();
}
