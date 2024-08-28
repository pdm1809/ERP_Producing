using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectProfilePhaseResources")]
[Microsoft.EntityFrameworkCore.Index("PmprojectProfilePhaseResourceNo", Name = "Idx_PMProjectProfilePhaseResources")]
public partial class PmprojectProfilePhaseResource
{
    [Key]
    [Column("PMProjectProfilePhaseResourceID")]
    public int PmprojectProfilePhaseResourceId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("PMProjectProfilePhaseResourceNo")]
    [StringLength(50)]
    public string PmprojectProfilePhaseResourceNo { get; set; }

    [Column("PMProjectProfilePhaseResourceName")]
    [StringLength(50)]
    public string PmprojectProfilePhaseResourceName { get; set; }

    [Column("PMProjectProfilePhaseResourceDesc")]
    [StringLength(255)]
    public string PmprojectProfilePhaseResourceDesc { get; set; }

    [Column("PMProjectProfilePhaseResourceRemark")]
    [StringLength(500)]
    public string PmprojectProfilePhaseResourceRemark { get; set; }

    [Column("PMProjectResourceType")]
    [StringLength(50)]
    public string PmprojectResourceType { get; set; }

    [Column("FK_PMProjectProfilePhaseID")]
    public int FkPmprojectProfilePhaseId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_HRPositionID")]
    public int? FkHrpositionId { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("PMProjectProfilePhaseResourceBasicUnit")]
    [StringLength(50)]
    public string PmprojectProfilePhaseResourceBasicUnit { get; set; }

    [Column("PMProjectProfilePhaseResourcePackagingUnit")]
    [StringLength(50)]
    public string PmprojectProfilePhaseResourcePackagingUnit { get; set; }

    [Column("PMProjectProfilePhaseResourcePackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourcePackagingFactor { get; set; }

    [Column("PMProjectProfilePhaseResourceUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceUnitCost { get; set; }

    [Column("PMProjectProfilePhaseResourceQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceQtyOld { get; set; }

    [Column("PMProjectProfilePhaseResourceQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceQty { get; set; }

    [Column("PMProjectProfilePhaseResourceBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceBasicQty { get; set; }

    [Column("PMProjectProfilePhaseResourcePakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourcePakagingQty { get; set; }

    [Column("PMProjectProfilePhaseResourceQty1", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceQty1 { get; set; }

    [Column("PMProjectProfilePhaseResourceQty2", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceQty2 { get; set; }

    [Column("PMProjectProfilePhaseResourceQty3", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceQty3 { get; set; }

    [Column("PMProjectProfilePhaseResourceQty4", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceQty4 { get; set; }

    [Column("PMProjectProfilePhaseResourceQty5", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceQty5 { get; set; }

    [Column("PMProjectProfilePhaseResourceQty6", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceQty6 { get; set; }

    [Column("PMProjectProfilePhaseResourceUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceUnitVolumn { get; set; }

    [Column("PMProjectProfilePhaseResourceUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceUnitWeight { get; set; }

    [Column("PMProjectProfilePhaseResourceTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectProfilePhaseResourceTotalCost { get; set; }
}
