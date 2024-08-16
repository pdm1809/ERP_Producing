using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APCancelPurchaseOrderItems")]
public partial class ApcancelPurchaseOrderItem
{
    [Key]
    [Column("APCancelPurchaseOrderItemID")]
    public int ApcancelPurchaseOrderItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APCancelPurchaseOrderID")]
    public int FkApcancelPurchaseOrderId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_APPurchaseOrderItemID")]
    public int? FkAppurchaseOrderItemId { get; set; }

    [Column("APCancelPurchaseOrderItemProductType")]
    [StringLength(50)]
    public string ApcancelPurchaseOrderItemProductType { get; set; }

    [Column("APCancelPurchaseOrderItemProductSerialNo")]
    [StringLength(50)]
    public string ApcancelPurchaseOrderItemProductSerialNo { get; set; }

    [Column("APCancelPurchaseOrderItemProductAttribute")]
    [StringLength(200)]
    public string ApcancelPurchaseOrderItemProductAttribute { get; set; }

    [Column("APCancelPurchaseOrderItemProductName")]
    [StringLength(50)]
    public string ApcancelPurchaseOrderItemProductName { get; set; }

    [Column("APCancelPurchaseOrderItemProductDesc")]
    [StringLength(512)]
    public string ApcancelPurchaseOrderItemProductDesc { get; set; }

    [Column("APCancelPurchaseOrderItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductUnitPrice { get; set; }

    [Column("APCancelPurchaseOrderItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductUnitCost { get; set; }

    [Column("APCancelPurchaseOrderItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductDiscount { get; set; }

    [Column("APCancelPurchaseOrderItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductTaxPercent { get; set; }

    [Column("APCancelPurchaseOrderItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductQty { get; set; }

    [Column("APCancelPurchaseOrderItemOrderedQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemOrderedQty { get; set; }

    [Column("APCancelPurchaseOrderItemTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemTotalQty { get; set; }

    [Column("APCancelPurchaseOrderItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemPrice { get; set; }

    [Column("APCancelPurchaseOrderItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemTaxAmount { get; set; }

    [Column("APCancelPurchaseOrderItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemDiscountAmount { get; set; }

    [Column("APCancelPurchaseOrderItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemNetAmount { get; set; }

    [Column("APCancelPurchaseOrderItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemTotalAmount { get; set; }

    [Column("APCancelPurchaseOrderItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemTotalCost { get; set; }

    [Column("APCancelPurchaseOrderItemProductSupplierNo")]
    [StringLength(50)]
    public string ApcancelPurchaseOrderItemProductSupplierNo { get; set; }

    [Column("APCancelPurchaseOrderItemComment")]
    [StringLength(512)]
    public string ApcancelPurchaseOrderItemComment { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMFromOperationID")]
    public int? FkMmfromOperationId { get; set; }

    [Column("FK_MMToOperationID")]
    public int? FkMmtoOperationId { get; set; }

    [Column("APCancelPurchaseOrderItemProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductionNormItemPaint { get; set; }

    [Column("APCancelPurchaseOrderItemProductionNormItemBlocks", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductionNormItemBlocks { get; set; }

    [Column("APCancelPurchaseOrderItemProductionNormItemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductionNormItemTotalPaint { get; set; }

    [Column("APCancelPurchaseOrderItemProductionNormItemTotalBlocks", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductionNormItemTotalBlocks { get; set; }

    [Column("APCancelPurchaseOrderItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductPerimeter { get; set; }

    [Column("APCancelPurchaseOrderItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemWoodQty { get; set; }

    [Column("APCancelPurchaseOrderItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductHeight { get; set; }

    [Column("APCancelPurchaseOrderItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductWidth { get; set; }

    [Column("APCancelPurchaseOrderItemProductLenght", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductLenght { get; set; }

    [Column("APCancelPurchaseOrderItemProductWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductWidthMax { get; set; }

    [Column("APCancelPurchaseOrderItemProductLenghtMax", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductLenghtMax { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("APCancelPurchaseOrderItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductFactor { get; set; }

    [Column("APCancelPurchaseOrderItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseOrderItemProductExchangeQty { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkApcancelPurchaseOrderId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual ApcancelPurchaseOrder FkApcancelPurchaseOrder { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmfromOperationId")]
    [InverseProperty("ApcancelPurchaseOrderItemFkMmfromOperations")]
    public virtual Mmoperation FkMmfromOperation { get; set; }

    [ForeignKey("FkMmtoOperationId")]
    [InverseProperty("ApcancelPurchaseOrderItemFkMmtoOperations")]
    public virtual Mmoperation FkMmtoOperation { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ApcancelPurchaseOrderItems")]
    public virtual Pmproject FkPmproject { get; set; }
}
