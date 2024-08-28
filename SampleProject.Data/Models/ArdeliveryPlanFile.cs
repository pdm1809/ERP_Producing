using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanFiles")]
public partial class ArdeliveryPlanFile
{
    [Key]
    [Column("ARDeliveryPlanFileID")]
    public int ArdeliveryPlanFileId { get; set; }

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

    [Column("FK_ARDeliveryPlanItemID")]
    public int? FkArdeliveryPlanItemId { get; set; }

    [Column("FK_ARDeliveryPlanTruckID")]
    public int? FkArdeliveryPlanTruckId { get; set; }

    [Column("FK_ARDeliveryPlanTruckItemID")]
    public int? FkArdeliveryPlanTruckItemId { get; set; }

    [Column("FK_ARDeliveryPlanReportIssueID")]
    public int? FkArdeliveryPlanReportIssueId { get; set; }

    [Column("FK_ARDeliveryPlanWorkID")]
    public int? FkArdeliveryPlanWorkId { get; set; }

    [Column("FK_ARDeliveryPlanWorkTaskID")]
    public int? FkArdeliveryPlanWorkTaskId { get; set; }

    [Column("ARDeliveryPlanFileType")]
    [StringLength(50)]
    public string ArdeliveryPlanFileType { get; set; }

    [Column("ARDeliveryPlanFileName")]
    public Guid? ArdeliveryPlanFileName { get; set; }

    [Column("ARDeliveryPlanFileNameDesc")]
    [StringLength(256)]
    public string ArdeliveryPlanFileNameDesc { get; set; }

    [Column("ARDeliveryPlanFileLinkRoot")]
    [StringLength(256)]
    public string ArdeliveryPlanFileLinkRoot { get; set; }

    [Column("ARDeliveryPlanFileLink")]
    [StringLength(256)]
    public string ArdeliveryPlanFileLink { get; set; }

    [Column("ARDeliveryPlanFileExtention")]
    [StringLength(10)]
    public string ArdeliveryPlanFileExtention { get; set; }

    [Column("FK_ARDeliveryPlanTruckPointID")]
    public int? FkArdeliveryPlanTruckPointId { get; set; }

    [Column("ARDeliveryPlanFilePurpose")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArdeliveryPlanFilePurpose { get; set; }

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanFiles")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArdeliveryPlanItemId")]
    [InverseProperty("ArdeliveryPlanFiles")]
    public virtual ArdeliveryPlanItem FkArdeliveryPlanItem { get; set; }

    [ForeignKey("FkArdeliveryPlanReportIssueId")]
    [InverseProperty("ArdeliveryPlanFiles")]
    public virtual ArdeliveryPlanReportIssue FkArdeliveryPlanReportIssue { get; set; }

    [ForeignKey("FkArdeliveryPlanTruckId")]
    [InverseProperty("ArdeliveryPlanFiles")]
    public virtual ArdeliveryPlanTruck FkArdeliveryPlanTruck { get; set; }

    [ForeignKey("FkArdeliveryPlanTruckItemId")]
    [InverseProperty("ArdeliveryPlanFiles")]
    public virtual ArdeliveryPlanTruckItem FkArdeliveryPlanTruckItem { get; set; }

    [ForeignKey("FkArdeliveryPlanTruckPointId")]
    [InverseProperty("ArdeliveryPlanFiles")]
    public virtual ArdeliveryPlanTruckPoint FkArdeliveryPlanTruckPoint { get; set; }

    [ForeignKey("FkArdeliveryPlanWorkId")]
    [InverseProperty("ArdeliveryPlanFiles")]
    public virtual ArdeliveryPlanWork FkArdeliveryPlanWork { get; set; }

    [ForeignKey("FkArdeliveryPlanWorkTaskId")]
    [InverseProperty("ArdeliveryPlanFiles")]
    public virtual ArdeliveryPlanWorkTask FkArdeliveryPlanWorkTask { get; set; }
}
