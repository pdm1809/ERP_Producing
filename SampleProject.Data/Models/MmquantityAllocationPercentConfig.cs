using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMQuantityAllocationPercentConfigs")]
public partial class MmquantityAllocationPercentConfig
{
    [Key]
    [Column("MMQuantityAllocationPercentConfigID")]
    public int MmquantityAllocationPercentConfigId { get; set; }

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

    [Column("MMQuantityAllocationPercentConfigDateType")]
    [StringLength(50)]
    public string MmquantityAllocationPercentConfigDateType { get; set; }

    [Column("MMQuantityAllocationPercentConfigDate", TypeName = "datetime")]
    public DateTime? MmquantityAllocationPercentConfigDate { get; set; }

    [Column("MMQuantityAllocationPercentConfigSoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmquantityAllocationPercentConfigSoChe { get; set; }

    [Column("MMQuantityAllocationPercentConfigDinhHinh", TypeName = "decimal(18, 5)")]
    public decimal? MmquantityAllocationPercentConfigDinhHinh { get; set; }

    [Column("MMQuantityAllocationPercentConfigLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmquantityAllocationPercentConfigLapRap { get; set; }

    [Column("MMQuantityAllocationPercentConfigSon", TypeName = "decimal(18, 5)")]
    public decimal? MmquantityAllocationPercentConfigSon { get; set; }

    [Column("MMQuantityAllocationPercentConfigDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmquantityAllocationPercentConfigDongGoi { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmquantityAllocationPercentConfigs")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmquantityAllocationPercentConfigs")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
