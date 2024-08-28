using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormCostFactors")]
public partial class MmproductionNormCostFactor
{
    [Key]
    [Column("MMProductionNormCostFactorID")]
    public int MmproductionNormCostFactorId { get; set; }

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

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_MMProductionNormFactorID")]
    public int? FkMmproductionNormFactorId { get; set; }

    [Column("FK_MMProductionCostFactorID")]
    public int? FkMmproductionCostFactorId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("MMProductionNormCostFactorNumber")]
    public int? MmproductionNormCostFactorNumber { get; set; }

    [Required]
    [Column("MMProductionNormCostFactorNo")]
    [StringLength(50)]
    public string MmproductionNormCostFactorNo { get; set; }

    [Required]
    [Column("MMProductionNormCostFactorName")]
    [StringLength(100)]
    public string MmproductionNormCostFactorName { get; set; }

    [Column("MMProductionNormCostFactorSourceData")]
    [StringLength(50)]
    public string MmproductionNormCostFactorSourceData { get; set; }

    [Column("MMProductionNormCostFactorProductGroup")]
    [StringLength(50)]
    public string MmproductionNormCostFactorProductGroup { get; set; }

    [Column("MMProductionNormCostFactorPriceType")]
    [StringLength(100)]
    public string MmproductionNormCostFactorPriceType { get; set; }

    [Column("MMProductionNormCostFactorDateData")]
    [StringLength(50)]
    public string MmproductionNormCostFactorDateData { get; set; }

    [Column("MMProductionNormCostFactorAllocation", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormCostFactorAllocation { get; set; }

    [Column("MMProductionNormCostFactorCalculator")]
    [StringLength(200)]
    public string MmproductionNormCostFactorCalculator { get; set; }

    [Column("MMProductionNormCostFactorFormula")]
    [StringLength(200)]
    public string MmproductionNormCostFactorFormula { get; set; }

    [Column("MMProductionNormCostFactorIsSetCostPrice")]
    public bool? MmproductionNormCostFactorIsSetCostPrice { get; set; }

    [Column("MMProductionNormCostFactorUpdatingType")]
    [StringLength(50)]
    public string MmproductionNormCostFactorUpdatingType { get; set; }

    [Column("MMProductionNormCostFactorAllocationType")]
    [StringLength(50)]
    public string MmproductionNormCostFactorAllocationType { get; set; }

    [Column("MMPriceType")]
    [StringLength(50)]
    public string MmpriceType { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("MmproductionNormCostFactorFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("MmproductionNormCostFactorFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmproductionNormCostFactors")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionNormCostFactors")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionNormFactorId")]
    [InverseProperty("MmproductionNormCostFactors")]
    public virtual MmproductionNormFactor FkMmproductionNormFactor { get; set; }
}
