using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInventoryStockSlotSeries")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcproductSerieId", "FkIcinventoryStockSlotId", Name = "Idx_ICInventoryStockSlotSeries")]
public partial class IcinventoryStockSlotSeries
{
    [Key]
    [Column("AAInventoryStockSlotSerieID")]
    public int AainventoryStockSlotSerieId { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICInventoryStockSlotID")]
    public int FkIcinventoryStockSlotId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("ICInventoryStockSlotSerieQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSlotSerieQuantity { get; set; }

    [Column("ICInventoryStockSlotSerieProposalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSlotSerieProposalQuantity { get; set; }

    [Column("ICInventoryStockSlotSerieSaleOrderQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSlotSerieSaleOrderQuantity { get; set; }

    [Column("ICInventoryStockSlotSeriePurchaseOrderQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSlotSeriePurchaseOrderQuantity { get; set; }

    [ForeignKey("FkIcinventoryStockSlotId")]
    [InverseProperty("IcinventoryStockSlotSeries")]
    public virtual IcinventoryStockSlot FkIcinventoryStockSlot { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcinventoryStockSlotSeries")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcinventoryStockSlotSeries")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }
}
