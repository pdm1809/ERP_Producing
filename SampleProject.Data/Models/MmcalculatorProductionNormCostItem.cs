using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCalculatorProductionNormCostItems")]
public partial class MmcalculatorProductionNormCostItem
{
    [Key]
    [Column("MMCalculatorProductionNormCostItemID")]
    public int MmcalculatorProductionNormCostItemId { get; set; }

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

    [Column("MMCalculatorProductionNormCostItemNumber")]
    public int? MmcalculatorProductionNormCostItemNumber { get; set; }

    [Column("MMCalculatorProductionNormCostItemNo")]
    [StringLength(50)]
    public string MmcalculatorProductionNormCostItemNo { get; set; }

    [Column("MMCalculatorProductionNormCostItemName")]
    [StringLength(100)]
    public string MmcalculatorProductionNormCostItemName { get; set; }

    [Column("MMCalculatorProductionNormCostItemCostPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostItemCostPrice { get; set; }

    [Column("MMCalculatorProductionNormCostItemCostPriceExchange", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostItemCostPriceExchange { get; set; }

    [Column("FK_MMCalculatorProductionNormCostID")]
    public int? FkMmcalculatorProductionNormCostId { get; set; }

    [Column("MMProductionNormCostFactorProductGroup")]
    [StringLength(50)]
    public string MmproductionNormCostFactorProductGroup { get; set; }

    [Column("MMCalculatorProductionNormCostItemAllocationType")]
    [StringLength(50)]
    public string MmcalculatorProductionNormCostItemAllocationType { get; set; }

    [Column("MMCalculatorProductionNormCostItemAllocation", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostItemAllocation { get; set; }

    [Column("MMCalculatorProductionNormCostItemAllocationQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostItemAllocationQty { get; set; }

    [Column("FK_ACDebitAccountID")]
    [StringLength(20)]
    public string FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    [StringLength(20)]
    public string FkAccreditAccountId { get; set; }

    [ForeignKey("FkMmcalculatorProductionNormCostId")]
    [InverseProperty("MmcalculatorProductionNormCostItems")]
    public virtual MmcalculatorProductionNormCost FkMmcalculatorProductionNormCost { get; set; }
}
