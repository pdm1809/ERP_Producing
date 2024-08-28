using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMDetailPlanEquipments")]
public partial class MmdetailPlanEquipment
{
    [Key]
    [Column("MMDetailPlanEquipmentID")]
    public int MmdetailPlanEquipmentId { get; set; }

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

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int? FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICEquipmentID")]
    public int? FkIcequipmentId { get; set; }

    [Column("MMDetailPlanEquipmentFromDate", TypeName = "datetime")]
    public DateTime? MmdetailPlanEquipmentFromDate { get; set; }

    [Column("MMDetailPlanEquipmentToDate", TypeName = "datetime")]
    public DateTime? MmdetailPlanEquipmentToDate { get; set; }

    [Column("MMDetailPlanEquipmentQty", TypeName = "decimal(18, 5)")]
    public decimal? MmdetailPlanEquipmentQty { get; set; }

    [Column("MMDetailPlanEquipmentPlanQty", TypeName = "decimal(18, 5)")]
    public decimal? MmdetailPlanEquipmentPlanQty { get; set; }

    [Column("MMDetailPlanEquipmentDesc")]
    [StringLength(512)]
    public string MmdetailPlanEquipmentDesc { get; set; }

    [Column("MMDetailPlanEquipmentAbstract")]
    [StringLength(524)]
    public string MmdetailPlanEquipmentAbstract { get; set; }

    [Column("MMDetailPlanEquipmentStatus")]
    [StringLength(50)]
    public string MmdetailPlanEquipmentStatus { get; set; }
}
