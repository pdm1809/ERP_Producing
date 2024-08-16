using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APAllocationCostItems")]
public partial class ApallocationCostItem
{
    [Key]
    [Column("APAllocationCostItemID")]
    public int ApallocationCostItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_APAllocationCostID")]
    public int? FkApallocationCostId { get; set; }

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_ICReceiptItemID")]
    public int? FkIcreceiptItemId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("APAllocationCostItemLotNo")]
    [StringLength(50)]
    public string ApallocationCostItemLotNo { get; set; }

    [Column("APAllocationCostItemProductName")]
    [StringLength(256)]
    public string ApallocationCostItemProductName { get; set; }

    [Column("APAllocationCostItemProductDesc")]
    [StringLength(512)]
    public string ApallocationCostItemProductDesc { get; set; }

    [Column("APAllocationCostItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemProductQty { get; set; }

    [Column("APAllocationCostItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemProductUnitCost { get; set; }

    [Column("APAllocationCostItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemTotalCost { get; set; }

    [Column("APAllocationCostItemFeeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemFeeAmount { get; set; }

    [Column("APAllocationCostItemOutSourcingFeeAmt", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemOutSourcingFeeAmt { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("APAllocationCostItemBOLFeeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemBolfeeAmount { get; set; }

    [Column("APAllocationCostItemTotalFee", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemTotalFee { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [ForeignKey("FkApallocationCostId")]
    [InverseProperty("ApallocationCostItems")]
    public virtual ApallocationCost FkApallocationCost { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApallocationCostItems")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("ApallocationCostItems")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApallocationCostItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ApallocationCostItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("ApallocationCostItems")]
    public virtual Icreceipt FkIcreceipt { get; set; }

    [ForeignKey("FkIcreceiptItemId")]
    [InverseProperty("ApallocationCostItems")]
    public virtual IcreceiptItem FkIcreceiptItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ApallocationCostItems")]
    public virtual Icstock FkIcstock { get; set; }
}
