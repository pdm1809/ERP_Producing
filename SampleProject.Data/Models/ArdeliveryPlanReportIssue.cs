using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanReportIssues")]
public partial class ArdeliveryPlanReportIssue
{
    [Key]
    [Column("ARDeliveryPlanReportIssueID")]
    public int ArdeliveryPlanReportIssueId { get; set; }

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

    [Column("FK_ARDeliveryPlanID")]
    public int? FkArdeliveryPlanId { get; set; }

    [Column("FK_ARDeliveryPlanTruckID")]
    public int? FkArdeliveryPlanTruckId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARDeliveryPlanReportIssueDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanReportIssueDate { get; set; }

    [Column("ARDeliveryPlanReportIssueName")]
    [StringLength(256)]
    public string ArdeliveryPlanReportIssueName { get; set; }

    [Column("ARDeliveryPlanReportIssueDesc")]
    [StringLength(512)]
    public string ArdeliveryPlanReportIssueDesc { get; set; }

    [Column("ARDeliveryPlanReportIssueType")]
    [StringLength(50)]
    public string ArdeliveryPlanReportIssueType { get; set; }

    [Column("ARDeliveryPlanReportIssueStatus")]
    [StringLength(50)]
    public string ArdeliveryPlanReportIssueStatus { get; set; }

    [Column("FK_ARDeliveryPlanTruckPointID")]
    public int? FkArdeliveryPlanTruckPointId { get; set; }

    [InverseProperty("FkArdeliveryPlanReportIssue")]
    public virtual ICollection<ArdeliveryPlanFile> ArdeliveryPlanFiles { get; set; } = new List<ArdeliveryPlanFile>();

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanReportIssues")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArdeliveryPlanTruckId")]
    [InverseProperty("ArdeliveryPlanReportIssues")]
    public virtual ArdeliveryPlanTruck FkArdeliveryPlanTruck { get; set; }

    [ForeignKey("FkArdeliveryPlanTruckPointId")]
    [InverseProperty("ArdeliveryPlanReportIssues")]
    public virtual ArdeliveryPlanTruckPoint FkArdeliveryPlanTruckPoint { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArdeliveryPlanReportIssues")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArdeliveryPlanReportIssues")]
    public virtual Hremployee FkHremployee { get; set; }
}
