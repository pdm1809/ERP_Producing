using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerSaleOrderTypeConfigs")]
public partial class ArcustomerSaleOrderTypeConfig
{
    [Key]
    [Column("ARCustomerSaleOrderTypeConfigID")]
    public int ArcustomerSaleOrderTypeConfigId { get; set; }

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

    [Column("ARCustomerType")]
    [StringLength(128)]
    public string ArcustomerType { get; set; }

    [Column("ARSaleOrderType")]
    [StringLength(128)]
    public string ArsaleOrderType { get; set; }
}
