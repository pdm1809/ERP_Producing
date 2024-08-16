using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("BRPostingHistorys")]
[Microsoft.EntityFrameworkCore.Index("BrpostingHistoryDate", "FkBrbranchId", Name = "Idx_BRPostingHistorys")]
public partial class BrpostingHistory
{
    [Key]
    [Column("BRPostingHistoryID")]
    public int BrpostingHistoryId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("BRPostingHistoryUserName")]
    [StringLength(100)]
    public string BrpostingHistoryUserName { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("BRPostingHistoryDate", TypeName = "datetime")]
    public DateTime? BrpostingHistoryDate { get; set; }

    [Column("BRPostingHistoryStatus")]
    [StringLength(100)]
    public string BrpostingHistoryStatus { get; set; }

    [Column("BRPostingHistoryType")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrpostingHistoryType { get; set; }

    [Column("BRPostingHistoryLog")]
    [StringLength(512)]
    public string BrpostingHistoryLog { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("BrpostingHistories")]
    public virtual Brbranch FkBrbranch { get; set; }
}
