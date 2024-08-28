using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRPayRollAudits")]
public partial class HrpayRollAudit
{
    [Key]
    [Column("HRPayRollAuditID")]
    public int HrpayRollAuditId { get; set; }

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

    [Column("FK_HRTimeSheetAuditID")]
    public int? FkHrtimeSheetAuditId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("HRPayRollAuditNo")]
    [StringLength(50)]
    public string HrpayRollAuditNo { get; set; }

    [Required]
    [Column("HRPayRollAuditName")]
    [StringLength(50)]
    public string HrpayRollAuditName { get; set; }

    [Column("HRPayRollAuditDesc")]
    [StringLength(512)]
    public string HrpayRollAuditDesc { get; set; }

    [Required]
    [Column("HRPayRollAuditType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrpayRollAuditType { get; set; }

    [Column("HRPayRollAuditStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrpayRollAuditStatus { get; set; }

    [Column("HRPayRollAuditDate", TypeName = "datetime")]
    public DateTime HrpayRollAuditDate { get; set; }

    [Column("HRPayRollAuditPeriod")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrpayRollAuditPeriod { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrpayRollAudits")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrpayRollAudits")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrpayRollAudit")]
    public virtual ICollection<HremployeePayRollAudit> HremployeePayRollAudits { get; set; } = new List<HremployeePayRollAudit>();
}
