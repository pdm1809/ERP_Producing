using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectPhaseResources")]
[Microsoft.EntityFrameworkCore.Index("PmprojectPhaseResourceNo", Name = "Idx_PMProjectPhaseResources")]
public partial class PmprojectPhaseResource
{
    [Key]
    [Column("PMProjectPhaseResourceID")]
    public int PmprojectPhaseResourceId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("PMProjectPhaseResourceNo")]
    [StringLength(50)]
    public string PmprojectPhaseResourceNo { get; set; }

    [Column("PMProjectPhaseResourceName")]
    [StringLength(50)]
    public string PmprojectPhaseResourceName { get; set; }

    [Column("PMProjectPhaseResourceDesc")]
    [StringLength(255)]
    public string PmprojectPhaseResourceDesc { get; set; }

    [Column("PMProjectPhaseResourceRemark")]
    [StringLength(500)]
    public string PmprojectPhaseResourceRemark { get; set; }

    [Column("PMProjectPhaseResourceType")]
    [StringLength(50)]
    public string PmprojectPhaseResourceType { get; set; }

    [Column("FK_PMProjectPhaseID")]
    public int FkPmprojectPhaseId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("PMProjectPhaseResourceBasicUnit")]
    [StringLength(50)]
    public string PmprojectPhaseResourceBasicUnit { get; set; }

    [Column("PMProjectPhaseResourcePackagingUnit")]
    [StringLength(50)]
    public string PmprojectPhaseResourcePackagingUnit { get; set; }

    [Column("PMProjectPhaseResourcePackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourcePackagingFactor { get; set; }

    [Column("PMProjectPhaseResourceUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceUnitCost { get; set; }

    [Column("PMProjectPhaseResourceQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceQtyOld { get; set; }

    [Column("PMProjectPhaseResourceQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceQty { get; set; }

    [Column("PMProjectPhaseResourceBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceBasicQty { get; set; }

    [Column("PMProjectPhaseResourcePakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourcePakagingQty { get; set; }

    [Column("PMProjectPhaseResourceQty1", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceQty1 { get; set; }

    [Column("PMProjectPhaseResourceQty2", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceQty2 { get; set; }

    [Column("PMProjectPhaseResourceQty3", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceQty3 { get; set; }

    [Column("PMProjectPhaseResourceQty4", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceQty4 { get; set; }

    [Column("PMProjectPhaseResourceQty5", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceQty5 { get; set; }

    [Column("PMProjectPhaseResourceQty6", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceQty6 { get; set; }

    [Column("PMProjectPhaseResourceUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceUnitVolumn { get; set; }

    [Column("PMProjectPhaseResourceUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceUnitWeight { get; set; }

    [Column("PMProjectPhaseResourceTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectPhaseResourceTotalCost { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmprojectPhaseResources")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkPmprojectPhaseId")]
    [InverseProperty("PmprojectPhaseResources")]
    public virtual PmprojectPhase FkPmprojectPhase { get; set; }
}
