using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMLabourProductivityTargetConfigs")]
public partial class MmlabourProductivityTargetConfig
{
    [Key]
    [Column("MMLabourProductivityTargetConfigID")]
    public int MmlabourProductivityTargetConfigId { get; set; }

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

    [Column("MMLabourProductivityTargetConfigDateType")]
    [StringLength(50)]
    public string MmlabourProductivityTargetConfigDateType { get; set; }

    [Column("MMLabourProductivityTargetConfigDate", TypeName = "datetime")]
    public DateTime? MmlabourProductivityTargetConfigDate { get; set; }

    [Column("MMLabourProductivityTargetConfigSoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmlabourProductivityTargetConfigSoChe { get; set; }

    [Column("MMLabourProductivityTargetConfigDinhHinh", TypeName = "decimal(18, 5)")]
    public decimal? MmlabourProductivityTargetConfigDinhHinh { get; set; }

    [Column("MMLabourProductivityTargetConfigLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmlabourProductivityTargetConfigLapRap { get; set; }

    [Column("MMLabourProductivityTargetConfigSon", TypeName = "decimal(18, 5)")]
    public decimal? MmlabourProductivityTargetConfigSon { get; set; }

    [Column("MMLabourProductivityTargetConfigDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmlabourProductivityTargetConfigDongGoi { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmlabourProductivityTargetConfigs")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmlabourProductivityTargetConfigs")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmlabourProductivityTargetConfigs")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
