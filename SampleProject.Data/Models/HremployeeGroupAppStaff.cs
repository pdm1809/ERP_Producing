using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeGroupAppStaffs")]
public partial class HremployeeGroupAppStaff
{
    [Key]
    [Column("HREmployeeGroupAppStaffID")]
    public int HremployeeGroupAppStaffId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ADGroupAppStaffID")]
    public int FkAdgroupAppStaffId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [InverseProperty("FkHremployeeGroupAppStaff")]
    public virtual ICollection<AddataViewPermissionAppStaff> AddataViewPermissionAppStaffs { get; set; } = new List<AddataViewPermissionAppStaff>();

    [ForeignKey("FkAdgroupAppStaffId")]
    [InverseProperty("HremployeeGroupAppStaffs")]
    public virtual AdgroupAppStaff FkAdgroupAppStaff { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HremployeeGroupAppStaffs")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeGroupAppStaffs")]
    public virtual Hremployee FkHremployee { get; set; }
}
