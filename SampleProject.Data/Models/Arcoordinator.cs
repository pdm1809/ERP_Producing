using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCoordinators")]
public partial class Arcoordinator
{
    [Key]
    [Column("ARCoordinatorID")]
    public long ArcoordinatorId { get; set; }

    [Column("ARCoordinatorDate")]
    public DateTime? ArcoordinatorDate { get; set; }

    [Column("ARCoordinatorNo")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcoordinatorNo { get; set; }

    [Column("ARCoordinatorStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcoordinatorStatus { get; set; }

    [Column("AACreatedDate")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(255)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AAUpdatedDate")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(255)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("ARCoordinatorVehicleNoPlate")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcoordinatorVehicleNoPlate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Arcoordinators")]
    public virtual Hremployee FkHremployee { get; set; }
}
