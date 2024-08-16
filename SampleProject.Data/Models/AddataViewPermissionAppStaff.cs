using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADDataViewPermissionAppStaffs")]
public partial class AddataViewPermissionAppStaff
{
    [Key]
    [Column("ADDataViewPermissionAppStaffID")]
    public int AddataViewPermissionAppStaffId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ADGroupAppStaffID")]
    public int? FkAdgroupAppStaffId { get; set; }

    [Column("FK_HREmployeeGroupAppStaffID")]
    public int? FkHremployeeGroupAppStaffId { get; set; }

    [Column("ADDataViewPermissionAppStaffType")]
    [StringLength(512)]
    public string AddataViewPermissionAppStaffType { get; set; }

    [Column("ADDataViewPermissionAppStaffDeliveryCheck")]
    public bool? AddataViewPermissionAppStaffDeliveryCheck { get; set; }

    [Column("ADDataViewPermissionAppStaffDriverCheck")]
    public bool? AddataViewPermissionAppStaffDriverCheck { get; set; }

    [Column("ADDataViewPermissionAppStaffGroupType")]
    [StringLength(64)]
    public string AddataViewPermissionAppStaffGroupType { get; set; }

    [Column("FK_ADPrivilegeAppSatffID")]
    public int? FkAdprivilegeAppSatffId { get; set; }

    [Column("ADDataViewPermissionAppStaffManagerCheck")]
    public bool? AddataViewPermissionAppStaffManagerCheck { get; set; }

    [Column("ADDataViewPermissionAppStaffOtherCheck")]
    public bool? AddataViewPermissionAppStaffOtherCheck { get; set; }

    [ForeignKey("FkAdgroupAppStaffId")]
    [InverseProperty("AddataViewPermissionAppStaffs")]
    public virtual AdgroupAppStaff FkAdgroupAppStaff { get; set; }

    [ForeignKey("FkAdprivilegeAppSatffId")]
    [InverseProperty("AddataViewPermissionAppStaffs")]
    public virtual AdprivilegeAppSatff FkAdprivilegeAppSatff { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AddataViewPermissionAppStaffs")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeGroupAppStaffId")]
    [InverseProperty("AddataViewPermissionAppStaffs")]
    public virtual HremployeeGroupAppStaff FkHremployeeGroupAppStaff { get; set; }
}
