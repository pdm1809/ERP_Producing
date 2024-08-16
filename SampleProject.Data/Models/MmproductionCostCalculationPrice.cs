using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostCalculationPrices")]
public partial class MmproductionCostCalculationPrice
{
    [Key]
    [Column("MMProductionCostCalculationPriceID")]
    public int MmproductionCostCalculationPriceId { get; set; }

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

    [Column("FK_MMProductionCostCalculationID")]
    public int? FkMmproductionCostCalculationId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("MMProductionCostCalculationPriceProductName")]
    [StringLength(250)]
    public string MmproductionCostCalculationPriceProductName { get; set; }

    [Column("MMProductionCostCalculationPriceProductDesc")]
    [StringLength(512)]
    public string MmproductionCostCalculationPriceProductDesc { get; set; }

    [Column("MMProductionCostCalculationPriceReceiptQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationPriceReceiptQty { get; set; }

    [Column("MMProductionCostCalculationUnitCost", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationUnitCost { get; set; }

    [Column("MMProductionCostCalculationTotalCost", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationTotalCost { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("MMProductionCostCalculationPriceSerialNo")]
    [StringLength(50)]
    public string MmproductionCostCalculationPriceSerialNo { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductionCostCalculationPrices")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmproductionCostCalculationPrices")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionCostCalculationPrices")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproductionCostCalculationPrices")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductionCostCalculationPrices")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostCalculationPrices")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostCalculationId")]
    [InverseProperty("MmproductionCostCalculationPrices")]
    public virtual MmproductionCostCalculation FkMmproductionCostCalculation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmproductionCostCalculationPrices")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("MmproductionCostCalculationPrices")]
    public virtual Pmproject FkPmproject { get; set; }
}
