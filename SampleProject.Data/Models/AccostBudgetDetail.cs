using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACCostBudgetDetails")]
public partial class AccostBudgetDetail
{
    [Key]
    [Column("ACCostBudgetDetailID")]
    public int AccostBudgetDetailId { get; set; }

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

    [Column("FK_ACCostBudgetID")]
    public int FkAccostBudgetId { get; set; }

    [Column("ACCostBudgetDetailFromDate", TypeName = "datetime")]
    public DateTime? AccostBudgetDetailFromDate { get; set; }

    [Column("ACCostBudgetDetailToDate", TypeName = "datetime")]
    public DateTime? AccostBudgetDetailToDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int FkAccreditAccountId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("ACCostBudgetDetailAmount", TypeName = "decimal(18, 0)")]
    public decimal? AccostBudgetDetailAmount { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACCostBudgetDetailExchangeRate", TypeName = "decimal(18, 0)")]
    public decimal? AccostBudgetDetailExchangeRate { get; set; }

    [ForeignKey("FkAccostBudgetId")]
    [InverseProperty("AccostBudgetDetails")]
    public virtual AccostBudget FkAccostBudget { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AccostBudgetDetails")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AccostBudgetDetailFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AccostBudgetDetailFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AccostBudgetDetails")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AccostBudgetDetails")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AccostBudgetDetails")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AccostBudgetDetails")]
    public virtual Hrdepartment FkHrdepartment { get; set; }
}
