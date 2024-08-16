using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMDefaultAllocationOperationConfigs")]
public partial class MmdefaultAllocationOperationConfig
{
    [Key]
    [Column("MMDefaultAllocationOperationConfigID")]
    public int MmdefaultAllocationOperationConfigId { get; set; }

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

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmdefaultAllocationOperationConfigs")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmdefaultAllocationOperationConfigs")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmdefaultAllocationOperationConfigs")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
