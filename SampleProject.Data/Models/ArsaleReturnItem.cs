using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleReturnItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkArsaleReturnId", Name = "Idx_ARSaleReturnItems")]
public partial class ArsaleReturnItem
{
    [Key]
    [Column("ARSaleReturnItemID")]
    public int ArsaleReturnItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleReturnID")]
    public int FkArsaleReturnId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("FK_ARInvoiceItemID")]
    public int? FkArinvoiceItemId { get; set; }

    [Column("ARSaleReturnItemProductSerialNo")]
    [StringLength(50)]
    public string ArsaleReturnItemProductSerialNo { get; set; }

    [Column("ARSaleReturnItemProductAttribute")]
    [StringLength(200)]
    public string ArsaleReturnItemProductAttribute { get; set; }

    [Column("ARSaleReturnItemProductType")]
    [StringLength(50)]
    public string ArsaleReturnItemProductType { get; set; }

    [Column("ARSaleReturnItemSortOrder")]
    public int? ArsaleReturnItemSortOrder { get; set; }

    [Column("ARSaleReturnItemProductName")]
    [StringLength(50)]
    public string ArsaleReturnItemProductName { get; set; }

    [Column("ARSaleReturnItemProductDesc", TypeName = "ntext")]
    public string ArsaleReturnItemProductDesc { get; set; }

    [Column("ARSaleReturnItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemProductUnitPrice { get; set; }

    [Column("ARSaleReturnItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemProductUnitCost { get; set; }

    [Column("ARSaleReturnItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemProductDiscount { get; set; }

    [Column("ARSaleReturnItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemProductTaxPercent { get; set; }

    [Column("ARSaleReturnItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemProductQty { get; set; }

    [Column("ARSaleReturnItemComment")]
    [StringLength(50)]
    public string ArsaleReturnItemComment { get; set; }

    [Column("ARSaleReturnItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemPrice { get; set; }

    [Column("ARSaleReturnItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemTaxAmount { get; set; }

    [Column("ARSaleReturnItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemDiscountAmount { get; set; }

    [Column("ARSaleReturnItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemNetAmount { get; set; }

    [Column("ARSaleReturnItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemTotalAmount { get; set; }

    [Column("ARSaleReturnItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemTotalCost { get; set; }

    [Column("ARSaleReturnItemProductSupplierNo")]
    [StringLength(50)]
    public string ArsaleReturnItemProductSupplierNo { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACAccountDiscountID")]
    public int? FkAcaccountDiscountId { get; set; }

    [Column("FK_ACAccountRevenueID")]
    public int? FkAcaccountRevenueId { get; set; }

    [Column("FK_ARDiscountProgramItemID")]
    public int? FkArdiscountProgramItemId { get; set; }

    [Column("FK_ARDiscountProgramID")]
    public int? FkArdiscountProgramId { get; set; }

    [Column("ARSaleReturnItemIsSpecificCalculation")]
    public bool? ArsaleReturnItemIsSpecificCalculation { get; set; }

    [Column("ARSaleReturnItemIsAverageCalculation")]
    public bool? ArsaleReturnItemIsAverageCalculation { get; set; }

    [Column("ARSaleReturnItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemProductFactor { get; set; }

    [Column("ARSaleReturnItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemProductExchangeQty { get; set; }

    [Column("ARSaleReturnItemExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemExchangeUnitCost { get; set; }

    [Column("ARSaleReturnItemExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemExchangeTotalCost { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("ARSaleReturnItemLotNo")]
    [StringLength(50)]
    public string ArsaleReturnItemLotNo { get; set; }

    [Column("ARSaleReturnItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemWoodQty { get; set; }

    [Column("ARSaleReturnItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ArsaleReturnItemProductNoOfOldSys { get; set; }

    [Column("ARSaleReturnItemProductCustomerNumber")]
    [StringLength(50)]
    public string ArsaleReturnItemProductCustomerNumber { get; set; }

    [Required]
    [Column("ARListOfSalesChannelType")]
    [StringLength(50)]
    public string ArlistOfSalesChannelType { get; set; }

    [Column("FK_ICMeasureUnitBeforeChangeID")]
    public int? FkIcmeasureUnitBeforeChangeId { get; set; }

    [InverseProperty("FkArsaleReturnItem")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkArsaleReturnItem")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkArsaleReturnItem")]
    public virtual ICollection<ArsaleReturnItemComponent> ArsaleReturnItemComponents { get; set; } = new List<ArsaleReturnItemComponent>();

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("ArsaleReturnItems")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAcoffsetAccountId")]
    [InverseProperty("ArsaleReturnItems")]
    public virtual Acaccount FkAcoffsetAccount { get; set; }

    [ForeignKey("FkArsaleReturnId")]
    [InverseProperty("ArsaleReturnItems")]
    public virtual ArsaleReturn FkArsaleReturn { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArsaleReturnItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArsaleReturnItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsaleReturnItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArsaleReturnItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ArsaleReturnItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArsaleReturnItems")]
    public virtual Icstock FkIcstock { get; set; }
}
