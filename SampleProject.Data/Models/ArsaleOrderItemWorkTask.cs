using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderItemWorkTasks")]
public partial class ArsaleOrderItemWorkTask
{
    [Key]
    [Column("ARSaleOrderItemWorkTaskID")]
    public int ArsaleOrderItemWorkTaskId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_PMProjectTypeID")]
    public int? FkPmprojectTypeId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICTaskID")]
    public int? FkIctaskId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ARSaleOrderItemWorkID")]
    public int? FkArsaleOrderItemWorkId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("ARSaleOrderItemWorkTaskNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderItemWorkTaskNo { get; set; }

    [Column("ARSaleOrderItemWorkTaskName")]
    [StringLength(256)]
    public string ArsaleOrderItemWorkTaskName { get; set; }

    [Column("ARSaleOrderItemWorkTaskInfo")]
    [StringLength(512)]
    public string ArsaleOrderItemWorkTaskInfo { get; set; }

    [Column("ARSaleOrderItemWorkTaskTotalEstimatedDays", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskTotalEstimatedDays { get; set; }

    [Column("ARSaleOrderItemWorkTaskTotalActualDays", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskTotalActualDays { get; set; }

    [Column("ARSaleOrderItemWorkTaskTotalEstimatedHours", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskTotalEstimatedHours { get; set; }

    [Column("ARSaleOrderItemWorkTaskTotalActualHours", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskTotalActualHours { get; set; }

    [Column("ARSaleOrderItemWorkTaskEstimatedExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskEstimatedExtendDays { get; set; }

    [Column("ARSaleOrderItemWorkTaskActualExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskActualExtendDays { get; set; }

    [Column("ARSaleOrderItemWorkTaskEstimatedExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskEstimatedExtendHours { get; set; }

    [Column("ARSaleOrderItemWorkTaskActualExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskActualExtendHours { get; set; }

    [Column("ARSaleOrderItemWorkTaskQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskQty { get; set; }

    [Column("ARSaleOrderItemWorkTaskEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskEstimatedTotalCost { get; set; }

    [Column("ARSaleOrderItemWorkTaskActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTaskActualTotalCost { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkArsaleOrderItemWorkId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual ArsaleOrderItemWork FkArsaleOrderItemWork { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIctaskId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual Ictask FkIctask { get; set; }

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("ArsaleOrderItemWorkTasks")]
    public virtual PmprojectType FkPmprojectType { get; set; }
}
