using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AREstimateItems")]
public partial class ArestimateItem
{
    [Key]
    [Column("AREstimateItemID")]
    public int ArestimateItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("FK_AREstimateID")]
    public int? FkArestimateId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_PMProjectNormID")]
    public int? FkPmprojectNormId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("AREstimateItemProductSerialNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArestimateItemProductSerialNo { get; set; }

    [Column("AREstimateItemProductAttribute")]
    [StringLength(200)]
    public string ArestimateItemProductAttribute { get; set; }

    [Column("AREstimateItemProductType")]
    [StringLength(50)]
    public string ArestimateItemProductType { get; set; }

    [Column("AREstimateItemSortOrder")]
    public int? ArestimateItemSortOrder { get; set; }

    [Column("AREstimateItemProductName")]
    [StringLength(256)]
    public string ArestimateItemProductName { get; set; }

    [Column("AREstimateItemProductDesc", TypeName = "ntext")]
    public string ArestimateItemProductDesc { get; set; }

    [Column("AREstimateItemProductSellUnit")]
    [StringLength(50)]
    public string ArestimateItemProductSellUnit { get; set; }

    [Column("AREstimateItemProductBasicUnit")]
    [StringLength(50)]
    public string ArestimateItemProductBasicUnit { get; set; }

    [Column("AREstimateItemProductPackagingUnit")]
    [StringLength(50)]
    public string ArestimateItemProductPackagingUnit { get; set; }

    [Column("AREstimateItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductSellFactor { get; set; }

    [Column("AREstimateItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductPackagingFactor { get; set; }

    [Column("AREstimateItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductUnitPrice { get; set; }

    [Column("AREstimateItemProductInternalUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductInternalUnitPrice { get; set; }

    [Column("AREstimateItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductUnitCost { get; set; }

    [Column("AREstimateItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductGroupDiscount { get; set; }

    [Column("AREstimateItemProductDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductDiscountPercent { get; set; }

    [Column("AREstimateItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductTaxPercent { get; set; }

    [Column("AREstimateItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductQtyOld { get; set; }

    [Column("AREstimateItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductQty { get; set; }

    [Column("AREstimateItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductBasicQty { get; set; }

    [Column("AREstimateItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductPakagingQty { get; set; }

    [Column("AREstimateItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemQty1 { get; set; }

    [Column("AREstimateItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemQty2 { get; set; }

    [Column("AREstimateItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemQty3 { get; set; }

    [Column("AREstimateItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemQty4 { get; set; }

    [Column("AREstimateItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemQty5 { get; set; }

    [Column("AREstimateItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemQty6 { get; set; }

    [Column("AREstimateItemComment")]
    [StringLength(50)]
    public string ArestimateItemComment { get; set; }

    [Column("AREstimateItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemUnitVolumn { get; set; }

    [Column("AREstimateItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemUnitWeight { get; set; }

    [Column("AREstimateItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemPrice { get; set; }

    [Column("AREstimateItemInternalPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemInternalPrice { get; set; }

    [Column("AREstimateItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemTaxAmount { get; set; }

    [Column("AREstimateItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemDiscountAmount { get; set; }

    [Column("AREstimateItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemNetAmount { get; set; }

    [Column("AREstimateItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemTotalAmount { get; set; }

    [Column("AREstimateItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemTotalCost { get; set; }

    [Column("AREstimateItemParentID")]
    public int? ArestimateItemParentId { get; set; }

    [Column("AREstimateItemProductNo")]
    [StringLength(50)]
    public string ArestimateItemProductNo { get; set; }

    [Column("AREstimateItemType")]
    [StringLength(50)]
    public string ArestimateItemType { get; set; }

    [Column("AREstimateItemProductWorkUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductWorkUnitPrice { get; set; }

    [Column("AREstimateItemProductMaterialUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductMaterialUnitPrice { get; set; }

    [Column("AREstimateItemProductEquipmentUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemProductEquipmentUnitPrice { get; set; }

    [Column("AREstimateItemWorkTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemWorkTotalAmount { get; set; }

    [Column("AREstimateItemMaterialTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemMaterialTotalAmount { get; set; }

    [Column("AREstimateItemEquipmentTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateItemEquipmentTotalAmount { get; set; }

    [InverseProperty("FkArestimateItem")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ArestimateItems")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkArestimateId")]
    [InverseProperty("ArestimateItems")]
    public virtual Arestimate FkArestimate { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArestimateItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArestimateItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArestimateItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArestimateItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArestimateItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("ArestimateItems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArestimateItems")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmprojectNormId")]
    [InverseProperty("ArestimateItems")]
    public virtual PmprojectNorm FkPmprojectNorm { get; set; }
}
