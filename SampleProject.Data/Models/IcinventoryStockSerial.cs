using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInventoryStockSerials")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcstockId", "FkIcproductSerieId", Name = "Idx_ICInventoryStockSerials")]
public partial class IcinventoryStockSerial
{
    [Key]
    [Column("ICInventoryStockSerialID")]
    public int IcinventoryStockSerialId { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICInventoryStockID")]
    public int FkIcinventoryStockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICInventoryStockSerialProductSerialNo")]
    [StringLength(50)]
    public string IcinventoryStockSerialProductSerialNo { get; set; }

    [Column("ICInventoryStockSerialQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSerialQuantity { get; set; }

    [Column("ICInventoryStockSerialProposalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSerialProposalQuantity { get; set; }

    [Column("ICInventoryStockSerialSaleOrderQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSerialSaleOrderQuantity { get; set; }

    [Column("ICInventoryStockSerialPurchaseOrderQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryStockSerialPurchaseOrderQuantity { get; set; }

    [ForeignKey("FkIcinventoryStockId")]
    [InverseProperty("IcinventoryStockSerials")]
    public virtual IcinventoryStock FkIcinventoryStock { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcinventoryStockSerials")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcinventoryStockSerials")]
    public virtual Icstock FkIcstock { get; set; }
}
