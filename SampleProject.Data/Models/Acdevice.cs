using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACDevices")]
public partial class Acdevice
{
    [Key]
    [Column("ACDeviceID")]
    public int AcdeviceId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ACDeviceNo")]
    [StringLength(50)]
    public string AcdeviceNo { get; set; }

    [Column("ACDeviceDate", TypeName = "datetime")]
    public DateTime? AcdeviceDate { get; set; }

    [Column("ACDeviceName")]
    [StringLength(100)]
    public string AcdeviceName { get; set; }

    [Column("ACDeviceEffectDate", TypeName = "datetime")]
    public DateTime? AcdeviceEffectDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ACDeviceIdentifierID")]
    public int? AcdeviceIdentifierId { get; set; }

    [Column("ACDeviceIdentifierType")]
    [StringLength(50)]
    public string AcdeviceIdentifierType { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Acdevices")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Acdevices")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("Acdevices")]
    public virtual Icproduct FkIcproduct { get; set; }
}
