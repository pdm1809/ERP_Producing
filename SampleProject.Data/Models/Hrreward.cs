using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRewards")]
public partial class Hrreward
{
    [Key]
    [Column("HRRewardID")]
    public int HrrewardId { get; set; }

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

    [Required]
    [Column("HRRewardNo")]
    [StringLength(50)]
    public string HrrewardNo { get; set; }

    [Required]
    [Column("HRRewardName")]
    [StringLength(100)]
    public string HrrewardName { get; set; }

    [Column("HRRewardDesc")]
    [StringLength(512)]
    public string HrrewardDesc { get; set; }

    [Column("HRRewardFromDate", TypeName = "datetime")]
    public DateTime HrrewardFromDate { get; set; }

    [Column("HRRewardToDate", TypeName = "datetime")]
    public DateTime HrrewardToDate { get; set; }

    [Required]
    [Column("HRRewardType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrrewardType { get; set; }

    [Required]
    [Column("HRRewardValue")]
    [StringLength(512)]
    public string HrrewardValue { get; set; }

    [Column("HRRewardOption")]
    [StringLength(200)]
    public string HrrewardOption { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Hrrewards")]
    public virtual Brbranch FkBrbranch { get; set; }

    [InverseProperty("FkHrreward")]
    public virtual ICollection<HremployeeReward> HremployeeRewards { get; set; } = new List<HremployeeReward>();
}
