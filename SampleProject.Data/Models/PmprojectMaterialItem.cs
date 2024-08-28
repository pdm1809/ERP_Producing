using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectMaterialItems")]
[Microsoft.EntityFrameworkCore.Index("FkPmprojectMaterialId", Name = "Idx_PMProjectMaterialItems")]
public partial class PmprojectMaterialItem
{
    [Key]
    [Column("PMProjectMaterialItemID")]
    public int PmprojectMaterialItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_PMProjectMaterialID")]
    public int FkPmprojectMaterialId { get; set; }

    [Column("FK_PMProjectID")]
    public int FkPmprojectId { get; set; }

    [Column("FK_PMProjectPhaseID")]
    public int FkPmprojectPhaseId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("PMProjectMaterialItemProductType")]
    [StringLength(50)]
    public string PmprojectMaterialItemProductType { get; set; }

    [Column("PMProjectMaterialItemTypeCombo")]
    [StringLength(20)]
    public string PmprojectMaterialItemTypeCombo { get; set; }

    [Column("PMProjectMaterialItemSortOrder")]
    public int? PmprojectMaterialItemSortOrder { get; set; }

    [Column("PMProjectMaterialItemProductDesc", TypeName = "ntext")]
    public string PmprojectMaterialItemProductDesc { get; set; }

    [Column("PMProjectMaterialItemProductBasicUnit")]
    [StringLength(50)]
    public string PmprojectMaterialItemProductBasicUnit { get; set; }

    [Column("PMProjectMaterialItemProductPackagingUnit")]
    [StringLength(50)]
    public string PmprojectMaterialItemProductPackagingUnit { get; set; }

    [Column("PMProjectMaterialItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemProductPackagingFactor { get; set; }

    [Column("PMProjectMaterialItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemProductUnitCost { get; set; }

    [Column("PMProjectMaterialItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemProductQtyOld { get; set; }

    [Column("PMProjectMaterialItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemProductQty { get; set; }

    [Column("PMProjectMaterialItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemProductBasicQty { get; set; }

    [Column("PMProjectMaterialItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemProductPakagingQty { get; set; }

    [Column("PMProjectMaterialItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemQty1 { get; set; }

    [Column("PMProjectMaterialItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemQty2 { get; set; }

    [Column("PMProjectMaterialItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemQty3 { get; set; }

    [Column("PMProjectMaterialItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemQty4 { get; set; }

    [Column("PMProjectMaterialItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemQty5 { get; set; }

    [Column("PMProjectMaterialItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemQty6 { get; set; }

    [Column("PMProjectMaterialItemComment")]
    [StringLength(50)]
    public string PmprojectMaterialItemComment { get; set; }

    [Column("PMProjectMaterialItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemUnitVolumn { get; set; }

    [Column("PMProjectMaterialItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemUnitWeight { get; set; }

    [Column("PMProjectMaterialItemPlusCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemPlusCost { get; set; }

    [Column("PMProjectMaterialItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialItemTotalCost { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmprojectMaterialItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("PmprojectMaterialItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmprojectMaterialItems")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmprojectMaterialId")]
    [InverseProperty("PmprojectMaterialItems")]
    public virtual PmprojectMaterial FkPmprojectMaterial { get; set; }

    [ForeignKey("FkPmprojectPhaseId")]
    [InverseProperty("PmprojectMaterialItems")]
    public virtual PmprojectPhase FkPmprojectPhase { get; set; }
}
