using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliverys")]
public partial class Ardelivery
{
    [Key]
    [Column("ARDeliveryID")]
    public int ArdeliveryId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRDeliveryEmployeeID")]
    public int FkHrdeliveryEmployeeId { get; set; }

    [Column("FK_VMVehicleID")]
    public int FkVmvehicleId { get; set; }

    [Column("ARDeliveryStatus")]
    [StringLength(100)]
    public string ArdeliveryStatus { get; set; }

    [Required]
    [Column("ARDeliveryNo")]
    [StringLength(50)]
    public string ArdeliveryNo { get; set; }

    [Column("ARDeliveryDesc")]
    [StringLength(512)]
    public string ArdeliveryDesc { get; set; }

    [Column("ARDeliveryDate", TypeName = "datetime")]
    public DateTime? ArdeliveryDate { get; set; }

    [Column("ARDeliveryTotalKm", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryTotalKm { get; set; }

    [Column("ARDeliveryTotalPackage", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryTotalPackage { get; set; }

    [Column("ARDeliveryReference")]
    [StringLength(512)]
    public string ArdeliveryReference { get; set; }

    [ForeignKey("FkHrdeliveryEmployeeId")]
    [InverseProperty("ArdeliveryFkHrdeliveryEmployees")]
    public virtual Hremployee FkHrdeliveryEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArdeliveryFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("Ardeliveries")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
