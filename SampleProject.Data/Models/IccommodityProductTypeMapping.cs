using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICCommodityProductTypeMappings")]
public partial class IccommodityProductTypeMapping
{
    [Key]
    [Column("ICCommodityProductTypeMappingID")]
    public int IccommodityProductTypeMappingId { get; set; }

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

    [Column("ICCommodityType")]
    [StringLength(50)]
    public string IccommodityType { get; set; }

    [Column("ICProductType")]
    [StringLength(50)]
    public string IcproductType { get; set; }
}
