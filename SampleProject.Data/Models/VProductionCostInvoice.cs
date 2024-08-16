using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class VProductionCostInvoice
{
    [Column("MMProductionCostFactorName")]
    [StringLength(256)]
    public string MmproductionCostFactorName { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? UnitCostAmount { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("MMProductionNormBlock", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionNormBlock { get; set; }

    [Column("MMProductionNormTotalPaint", TypeName = "decimal(38, 18)")]
    public decimal? MmproductionNormTotalPaint { get; set; }

    [Column("ARInvoiceItemID")]
    public int? ArinvoiceItemId { get; set; }
}
