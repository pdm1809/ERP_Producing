using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimesheetConfigs")]
public partial class HrtimesheetConfig
{
    [Key]
    [Column("HRTimesheetConfigID")]
    public int HrtimesheetConfigId { get; set; }

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

    [Column("FK_HRTimesheetGroupID")]
    public int? FkHrtimesheetGroupId { get; set; }

    [Column("HRTimesheetConfigJan")]
    public int? HrtimesheetConfigJan { get; set; }

    [Column("HRTimesheetConfigFeb")]
    public int? HrtimesheetConfigFeb { get; set; }

    [Column("HRTimesheetConfigMar")]
    public int? HrtimesheetConfigMar { get; set; }

    [Column("HRTimesheetConfigApr")]
    public int? HrtimesheetConfigApr { get; set; }

    [Column("HRTimesheetConfigMay")]
    public int? HrtimesheetConfigMay { get; set; }

    [Column("HRTimesheetConfigJun")]
    public int? HrtimesheetConfigJun { get; set; }

    [Column("HRTimesheetConfigJul")]
    public int? HrtimesheetConfigJul { get; set; }

    [Column("HRTimesheetConfigAug")]
    public int? HrtimesheetConfigAug { get; set; }

    [Column("HRTimesheetConfigSep")]
    public int? HrtimesheetConfigSep { get; set; }

    [Column("HRTimesheetConfigOct")]
    public int? HrtimesheetConfigOct { get; set; }

    [Column("HRTimesheetConfigNov")]
    public int? HrtimesheetConfigNov { get; set; }

    [Column("HRTimesheetConfigDec")]
    public int? HrtimesheetConfigDec { get; set; }

    [Column("HRTimesheetConfigYear", TypeName = "datetime")]
    public DateTime? HrtimesheetConfigYear { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int? FkHremployeePayrollFormulaId { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("HrtimesheetConfigs")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }
}
