using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAnnualLeaveDayConfigs")]
public partial class HrannualLeaveDayConfig
{
    [Key]
    [Column("HRAnnualLeaveDayConfigID")]
    public int HrannualLeaveDayConfigId { get; set; }

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

    [Column("HRAnnualLeaveDayConfigNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrannualLeaveDayConfigNo { get; set; }

    [Column("HRAnnualLeaveDayConfigName")]
    [StringLength(100)]
    public string HrannualLeaveDayConfigName { get; set; }

    [Column("HRAnnualLeaveDayConfigDate", TypeName = "datetime")]
    public DateTime? HrannualLeaveDayConfigDate { get; set; }

    [Column("HRAnnualLeaveDayConfigQty", TypeName = "decimal(18, 5)")]
    public decimal? HrannualLeaveDayConfigQty { get; set; }

    [Column("HRAnnualLeaveDayConfigExpiryDate", TypeName = "decimal(18, 5)")]
    public decimal? HrannualLeaveDayConfigExpiryDate { get; set; }

    [Column("HRAnnualLeaveDayConfigAdditionalLastYear")]
    public bool? HrannualLeaveDayConfigAdditionalLastYear { get; set; }

    [Column("HRAnnualLeaveDayConfigAdditionalSeniority")]
    public bool? HrannualLeaveDayConfigAdditionalSeniority { get; set; }
}
