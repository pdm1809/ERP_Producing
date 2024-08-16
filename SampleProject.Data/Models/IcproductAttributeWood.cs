using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductAttributeWoods")]
public partial class IcproductAttributeWood
{
    [Key]
    [Column("ICProductAttributeWoodID")]
    public int IcproductAttributeWoodId { get; set; }

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

    [Column("ICProductAttributeWoodName")]
    [StringLength(100)]
    public string IcproductAttributeWoodName { get; set; }

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Column("ICProductAttributeWoodthick", TypeName = "decimal(18, 5)")]
    public decimal? IcproductAttributeWoodthick { get; set; }

    [Column("ICProductAttributeWoodTime", TypeName = "decimal(18, 5)")]
    public decimal? IcproductAttributeWoodTime { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("IcproductAttributeWoods")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }
}
