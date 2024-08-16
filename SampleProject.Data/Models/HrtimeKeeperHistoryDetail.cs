using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeKeeperHistoryDetails")]
public partial class HrtimeKeeperHistoryDetail
{
    [Key]
    [Column("HRTimeKeeperHistoryDetailID")]
    public int HrtimeKeeperHistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(32)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRTimeKeeperHistoryID")]
    public int FkHrtimeKeeperHistoryId { get; set; }

    [Required]
    [Column("HRTimeKeeperHistoryDetailTableName")]
    [StringLength(64)]
    public string HrtimeKeeperHistoryDetailTableName { get; set; }

    [Required]
    [Column("HRTimeKeeperHistoryDetailColumnName")]
    [StringLength(128)]
    public string HrtimeKeeperHistoryDetailColumnName { get; set; }

    [Required]
    [Column("HRTimeKeeperHistoryDetailOldValue")]
    [StringLength(512)]
    public string HrtimeKeeperHistoryDetailOldValue { get; set; }

    [Required]
    [Column("HRTimeKeeperHistoryDetailNewValue")]
    [StringLength(512)]
    public string HrtimeKeeperHistoryDetailNewValue { get; set; }

    [Required]
    [Column("HRTimeKeeperHistoryDetailEmployeeCardNumber")]
    [StringLength(32)]
    [Unicode(false)]
    public string HrtimeKeeperHistoryDetailEmployeeCardNumber { get; set; }

    [ForeignKey("FkHrtimeKeeperHistoryId")]
    [InverseProperty("HrtimeKeeperHistoryDetails")]
    public virtual HrtimeKeeperHistory FkHrtimeKeeperHistory { get; set; }
}
