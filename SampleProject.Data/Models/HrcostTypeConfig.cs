using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRCostTypeConfigs")]
public partial class HrcostTypeConfig
{
    [Key]
    [Column("HRCostTypeConfigID")]
    public int HrcostTypeConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("HRCostTypeConfigNo")]
    [StringLength(50)]
    public string HrcostTypeConfigNo { get; set; }

    [Required]
    [Column("HRCostTypeConfigName")]
    [StringLength(256)]
    public string HrcostTypeConfigName { get; set; }

    [Column("HRCostTypeConfigDesc")]
    [StringLength(512)]
    public string HrcostTypeConfigDesc { get; set; }

    [InverseProperty("FkHrcostTypeConfig")]
    public virtual ICollection<HrworkingFeeConfig> HrworkingFeeConfigs { get; set; } = new List<HrworkingFeeConfig>();
}
