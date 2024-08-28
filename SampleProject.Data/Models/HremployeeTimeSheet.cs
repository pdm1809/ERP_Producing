using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeTimeSheets")]
public partial class HremployeeTimeSheet
{
    [Key]
    [Column("HREmployeeTimeSheetID")]
    public int HremployeeTimeSheetId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRTimeSheetID")]
    public int FkHrtimeSheetId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("HREmployeeTimeSheetWorkingQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetWorkingQty { get; set; }

    [Column("HREmployeeTimeSheetOTQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetOtqty { get; set; }

    [Column("HREmployeeTimeSheetLeaveQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetLeaveQty { get; set; }

    [Column("HREmployeeTimeSheetWorkingSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetWorkingSalaryFactor { get; set; }

    [Column("HREmployeeTimeSheetOTSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetOtsalaryFactor { get; set; }

    [Column("HREmployeeTimeSheetLeaveSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetLeaveSalaryFactor { get; set; }

    [Column("HREmployeeTimeSheetNightQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetNightQty { get; set; }

    [Column("HREmployeeTimeSheetWorkDayQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetWorkDayQty { get; set; }

    [Column("HREmployeeTimeSheetNghiLe", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetNghiLe { get; set; }

    [Column("HREmployeeTimeSheetNghiCoPhep", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetNghiCoPhep { get; set; }

    [Column("HREmployeeTimeSheetNghiKhongPhep", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetNghiKhongPhep { get; set; }

    [Column("HREmployeeTimeSheetNghiCheDo", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetNghiCheDo { get; set; }

    [Column("HREmployeeTimeSheetCongTyChoNghi", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetCongTyChoNghi { get; set; }

    [Column("HREmployeeTimeSheetPermissionOTDaysOff", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetPermissionOtdaysOff { get; set; }

    [Column("HREmployeeTimeSheetNghiPhepNam", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetNghiPhepNam { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeTimeSheets")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeTimeSheets")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrtimeSheetId")]
    [InverseProperty("HremployeeTimeSheets")]
    public virtual HrtimeSheet FkHrtimeSheet { get; set; }

    [InverseProperty("FkHremployeeTimeSheet")]
    public virtual ICollection<HremployeeTimeSheetOtdetail> HremployeeTimeSheetOtdetails { get; set; } = new List<HremployeeTimeSheetOtdetail>();

    [InverseProperty("FkHremployeeTimeSheet")]
    public virtual ICollection<HrtimeSheetEntry> HrtimeSheetEntries { get; set; } = new List<HrtimeSheetEntry>();
}
