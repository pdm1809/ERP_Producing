using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimesheetEmployeeLateConfigs")]
public partial class HrtimesheetEmployeeLateConfig
{
    [Key]
    [Column("HRTimesheetEmployeeLateConfigID")]
    public int HrtimesheetEmployeeLateConfigId { get; set; }

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

    [Column("HRTimesheetEmployeeLateConfigName")]
    [StringLength(50)]
    public string HrtimesheetEmployeeLateConfigName { get; set; }

    [Column("HRTimesheetEmployeeLateConfigTimeFrom")]
    public int? HrtimesheetEmployeeLateConfigTimeFrom { get; set; }

    [Column("HRTimesheetEmployeeLateConfigTimeTo")]
    public int? HrtimesheetEmployeeLateConfigTimeTo { get; set; }

    [Column("HRTimesheetEmployeeLateConfigOTTime")]
    public int? HrtimesheetEmployeeLateConfigOttime { get; set; }

    [Column("HRTimesheetEmployeeLateConfigDeduct", TypeName = "decimal(18, 5)")]
    public decimal? HrtimesheetEmployeeLateConfigDeduct { get; set; }

    [Column("HRTimesheetEmployeeLateConfigType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtimesheetEmployeeLateConfigType { get; set; }
}
