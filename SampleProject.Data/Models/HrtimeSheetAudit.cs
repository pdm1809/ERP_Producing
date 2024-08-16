using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeSheetAudits")]
public partial class HrtimeSheetAudit
{
    [Key]
    [Column("HRTimeSheetAuditID")]
    public int HrtimeSheetAuditId { get; set; }

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

    public bool? IsTransferred { get; set; }

    [Column("AATransferredDate", TypeName = "datetime")]
    public DateTime? AatransferredDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("HRTimeSheetAuditNo")]
    [StringLength(50)]
    public string HrtimeSheetAuditNo { get; set; }

    [Required]
    [Column("HRTimeSheetAuditName")]
    [StringLength(50)]
    public string HrtimeSheetAuditName { get; set; }

    [Column("HRTimeSheetAuditDesc")]
    [StringLength(512)]
    public string HrtimeSheetAuditDesc { get; set; }

    [Column("HRTimeSheetAuditDate", TypeName = "datetime")]
    public DateTime HrtimeSheetAuditDate { get; set; }

    [Column("HRTimeSheetAuditStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtimeSheetAuditStatus { get; set; }

    [Column("HRTimeSheetAuditType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtimeSheetAuditType { get; set; }

    [Column("HRTimeSheetAuditFromDate", TypeName = "datetime")]
    public DateTime HrtimeSheetAuditFromDate { get; set; }

    [Column("HRTimeSheetAuditToDate", TypeName = "datetime")]
    public DateTime HrtimeSheetAuditToDate { get; set; }

    [Column("FK_HRTimeSheetID")]
    public int? FkHrtimeSheetId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrtimeSheetAudits")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrtimeSheetAudits")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrtimeSheetId")]
    [InverseProperty("HrtimeSheetAudits")]
    public virtual HrtimeSheet FkHrtimeSheet { get; set; }

    [InverseProperty("FkHrtimeSheetAudit")]
    public virtual ICollection<HremployeeTimeSheetAudit> HremployeeTimeSheetAudits { get; set; } = new List<HremployeeTimeSheetAudit>();

    [InverseProperty("FkHrtimeSheetAudit")]
    public virtual ICollection<HrtimeSheetAuditEntry> HrtimeSheetAuditEntries { get; set; } = new List<HrtimeSheetAuditEntry>();
}
