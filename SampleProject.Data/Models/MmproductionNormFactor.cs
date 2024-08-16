using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormFactors")]
public partial class MmproductionNormFactor
{
    [Key]
    [Column("MMProductionNormFactorID")]
    public int MmproductionNormFactorId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("MMProductionNormFactorNumber")]
    public int? MmproductionNormFactorNumber { get; set; }

    [Required]
    [Column("MMProductionNormFactorNo")]
    [StringLength(50)]
    public string MmproductionNormFactorNo { get; set; }

    [Required]
    [Column("MMProductionNormFactorName")]
    [StringLength(200)]
    public string MmproductionNormFactorName { get; set; }

    [Column("MMProductionNormFactorOrtherName")]
    [StringLength(200)]
    public string MmproductionNormFactorOrtherName { get; set; }

    [Column("MMProductionNormFactorStatus")]
    [StringLength(50)]
    public string MmproductionNormFactorStatus { get; set; }

    [InverseProperty("FkMmproductionNormFactor")]
    public virtual ICollection<MmproductionNormCostFactor> MmproductionNormCostFactors { get; set; } = new List<MmproductionNormCostFactor>();
}
