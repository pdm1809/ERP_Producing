using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AREmailTrackings")]
public partial class AremailTracking
{
    [Key]
    [Column("AREmailTrackingID")]
    public int AremailTrackingId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("CreatedUserID")]
    public int? CreatedUserId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("AREmailTrackingTitle")]
    [StringLength(512)]
    public string AremailTrackingTitle { get; set; }

    [Column("AREmailTrackingContent")]
    [StringLength(100)]
    public string AremailTrackingContent { get; set; }

    [Column("AREmailTrackingSubject")]
    [StringLength(512)]
    public string AremailTrackingSubject { get; set; }

    [Column("AREmailTrackingTo")]
    [StringLength(512)]
    public string AremailTrackingTo { get; set; }

    [Column("AREmailTrackingRecipients")]
    [StringLength(4000)]
    public string AremailTrackingRecipients { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AremailTrackings")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AremailTrackings")]
    public virtual Hremployee FkHremployee { get; set; }
}
