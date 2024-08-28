using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLeaveApplications")]
public partial class HrleaveApplication
{
    [Key]
    [Column("HRLeaveApplicationID")]
    public int HrleaveApplicationId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("HRLeaveApplicationNo")]
    [StringLength(50)]
    public string HrleaveApplicationNo { get; set; }

    [Required]
    [Column("HRLeaveApplicationName")]
    [StringLength(256)]
    public string HrleaveApplicationName { get; set; }

    [Column("HRLeaveApplicationDesc")]
    [StringLength(512)]
    public string HrleaveApplicationDesc { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int FkHrtimeSheetParamId { get; set; }

    [Column("FK_HREmployeeLeaveID")]
    public int FkHremployeeLeaveId { get; set; }

    [Column("FK_HREmployeeApproveID")]
    public int FkHremployeeApproveId { get; set; }

    [Column("HRLeaveApplicationDate", TypeName = "datetime")]
    public DateTime HrleaveApplicationDate { get; set; }

    [Column("HRLeaveApplicationFromDate", TypeName = "datetime")]
    public DateTime? HrleaveApplicationFromDate { get; set; }

    [Column("HRLeaveApplicationToDate", TypeName = "datetime")]
    public DateTime? HrleaveApplicationToDate { get; set; }

    [Column("HRLeaveApplicationStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrleaveApplicationStatus { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrleaveApplications")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrleaveApplicationFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApproveId")]
    [InverseProperty("HrleaveApplicationFkHremployeeApproves")]
    public virtual Hremployee FkHremployeeApprove { get; set; }

    [ForeignKey("FkHremployeeLeaveId")]
    [InverseProperty("HrleaveApplicationFkHremployeeLeaves")]
    public virtual Hremployee FkHremployeeLeave { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HrleaveApplications")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
