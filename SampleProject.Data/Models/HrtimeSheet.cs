using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeSheets")]
public partial class HrtimeSheet
{
    [Key]
    [Column("HRTimeSheetID")]
    public int HrtimeSheetId { get; set; }

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
    [Column("HRTimeSheetNo")]
    [StringLength(50)]
    public string HrtimeSheetNo { get; set; }

    [Required]
    [Column("HRTimeSheetName")]
    [StringLength(50)]
    public string HrtimeSheetName { get; set; }

    [Column("HRTimeSheetDesc")]
    [StringLength(512)]
    public string HrtimeSheetDesc { get; set; }

    [Column("HRTimeSheetDate", TypeName = "datetime")]
    public DateTime HrtimeSheetDate { get; set; }

    [Column("HRTimeSheetStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtimeSheetStatus { get; set; }

    [Column("HRTimeSheetType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtimeSheetType { get; set; }

    [Column("HRTimeSheetFromDate", TypeName = "datetime")]
    public DateTime HrtimeSheetFromDate { get; set; }

    [Column("HRTimeSheetToDate", TypeName = "datetime")]
    public DateTime HrtimeSheetToDate { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrtimeSheets")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrtimeSheets")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrtimeSheet")]
    public virtual ICollection<HremployeeTimeSheet> HremployeeTimeSheets { get; set; } = new List<HremployeeTimeSheet>();

    [InverseProperty("FkHrtimeSheet")]
    public virtual ICollection<HrtimeSheetAudit> HrtimeSheetAudits { get; set; } = new List<HrtimeSheetAudit>();

    [InverseProperty("FkHrtimeSheet")]
    public virtual ICollection<HrtimeSheetEntry> HrtimeSheetEntries { get; set; } = new List<HrtimeSheetEntry>();
}
