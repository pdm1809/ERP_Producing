using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICMachines")]
public partial class Icmachine
{
    [Key]
    [Column("ICMachineID")]
    public int IcmachineId { get; set; }

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

    [Column("ICMachineName")]
    [StringLength(100)]
    public string IcmachineName { get; set; }

    [Column("ICMachineStatus")]
    [StringLength(50)]
    public string IcmachineStatus { get; set; }

    [Column("ICMachineTime", TypeName = "decimal(18, 5)")]
    public decimal? IcmachineTime { get; set; }

    [Column("ICMachineTimeCapacity", TypeName = "decimal(18, 5)")]
    public decimal? IcmachineTimeCapacity { get; set; }

    [Column("ICMachineUnit")]
    [StringLength(50)]
    public string IcmachineUnit { get; set; }

    [Column("ICMachineNumberPerson")]
    public int? IcmachineNumberPerson { get; set; }

    [InverseProperty("FkIcmachine")]
    public virtual ICollection<IcmachineGroup> IcmachineGroups { get; set; } = new List<IcmachineGroup>();
}
