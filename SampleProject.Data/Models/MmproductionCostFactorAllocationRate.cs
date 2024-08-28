using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostFactorAllocationRates")]
public partial class MmproductionCostFactorAllocationRate
{
    [Key]
    [Column("MMProductionCostFactorAllocationRateID")]
    public int MmproductionCostFactorAllocationRateId { get; set; }

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

    [Column("FK_MMProductionCostFactorID")]
    public int? FkMmproductionCostFactorId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMProductionCostFactorAllocationRateValue", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostFactorAllocationRateValue { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmproductionCostFactorAllocationRates")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostFactorAllocationRates")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostFactorId")]
    [InverseProperty("MmproductionCostFactorAllocationRates")]
    public virtual MmproductionCostFactor FkMmproductionCostFactor { get; set; }
}
