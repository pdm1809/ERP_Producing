using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostCalculations")]
public partial class MmproductionCostCalculation
{
    [Key]
    [Column("MMProductionCostCalculationID")]
    public int MmproductionCostCalculationId { get; set; }

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

    [Required]
    [Column("MMProductionCostCalculationNo")]
    [StringLength(50)]
    public string MmproductionCostCalculationNo { get; set; }

    [Column("MMProductionCostCalculationDate", TypeName = "datetime")]
    public DateTime? MmproductionCostCalculationDate { get; set; }

    [Column("MMProductionCostCalculationFromDate", TypeName = "datetime")]
    public DateTime? MmproductionCostCalculationFromDate { get; set; }

    [Column("MMProductionCostCalculationToDate", TypeName = "datetime")]
    public DateTime? MmproductionCostCalculationToDate { get; set; }

    [Column("MMProductionCostCalculationDesc")]
    [StringLength(512)]
    public string MmproductionCostCalculationDesc { get; set; }

    [Column("FK_MMProductionCostFormulaID")]
    public int? FkMmproductionCostFormulaId { get; set; }

    [Column("MMProductionCostCalculationStatus")]
    [StringLength(64)]
    public string MmproductionCostCalculationStatus { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMProductionCostCalculationTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostCalculationTotalBlock { get; set; }

    [Column("MMProductionCostCalculationTotalAcreage", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostCalculationTotalAcreage { get; set; }

    [Column("MMProductionCostCalculationTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostCalculationTotalQty { get; set; }

    [Column("MMProductionCostCalculationTotalQtyByFactor", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostCalculationTotalQtyByFactor { get; set; }

    [Column("MMProductionCostCalculationOperationBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostCalculationOperationBlock { get; set; }

    [Column("MMProductionCostCalculationOperationAcreage", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostCalculationOperationAcreage { get; set; }

    [Column("MMProductionCostCalculationOperationQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostCalculationOperationQty { get; set; }

    [Column("MMProductionCostCalculationOperationQtyByFactor", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostCalculationOperationQtyByFactor { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostCalculations")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostFormulaId")]
    [InverseProperty("MmproductionCostCalculations")]
    public virtual MmproductionCostFormula FkMmproductionCostFormula { get; set; }

    [InverseProperty("FkMmproductionCostCalculation")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkMmproductionCostCalculation")]
    public virtual ICollection<MmproductionCostCalculationDetailCost> MmproductionCostCalculationDetailCosts { get; set; } = new List<MmproductionCostCalculationDetailCost>();

    [InverseProperty("FkMmproductionCostCalculation")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkMmproductionCostCalculation")]
    public virtual ICollection<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; } = new List<MmproductionCostCalculationPrice>();
}
