using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectEquipmentItems")]
public partial class PmprojectEquipmentItem
{
    [Key]
    [Column("PMProjectEquipmentItemID")]
    public int PmprojectEquipmentItemId { get; set; }

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

    [Column("PMProjectEquipmentItemProductType")]
    [StringLength(50)]
    public string PmprojectEquipmentItemProductType { get; set; }

    [Column("PMProjectEquipmentItemTypeCombo")]
    [StringLength(20)]
    public string PmprojectEquipmentItemTypeCombo { get; set; }

    [Column("PMProjectEquipmentItemSortOrder")]
    public int? PmprojectEquipmentItemSortOrder { get; set; }

    [Column("PMProjectEquipmentItemProductDesc", TypeName = "ntext")]
    public string PmprojectEquipmentItemProductDesc { get; set; }

    [Column("PMProjectEquipmentItemProductBasicUnit")]
    [StringLength(50)]
    public string PmprojectEquipmentItemProductBasicUnit { get; set; }

    [Column("PMProjectEquipmentItemProductPackagingUnit")]
    [StringLength(50)]
    public string PmprojectEquipmentItemProductPackagingUnit { get; set; }

    [Column("PMProjectEquipmentItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemProductPackagingFactor { get; set; }

    [Column("PMProjectEquipmentItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemProductUnitCost { get; set; }

    [Column("PMProjectEquipmentItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemProductQtyOld { get; set; }

    [Column("PMProjectEquipmentItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemProductQty { get; set; }

    [Column("PMProjectEquipmentItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemProductBasicQty { get; set; }

    [Column("PMProjectEquipmentItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemProductPakagingQty { get; set; }

    [Column("PMProjectEquipmentItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemQty1 { get; set; }

    [Column("PMProjectEquipmentItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemQty2 { get; set; }

    [Column("PMProjectEquipmentItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemQty3 { get; set; }

    [Column("PMProjectEquipmentItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemQty4 { get; set; }

    [Column("PMProjectEquipmentItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemQty5 { get; set; }

    [Column("PMProjectEquipmentItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemQty6 { get; set; }

    [Column("PMProjectEquipmentItemComment")]
    [StringLength(50)]
    public string PmprojectEquipmentItemComment { get; set; }

    [Column("PMProjectEquipmentItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemUnitVolumn { get; set; }

    [Column("PMProjectEquipmentItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemUnitWeight { get; set; }

    [Column("PMProjectEquipmentItemPlusCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemPlusCost { get; set; }

    [Column("PMProjectEquipmentItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentItemTotalCost { get; set; }
}
