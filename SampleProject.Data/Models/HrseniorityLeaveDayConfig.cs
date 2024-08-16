using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRSeniorityLeaveDayConfigs")]
public partial class HrseniorityLeaveDayConfig
{
    [Key]
    [Column("HRSeniorityLeaveDayConfigID")]
    public int HrseniorityLeaveDayConfigId { get; set; }

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

    [Column("HRSeniorityLeaveDayConfigNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrseniorityLeaveDayConfigNo { get; set; }

    [Column("HRSeniorityLeaveDayConfigName")]
    [StringLength(100)]
    public string HrseniorityLeaveDayConfigName { get; set; }

    [Column("HRSeniorityLeaveDayConfigFrom", TypeName = "decimal(18, 5)")]
    public decimal? HrseniorityLeaveDayConfigFrom { get; set; }

    [Column("HRSeniorityLeaveDayConfigTo", TypeName = "decimal(18, 5)")]
    public decimal? HrseniorityLeaveDayConfigTo { get; set; }

    [Column("HRSeniorityLeaveDayConfigQty", TypeName = "decimal(18, 5)")]
    public decimal? HrseniorityLeaveDayConfigQty { get; set; }
}
