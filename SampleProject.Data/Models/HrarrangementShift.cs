using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRArrangementShifts")]
public partial class HrarrangementShift
{
    [Key]
    [Column("HRArrangementShiftID")]
    public int HrarrangementShiftId { get; set; }

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

    [Required]
    [Column("HRArrangementShiftNo")]
    [StringLength(50)]
    public string HrarrangementShiftNo { get; set; }

    [Required]
    [Column("HRArrangementShiftName")]
    [StringLength(100)]
    public string HrarrangementShiftName { get; set; }

    [Column("HRArrangementShiftDesc")]
    [StringLength(512)]
    public string HrarrangementShiftDesc { get; set; }

    [Column("HRArrangementShiftFromDate", TypeName = "datetime")]
    public DateTime HrarrangementShiftFromDate { get; set; }

    [Column("HRArrangementShiftToDate", TypeName = "datetime")]
    public DateTime HrarrangementShiftToDate { get; set; }

    [Required]
    [Column("HRArrangementShiftType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrarrangementShiftType { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrarrangementShifts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrarrangementShifts")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrarrangementShift")]
    public virtual ICollection<HremployeeArrangementShift> HremployeeArrangementShifts { get; set; } = new List<HremployeeArrangementShift>();
}
