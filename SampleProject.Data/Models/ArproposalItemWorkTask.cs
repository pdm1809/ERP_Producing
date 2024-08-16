using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProposalItemWorkTasks")]
public partial class ArproposalItemWorkTask
{
    [Key]
    [Column("ARProposalItemWorkTaskID")]
    public int ArproposalItemWorkTaskId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_PMProjectTypeID")]
    public int? FkPmprojectTypeId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICTaskID")]
    public int? FkIctaskId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ARProposalID")]
    public int? FkArproposalId { get; set; }

    [Column("FK_ARProposalItemWorkID")]
    public int? FkArproposalItemWorkId { get; set; }

    [Column("ARProposalItemWorkTaskNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArproposalItemWorkTaskNo { get; set; }

    [Column("ARProposalItemWorkTaskName")]
    [StringLength(256)]
    public string ArproposalItemWorkTaskName { get; set; }

    [Column("ARProposalItemWorkTaskInfo")]
    [StringLength(512)]
    public string ArproposalItemWorkTaskInfo { get; set; }

    [Column("ARProposalItemWorkTaskTotalEstimatedDays", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskTotalEstimatedDays { get; set; }

    [Column("ARProposalItemWorkTaskTotalActualDays", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskTotalActualDays { get; set; }

    [Column("ARProposalItemWorkTaskTotalEstimatedHours", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskTotalEstimatedHours { get; set; }

    [Column("ARProposalItemWorkTaskTotalActualHours", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskTotalActualHours { get; set; }

    [Column("ARProposalItemWorkTaskEstimatedExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskEstimatedExtendDays { get; set; }

    [Column("ARProposalItemWorkTaskActualExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskActualExtendDays { get; set; }

    [Column("ARProposalItemWorkTaskEstimatedExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskEstimatedExtendHours { get; set; }

    [Column("ARProposalItemWorkTaskActualExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskActualExtendHours { get; set; }

    [Column("ARProposalItemWorkTaskQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskQty { get; set; }

    [Column("ARProposalItemWorkTaskEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskEstimatedTotalCost { get; set; }

    [Column("ARProposalItemWorkTaskActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkTaskActualTotalCost { get; set; }

    [ForeignKey("FkArproposalId")]
    [InverseProperty("ArproposalItemWorkTasks")]
    public virtual Arproposal FkArproposal { get; set; }

    [ForeignKey("FkArproposalItemWorkId")]
    [InverseProperty("ArproposalItemWorkTasks")]
    public virtual ArproposalItemWork FkArproposalItemWork { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("ArproposalItemWorkTasks")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("ArproposalItemWorkTasks")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArproposalItemWorkTasks")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArproposalItemWorkTasks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArproposalItemWorkTasks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIctaskId")]
    [InverseProperty("ArproposalItemWorkTasks")]
    public virtual Ictask FkIctask { get; set; }

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("ArproposalItemWorkTasks")]
    public virtual PmprojectType FkPmprojectType { get; set; }
}
