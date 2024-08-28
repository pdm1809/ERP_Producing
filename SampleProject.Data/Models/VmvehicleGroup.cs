using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("VMVehicleGroups")]
[Microsoft.EntityFrameworkCore.Index("VmvehicleGroupNo", Name = "Idx_VMVehicleGroups")]
public partial class VmvehicleGroup
{
    [Key]
    [Column("VMVehicleGroupID")]
    public int VmvehicleGroupId { get; set; }

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
    [Column("VMVehicleGroupNo")]
    [StringLength(50)]
    public string VmvehicleGroupNo { get; set; }

    [Required]
    [Column("VMVehicleGroupDesc")]
    [StringLength(512)]
    public string VmvehicleGroupDesc { get; set; }

    [InverseProperty("FkVmvehicleGroup")]
    public virtual ICollection<Vmvehicle> Vmvehicles { get; set; } = new List<Vmvehicle>();
}
