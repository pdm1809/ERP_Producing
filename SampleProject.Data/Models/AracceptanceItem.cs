using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARAcceptanceItems")]
public partial class AracceptanceItem
{
    [Key]
    [Column("ARAcceptanceItemID")]
    public int AracceptanceItemId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARAcceptanceID")]
    public int? FkAracceptanceId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ARAcceptanceItemProductType")]
    [StringLength(50)]
    public string AracceptanceItemProductType { get; set; }

    [Column("ARAcceptanceItemProductName")]
    [StringLength(50)]
    public string AracceptanceItemProductName { get; set; }

    [Column("ARAcceptanceItemProductDesc")]
    [StringLength(1024)]
    public string AracceptanceItemProductDesc { get; set; }

    [Column("ARAcceptanceItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemProductQty { get; set; }

    [Column("ARAcceptanceItemDesc")]
    [StringLength(1024)]
    public string AracceptanceItemDesc { get; set; }

    [Column("ARAcceptanceItemSaleOrderType")]
    [StringLength(128)]
    public string AracceptanceItemSaleOrderType { get; set; }

    [Column("ARAcceptanceItemSaleOrderQty", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemSaleOrderQty { get; set; }

    [Column("ARAcceptanceItemShippedQty", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemShippedQty { get; set; }

    [Column("ARAcceptanceItemLength", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemLength { get; set; }

    [Column("ARAcceptanceItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemWidth { get; set; }

    [Column("ARAcceptanceItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemHeight { get; set; }

    [Column("ARAcceptanceItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemProductUnitPrice { get; set; }

    [Column("ARAcceptanceItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemPrice { get; set; }

    [Column("ARAcceptanceItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemProductDiscount { get; set; }

    [Column("ARAcceptanceItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemDiscountAmount { get; set; }

    [Column("ARAcceptanceItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemTotalAmount { get; set; }

    [Column("ARAcceptanceItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemProductTaxPercent { get; set; }

    [Column("ARAcceptanceItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemTaxAmount { get; set; }

    [Column("FK_ICShipmentItemID")]
    public int? FkIcshipmentItemId { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ARAcceptanceItemOneLevelArea")]
    [StringLength(1024)]
    public string AracceptanceItemOneLevelArea { get; set; }

    [Column("ARAcceptanceItemTwoLevelArea")]
    [StringLength(1024)]
    public string AracceptanceItemTwoLevelArea { get; set; }

    [Column("ARAcceptanceItemThreeLevelArea")]
    [StringLength(1024)]
    public string AracceptanceItemThreeLevelArea { get; set; }

    [Column("FK_ICSectionProductID")]
    public int? FkIcsectionProductId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("ARAcceptanceItemSOLength", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemSolength { get; set; }

    [Column("ARAcceptanceItemSOWidth", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemSowidth { get; set; }

    [Column("ARAcceptanceItemSOHeight", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemSoheight { get; set; }

    [Column("FK_ARProposalTemplateItemID")]
    public int? FkArproposalTemplateItemId { get; set; }

    [InverseProperty("FkAracceptanceItem")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AracceptanceItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAracceptanceId")]
    [InverseProperty("AracceptanceItems")]
    public virtual Aracceptance FkAracceptance { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("AracceptanceItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("AracceptanceItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("AracceptanceItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("AracceptanceItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AracceptanceItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("AracceptanceItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcsectionProductId")]
    [InverseProperty("AracceptanceItemFkIcsectionProducts")]
    public virtual Icproduct FkIcsectionProduct { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("AracceptanceItems")]
    public virtual Icshipment FkIcshipment { get; set; }

    [ForeignKey("FkIcshipmentItemId")]
    [InverseProperty("AracceptanceItems")]
    public virtual IcshipmentItem FkIcshipmentItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("AracceptanceItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("AracceptanceItems")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }
}
