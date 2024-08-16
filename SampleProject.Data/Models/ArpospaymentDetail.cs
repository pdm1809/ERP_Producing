using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARPOSPaymentDetails")]
public partial class ArpospaymentDetail
{
    [Key]
    [Column("ARPOSPaymentDetailID")]
    public int ArpospaymentDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerPaymentID")]
    public int FkArcustomerPaymentId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_CSCashFundID")]
    public int? FkCscashFundId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("ARPOSPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArpospaymentMethodCombo { get; set; }

    [Column("ARPOSPaymentDetailAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailAmount { get; set; }

    [Column("ARPOSPaymentDetailInfo")]
    [StringLength(1000)]
    public string ArpospaymentDetailInfo { get; set; }

    [Column("ARPOSPaymentDetailSubAmount1", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount1 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount2", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount2 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount3", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount3 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount4", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount4 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount5", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount5 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount6", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount6 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount7", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount7 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount8", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount8 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount9", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount9 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount10", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount10 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount11", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount11 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount12", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount12 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount13", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount13 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount14", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount14 { get; set; }

    [Column("ARPOSPaymentDetailSubAmount15", TypeName = "decimal(18, 5)")]
    public decimal? ArpospaymentDetailSubAmount15 { get; set; }

    [Column("ARPOSPaymentDetailDate", TypeName = "datetime")]
    public DateTime? ArpospaymentDetailDate { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("ArpospaymentDetails")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkArcustomerPaymentId")]
    [InverseProperty("ArpospaymentDetails")]
    public virtual ArcustomerPayment FkArcustomerPayment { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArpospaymentDetails")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkCscashFundId")]
    [InverseProperty("ArpospaymentDetails")]
    public virtual CscashFund FkCscashFund { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("ArpospaymentDetails")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }
}
