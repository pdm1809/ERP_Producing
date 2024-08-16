using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAllowanceManageConfigs")]
public partial class HrallowanceManageConfig
{
    [Key]
    [Column("HRAllowanceManageConfigID")]
    public int HrallowanceManageConfigId { get; set; }

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

    [Column("HRAllowanceManageConfigName")]
    [StringLength(255)]
    public string HrallowanceManageConfigName { get; set; }

    [Column("HRAllowanceManageConfigAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceManageConfigAmount { get; set; }

    [Column("HRAllowanceManageConfigCalculatedOnCont")]
    public bool? HrallowanceManageConfigCalculatedOnCont { get; set; }

    [Column("HRAllowanceManageConfigPlusHoliday")]
    public bool? HrallowanceManageConfigPlusHoliday { get; set; }

    [Column("HRAllowanceManageConfigContdifferenceWithReality", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceManageConfigContdifferenceWithReality { get; set; }

    [Column("HRAllowanceManageConfigQualityCriteria", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceManageConfigQualityCriteria { get; set; }

    [Column("HRAllowanceManageConfigProductivityCriteria", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceManageConfigProductivityCriteria { get; set; }

    [Column("HRAllowanceManageConfigManageCriteria", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceManageConfigManageCriteria { get; set; }

    [Column("HRAllowanceManageConfigNo")]
    [StringLength(50)]
    public string HrallowanceManageConfigNo { get; set; }

    [Column("HRAllowanceManageConfigFromDate", TypeName = "datetime")]
    public DateTime? HrallowanceManageConfigFromDate { get; set; }

    [Column("HRAllowanceManageConfigToDate", TypeName = "datetime")]
    public DateTime? HrallowanceManageConfigToDate { get; set; }

    [Column("HRAllowanceManageConfigExactlyCriteria", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceManageConfigExactlyCriteria { get; set; }

    [Column("HRAllowanceManageConfigPercentBasicSalary", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceManageConfigPercentBasicSalary { get; set; }

    [InverseProperty("FkHrallowanceManageConfig")]
    public virtual ICollection<HrallowanceManageConfigHistory> HrallowanceManageConfigHistories { get; set; } = new List<HrallowanceManageConfigHistory>();

    [InverseProperty("FkHrallowanceManageConfig")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();
}
