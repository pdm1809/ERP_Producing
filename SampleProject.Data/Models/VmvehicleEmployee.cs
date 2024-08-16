using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("VMVehicleEmployees")]
public partial class VmvehicleEmployee
{
    [Key]
    [Column("VMVehicleEmployeeID")]
    public int VmvehicleEmployeeId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Required]
    [Column("VMVehicleEmployeeNo")]
    [StringLength(50)]
    public string VmvehicleEmployeeNo { get; set; }

    [Column("VMVehicleEmployeeName")]
    [StringLength(200)]
    public string VmvehicleEmployeeName { get; set; }

    [Column("VMVehicleEmployeeTel")]
    [StringLength(50)]
    public string VmvehicleEmployeeTel { get; set; }

    [Column("VMVehicleEmployeeContactAddress")]
    [StringLength(200)]
    public string VmvehicleEmployeeContactAddress { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("VMObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string VmobjectType { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("VmvehicleEmployees")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
