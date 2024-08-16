using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADGroupAppStaffs")]
public partial class AdgroupAppStaff
{
    [Key]
    [Column("ADGroupAppStaffID")]
    public int AdgroupAppStaffId { get; set; }

    [Column("ADGroupAppStaffDesc")]
    [StringLength(200)]
    public string AdgroupAppStaffDesc { get; set; }

    [Required]
    [Column("ADGroupAppStaffName")]
    [StringLength(100)]
    public string AdgroupAppStaffName { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("ADGroupAppStaffRole")]
    [StringLength(128)]
    [Unicode(false)]
    public string AdgroupAppStaffRole { get; set; }

    [InverseProperty("FkAdgroupAppStaff")]
    public virtual ICollection<AddataViewPermissionAppStaff> AddataViewPermissionAppStaffs { get; set; } = new List<AddataViewPermissionAppStaff>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AdgroupAppStaffs")]
    public virtual Brbranch FkBrbranch { get; set; }

    [InverseProperty("FkAdgroupAppStaff")]
    public virtual ICollection<HremployeeGroupAppStaff> HremployeeGroupAppStaffs { get; set; } = new List<HremployeeGroupAppStaff>();
}
