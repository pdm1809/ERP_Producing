using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePauses")]
public partial class HremployeePause
{
    [Key]
    [Column("HREmployeePauseID")]
    public int HremployeePauseId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("HREmployeePauseNo")]
    [StringLength(50)]
    public string HremployeePauseNo { get; set; }

    [Column("HREmployeePauseName")]
    [StringLength(50)]
    public string HremployeePauseName { get; set; }

    [Column("HREmployeePauseDesc")]
    [StringLength(512)]
    public string HremployeePauseDesc { get; set; }

    [Column("HREmployeePauseStartDate", TypeName = "datetime")]
    public DateTime? HremployeePauseStartDate { get; set; }

    [Column("HREmployeePauseEndDate", TypeName = "datetime")]
    public DateTime? HremployeePauseEndDate { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int? FkHrtimeSheetParamId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeePauseDate", TypeName = "datetime")]
    public DateTime? HremployeePauseDate { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeePauses")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HremployeePauses")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
