using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductItemDetails")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ICProductItemDetails")]
public partial class IcproductItemDetail
{
    [Key]
    [Column("ICProductItemDetailID")]
    public int IcproductItemDetailId { get; set; }

    [Column("FK_ICProductItemID")]
    public int FkIcproductItemId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICProductItemDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemDetailQty { get; set; }

    [Column("ICProductItemDetailUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemDetailUnitPrice { get; set; }

    [Column("ICProductItemDetailIncludePriceCheck")]
    public bool? IcproductItemDetailIncludePriceCheck { get; set; }
}
