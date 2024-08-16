using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeRewards")]
public partial class HrtimeReward
{
    [Key]
    [Column("HRTimeRewardID")]
    public int HrtimeRewardId { get; set; }

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

    [Column("HRTimeRewardSalesFrom", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeRewardSalesFrom { get; set; }

    [Column("HRTimeRewardSalesTo", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeRewardSalesTo { get; set; }

    [Column("HRTimeRewardReceiptRate", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeRewardReceiptRate { get; set; }

    [Column("HRTimeRewardReceiptType")]
    [StringLength(50)]
    public string HrtimeRewardReceiptType { get; set; }
}
