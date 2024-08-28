using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostCalculationDetailCosts")]
public partial class MmproductionCostCalculationDetailCost
{
    [Key]
    [Column("MMProductionCostCalculationDetailCostID")]
    public int MmproductionCostCalculationDetailCostId { get; set; }

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

    [Column("MMProductionCostCalculationDetailCostValue", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationDetailCostValue { get; set; }

    [Column("MMProductionCostCalculationDetailCostProductName")]
    [StringLength(512)]
    public string MmproductionCostCalculationDetailCostProductName { get; set; }

    [Column("MMAllocationType")]
    [StringLength(50)]
    public string MmallocationType { get; set; }

    [Column("MMProductCollectType")]
    [StringLength(50)]
    public string MmproductCollectType { get; set; }

    [Column("MMProjectCollectType")]
    [StringLength(50)]
    public string MmprojectCollectType { get; set; }

    [Column("MMProductGroupCollectType")]
    [StringLength(50)]
    public string MmproductGroupCollectType { get; set; }

    [Column("MMSaleOrderCollectType")]
    [StringLength(50)]
    public string MmsaleOrderCollectType { get; set; }

    [Column("MMDepartmentCollectType")]
    [StringLength(50)]
    public string MmdepartmentCollectType { get; set; }

    [Column("MMBatchProductCollectType")]
    [StringLength(50)]
    public string MmbatchProductCollectType { get; set; }

    [Column("MMOperationCollectType")]
    [StringLength(50)]
    public string MmoperationCollectType { get; set; }

    [Column("MMProductionCostCalculationDetailCostTotalValue", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationDetailCostTotalValue { get; set; }

    [Column("MMProductionCostCalculationDetailCostOpeningValue", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationDetailCostOpeningValue { get; set; }

    [Column("MMProductionCostCalculationDetailCostEndValue", TypeName = "decimal(18, 6)")]
    public decimal? MmproductionCostCalculationDetailCostEndValue { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductionCostCalculationDetailCosts")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionCostCalculationDetailCosts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproductionCostCalculationDetailCosts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductionCostCalculationDetailCosts")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostCalculationDetailCosts")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostCalculationId")]
    [InverseProperty("MmproductionCostCalculationDetailCosts")]
    public virtual MmproductionCostCalculation FkMmproductionCostCalculation { get; set; }

    [ForeignKey("FkMmproductionCostFactorId")]
    [InverseProperty("MmproductionCostCalculationDetailCosts")]
    public virtual MmproductionCostFactor FkMmproductionCostFactor { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmproductionCostCalculationDetailCosts")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
