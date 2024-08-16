using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLeaveDays")]
public partial class HrleaveDay
{
    [Key]
    [Column("HRLeaveDayID")]
    public int HrleaveDayId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int FkHrtimeSheetParamId { get; set; }

    [Column("HRLeaveDayDate", TypeName = "datetime")]
    public DateTime? HrleaveDayDate { get; set; }

    [Column("HRLeaveDayReason")]
    [StringLength(512)]
    public string HrleaveDayReason { get; set; }

    public bool? IsAllowedLeave { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrleaveDays")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HrleaveDays")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
