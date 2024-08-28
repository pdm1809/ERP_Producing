using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeKeeperHistorys")]
public partial class HrtimeKeeperHistory
{
    [Key]
    [Column("HRTimeKeeperHistoryID")]
    public int HrtimeKeeperHistoryId { get; set; }

    [Column("AAStatus")]
    [StringLength(32)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADUserID")]
    public int AduserId { get; set; }

    [Column("ADUserName")]
    [StringLength(64)]
    public string AduserName { get; set; }

    [Required]
    [Column("HRTimeKeeperHistoryObjectName")]
    [StringLength(64)]
    public string HrtimeKeeperHistoryObjectName { get; set; }

    [Column("HRTimeKeeperHistoryObjectID")]
    public int? HrtimeKeeperHistoryObjectId { get; set; }

    [Column("HRTimeKeeperHistoryObjectNo")]
    [StringLength(64)]
    public string HrtimeKeeperHistoryObjectNo { get; set; }

    [Required]
    [Column("HRTimeKeeperHistoryAction")]
    [StringLength(64)]
    public string HrtimeKeeperHistoryAction { get; set; }

    [Column("HRTimeKeeperHistoryDate", TypeName = "datetime")]
    public DateTime? HrtimeKeeperHistoryDate { get; set; }

    [Column("FK_HRTimeKeeperCompleteID")]
    public int? FkHrtimeKeeperCompleteId { get; set; }

    [ForeignKey("FkHrtimeKeeperCompleteId")]
    [InverseProperty("HrtimeKeeperHistories")]
    public virtual HrtimeKeeperComplete FkHrtimeKeeperComplete { get; set; }

    [InverseProperty("FkHrtimeKeeperHistory")]
    public virtual ICollection<HrtimeKeeperHistoryDetail> HrtimeKeeperHistoryDetails { get; set; } = new List<HrtimeKeeperHistoryDetail>();
}
