using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ImportReceiptItem")]
public partial class ImportReceiptItem
{
    [Column("ICProductNo")]
    [StringLength(50)]
    public string IcproductNo { get; set; }

    [Column("ICStockNo")]
    [StringLength(50)]
    public string IcstockNo { get; set; }

    [Column("ICMeasureUnitID")]
    [StringLength(50)]
    public string IcmeasureUnitId { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? UnitCost { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? WoodQty { get; set; }

    [StringLength(20)]
    public string LotNo { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Width { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Length { get; set; }

    [StringLength(50)]
    public string SerialNo { get; set; }

    [StringLength(10)]
    public string CurrencyNo { get; set; }

    [StringLength(50)]
    public string NoOfOldSys { get; set; }
}
