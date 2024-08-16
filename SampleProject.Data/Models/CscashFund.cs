using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("CSCashFunds")]
public partial class CscashFund
{
    [Key]
    [Column("CSCashFundID")]
    public int CscashFundId { get; set; }

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

    [Column("FK_ACAcountID")]
    public int? FkAcacountId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("CSCashFundNo")]
    [StringLength(50)]
    public string CscashFundNo { get; set; }

    [Column("CSCashFundName")]
    [StringLength(100)]
    public string CscashFundName { get; set; }

    [InverseProperty("FkCscashFund")]
    public virtual ICollection<AcbankTransaction> AcbankTransactionFkCscashFunds { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkToCscashFund")]
    public virtual ICollection<AcbankTransaction> AcbankTransactionFkToCscashFunds { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkCscashFund")]
    public virtual ICollection<AcmoneyChangeItem> AcmoneyChangeItems { get; set; } = new List<AcmoneyChangeItem>();

    [InverseProperty("FkCscashFund")]
    public virtual ICollection<AppaymentVoucher> AppaymentVouchers { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkCscashFund")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPayments { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkCscashFund")]
    public virtual ICollection<ArcustomerPaymentDetail> ArcustomerPaymentDetails { get; set; } = new List<ArcustomerPaymentDetail>();

    [InverseProperty("FkCscashFund")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPayments { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkCscashFund")]
    public virtual ICollection<ArpospaymentDetail> ArpospaymentDetails { get; set; } = new List<ArpospaymentDetail>();

    [InverseProperty("FkCscashFund")]
    public virtual ICollection<ArreceiptVoucher> ArreceiptVouchers { get; set; } = new List<ArreceiptVoucher>();

    [ForeignKey("FkAcacountId")]
    [InverseProperty("CscashFunds")]
    public virtual Acaccount FkAcacount { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("CscashFunds")]
    public virtual Brbranch FkBrbranch { get; set; }
}
