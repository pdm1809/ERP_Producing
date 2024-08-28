using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBalanceAmountArisingDetails")]
public partial class AcbalanceAmountArisingDetail
{
    [Key]
    [Column("ACBalanceAmountArisingDetailID")]
    public int AcbalanceAmountArisingDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACBalanceAmountArisingID")]
    public int? FkAcbalanceAmountArisingId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ACBalanceAmountArisingDetailAcountNumber")]
    [StringLength(10)]
    public string AcbalanceAmountArisingDetailAcountNumber { get; set; }

    [Column("ACBalanceAmountArisingDetailAcountName")]
    [StringLength(200)]
    public string AcbalanceAmountArisingDetailAcountName { get; set; }

    [Column("ACBalanceAmountArisingDetailStartPeriodDebitBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingDetailStartPeriodDebitBalance { get; set; }

    [Column("ACBalanceAmountArisingDetailStartPeriodCreditBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingDetailStartPeriodCreditBalance { get; set; }

    [Column("ACBalanceAmountArisingDetailPeriodDebitBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingDetailPeriodDebitBalance { get; set; }

    [Column("ACBalanceAmountArisingDetailPeriodCreditBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingDetailPeriodCreditBalance { get; set; }

    [Column("ACBalanceAmountArisingDetailEndPeriodDebitBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingDetailEndPeriodDebitBalance { get; set; }

    [Column("ACBalanceAmountArisingDetailEndPeriodCreditBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceAmountArisingDetailEndPeriodCreditBalance { get; set; }

    [InverseProperty("FkAcbalanceAmountArisingDetail")]
    public virtual ICollection<AcbalanceAmountArisingObjectDetail> AcbalanceAmountArisingObjectDetails { get; set; } = new List<AcbalanceAmountArisingObjectDetail>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcbalanceAmountArisingDetails")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcbalanceAmountArisingId")]
    [InverseProperty("AcbalanceAmountArisingDetails")]
    public virtual AcbalanceAmountArising FkAcbalanceAmountArising { get; set; }
}
