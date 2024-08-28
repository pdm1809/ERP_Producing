using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCapacityHumanUnits")]
public partial class MmcapacityHumanUnit
{
    [Key]
    [Column("MMCapacityHumanUnitID")]
    public int MmcapacityHumanUnitId { get; set; }

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

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int? FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("FK_MMOperationDetailPlanCapacityItemID")]
    public int? FkMmoperationDetailPlanCapacityItemId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("MMCapacityHumanUnitDesc")]
    [StringLength(512)]
    public string MmcapacityHumanUnitDesc { get; set; }

    [Column("MMCapacityHumanUnitAbstract")]
    [StringLength(524)]
    public string MmcapacityHumanUnitAbstract { get; set; }
}
