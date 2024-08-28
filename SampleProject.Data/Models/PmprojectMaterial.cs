using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectMaterials")]
[Microsoft.EntityFrameworkCore.Index("PmprojectMaterialNo", "PmprojectMaterialDate", Name = "Idx_PMProjectMaterials")]
public partial class PmprojectMaterial
{
    [Key]
    [Column("PMProjectMaterialID")]
    public int PmprojectMaterialId { get; set; }

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
    [Column("PMProjectMaterialNo")]
    [StringLength(50)]
    public string PmprojectMaterialNo { get; set; }

    [Column("PMProjectMaterialName")]
    [StringLength(50)]
    public string PmprojectMaterialName { get; set; }

    [Column("PMProjectMaterialDesc")]
    [StringLength(255)]
    public string PmprojectMaterialDesc { get; set; }

    [Column("PMProjectMaterialRemark")]
    [StringLength(500)]
    public string PmprojectMaterialRemark { get; set; }

    [Column("PMProjectMaterialActiveCheck")]
    public bool? PmprojectMaterialActiveCheck { get; set; }

    [Column("PMProjectMaterialMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode01Combo { get; set; }

    [Column("PMProjectMaterialMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode02Combo { get; set; }

    [Column("PMProjectMaterialMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode03Combo { get; set; }

    [Column("PMProjectMaterialMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode04Combo { get; set; }

    [Column("PMProjectMaterialMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode05Combo { get; set; }

    [Column("PMProjectMaterialMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode06Combo { get; set; }

    [Column("PMProjectMaterialMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode07Combo { get; set; }

    [Column("PMProjectMaterialMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode08Combo { get; set; }

    [Column("PMProjectMaterialMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode09Combo { get; set; }

    [Column("PMProjectMaterialMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode10Combo { get; set; }

    [Column("PMProjectMaterialMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode11Combo { get; set; }

    [Column("PMProjectMaterialMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMaterialMatchCode12Combo { get; set; }

    [Column("PMProjectMaterialStartDate", TypeName = "datetime")]
    public DateTime? PmprojectMaterialStartDate { get; set; }

    [Column("PMProjectMaterialDate", TypeName = "datetime")]
    public DateTime? PmprojectMaterialDate { get; set; }

    [Column("PMProjectMaterialTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialTotalCost { get; set; }

    [InverseProperty("FkPmprojectMaterial")]
    public virtual ICollection<PmprojectMaterialItem> PmprojectMaterialItems { get; set; } = new List<PmprojectMaterialItem>();
}
