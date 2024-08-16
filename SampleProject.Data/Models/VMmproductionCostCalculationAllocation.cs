using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class VMmproductionCostCalculationAllocation
{
    [Column("MMProductionCostCalculationAllocationID")]
    public int MmproductionCostCalculationAllocationId { get; set; }

    [Column("FK_MMProductionCostCalculationID")]
    public int? FkMmproductionCostCalculationId { get; set; }

    [Column("FK_MMProductionCostFactorID")]
    public int? FkMmproductionCostFactorId { get; set; }

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

    [Column("MMProductionCostCalculationAllocationFactorType")]
    [StringLength(250)]
    public string MmproductionCostCalculationAllocationFactorType { get; set; }

    [Column("MMProductionCostCalculationAllocationProductName")]
    [StringLength(250)]
    public string MmproductionCostCalculationAllocationProductName { get; set; }

    [Column("MMProductionCostCalculationAllocationProductDesc")]
    [StringLength(512)]
    public string MmproductionCostCalculationAllocationProductDesc { get; set; }

    [Column("MMProductionCostCalculationAllocationOpeningAmount", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationAllocationOpeningAmount { get; set; }

    [Column("MMProductionCostCalculationAllocationAmount", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationAllocationAmount { get; set; }

    [Column("MMProductionCostCalculationAllocationCostAmount", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationAllocationCostAmount { get; set; }

    [Column("MMProductionCostCalculationAllocationEndAmount", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationAllocationEndAmount { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("MMProductionCostCalculationAllocationSerialNo")]
    [StringLength(50)]
    public string MmproductionCostCalculationAllocationSerialNo { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("MMProductionCostCalculationPriceReceiptQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationPriceReceiptQty { get; set; }
}
