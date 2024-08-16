using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanWorkTasks")]
public partial class ArdeliveryPlanWorkTask
{
    [Key]
    [Column("ARDeliveryPlanWorkTaskID")]
    public int ArdeliveryPlanWorkTaskId { get; set; }

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

    [Column("FK_ARDeliveryPlanWorkID")]
    public int? FkArdeliveryPlanWorkId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeOwnerID")]
    public int? FkHremployeeOwnerId { get; set; }

    [Column("FK_ICTaskID")]
    public int? FkIctaskId { get; set; }

    [Column("ARDeliveryPlanWorkTaskNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArdeliveryPlanWorkTaskNo { get; set; }

    [Column("ARDeliveryPlanWorkTaskName")]
    [StringLength(256)]
    public string ArdeliveryPlanWorkTaskName { get; set; }

    [Column("ARDeliveryPlanWorkTaskInfo")]
    [StringLength(512)]
    public string ArdeliveryPlanWorkTaskInfo { get; set; }

    [Column("ARDeliveryPlanWorkTaskTotalEstimatedDays", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskTotalEstimatedDays { get; set; }

    [Column("ARDeliveryPlanWorkTaskTotalActualDays", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskTotalActualDays { get; set; }

    [Column("ARDeliveryPlanWorkTaskTotalEstimatedHours", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskTotalEstimatedHours { get; set; }

    [Column("ARDeliveryPlanWorkTaskTotalActualHours", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskTotalActualHours { get; set; }

    [Column("ARDeliveryPlanWorkTaskEstimatedExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskEstimatedExtendDays { get; set; }

    [Column("AARDeliveryPlanWorkTaskActualExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? AardeliveryPlanWorkTaskActualExtendDays { get; set; }

    [Column("ARDeliveryPlanWorkTaskEstimatedExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskEstimatedExtendHours { get; set; }

    [Column("ARDeliveryPlanWorkTaskActualExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskActualExtendHours { get; set; }

    [Column("ARDeliveryPlanWorkTaskQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskQty { get; set; }

    [Column("ARDeliveryPlanWorkTaskEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskEstimatedTotalCost { get; set; }

    [Column("ARDeliveryPlanWorkTaskActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTaskActualTotalCost { get; set; }

    [Column("ARDeliveryPlanWorkTaskBeginDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanWorkTaskBeginDate { get; set; }

    [Column("ARDeliveryPlanWorkTaskEndDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanWorkTaskEndDate { get; set; }

    [Column("ARDeliveryPlanWorkTaskStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArdeliveryPlanWorkTaskStatus { get; set; }

    [InverseProperty("FkArdeliveryPlanWorkTask")]
    public virtual ICollection<ArdeliveryPlanFile> ArdeliveryPlanFiles { get; set; } = new List<ArdeliveryPlanFile>();

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArdeliveryPlanItemId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual ArdeliveryPlanItem FkArdeliveryPlanItem { get; set; }

    [ForeignKey("FkArdeliveryPlanWorkId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual ArdeliveryPlanWork FkArdeliveryPlanWork { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArdeliveryPlanWorkTaskFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeOwnerId")]
    [InverseProperty("ArdeliveryPlanWorkTaskFkHremployeeOwners")]
    public virtual Hremployee FkHremployeeOwner { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIctaskId")]
    [InverseProperty("ArdeliveryPlanWorkTasks")]
    public virtual Ictask FkIctask { get; set; }
}
