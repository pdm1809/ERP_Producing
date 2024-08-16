using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanTrucks")]
public partial class ArdeliveryPlanTruck
{
    [Key]
    [Column("ARDeliveryPlanTruckID")]
    public int ArdeliveryPlanTruckId { get; set; }

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

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeDeliveryID")]
    public int? FkHremployeeDeliveryId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("ARDeliveryPlanTruckName")]
    [StringLength(256)]
    public string ArdeliveryPlanTruckName { get; set; }

    [Column("ARDeliveryPlanTruckNumber")]
    [StringLength(256)]
    public string ArdeliveryPlanTruckNumber { get; set; }

    [Column("ARDeliveryPlanTruckGrossTon", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckGrossTon { get; set; }

    [Column("ARDeliveryPlanTruckCapacity", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckCapacity { get; set; }

    [Column("ARDeliveryPlanTruckTotalM3", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckTotalM3 { get; set; }

    [Column("ARDeliveryPlanTruckTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckTotalQty { get; set; }

    [Column("ARDeliveryPlanTruckStatus")]
    [StringLength(50)]
    public string ArdeliveryPlanTruckStatus { get; set; }

    [Column("ARDeliveryPlanTruckSource")]
    [StringLength(50)]
    public string ArdeliveryPlanTruckSource { get; set; }

    [Column("ARDeliveryPlanTruckDriver")]
    [StringLength(50)]
    public string ArdeliveryPlanTruckDriver { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ARDeliveryPlanTruckDeliveryEmployee")]
    [StringLength(256)]
    public string ArdeliveryPlanTruckDeliveryEmployee { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("ARDeliveryPlanTruckComments")]
    [StringLength(500)]
    public string ArdeliveryPlanTruckComments { get; set; }

    [Column("ARDeliverPlanTruckType")]
    [StringLength(100)]
    public string ArdeliverPlanTruckType { get; set; }

    [InverseProperty("FkArdeliveryPlanTruck")]
    public virtual ICollection<ArdeliveryPlanFile> ArdeliveryPlanFiles { get; set; } = new List<ArdeliveryPlanFile>();

    [InverseProperty("FkArdeliveryPlanTruck")]
    public virtual ICollection<ArdeliveryPlanReportIssue> ArdeliveryPlanReportIssues { get; set; } = new List<ArdeliveryPlanReportIssue>();

    [InverseProperty("FkArdeliveryPlanTruck")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkArdeliveryPlanTruck")]
    public virtual ICollection<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; } = new List<ArdeliveryPlanTruckPoint>();

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanTrucks")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArdeliveryPlanTrucks")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("ArdeliveryPlanTrucks")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("ArdeliveryPlanTrucks")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArdeliveryPlanTruckFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeDeliveryId")]
    [InverseProperty("ArdeliveryPlanTruckFkHremployeeDeliveries")]
    public virtual Hremployee FkHremployeeDelivery { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArdeliveryPlanTrucks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArdeliveryPlanTrucks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("ArdeliveryPlanTrucks")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
