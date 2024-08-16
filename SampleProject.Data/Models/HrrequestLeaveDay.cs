using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRequestLeaveDays")]
public partial class HrrequestLeaveDay
{
    [Key]
    [Column("HRRequestLeaveDayID")]
    public int HrrequestLeaveDayId { get; set; }

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
    public int FkHrtimeSheetParamId { get; set; }

    [Column("HRRequestLeaveDayFromDate", TypeName = "datetime")]
    public DateTime? HrrequestLeaveDayFromDate { get; set; }

    [Column("HRRequestLeaveDayToDate", TypeName = "datetime")]
    public DateTime? HrrequestLeaveDayToDate { get; set; }

    [Column("HRRequestLeaveDayTotalTime", TypeName = "decimal(18, 0)")]
    public decimal? HrrequestLeaveDayTotalTime { get; set; }

    [Column("HRRequestLeaveDayReason")]
    [StringLength(500)]
    public string HrrequestLeaveDayReason { get; set; }

    [Column("HRRequestLeaveDayNote")]
    [StringLength(500)]
    public string HrrequestLeaveDayNote { get; set; }

    [Column("HRRequestLeaveDayStatus")]
    [StringLength(50)]
    public string HrrequestLeaveDayStatus { get; set; }

    [Column("HRRequestLeaveDayReasonStatus")]
    [StringLength(500)]
    public string HrrequestLeaveDayReasonStatus { get; set; }

    [Required]
    [Column("HRRequestLeaveDayNo")]
    [StringLength(50)]
    public string HrrequestLeaveDayNo { get; set; }

    [Column("FK_HREmployeeLeaveID")]
    public int FkHremployeeLeaveId { get; set; }

    [Column("HRLeaveApplicationDate", TypeName = "datetime")]
    public DateTime? HrleaveApplicationDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [ForeignKey("FkHrapproveEmployeeId")]
    [InverseProperty("HrrequestLeaveDayFkHrapproveEmployees")]
    public virtual Hremployee FkHrapproveEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrrequestLeaveDayFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeLeaveId")]
    [InverseProperty("HrrequestLeaveDayFkHremployeeLeaves")]
    public virtual Hremployee FkHremployeeLeave { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HrrequestLeaveDays")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
