using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADUserDevices")]
public partial class AduserDevice
{
    [Key]
    [Column("ADUserDeviceID")]
    public long AduserDeviceId { get; set; }

    [Column("ADUserDeviceIsActive")]
    public bool? AduserDeviceIsActive { get; set; }

    [Column("AACreatedDate")]
    public DateTime? AacreatedDate { get; set; }

    [Column("ADUserDeviceName")]
    [StringLength(255)]
    [Unicode(false)]
    public string AduserDeviceName { get; set; }

    [Column("ADUserDeviceType")]
    [StringLength(255)]
    [Unicode(false)]
    public string AduserDeviceType { get; set; }

    [Column("AAUpdatedDate")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ADUserID")]
    public int? FkAduserId { get; set; }

    [ForeignKey("FkAduserId")]
    [InverseProperty("AduserDevices")]
    public virtual Aduser FkAduser { get; set; }
}
