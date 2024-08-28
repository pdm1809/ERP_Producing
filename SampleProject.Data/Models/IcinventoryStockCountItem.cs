using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInventoryStockCountItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcstockId", "FkIcinventoryStockCountId", Name = "Idx_ICInventoryStockCountItems")]
public partial class IcinventoryStockCountItem
{
    [Key]
    [Column("ICInventoryStockCountItemID")]
    public int IcinventoryStockCountItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICInventoryStockCountID")]
    public int FkIcinventoryStockCountId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("ICInventoryStockCountItemQuantity", TypeName = "decimal(18, 6)")]
    public decimal? IcinventoryStockCountItemQuantity { get; set; }

    [Column("ICInventoryStockCountItemActualQuantity", TypeName = "decimal(18, 6)")]
    public decimal? IcinventoryStockCountItemActualQuantity { get; set; }

    [Column("ICInventoryStockCountItemICProductSupplierNumber")]
    [StringLength(50)]
    public string IcinventoryStockCountItemIcproductSupplierNumber { get; set; }

    [Column("ICInventoryStockCountItemICProductDesc")]
    [StringLength(512)]
    public string IcinventoryStockCountItemIcproductDesc { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICInventoryStockCountItemProductSerialNo")]
    [StringLength(128)]
    public string IcinventoryStockCountItemProductSerialNo { get; set; }

    [Column("ICInventoryStockActualUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockActualUnitCost { get; set; }

    [Column("ICInventoryStockCountItemPackageBarcode")]
    [StringLength(255)]
    public string IcinventoryStockCountItemPackageBarcode { get; set; }

    [Column("ICInventoryStockCountItemPackageQty", TypeName = "decimal(18, 6)")]
    public decimal? IcinventoryStockCountItemPackageQty { get; set; }

    [Column("ICInventoryStockCountItemDesc")]
    [StringLength(256)]
    public string IcinventoryStockCountItemDesc { get; set; }

    [Column("ICInventoryStockCountItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? IcinventoryStockCountItemProductQty { get; set; }

    [Column("FK_ICProductPackageItemID")]
    public int? FkIcproductPackageItemId { get; set; }

    [Column("FK_ICProductPackageID")]
    public int? FkIcproductPackageId { get; set; }

    [Column("ICInventoryStockCountItemProductNo")]
    [StringLength(256)]
    public string IcinventoryStockCountItemProductNo { get; set; }

    [Column("ICInventoryStockCountItemIsSpecificCalculation")]
    public bool? IcinventoryStockCountItemIsSpecificCalculation { get; set; }

    [Column("ICInventoryStockCountItemIsAverageCalculation")]
    public bool? IcinventoryStockCountItemIsAverageCalculation { get; set; }

    [Column("ICInventoryStockUnitCostAVG", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockUnitCostAvg { get; set; }

    [Column("ICInventoryStockActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockActualTotalCost { get; set; }

    [ForeignKey("FkIcinventoryStockCountId")]
    [InverseProperty("IcinventoryStockCountItems")]
    public virtual Hremployee FkIcinventoryStockCount { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcinventoryStockCountItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcinventoryStockCountItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcinventoryStockCountItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("IcinventoryStockCountItems")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }
}
