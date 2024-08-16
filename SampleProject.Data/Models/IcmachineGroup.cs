using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICMachineGroups")]
public partial class IcmachineGroup
{
    [Key]
    [Column("ICMachineGroupID")]
    public int IcmachineGroupId { get; set; }

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

    [Column("ICMachineGroupName")]
    [StringLength(100)]
    public string IcmachineGroupName { get; set; }

    [Column("ICMachineGroupType")]
    [StringLength(50)]
    public string IcmachineGroupType { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("FK_ICProductIdentifiedEquipmentID")]
    public int? FkIcproductIdentifiedEquipmentId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICMachineGroupStatus")]
    [StringLength(50)]
    public string IcmachineGroupStatus { get; set; }

    [Column("ICMachineGroupTime", TypeName = "decimal(18, 5)")]
    public decimal? IcmachineGroupTime { get; set; }

    [Column("ICMachineGroupTimeCapacity", TypeName = "decimal(18, 5)")]
    public decimal? IcmachineGroupTimeCapacity { get; set; }

    [Column("ICMachineGroupUnit")]
    [StringLength(50)]
    public string IcmachineGroupUnit { get; set; }

    [Column("ICMachineGroupNumberPerson")]
    public int? IcmachineGroupNumberPerson { get; set; }

    [Column("FK_ICMachineID")]
    public int? FkIcmachineId { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("IcmachineGroups")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkIcmachineId")]
    [InverseProperty("IcmachineGroups")]
    public virtual Icmachine FkIcmachine { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcmachineGroups")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductIdentifiedEquipmentId")]
    [InverseProperty("IcmachineGroups")]
    public virtual IcproductIdentifiedEquipment FkIcproductIdentifiedEquipment { get; set; }
}
