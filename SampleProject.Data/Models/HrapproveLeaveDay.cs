using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRApproveLeaveDays")]
public partial class HrapproveLeaveDay
{
    [Key]
    [Column("HRApproveLeaveDayID")]
    public int HrapproveLeaveDayId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRApproveEmployeeID")]
    public int? FkHrapproveEmployeeId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int? FkHrtimeSheetParamId { get; set; }

    [Column("HRApproveLeaveDayFromDate", TypeName = "datetime")]
    public DateTime? HrapproveLeaveDayFromDate { get; set; }

    [Column("HRApproveLeaveDayToDate", TypeName = "datetime")]
    public DateTime? HrapproveLeaveDayToDate { get; set; }

    [Column("HRApproveLeaveDayTotalTime", TypeName = "decimal(18, 0)")]
    public decimal? HrapproveLeaveDayTotalTime { get; set; }

    [Column("HRApproveLeaveDayReason")]
    [StringLength(500)]
    public string HrapproveLeaveDayReason { get; set; }

    [Column("HRApproveLeaveDayNote")]
    [StringLength(500)]
    public string HrapproveLeaveDayNote { get; set; }

    [Column("HRApproveLeaveDayStatus")]
    [StringLength(50)]
    public string HrapproveLeaveDayStatus { get; set; }

    [Column("HRApproveLeaveDayReasonStatus")]
    [StringLength(500)]
    public string HrapproveLeaveDayReasonStatus { get; set; }

    [ForeignKey("FkHrapproveEmployeeId")]
    [InverseProperty("HrapproveLeaveDayFkHrapproveEmployees")]
    public virtual Hremployee FkHrapproveEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrapproveLeaveDayFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HrapproveLeaveDays")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
