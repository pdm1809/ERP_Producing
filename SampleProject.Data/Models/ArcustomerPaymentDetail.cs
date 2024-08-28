using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerPaymentDetails")]
public partial class ArcustomerPaymentDetail
{
    [Key]
    [Column("ARCustomerPaymentDetailID")]
    public int ArcustomerPaymentDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerPaymentID")]
    public int FkArcustomerPaymentId { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ARCustomerPaymentDetailAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailAmount { get; set; }

    [Column("ARCustomerPaymentDetailInfo")]
    [StringLength(1000)]
    public string ArcustomerPaymentDetailInfo { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount1", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount1 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount2", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount2 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount3", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount3 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount4", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount4 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount5", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount5 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount6", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount6 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount7", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount7 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount8", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount8 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount9", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount9 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount10", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount10 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount11", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount11 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount12", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount12 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount13", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount13 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount14", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount14 { get; set; }

    [Column("ARCustomerPaymentDetailSubAmount15", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDetailSubAmount15 { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_CSCashFundID")]
    public int? FkCscashFundId { get; set; }

    [InverseProperty("FkArcustomerPaymentDetail")]
    public virtual ICollection<ArcustomerPaymentCurrency> ArcustomerPaymentCurrencies { get; set; } = new List<ArcustomerPaymentCurrency>();

    [ForeignKey("FkArcustomerPaymentId")]
    [InverseProperty("ArcustomerPaymentDetails")]
    public virtual ArcustomerPayment FkArcustomerPayment { get; set; }

    [ForeignKey("FkCscashFundId")]
    [InverseProperty("ArcustomerPaymentDetails")]
    public virtual CscashFund FkCscashFund { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("ArcustomerPaymentDetails")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }
}
