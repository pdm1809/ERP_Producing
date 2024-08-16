using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectMaterialReturnItems")]
public partial class PmprojectMaterialReturnItem
{
    [Key]
    [Column("PMProjectMaterialReturnItemID")]
    public int PmprojectMaterialReturnItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_PMProjectPhaseID")]
    public int? FkPmprojectPhaseId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("PMProjectMaterialReturnItemProductType")]
    [StringLength(50)]
    public string PmprojectMaterialReturnItemProductType { get; set; }

    [Column("PMProjectMaterialReturnItemTypeCombo")]
    [StringLength(20)]
    public string PmprojectMaterialReturnItemTypeCombo { get; set; }

    [Column("PMProjectMaterialReturnItemSortOrder")]
    public int? PmprojectMaterialReturnItemSortOrder { get; set; }

    [Column("PMProjectMaterialReturnItemProductDesc", TypeName = "ntext")]
    public string PmprojectMaterialReturnItemProductDesc { get; set; }

    [Column("PMProjectMaterialReturnItemProductBasicUnit")]
    [StringLength(50)]
    public string PmprojectMaterialReturnItemProductBasicUnit { get; set; }

    [Column("PMProjectMaterialReturnItemProductPackagingUnit")]
    [StringLength(50)]
    public string PmprojectMaterialReturnItemProductPackagingUnit { get; set; }

    [Column("PMProjectMaterialReturnItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemProductPackagingFactor { get; set; }

    [Column("PMProjectMaterialReturnItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemProductUnitPrice { get; set; }

    [Column("PMProjectMaterialReturnItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemProductQtyOld { get; set; }

    [Column("PMProjectMaterialReturnItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemProductQty { get; set; }

    [Column("PMProjectMaterialReturnItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemProductBasicQty { get; set; }

    [Column("PMProjectMaterialReturnItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemProductPakagingQty { get; set; }

    [Column("PMProjectMaterialReturnItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemQty1 { get; set; }

    [Column("PMProjectMaterialReturnItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemQty2 { get; set; }

    [Column("PMProjectMaterialReturnItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemQty3 { get; set; }

    [Column("PMProjectMaterialReturnItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemQty4 { get; set; }

    [Column("PMProjectMaterialReturnItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemQty5 { get; set; }

    [Column("PMProjectMaterialReturnItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemQty6 { get; set; }

    [Column("PMProjectMaterialReturnItemComment")]
    [StringLength(50)]
    public string PmprojectMaterialReturnItemComment { get; set; }

    [Column("PMProjectMaterialReturnItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemUnitVolumn { get; set; }

    [Column("PMProjectMaterialReturnItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemUnitWeight { get; set; }

    [Column("PMProjectMaterialReturnItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectMaterialReturnItemTotalAmount { get; set; }
}
