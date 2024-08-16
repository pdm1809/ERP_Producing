using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeTimeSheetOTDetails")]
public partial class HremployeeTimeSheetOtdetail
{
    [Key]
    [Column("HREmployeeTimeSheetOTDetailID")]
    public int HremployeeTimeSheetOtdetailId { get; set; }

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

    [Column("FK_HREmployeeTimeSheetID")]
    public int? FkHremployeeTimeSheetId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int? FkHrtimeSheetParamId { get; set; }

    [Column("HREmployeeTimeSheetOTDetailName")]
    [StringLength(200)]
    public string HremployeeTimeSheetOtdetailName { get; set; }

    [Column("HREmployeeTimeSheetOTDetailFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetOtdetailFactor { get; set; }

    [Column("HREmployeeTimeSheetOTDetailHours", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetOtdetailHours { get; set; }

    [Column("HREmployeeTimeSheetOTDetailEntryDate", TypeName = "datetime")]
    public DateTime? HremployeeTimeSheetOtdetailEntryDate { get; set; }

    [ForeignKey("FkHremployeeTimeSheetId")]
    [InverseProperty("HremployeeTimeSheetOtdetails")]
    public virtual HremployeeTimeSheet FkHremployeeTimeSheet { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HremployeeTimeSheetOtdetails")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
