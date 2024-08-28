using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationMachineGroups")]
public partial class MmoperationMachineGroup
{
    [Key]
    [Column("MMOperationMachineGroupID")]
    public int MmoperationMachineGroupId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMMachineGroup")]
    [StringLength(50)]
    public string MmmachineGroup { get; set; }

    [Column("MMOperationMachineGroupIsDefault")]
    public bool? MmoperationMachineGroupIsDefault { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmoperationMachineGroups")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
