using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMDepartmentCapacityConfigs")]
public partial class MmdepartmentCapacityConfig
{
    [Key]
    [Column("MMDepartmentCapacityConfigID")]
    public int MmdepartmentCapacityConfigId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("MMProductGroupType")]
    [StringLength(50)]
    public string MmproductGroupType { get; set; }

    [Column("MMDepartmentCapacityConfigQtyPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? MmdepartmentCapacityConfigQtyPerMonth { get; set; }

    [Column("MMDepartmentCapacityConfigDayInMonth", TypeName = "decimal(18, 5)")]
    public decimal? MmdepartmentCapacityConfigDayInMonth { get; set; }

    [Column("MMDepartmentCapacityConfigQtyPerDay", TypeName = "decimal(18, 5)")]
    public decimal? MmdepartmentCapacityConfigQtyPerDay { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmdepartmentCapacityConfigs")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmdepartmentCapacityConfigs")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
