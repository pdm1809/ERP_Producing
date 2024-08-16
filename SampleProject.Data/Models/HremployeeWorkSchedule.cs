using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeWorkSchedules")]
public partial class HremployeeWorkSchedule
{
    [Key]
    [Column("HREmployeeWorkScheduleID")]
    public int HremployeeWorkScheduleId { get; set; }

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
    [Column("HREmployeeWorkScheduleNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeWorkScheduleNo { get; set; }

    [Column("HREmployeeWorkScheduleName")]
    [StringLength(50)]
    public string HremployeeWorkScheduleName { get; set; }

    [Required]
    [Column("HREmployeeWorkScheduleDesc")]
    [StringLength(512)]
    public string HremployeeWorkScheduleDesc { get; set; }

    [Column("HREmployeeWorkScheduleDateFrom", TypeName = "datetime")]
    public DateTime? HremployeeWorkScheduleDateFrom { get; set; }

    [Column("HREmployeeWorkScheduleDateTo", TypeName = "datetime")]
    public DateTime? HremployeeWorkScheduleDateTo { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("HREmployeeCardNumber")]
    [StringLength(200)]
    public string HremployeeCardNumber { get; set; }

    [Column("HREmployeeName")]
    [StringLength(200)]
    public string HremployeeName { get; set; }

    [Column("HREmployeeWorkScheduleStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeWorkScheduleStatus { get; set; }

    [Column("FK_HREmployeeApproveID")]
    public int? FkHremployeeApproveId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HremployeeWorkSchedules")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeApproveId")]
    [InverseProperty("HremployeeWorkSchedules")]
    public virtual Hremployee FkHremployeeApprove { get; set; }
}
