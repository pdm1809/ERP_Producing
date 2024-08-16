using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("VMVehicleFuelLogs")]
[Microsoft.EntityFrameworkCore.Index("VmvehicleFuelLogDate", Name = "Idx_VMVehicleFuelLogs")]
public partial class VmvehicleFuelLog
{
    [Key]
    [Column("VMVehicleFuelLogID")]
    public int VmvehicleFuelLogId { get; set; }

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

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Column("VMVehicleFuelLogDate", TypeName = "datetime")]
    public DateTime? VmvehicleFuelLogDate { get; set; }

    [Column("VMVehicleFuelLogQty", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleFuelLogQty { get; set; }

    [Column("VMVehicleFuelLogCost", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleFuelLogCost { get; set; }

    [Column("VMVehicleFuelLogTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleFuelLogTotalCost { get; set; }

    [Column("VMVehicleFuelLogStartOdometer", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleFuelLogStartOdometer { get; set; }

    [Column("VMVehicleFuelLogEndOdometer", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleFuelLogEndOdometer { get; set; }

    [Column("VMVehicleFuelLogDistanceCovered", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleFuelLogDistanceCovered { get; set; }

    [Column("VMVehicleFuelLogConsumption1", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleFuelLogConsumption1 { get; set; }

    [Column("VMVehicleFuelLogConsumption2", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleFuelLogConsumption2 { get; set; }

    [Column("VMVehicleFuelLogRemark")]
    [StringLength(512)]
    public string VmvehicleFuelLogRemark { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("VmvehicleFuelLogs")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
