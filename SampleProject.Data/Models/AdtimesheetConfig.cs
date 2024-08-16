using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADTimesheetConfigs")]
public partial class AdtimesheetConfig
{
    [Key]
    [Column("ADTimesheetConfigID")]
    public int AdtimesheetConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADTimesheetConfigJan")]
    public int? AdtimesheetConfigJan { get; set; }

    [Column("ADTimesheetConfigFeb")]
    public int? AdtimesheetConfigFeb { get; set; }

    [Column("ADTimesheetConfigMar")]
    public int? AdtimesheetConfigMar { get; set; }

    [Column("ADTimesheetConfigApr")]
    public int? AdtimesheetConfigApr { get; set; }

    [Column("ADTimesheetConfigMay")]
    public int? AdtimesheetConfigMay { get; set; }

    [Column("ADTimesheetConfigJun")]
    public int? AdtimesheetConfigJun { get; set; }

    [Column("ADTimesheetConfigJul")]
    public int? AdtimesheetConfigJul { get; set; }

    [Column("ADTimesheetConfigAug")]
    public int? AdtimesheetConfigAug { get; set; }

    [Column("ADTimesheetConfigSep")]
    public int? AdtimesheetConfigSep { get; set; }

    [Column("ADTimesheetConfigOct")]
    public int? AdtimesheetConfigOct { get; set; }

    [Column("ADTimesheetConfigNov")]
    public int? AdtimesheetConfigNov { get; set; }

    [Column("ADTimesheetConfigDec")]
    public int? AdtimesheetConfigDec { get; set; }

    [Column("ADTimesheetConfigYear", TypeName = "date")]
    public DateTime? AdtimesheetConfigYear { get; set; }
}
