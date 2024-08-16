using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostFormulaDetails")]
public partial class MmproductionCostFormulaDetail
{
    [Key]
    [Column("MMProductionCostFormulaDetailID")]
    public int MmproductionCostFormulaDetailId { get; set; }

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

    [Column("FK_MMProductionCostFormulaID")]
    public int? FkMmproductionCostFormulaId { get; set; }

    [Column("FK_MMProductionCostFactorID")]
    public int? FkMmproductionCostFactorId { get; set; }

    [Column("FK_MMProductionCostFactorGroupID")]
    public int? FkMmproductionCostFactorGroupId { get; set; }

    [Column("MMProductionCostFormulaDetailProductCollectType")]
    [StringLength(50)]
    public string MmproductionCostFormulaDetailProductCollectType { get; set; }

    [Column("MMProductionCostFormulaDetailProjectCollectType")]
    [StringLength(50)]
    public string MmproductionCostFormulaDetailProjectCollectType { get; set; }

    [Column("MMProductionCostFormulaDetailProductGroupCollectType")]
    [StringLength(50)]
    public string MmproductionCostFormulaDetailProductGroupCollectType { get; set; }

    [Column("MMProductionCostFormulaDetailSaleOrderCollectType")]
    [StringLength(50)]
    public string MmproductionCostFormulaDetailSaleOrderCollectType { get; set; }

    [Column("MMProductionCostFormulaDetailDepartmentCollectType")]
    [StringLength(50)]
    public string MmproductionCostFormulaDetailDepartmentCollectType { get; set; }

    [Column("MMProductionCostFormulaDetailBatchProductCollectType")]
    [StringLength(50)]
    public string MmproductionCostFormulaDetailBatchProductCollectType { get; set; }

    [Column("MMProductionCostFormulaDetailOperationCollectType")]
    [StringLength(50)]
    public string MmproductionCostFormulaDetailOperationCollectType { get; set; }

    [Column("MMProductionCostAllocationType")]
    [StringLength(50)]
    public string MmproductionCostAllocationType { get; set; }

    [Column("FK_MMRefProductionCostFactorID")]
    public int? FkMmrefProductionCostFactorId { get; set; }

    [Column("MMProductionCostFormulaDetailHasEndingInProgress")]
    public bool? MmproductionCostFormulaDetailHasEndingInProgress { get; set; }

    [Column("MMProductionCostInProgressCalType")]
    [StringLength(50)]
    public string MmproductionCostInProgressCalType { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("MMProductionCostFormulaDetailIsDeduction")]
    public bool? MmproductionCostFormulaDetailIsDeduction { get; set; }

    [Column("FK_ACInProgressAccountID")]
    public int? FkAcinProgressAccountId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("MmproductionCostFormulaDetailFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("MmproductionCostFormulaDetailFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcinProgressAccountId")]
    [InverseProperty("MmproductionCostFormulaDetailFkAcinProgressAccounts")]
    public virtual Acaccount FkAcinProgressAccount { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostFormulaDetails")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostFactorId")]
    [InverseProperty("MmproductionCostFormulaDetailFkMmproductionCostFactors")]
    public virtual MmproductionCostFactor FkMmproductionCostFactor { get; set; }

    [ForeignKey("FkMmproductionCostFactorGroupId")]
    [InverseProperty("MmproductionCostFormulaDetails")]
    public virtual MmproductionCostFactorGroup FkMmproductionCostFactorGroup { get; set; }

    [ForeignKey("FkMmproductionCostFormulaId")]
    [InverseProperty("MmproductionCostFormulaDetails")]
    public virtual MmproductionCostFormula FkMmproductionCostFormula { get; set; }

    [ForeignKey("FkMmrefProductionCostFactorId")]
    [InverseProperty("MmproductionCostFormulaDetailFkMmrefProductionCostFactors")]
    public virtual MmproductionCostFactor FkMmrefProductionCostFactor { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmproductionCostFormulaDetails")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
