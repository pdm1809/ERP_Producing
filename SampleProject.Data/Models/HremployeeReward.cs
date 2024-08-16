using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeRewards")]
public partial class HremployeeReward
{
    [Key]
    [Column("HREmployeeRewardID")]
    public int HremployeeRewardId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRRewardID")]
    public int FkHrrewardId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("HREmployeeRewardValue")]
    [StringLength(512)]
    public string HremployeeRewardValue { get; set; }

    [Column("HREmployeeRewardValueAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeRewardValueAmount { get; set; }

    [Column("HREmployeeRewardFromDate", TypeName = "datetime")]
    public DateTime? HremployeeRewardFromDate { get; set; }

    [Column("HREmployeeRewardToDate", TypeName = "datetime")]
    public DateTime? HremployeeRewardToDate { get; set; }

    [Column("HREmployeeRewardSPN", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeRewardSpn { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeRewards")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrrewardId")]
    [InverseProperty("HremployeeRewards")]
    public virtual Hrreward FkHrreward { get; set; }
}
