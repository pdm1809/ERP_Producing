using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeTimeSheetAuditOTDetails")]
public partial class HremployeeTimeSheetAuditOtdetail
{
    [Key]
    [Column("HREmployeeTimeSheetAuditOTDetailID")]
    public int HremployeeTimeSheetAuditOtdetailId { get; set; }

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

    [Column("FK_HREmployeeTimeSheetAuditID")]
    public int? FkHremployeeTimeSheetAuditId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int? FkHrtimeSheetParamId { get; set; }

    [Column("HREmployeeTimeSheetAuditOTDetailName")]
    [StringLength(200)]
    public string HremployeeTimeSheetAuditOtdetailName { get; set; }

    [Column("HREmployeeTimeSheetAuditOTDetailFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditOtdetailFactor { get; set; }

    [Column("HREmployeeTimeSheetAuditOTDetailHours", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditOtdetailHours { get; set; }

    [ForeignKey("FkHremployeeTimeSheetAuditId")]
    [InverseProperty("HremployeeTimeSheetAuditOtdetails")]
    public virtual HremployeeTimeSheetAudit FkHremployeeTimeSheetAudit { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HremployeeTimeSheetAuditOtdetails")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
