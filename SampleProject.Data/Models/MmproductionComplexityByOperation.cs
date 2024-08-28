using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionComplexityByOperations")]
public partial class MmproductionComplexityByOperation
{
    [Key]
    [Column("MMProductionComplexityByOperationID")]
    public int MmproductionComplexityByOperationId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMConfigProductionComplexityType")]
    [StringLength(100)]
    public string MmconfigProductionComplexityType { get; set; }

    [Column("MMUnitTime", TypeName = "decimal(18, 5)")]
    public decimal? MmunitTime { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionComplexityByOperations")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
