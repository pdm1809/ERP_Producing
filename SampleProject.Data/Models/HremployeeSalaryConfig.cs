using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeSalaryConfigs")]
public partial class HremployeeSalaryConfig
{
    [Key]
    [Column("HREmployeeSalaryConfigID")]
    public int HremployeeSalaryConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("HREmployeeSalaryConfigContractAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSalaryConfigContractAmount { get; set; }

    [Column("HREmployeeSalaryConfigResponsibilityAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSalaryConfigResponsibilityAmount { get; set; }

    [Column("HREmployeeSalaryConfigMeasureUnitType")]
    [StringLength(50)]
    public string HremployeeSalaryConfigMeasureUnitType { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HremployeeSalaryConfigs")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeeSalaryConfigs")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeSalaryConfigs")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HremployeeSalaryConfigs")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeeSalaryConfigs")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("HremployeeSalaryConfigs")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
