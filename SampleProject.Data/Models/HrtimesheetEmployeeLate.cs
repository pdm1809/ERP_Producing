using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimesheetEmployeeLates")]
public partial class HrtimesheetEmployeeLate
{
    [Key]
    [Column("HRTimesheetEmployeeLateID")]
    public int HrtimesheetEmployeeLateId { get; set; }

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

    [Column("HRTimesheetEmployeeLateName")]
    [StringLength(50)]
    public string HrtimesheetEmployeeLateName { get; set; }

    [Column("HRTimesheetEmployeeLateTimeFrom")]
    public int? HrtimesheetEmployeeLateTimeFrom { get; set; }

    [Column("HRTimesheetEmployeeLateTimeTo")]
    public int? HrtimesheetEmployeeLateTimeTo { get; set; }

    [Column("HRTimesheetEmployeeLateOTTime")]
    public int? HrtimesheetEmployeeLateOttime { get; set; }

    [Column("HRTimesheetEmployeeLateDeduct", TypeName = "decimal(18, 5)")]
    public decimal? HrtimesheetEmployeeLateDeduct { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int? FkHremployeePayrollFormulaId { get; set; }

    [Column("HRTimesheetEmployeeLateOTDefault", TypeName = "decimal(18, 5)")]
    public decimal? HrtimesheetEmployeeLateOtdefault { get; set; }

    [Column("HRTimesheetEmployeeLateType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtimesheetEmployeeLateType { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("HrtimesheetEmployeeLates")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }
}
