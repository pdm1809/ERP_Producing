using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInventoryStockSlots")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcinventoryStockId", Name = "Idx_ICInventoryStockSlots")]
public partial class IcinventoryStockSlot
{
    [Key]
    [Column("ICInventoryStockSlotID")]
    public int IcinventoryStockSlotId { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICStockSlotID")]
    public int FkIcstockSlotId { get; set; }

    [Column("FK_ICInventoryStockID")]
    public int FkIcinventoryStockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICInventoryStockSlotQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSlotQuantity { get; set; }

    [Column("ICInventoryStockSlotProposalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSlotProposalQuantity { get; set; }

    [Column("ICInventoryStockSlotSaleOrderQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSlotSaleOrderQuantity { get; set; }

    [Column("ICInventoryStockSlotPurchaseOrderQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSlotPurchaseOrderQuantity { get; set; }

    [ForeignKey("FkIcinventoryStockId")]
    [InverseProperty("IcinventoryStockSlots")]
    public virtual IcinventoryStock FkIcinventoryStock { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcinventoryStockSlots")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("IcinventoryStockSlots")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }

    [InverseProperty("FkIcinventoryStockSlot")]
    public virtual ICollection<IcinventoryStockSlotSeries> IcinventoryStockSlotSeries { get; set; } = new List<IcinventoryStockSlotSeries>();
}
