using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostCalculationAllocations")]
public partial class MmproductionCostCalculationAllocation
{
    [Key]
    [Column("MMProductionCostCalculationAllocationID")]
    public int MmproductionCostCalculationAllocationId { get; set; }

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

    [Column("MMProductionCostCalculationAllocationBlockPerOne", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationAllocationBlockPerOne { get; set; }

    [Column("MMProductionNormTotalPaint", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionNormTotalPaint { get; set; }

    [Column("MMProductionCostCalculationItemTotalM3Qty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemTotalM3qty { get; set; }

    [Column("MMProductionCostCalculationItemTotalBOMQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemTotalBomqty { get; set; }

    [Column("MMProductionCostCalculationItemTotalReceiptQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemTotalReceiptQty { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostCalculationId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual MmproductionCostCalculation FkMmproductionCostCalculation { get; set; }

    [ForeignKey("FkMmproductionCostFactorId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual MmproductionCostFactor FkMmproductionCostFactor { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("MmproductionCostCalculationAllocations")]
    public virtual Pmproject FkPmproject { get; set; }
}
