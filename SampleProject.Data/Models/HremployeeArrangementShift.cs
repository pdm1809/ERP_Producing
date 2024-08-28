using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeArrangementShifts")]
public partial class HremployeeArrangementShift
{
    [Key]
    [Column("HREmployeeArrangementShiftID")]
    public int HremployeeArrangementShiftId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRArrangementShiftID")]
    public int? FkHrarrangementShiftId { get; set; }

    [ForeignKey("FkHrarrangementShiftId")]
    [InverseProperty("HremployeeArrangementShifts")]
    public virtual HrarrangementShift FkHrarrangementShift { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeArrangementShifts")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeArrangementShifts")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHremployeeArrangementShift")]
    public virtual ICollection<HrarrangementShiftEntry> HrarrangementShiftEntries { get; set; } = new List<HrarrangementShiftEntry>();
}
