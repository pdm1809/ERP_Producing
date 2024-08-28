using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APReturnSupplierItems")]
public partial class ApreturnSupplierItem
{
    [Key]
    [Column("APReturnSupplierItemID")]
    public int ApreturnSupplierItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("FK_APReturnSupplierID")]
    public int? FkApreturnSupplierId { get; set; }

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

    [Column("FK_ICReciptID")]
    public int? FkIcreciptId { get; set; }

    [Column("FK_ICReciptItemID")]
    public int? FkIcreciptItemId { get; set; }

    [Column("APReturnSupplierItemProductType")]
    [StringLength(50)]
    public string ApreturnSupplierItemProductType { get; set; }

    [Column("APReturnSupplierItemTypeCombo")]
    [StringLength(20)]
    public string ApreturnSupplierItemTypeCombo { get; set; }

    [Column("APReturnSupplierItemSortOrder")]
    public int? ApreturnSupplierItemSortOrder { get; set; }

    [Column("APReturnSupplierItemProductSerialNo")]
    [StringLength(50)]
    public string ApreturnSupplierItemProductSerialNo { get; set; }

    [Column("APReturnSupplierItemProductAttribute")]
    [StringLength(200)]
    public string ApreturnSupplierItemProductAttribute { get; set; }

    [Column("APReturnSupplierItemProductName")]
    [StringLength(50)]
    public string ApreturnSupplierItemProductName { get; set; }

    [Column("APReturnSupplierItemProductDesc", TypeName = "ntext")]
    public string ApreturnSupplierItemProductDesc { get; set; }

    [Column("APReturnSupplierItemProductSellUnit")]
    [StringLength(50)]
    public string ApreturnSupplierItemProductSellUnit { get; set; }

    [Column("APReturnSupplierItemProductBasicUnit")]
    [StringLength(50)]
    public string ApreturnSupplierItemProductBasicUnit { get; set; }

    [Column("APReturnSupplierItemProductPackagingUnit")]
    [StringLength(50)]
    public string ApreturnSupplierItemProductPackagingUnit { get; set; }

    [Column("APReturnSupplierItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductSellFactor { get; set; }

    [Column("APReturnSupplierItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductPackagingFactor { get; set; }

    [Column("APReturnSupplierItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductUnitPrice { get; set; }

    [Column("APReturnSupplierItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductUnitCost { get; set; }

    [Column("APReturnSupplierItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductGroupDiscount { get; set; }

    [Column("APReturnSupplierItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductDiscount { get; set; }

    [Column("APReturnSupplierItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductTaxPercent { get; set; }

    [Column("APReturnSupplierItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductQtyOld { get; set; }

    [Column("APReturnSupplierItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductQty { get; set; }

    [Column("APReturnSupplierItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductBasicQty { get; set; }

    [Column("APReturnSupplierItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductPakagingQty { get; set; }

    [Column("APReturnSupplierItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemQty1 { get; set; }

    [Column("APReturnSupplierItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemQty2 { get; set; }

    [Column("APReturnSupplierItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemQty3 { get; set; }

    [Column("APReturnSupplierItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemQty4 { get; set; }

    [Column("APReturnSupplierItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemQty5 { get; set; }

    [Column("APReturnSupplierItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemQty6 { get; set; }

    [Column("APReturnSupplierItemComment")]
    [StringLength(50)]
    public string ApreturnSupplierItemComment { get; set; }

    [Column("APReturnSupplierItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemUnitVolumn { get; set; }

    [Column("APReturnSupplierItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemUnitWeight { get; set; }

    [Column("APReturnSupplierItemExtCost", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemExtCost { get; set; }

    [Column("APReturnSupplierItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemTaxAmount { get; set; }

    [Column("APReturnSupplierItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemDiscountAmount { get; set; }

    [Column("APReturnSupplierItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemTotalCost { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("FK_APInvoiceInItemID")]
    public int? FkApinvoiceInItemId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("APReturnSupplierItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductFactor { get; set; }

    [Column("APReturnSupplierItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? ApreturnSupplierItemProductExchangeQty { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("APReturnSupplierItemLotNo")]
    [StringLength(50)]
    public string ApreturnSupplierItemLotNo { get; set; }

    [Column("APReturnSupplierItemWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? ApreturnSupplierItemWoodQty { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkApinvoiceInItemId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual ApinvoiceInItem FkApinvoiceInItem { get; set; }

    [ForeignKey("FkApreturnSupplierId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual ApreturnSupplier FkApreturnSupplier { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ApreturnSupplierItems")]
    public virtual Pmproject FkPmproject { get; set; }
}
