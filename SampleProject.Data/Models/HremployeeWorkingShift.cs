using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeWorkingShifts")]
[Microsoft.EntityFrameworkCore.Index("FkHremployeeId", Name = "Idx_HREmployeeWorkingShifts")]
public partial class HremployeeWorkingShift
{
    [Key]
    [Column("HREmployeeWorkingShiftID")]
    public int HremployeeWorkingShiftId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRWorkingShiftID")]
    public int FkHrworkingShiftId { get; set; }

    [Column("HREmployeeWorkingShiftFromDate", TypeName = "datetime")]
    public DateTime? HremployeeWorkingShiftFromDate { get; set; }

    [Column("HREmployeeWorkingShiftToDate", TypeName = "datetime")]
    public DateTime? HremployeeWorkingShiftToDate { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeWorkingShifts")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrworkingShiftId")]
    [InverseProperty("HremployeeWorkingShifts")]
    public virtual HrworkingShift FkHrworkingShift { get; set; }
}
