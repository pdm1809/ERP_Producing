using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDepartmentGroupCapacitys")]
public partial class HrdepartmentGroupCapacity
{
    [Key]
    [Column("HRDepartmentGroupCapacityID")]
    public int HrdepartmentGroupCapacityId { get; set; }

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

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_MMMeasureUnitID")]
    public int? FkMmmeasureUnitId { get; set; }

    [Column("HRDepartmentGroupCapacity", TypeName = "decimal(18, 5)")]
    public decimal? HrdepartmentGroupCapacity1 { get; set; }

    [Column("HRDepartmentProductType")]
    [StringLength(50)]
    public string HrdepartmentProductType { get; set; }

    [Column("HRDepartmentGroupCapacityDesc")]
    [StringLength(512)]
    public string HrdepartmentGroupCapacityDesc { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HrdepartmentGroupCapacities")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }
}
