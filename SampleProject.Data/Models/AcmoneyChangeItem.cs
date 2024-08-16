using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACMoneyChangeItems")]
public partial class AcmoneyChangeItem
{
    [Key]
    [Column("ACMoneyChangeItemID")]
    public int AcmoneyChangeItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACMoneyChangeID")]
    public int FkAcmoneyChangeId { get; set; }

    [Column("FK_CSCashFundID")]
    public int FkCscashFundId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int FkCscompanyBankId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("ACMoneyChangeItemGroup")]
    public int AcmoneyChangeItemGroup { get; set; }

    [Column("ACMoneyChangeItemDesc")]
    [StringLength(512)]
    public string AcmoneyChangeItemDesc { get; set; }

    [Column("ACMoneyChangeItemExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcmoneyChangeItemExchangeRate { get; set; }

    [Column("ACMoneyChangeItemDebitAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcmoneyChangeItemDebitAmount { get; set; }

    [Column("ACMoneyChangeItemDebitExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcmoneyChangeItemDebitExchangeAmount { get; set; }

    [Column("ACMoneyChangeItemCreditAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcmoneyChangeItemCreditAmount { get; set; }

    [Column("ACMoneyChangeItemCreditExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcmoneyChangeItemCreditExchangeAmount { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(128)]
    public string AcobjectType { get; set; }

    [Column("FK_ACAccountID")]
    public int FkAcaccountId { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcmoneyChangeItems")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcmoneyChangeId")]
    [InverseProperty("AcmoneyChangeItems")]
    public virtual AcmoneyChange FkAcmoneyChange { get; set; }

    [ForeignKey("FkCscashFundId")]
    [InverseProperty("AcmoneyChangeItems")]
    public virtual CscashFund FkCscashFund { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("AcmoneyChangeItems")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcmoneyChangeItems")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
