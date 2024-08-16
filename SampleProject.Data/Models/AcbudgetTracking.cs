using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBudgetTrackings")]
public partial class AcbudgetTracking
{
    [Key]
    [Column("ACBudgetTrackingID")]
    public int AcbudgetTrackingId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ACBudgetTrackingFromYear", TypeName = "datetime")]
    public DateTime? AcbudgetTrackingFromYear { get; set; }

    [Column("ACBudgetTrackingToMonth", TypeName = "datetime")]
    public DateTime? AcbudgetTrackingToMonth { get; set; }

    [InverseProperty("FkAcbudgetTracking")]
    public virtual ICollection<AcbudgetTrackingItem> AcbudgetTrackingItems { get; set; } = new List<AcbudgetTrackingItem>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcbudgetTrackings")]
    public virtual Brbranch FkBrbranch { get; set; }
}
