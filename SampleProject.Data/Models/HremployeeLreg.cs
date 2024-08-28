using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeLRegs")]
public partial class HremployeeLreg
{
    [Key]
    [Column("HREmployeeLRegID")]
    public int HremployeeLregId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeeLRegDftDays", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregDftDays { get; set; }

    [Column("HREmployeeLRegPreviousDays", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregPreviousDays { get; set; }

    [Column("HREmployeeLRegExpDays", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregExpDays { get; set; }

    [Column("HREmployeeLRegTotDays", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregTotDays { get; set; }

    [Column("HREmployeeLRegLeaveDays", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregLeaveDays { get; set; }

    [Column("HREmployeeLRegRemainDays", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregRemainDays { get; set; }

    [Column("HREmployeeLRegDesc")]
    [StringLength(250)]
    public string HremployeeLregDesc { get; set; }

    [Column("HREmployeeLRegAnnualLeaveTot", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregAnnualLeaveTot { get; set; }

    [Column("HREmployeeLRegNoxiouDays", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregNoxiouDays { get; set; }

    [Column("HREmployeeLRegAnnualLeaveOtherDays", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregAnnualLeaveOtherDays { get; set; }

    [Column("HREmployeeLRegYear")]
    public int? HremployeeLregYear { get; set; }

    [Column("HREmployeeLRegDateCal", TypeName = "datetime")]
    public DateTime? HremployeeLregDateCal { get; set; }

    [Column("HREmployeeLRegPreviousDayUsed", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLregPreviousDayUsed { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeLregs")]
    public virtual Hremployee FkHremployee { get; set; }
}
