using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAllowanceManageConfigHistorys")]
public partial class HrallowanceManageConfigHistory
{
    [Key]
    [Column("HRAllowanceManageConfigHistoryID")]
    public int HrallowanceManageConfigHistoryId { get; set; }

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

    [Column("HRAllowanceManageConfigHistoryNo")]
    [StringLength(50)]
    public string HrallowanceManageConfigHistoryNo { get; set; }

    [Column("HRAllowanceManageConfigHistoryOption")]
    [StringLength(250)]
    public string HrallowanceManageConfigHistoryOption { get; set; }

    [Column("HRAllowanceManageConfigHistoryOldValue")]
    [StringLength(512)]
    public string HrallowanceManageConfigHistoryOldValue { get; set; }

    [Column("HRAllowanceManageConfigHistoryNewValue")]
    [StringLength(512)]
    public string HrallowanceManageConfigHistoryNewValue { get; set; }

    [Column("HRAllowanceManageConfigHistoryDate", TypeName = "datetime")]
    public DateTime? HrallowanceManageConfigHistoryDate { get; set; }

    [Column("FK_HREmployeeUserChangeID")]
    public int? FkHremployeeUserChangeId { get; set; }

    [Column("FK_HRAllowanceManageConfigID")]
    public int FkHrallowanceManageConfigId { get; set; }

    [Column("HRAllowanceManageConfigHistoryUserName")]
    [StringLength(250)]
    public string HrallowanceManageConfigHistoryUserName { get; set; }

    [ForeignKey("FkHrallowanceManageConfigId")]
    [InverseProperty("HrallowanceManageConfigHistories")]
    public virtual HrallowanceManageConfig FkHrallowanceManageConfig { get; set; }

    [ForeignKey("FkHremployeeUserChangeId")]
    [InverseProperty("HrallowanceManageConfigHistories")]
    public virtual Hremployee FkHremployeeUserChange { get; set; }
}
