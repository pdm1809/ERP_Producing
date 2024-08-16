using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostGeneralCostAllocationDetails")]
public partial class MmproductionCostGeneralCostAllocationDetail
{
    [Key]
    [Column("MMProductionCostGeneralCostAllocationDetailID")]
    public int MmproductionCostGeneralCostAllocationDetailId { get; set; }

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

    [Column("FK_MMProductionCostGeneralCostAllocationID")]
    public int? FkMmproductionCostGeneralCostAllocationId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMProductionCostGeneralCostAllocationDetailRateValue", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostGeneralCostAllocationDetailRateValue { get; set; }

    [Column("MMProductionCostGeneralCostAllocationDetailAmount", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostGeneralCostAllocationDetailAmount { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmproductionCostGeneralCostAllocationDetails")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostGeneralCostAllocationDetails")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostGeneralCostAllocationId")]
    [InverseProperty("MmproductionCostGeneralCostAllocationDetails")]
    public virtual MmproductionCostGeneralCostAllocation FkMmproductionCostGeneralCostAllocation { get; set; }
}
