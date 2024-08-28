using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACMoneyChanges")]
public partial class AcmoneyChange
{
    [Key]
    [Column("ACMoneyChangeID")]
    public int AcmoneyChangeId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ACMoneyChangeNo")]
    [StringLength(50)]
    public string AcmoneyChangeNo { get; set; }

    [Column("ACMoneyChangeDesc")]
    [StringLength(512)]
    public string AcmoneyChangeDesc { get; set; }

    [Column("ACMoneyChangeDate", TypeName = "datetime")]
    public DateTime? AcmoneyChangeDate { get; set; }

    [Column("ACMoneyChangeType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcmoneyChangeType { get; set; }

    [Column("ACMoneyChangeStatus")]
    [StringLength(128)]
    public string AcmoneyChangeStatus { get; set; }

    [Column("FK_HREmployeeApprovedID")]
    public int? FkHremployeeApprovedId { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(50)]
    public string SttoolbarActionName { get; set; }

    [Column("ACMoneyChangePostedStatus")]
    [StringLength(50)]
    public string AcmoneyChangePostedStatus { get; set; }

    [InverseProperty("FkAcmoneyChange")]
    public virtual ICollection<AcmoneyChangeItem> AcmoneyChangeItems { get; set; } = new List<AcmoneyChangeItem>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcmoneyChanges")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AcmoneyChangeFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("AcmoneyChangeFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [ForeignKey("FkHremployeeCompletedId")]
    [InverseProperty("AcmoneyChangeFkHremployeeCompleteds")]
    public virtual Hremployee FkHremployeeCompleted { get; set; }
}
