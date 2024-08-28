using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeTimeSheetAudits")]
public partial class HremployeeTimeSheetAudit
{
    [Key]
    [Column("HREmployeeTimeSheetAuditID")]
    public int HremployeeTimeSheetAuditId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRTimeSheetAuditID")]
    public int FkHrtimeSheetAuditId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("HREmployeeTimeSheetAuditWorkingQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditWorkingQty { get; set; }

    [Column("HREmployeeTimeSheetAuditOTQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditOtqty { get; set; }

    [Column("HREmployeeTimeSheetAuditLeaveQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditLeaveQty { get; set; }

    [Column("HREmployeeTimeSheetAuditWorkingSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditWorkingSalaryFactor { get; set; }

    [Column("HREmployeeTimeSheetAuditOTSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditOtsalaryFactor { get; set; }

    [Column("HREmployeeTimeSheetAuditLeaveSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditLeaveSalaryFactor { get; set; }

    [Column("HREmployeeTimeSheetAuditNightQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditNightQty { get; set; }

    [Column("HREmployeeTimeSheetAuditWorkDayQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditWorkDayQty { get; set; }

    [Column("HREmployeeTimeSheetAuditNghiPhepNam", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditNghiPhepNam { get; set; }

    [Column("HREmployeeTimeSheetAuditCongTyChoNghi", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditCongTyChoNghi { get; set; }

    [Column("HREmployeeTimeSheetAuditNghiCheDo", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditNghiCheDo { get; set; }

    [Column("HREmployeeTimeSheetAuditNghiLe", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditNghiLe { get; set; }

    [Column("HREmployeeTimeSheetAuditNghiKhongPhep", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditNghiKhongPhep { get; set; }

    [Column("HREmployeeTimeSheetAuditNghiCoPhep", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditNghiCoPhep { get; set; }

    [Column("HREmployeeTimeSheetAuditHourProductivity", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditHourProductivity { get; set; }

    [Column("HREmployeeTimeSheetAuditPermissionOTDaysOff", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditPermissionOtdaysOff { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeTimeSheetAudits")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeTimeSheetAudits")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrtimeSheetAuditId")]
    [InverseProperty("HremployeeTimeSheetAudits")]
    public virtual HrtimeSheetAudit FkHrtimeSheetAudit { get; set; }

    [InverseProperty("FkHremployeeTimeSheetAudit")]
    public virtual ICollection<HremployeeTimeSheetAuditOtdetail> HremployeeTimeSheetAuditOtdetails { get; set; } = new List<HremployeeTimeSheetAuditOtdetail>();

    [InverseProperty("FkHremployeeTimeSheetAudit")]
    public virtual ICollection<HrtimeSheetAuditEntry> HrtimeSheetAuditEntries { get; set; } = new List<HrtimeSheetAuditEntry>();
}
