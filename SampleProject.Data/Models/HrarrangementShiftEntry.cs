using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRArrangementShiftEntrys")]
public partial class HrarrangementShiftEntry
{
    [Key]
    [Column("HRArrangementShiftEntryID")]
    public int HrarrangementShiftEntryId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRWorkingShiftID")]
    public int FkHrworkingShiftId { get; set; }

    [Column("FK_HREmployeeArrangementShiftID")]
    public int? FkHremployeeArrangementShiftId { get; set; }

    [Column("HRArrangementShiftEntryDate", TypeName = "datetime")]
    public DateTime? HrarrangementShiftEntryDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRArrangementShiftID")]
    public int? FkHrarrangementShiftId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrarrangementShiftEntries")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeArrangementShiftId")]
    [InverseProperty("HrarrangementShiftEntries")]
    public virtual HremployeeArrangementShift FkHremployeeArrangementShift { get; set; }

    [ForeignKey("FkHrworkingShiftId")]
    [InverseProperty("HrarrangementShiftEntries")]
    public virtual HrworkingShift FkHrworkingShift { get; set; }
}
