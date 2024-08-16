using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMachineUnitOperations")]
public partial class MmmachineUnitOperation
{
    [Key]
    [Column("MMMachineUnitOperationID")]
    public int MmmachineUnitOperationId { get; set; }

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

    [Column("FK_MMMachineUnitID")]
    public int? FkMmmachineUnitId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMMachineUnitOperationNo")]
    [StringLength(50)]
    public string MmmachineUnitOperationNo { get; set; }

    [Column("MMMachineUnitOperationName")]
    [StringLength(50)]
    public string MmmachineUnitOperationName { get; set; }

    [Column("MMMachineUnitOperationDesc")]
    [StringLength(512)]
    public string MmmachineUnitOperationDesc { get; set; }

    [Column("MMMachineUnitOperationSetupTime", TypeName = "decimal(18, 5)")]
    public decimal? MmmachineUnitOperationSetupTime { get; set; }

    [Column("MMMachineUnitOperationCapacity", TypeName = "decimal(18, 5)")]
    public decimal? MmmachineUnitOperationCapacity { get; set; }

    [Column("MMCapacityUnit")]
    [StringLength(50)]
    public string MmcapacityUnit { get; set; }

    [ForeignKey("FkMmmachineUnitId")]
    [InverseProperty("MmmachineUnitOperations")]
    public virtual MmmachineUnit FkMmmachineUnit { get; set; }
}
