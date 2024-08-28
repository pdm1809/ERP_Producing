using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACStopAllocationEquipments")]
public partial class AcstopAllocationEquipment
{
    [Key]
    [Column("ACStopAllocationEquipmentID")]
    public int AcstopAllocationEquipmentId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("ACStopAllocationEquipmentNo")]
    [StringLength(50)]
    public string AcstopAllocationEquipmentNo { get; set; }

    [Column("ACStopAllocationEquipmentName")]
    [StringLength(128)]
    public string AcstopAllocationEquipmentName { get; set; }

    [Column("ACStopAllocationEquipmentDesc")]
    [StringLength(512)]
    public string AcstopAllocationEquipmentDesc { get; set; }

    [Column("ACStopAllocationEquipmentReason")]
    [StringLength(512)]
    public string AcstopAllocationEquipmentReason { get; set; }

    [Column("ACStopAllocationEquipmentDate", TypeName = "datetime")]
    public DateTime? AcstopAllocationEquipmentDate { get; set; }

    [Column("ACStopAllocationEquipmentDateStop", TypeName = "datetime")]
    public DateTime AcstopAllocationEquipmentDateStop { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductIdentifiedEquipmentID")]
    public int? FkIcproductIdentifiedEquipmentId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ACStopAllocationEquipmentType")]
    [StringLength(50)]
    public string AcstopAllocationEquipmentType { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcstopAllocationEquipments")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcstopAllocationEquipments")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductIdentifiedEquipmentId")]
    [InverseProperty("AcstopAllocationEquipments")]
    public virtual IcproductIdentifiedEquipment FkIcproductIdentifiedEquipment { get; set; }
}
