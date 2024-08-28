using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInventoryStocks")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcstockId", "FkIcproductSerieId", Name = "Idx_ICInventoryStocks")]
public partial class IcinventoryStock
{
    [Key]
    [Column("ICInventoryStockID")]
    public int IcinventoryStockId { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICInventoryStockInitQty", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockInitQty { get; set; }

    [Column("ICInventoryStockQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockQuantity { get; set; }

    [Column("ICInventoryStockProposalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockProposalQuantity { get; set; }

    [Column("ICInventoryStockSaleOrderQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSaleOrderQuantity { get; set; }

    [Column("ICInventoryStockPurchaseOrderQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockPurchaseOrderQuantity { get; set; }

    [Column("ICInventoryStockUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockUnitCost { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ICInventoryStockTransferredDate", TypeName = "datetime")]
    public DateTime? IcinventoryStockTransferredDate { get; set; }

    [Column("ICInventoryStockWoodQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockWoodQuantity { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcinventoryStocks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcinventoryStocks")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcinventoryStocks")]
    public virtual Icstock FkIcstock { get; set; }

    [InverseProperty("FkIcinventoryStock")]
    public virtual ICollection<IcinventoryStockSerial> IcinventoryStockSerials { get; set; } = new List<IcinventoryStockSerial>();

    [InverseProperty("FkIcinventoryStock")]
    public virtual ICollection<IcinventoryStockSlot> IcinventoryStockSlots { get; set; } = new List<IcinventoryStockSlot>();

    [InverseProperty("FkIcinventoryStock")]
    public virtual ICollection<IcpriceAdjustmentItem> IcpriceAdjustmentItems { get; set; } = new List<IcpriceAdjustmentItem>();
}
