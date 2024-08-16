using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMDetailPlanMachineUnits")]
public partial class MmdetailPlanMachineUnit
{
    [Key]
    [Column("MMDetailPlanMachineUnitID")]
    public int MmdetailPlanMachineUnitId { get; set; }

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

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int? FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("HRDepartmentEmployeeQty", TypeName = "decimal(18, 5)")]
    public decimal? HrdepartmentEmployeeQty { get; set; }

    [Column("MMDetailPlanMachineUnitDesc")]
    [StringLength(512)]
    public string MmdetailPlanMachineUnitDesc { get; set; }

    [Column("MMDetailPlanMachineUnitAbstract")]
    [StringLength(524)]
    public string MmdetailPlanMachineUnitAbstract { get; set; }

    [Column("FK_ADWorkingShiftID")]
    public int? FkAdworkingShiftId { get; set; }

    [Column("MMDetailPlanMachineUnitCapacity", TypeName = "decimal(18, 5)")]
    public decimal? MmdetailPlanMachineUnitCapacity { get; set; }

    [Column("MMCapacityUnit")]
    [StringLength(50)]
    public string MmcapacityUnit { get; set; }

    [Column("MMDetailPlanMachineUnitQty", TypeName = "decimal(18, 5)")]
    public decimal? MmdetailPlanMachineUnitQty { get; set; }

    [Column("MMDetailPlanMachineUnitType")]
    [StringLength(50)]
    public string MmdetailPlanMachineUnitType { get; set; }

    [Column("MMDetailPlanMachineUnitSetupTime", TypeName = "decimal(18, 5)")]
    public decimal? MmdetailPlanMachineUnitSetupTime { get; set; }
}
