using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICTransferLogItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIctransferLogId", Name = "Idx_ICTransferLogItems")]
public partial class IctransferLogItem
{
    [Key]
    [Column("ICTransferLogItemID")]
    public int IctransferLogItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICTransferLogID")]
    public int? FkIctransferLogId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICFromStockID")]
    public int? FkIcfromStockId { get; set; }

    [Column("FK_ICToStockID")]
    public int? FkIctoStockId { get; set; }

    [Column("FK_ICTransitStockID")]
    public int? FkIctransitStockId { get; set; }

    [Column("ICTransferLogItemProductType")]
    [StringLength(50)]
    public string IctransferLogItemProductType { get; set; }

    [Column("ICTransferLogItemSortOrder")]
    public int? IctransferLogItemSortOrder { get; set; }

    [Column("ICTransferLogItemProductSerialNo")]
    [StringLength(50)]
    public string IctransferLogItemProductSerialNo { get; set; }

    [Column("ICTransferLogItemProductDesc", TypeName = "ntext")]
    public string IctransferLogItemProductDesc { get; set; }

    [Column("ICTransferLogItemProductSellUnit")]
    [StringLength(50)]
    public string IctransferLogItemProductSellUnit { get; set; }

    [Column("ICTransferLogItemProductBasicUnit")]
    [StringLength(50)]
    public string IctransferLogItemProductBasicUnit { get; set; }

    [Column("ICTransferLogItemProductPackagingUnit")]
    [StringLength(50)]
    public string IctransferLogItemProductPackagingUnit { get; set; }

    [Column("ICTransferLogItemProductSellFactor", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductSellFactor { get; set; }

    [Column("ICTransferLogItemProductPackagingFactor", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductPackagingFactor { get; set; }

    [Column("ICTransferLogItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductUnitPrice { get; set; }

    [Column("ICTransferLogItemProductUnitBuyingPrice", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductUnitBuyingPrice { get; set; }

    [Column("ICTransferLogItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductGroupDiscount { get; set; }

    [Column("ICTransferLogItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductDiscount { get; set; }

    [Column("ICTransferLogItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductTaxPercent { get; set; }

    [Column("ICTransferLogItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductQtyOld { get; set; }

    [Column("ICTransferLogItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductQty { get; set; }

    [Column("ICTransferLogItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductBasicQty { get; set; }

    [Column("ICTransferLogItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemProductPakagingQty { get; set; }

    [Column("ICTransferLogItemQty1", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemQty1 { get; set; }

    [Column("ICTransferLogItemQty2", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemQty2 { get; set; }

    [Column("ICTransferLogItemQty3", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemQty3 { get; set; }

    [Column("ICTransferLogItemQty4", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemQty4 { get; set; }

    [Column("ICTransferLogItemQty5", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemQty5 { get; set; }

    [Column("ICTransferLogItemQty6", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemQty6 { get; set; }

    [Column("ICTransferLogItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemPrice { get; set; }

    [Column("ICTransferLogItemComment")]
    [StringLength(50)]
    public string IctransferLogItemComment { get; set; }

    [Column("ICTransferLogItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemUnitVolumn { get; set; }

    [Column("ICTransferLogItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? IctransferLogItemUnitWeight { get; set; }

    [Column("ICTransferLogItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferLogItemStatus { get; set; }

    [ForeignKey("FkIcfromStockId")]
    [InverseProperty("IctransferLogItemFkIcfromStocks")]
    public virtual Icstock FkIcfromStock { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IctransferLogItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IctransferLogItemFkIcproductNavigations")]
    public virtual Icstock FkIcproductNavigation { get; set; }

    [ForeignKey("FkIctransferLogId")]
    [InverseProperty("IctransferLogItems")]
    public virtual IctransferLog FkIctransferLog { get; set; }

    [ForeignKey("FkIctransitStockId")]
    [InverseProperty("IctransferLogItemFkIctransitStocks")]
    public virtual Icstock FkIctransitStock { get; set; }
}
