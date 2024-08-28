using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostCalculationItems")]
public partial class MmproductionCostCalculationItem
{
    [Key]
    [Column("MMProductionCostCalculationItemID")]
    public int MmproductionCostCalculationItemId { get; set; }

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

    [Column("MMProductionCostCalculationItemProductName")]
    [StringLength(250)]
    public string MmproductionCostCalculationItemProductName { get; set; }

    [Column("MMProductionCostCalculationItemProductDesc")]
    [StringLength(512)]
    public string MmproductionCostCalculationItemProductDesc { get; set; }

    [Column("MMProductionCostCalculationItemOpeningQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemOpeningQty { get; set; }

    [Column("MMProductionCostCalculationItemReceiptQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemReceiptQty { get; set; }

    [Column("MMProductionCostCalculationItemEndQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemEndQty { get; set; }

    [Column("MMProductionCostCalculationItemQty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemQty { get; set; }

    [Column("MMProductionCostCalculationUnitCost", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationUnitCost { get; set; }

    [Column("MMProductionCostCalculationTotalCost", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationTotalCost { get; set; }

    [Column("MMProductionCostCalculationItemM3Qty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemM3qty { get; set; }

    [Column("MMProductionCostCalculationItemM2Qty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemM2qty { get; set; }

    [Column("MMProductionCostCalculationItemFactor", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemFactor { get; set; }

    [Column("MMProductionCostCalculationItemSerialNo")]
    [StringLength(200)]
    public string MmproductionCostCalculationItemSerialNo { get; set; }

    [Column("MMProductionCostCalculationItemUsePercent", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemUsePercent { get; set; }

    [Column("MMProductionCostCalculationItemTotalM2Qty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemTotalM2qty { get; set; }

    [Column("MMProductionCostCalculationItemTotalM3Qty", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemTotalM3qty { get; set; }

    [Column("MMProductionCostCalculationItemType")]
    [StringLength(100)]
    public string MmproductionCostCalculationItemType { get; set; }

    [Column("MMProductionCostCalculationItemFactorPerOne", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemFactorPerOne { get; set; }

    [Column("MMProductionCostCalculationItemOpeningValue", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationItemOpeningValue { get; set; }

    [Column("MMProductionCostCalculationItemEndValue", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostCalculationItemEndValue { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostCalculationId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual MmproductionCostCalculation FkMmproductionCostCalculation { get; set; }

    [ForeignKey("FkMmproductionCostFactorId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual MmproductionCostFactor FkMmproductionCostFactor { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("MmproductionCostCalculationItems")]
    public virtual Pmproject FkPmproject { get; set; }
}
