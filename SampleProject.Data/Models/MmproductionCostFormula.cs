using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostFormulas")]
public partial class MmproductionCostFormula
{
    [Key]
    [Column("MMProductionCostFormulaID")]
    public int MmproductionCostFormulaId { get; set; }

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
    [Column("MMProductionCostFormulaNo")]
    [StringLength(50)]
    public string MmproductionCostFormulaNo { get; set; }

    [Column("MMProductionCostFormulaDate", TypeName = "datetime")]
    public DateTime? MmproductionCostFormulaDate { get; set; }

    [Column("MMProductionCostFormulaName")]
    [StringLength(512)]
    public string MmproductionCostFormulaName { get; set; }

    [Column("MMProductionCostFormulaDesc")]
    [StringLength(512)]
    public string MmproductionCostFormulaDesc { get; set; }

    [Column("MMProductionCostFormulaFromDate", TypeName = "datetime")]
    public DateTime? MmproductionCostFormulaFromDate { get; set; }

    [Column("MMProductionCostFormulaToDate", TypeName = "datetime")]
    public DateTime? MmproductionCostFormulaToDate { get; set; }

    [Column("MMProductionCostFormulaType")]
    [StringLength(50)]
    public string MmproductionCostFormulaType { get; set; }

    [Column("MMProductionCostFormulaHasReceiptShipment")]
    public bool? MmproductionCostFormulaHasReceiptShipment { get; set; }

    public bool? IsBatchProduct { get; set; }

    public bool? IsProduct { get; set; }

    public bool? IsSaleOrder { get; set; }

    public bool? IsProductGroup { get; set; }

    public bool? IsDepartment { get; set; }

    public bool? IsOperation { get; set; }

    public bool? IsProject { get; set; }

    [InverseProperty("FkMmproductionCostFormula")]
    public virtual ICollection<MminProgressStatistic> MminProgressStatistics { get; set; } = new List<MminProgressStatistic>();

    [InverseProperty("FkMmproductionCostFormula")]
    public virtual ICollection<MmproductionCostCalculation> MmproductionCostCalculations { get; set; } = new List<MmproductionCostCalculation>();

    [InverseProperty("FkMmproductionCostFormula")]
    public virtual ICollection<MmproductionCostFormulaDetail> MmproductionCostFormulaDetails { get; set; } = new List<MmproductionCostFormulaDetail>();

    [InverseProperty("FkMmproductionCostFormula")]
    public virtual ICollection<MmproductionCostFormulaOperationItem> MmproductionCostFormulaOperationItems { get; set; } = new List<MmproductionCostFormulaOperationItem>();

    [InverseProperty("FkMmproductionCostFormula")]
    public virtual ICollection<MmproductionCostFormulaOperation> MmproductionCostFormulaOperations { get; set; } = new List<MmproductionCostFormulaOperation>();

    [InverseProperty("FkMmproductionCostFormula")]
    public virtual ICollection<MmproductionCostFormulaProduct> MmproductionCostFormulaProducts { get; set; } = new List<MmproductionCostFormulaProduct>();
}
