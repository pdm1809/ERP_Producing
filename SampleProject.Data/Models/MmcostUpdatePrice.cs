using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCostUpdatePrices")]
public partial class MmcostUpdatePrice
{
    [Key]
    [Column("MMCostUpdatePriceID")]
    public int MmcostUpdatePriceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("MMProductionCostCalculationNo")]
    [StringLength(100)]
    public string MmproductionCostCalculationNo { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("MMCostUpdatePriceProductNo")]
    [StringLength(100)]
    public string MmcostUpdatePriceProductNo { get; set; }

    [Column("MMCostUpdatePriceProductName")]
    [StringLength(524)]
    public string MmcostUpdatePriceProductName { get; set; }

    [Column("MMCostUpdatePriceReceiptQty", TypeName = "decimal(18, 6)")]
    public decimal? MmcostUpdatePriceReceiptQty { get; set; }

    [Column("MMCostUpdatePriceUnitCost", TypeName = "decimal(18, 6)")]
    public decimal? MmcostUpdatePriceUnitCost { get; set; }

    [Column("MMCostUpdatePriceTotalCost", TypeName = "decimal(18, 6)")]
    public decimal? MmcostUpdatePriceTotalCost { get; set; }

    [Column("MMCostUpdatePriceTranferTotalCost", TypeName = "decimal(18, 6)")]
    public decimal? MmcostUpdatePriceTranferTotalCost { get; set; }

    [Column("MMCostUpdatePriceSerialNo")]
    [StringLength(50)]
    public string MmcostUpdatePriceSerialNo { get; set; }

    [Column("MMCostUpdatePriceShipmentNo")]
    [StringLength(2000)]
    public string MmcostUpdatePriceShipmentNo { get; set; }
}
