using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMachineUnitCapacitys")]
public partial class MmmachineUnitCapacity
{
    [Key]
    [Column("MMMachineUnitCapacityID")]
    public int MmmachineUnitCapacityId { get; set; }

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

    [Column("FK_MMMeasureUnitID")]
    public int? FkMmmeasureUnitId { get; set; }

    [Column("MMMachineUnitCapacity", TypeName = "decimal(18, 5)")]
    public decimal? MmmachineUnitCapacity1 { get; set; }

    [Column("HRDepartmentProductType")]
    [StringLength(50)]
    public string HrdepartmentProductType { get; set; }

    [Column("MMMachineUnitCapacityDesc")]
    [StringLength(512)]
    public string MmmachineUnitCapacityDesc { get; set; }

    [ForeignKey("FkMmmachineUnitId")]
    [InverseProperty("MmmachineUnitCapacities")]
    public virtual MmmachineUnit FkMmmachineUnit { get; set; }
}
