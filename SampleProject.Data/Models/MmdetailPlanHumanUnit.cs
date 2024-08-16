using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMDetailPlanHumanUnits")]
public partial class MmdetailPlanHumanUnit
{
    [Key]
    [Column("MMDetailPlanHumanUnitID")]
    public int MmdetailPlanHumanUnitId { get; set; }

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

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("MMDetailPlanHumanUnitDesc")]
    [StringLength(512)]
    public string MmdetailPlanHumanUnitDesc { get; set; }

    [Column("MMDetailPlanHumanUnitAbstract")]
    [StringLength(524)]
    public string MmdetailPlanHumanUnitAbstract { get; set; }
}
