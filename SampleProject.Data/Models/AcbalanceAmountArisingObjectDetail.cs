using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBalanceAmountArisingObjectDetails")]
public partial class AcbalanceAmountArisingObjectDetail
{
    [Key]
    [Column("ACBalanceAmountArisingObjectDetailID")]
    public int AcbalanceAmountArisingObjectDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACBalanceAmountArisingID")]
    public int? FkAcbalanceAmountArisingId { get; set; }

    [Column("FK_ACBalanceAmountArisingDetailID")]
    public int? FkAcbalanceAmountArisingDetailId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(20)]
    public string AcobjectType { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailAcountNumber")]
    [StringLength(10)]
    public string AcbalanceAmountArisingObjectDetailAcountNumber { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailStartPeriodDebitBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingObjectDetailStartPeriodDebitBalance { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailStartPeriodCreditBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingObjectDetailStartPeriodCreditBalance { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailPeriodDebitBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingObjectDetailPeriodDebitBalance { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailPeriodCreditBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingObjectDetailPeriodCreditBalance { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailEndPeriodDebitBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingObjectDetailEndPeriodDebitBalance { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailEndPeriodCreditBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingObjectDetailEndPeriodCreditBalance { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailFromDate", TypeName = "datetime")]
    public DateTime? AcbalanceAmountArisingObjectDetailFromDate { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailToDate", TypeName = "datetime")]
    public DateTime? AcbalanceAmountArisingObjectDetailToDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingObjectDetailExchangeRate { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailInitialBalanceByCurrency", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingObjectDetailInitialBalanceByCurrency { get; set; }

    [Column("ACBalanceAmountArisingObjectDetailInitialBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingObjectDetailInitialBalance { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcbalanceAmountArisingObjectDetails")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcbalanceAmountArisingId")]
    [InverseProperty("AcbalanceAmountArisingObjectDetails")]
    public virtual AcbalanceAmountArising FkAcbalanceAmountArising { get; set; }

    [ForeignKey("FkAcbalanceAmountArisingDetailId")]
    [InverseProperty("AcbalanceAmountArisingObjectDetails")]
    public virtual AcbalanceAmountArisingDetail FkAcbalanceAmountArisingDetail { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcbalanceAmountArisingObjectDetails")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("AcbalanceAmountArisingObjectDetails")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcbalanceAmountArisingObjectDetails")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
