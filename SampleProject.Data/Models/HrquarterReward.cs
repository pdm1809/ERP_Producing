using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRQuarterRewards")]
public partial class HrquarterReward
{
    [Key]
    [Column("HRQuarterRewardID")]
    public int HrquarterRewardId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Required]
    [Column("HRQuarterRewardNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrquarterRewardNo { get; set; }

    [Required]
    [Column("HRQuarterRewardName")]
    [StringLength(500)]
    [Unicode(false)]
    public string HrquarterRewardName { get; set; }

    [Required]
    [Column("HRQuarterRewardDesc")]
    [StringLength(500)]
    [Unicode(false)]
    public string HrquarterRewardDesc { get; set; }

    [Column("HRQuarterRewardAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrquarterRewardAmount { get; set; }

    [Column("HRQuarterRewardType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrquarterRewardType { get; set; }

    [Column("HRQuarterRewardDateFrom", TypeName = "datetime")]
    public DateTime? HrquarterRewardDateFrom { get; set; }

    [Column("HRQuarterRewardateTo", TypeName = "datetime")]
    public DateTime? HrquarterRewardateTo { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("HRQuarterRewardDate", TypeName = "datetime")]
    public DateTime? HrquarterRewardDate { get; set; }

    [Column("HRQuarterRewardEffectiveDate", TypeName = "datetime")]
    public DateTime? HrquarterRewardEffectiveDate { get; set; }

    [Column("HRQuarterRewardExpiryDate", TypeName = "datetime")]
    public DateTime? HrquarterRewardExpiryDate { get; set; }

    [Column("HRQuarterRewardStatus")]
    [StringLength(500)]
    public string HrquarterRewardStatus { get; set; }

    [Column("HRQuarterRewardMonth")]
    public int? HrquarterRewardMonth { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrquarterRewards")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrquarterRewards")]
    public virtual Hremployee FkHremployee { get; set; }
}
