using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectMaterialReturns")]
[Microsoft.EntityFrameworkCore.Index("PmprojectMaterialReturnNo", "PmprojectMaterialReturnDate", Name = "Idx_PMProjectMaterialReturns")]
public partial class PmprojectMaterialReturn
{
    [Key]
    [Column("PMProjectMaterialReturnID")]
    public int PmprojectMaterialReturnId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Required]
    [Column("PMProjectMaterialReturnNo")]
    [StringLength(50)]
    public string PmprojectMaterialReturnNo { get; set; }

    [Column("PMProjectMaterialReturnName")]
    [StringLength(50)]
    public string PmprojectMaterialReturnName { get; set; }

    [Column("PMProjectMaterialReturnDesc")]
    [StringLength(255)]
    public string PmprojectMaterialReturnDesc { get; set; }

    [Column("PMProjectMaterialReturnRemark")]
    [StringLength(500)]
    public string PmprojectMaterialReturnRemark { get; set; }

    [Column("PMProjectMaterialReturntActiveCheck")]
    public bool? PmprojectMaterialReturntActiveCheck { get; set; }

    [Column("PMProjectMaterialReturnMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode01Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode02Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode03Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode04Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode05Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode06Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode07Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode08Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode09Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode10Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode11Combo { get; set; }

    [Column("PMProjectMaterialReturnMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialReturnMatchCode12Combo { get; set; }

    [Column("PMProjectMaterialReturnStartDate", TypeName = "datetime")]
    public DateTime? PmprojectMaterialReturnStartDate { get; set; }

    [Column("PMProjectMaterialReturnDate", TypeName = "datetime")]
    public DateTime? PmprojectMaterialReturnDate { get; set; }

    [Column("PMProjectMaterialReturnTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnTotalAmount { get; set; }
}
