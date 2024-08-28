using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderPaymentTimes")]
public partial class ArsaleOrderPaymentTime
{
    [Key]
    [Column("ARSaleOrderPaymentTimeID")]
    public int ArsaleOrderPaymentTimeId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Required]
    [Column("ARSaleOrderPaymentTimeName")]
    [StringLength(100)]
    public string ArsaleOrderPaymentTimeName { get; set; }

    [Column("ARSaleOrderPaymentTimeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentTimeAmount { get; set; }

    [Column("ARSaleOrderPaymentTimeDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderPaymentTimeDate { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ARSaleOrderPaymentTimeRemark")]
    [StringLength(512)]
    public string ArsaleOrderPaymentTimeRemark { get; set; }

    [Column("ARSaleOrderPaymentTimeStatus")]
    [StringLength(50)]
    public string ArsaleOrderPaymentTimeStatus { get; set; }

    [Column("FK_GEPaymentTermID")]
    public int? FkGepaymentTermId { get; set; }

    [Column("ARSaleOrderPaymentTimeDueDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderPaymentTimeDueDate { get; set; }

    [Column("ARSaleOrderPaymentTimeDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentTimeDepositBalance { get; set; }

    [Column("ARSaleOrderPaymentTimeBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentTimeBalanceDue { get; set; }

    [Column("ARSaleOrderPaymentTimePaymentType")]
    [StringLength(50)]
    public string ArsaleOrderPaymentTimePaymentType { get; set; }

    [Column("ARSaleOrderPaymentTimePaymentTimepoint")]
    [StringLength(100)]
    public string ArsaleOrderPaymentTimePaymentTimepoint { get; set; }

    [Column("ARSaleOrderPaymentTimePaymentTermItemDay")]
    public int? ArsaleOrderPaymentTimePaymentTermItemDay { get; set; }

    [Column("ARSaleOrderPaymentTimePaymentTermItemPercentPayment", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentTimePaymentTermItemPercentPayment { get; set; }

    [Column("ARSaleOrderPaymentTimePaymentTermItemPaymentType")]
    [StringLength(50)]
    public string ArsaleOrderPaymentTimePaymentTermItemPaymentType { get; set; }

    [Column("ARSaleOrderPaymentTimePaymentTermItemType")]
    [StringLength(50)]
    public string ArsaleOrderPaymentTimePaymentTermItemType { get; set; }

    [Column("FK_ARCustomerPaymentID")]
    public int? FkArcustomerPaymentId { get; set; }

    [Column("ARSaleOrderPaymentTimeDepositBalanceFromCustomerPayment", TypeName = "decimal(18, 0)")]
    public decimal? ArsaleOrderPaymentTimeDepositBalanceFromCustomerPayment { get; set; }

    [Column("ARSaleOrderPaymentTimeDepositBalanceFromExtraCustomerPayment", TypeName = "decimal(18, 0)")]
    public decimal? ArsaleOrderPaymentTimeDepositBalanceFromExtraCustomerPayment { get; set; }

    [Column("FK_ARExtraCustomerPaymentID")]
    public int? FkArextraCustomerPaymentId { get; set; }

    [Column("FK_GEPaymentTermItemID")]
    public int? FkGepaymentTermItemId { get; set; }

    [Column("ARSaleOrderPaymentTimeGuaranteeName")]
    [StringLength(256)]
    public string ArsaleOrderPaymentTimeGuaranteeName { get; set; }

    [Column("ARSaleOrderPaymentTimeGuaranteeFromDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderPaymentTimeGuaranteeFromDate { get; set; }

    [Column("ARSaleOrderPaymentTimeGuaranteeToDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderPaymentTimeGuaranteeToDate { get; set; }

    [Column("ARSaleOrderPaymentTimeGuaranteeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentTimeGuaranteeAmount { get; set; }

    [Column("ARSaleOrderPaymentTimeCanceledAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentTimeCanceledAmount { get; set; }

    [Column("ARSaleOrderPaymentTimeClearingAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaymentTimeClearingAmount { get; set; }

    [InverseProperty("FkArsaleOrderPaymentTime")]
    public virtual ICollection<ArclearingDetail> ArclearingDetails { get; set; } = new List<ArclearingDetail>();

    [InverseProperty("FkArsaleOrderPaymentTime")]
    public virtual ICollection<ArpaymentProposalItem> ArpaymentProposalItems { get; set; } = new List<ArpaymentProposalItem>();

    [InverseProperty("FkArsaleOrderPaymentTime")]
    public virtual ICollection<ArsaleOrderPaymentTimeTemplate> ArsaleOrderPaymentTimeTemplates { get; set; } = new List<ArsaleOrderPaymentTimeTemplate>();

    [InverseProperty("FkArsaleOrderPaymentTime")]
    public virtual ICollection<ArsopaymentTimeInvoiceDetail> ArsopaymentTimeInvoiceDetails { get; set; } = new List<ArsopaymentTimeInvoiceDetail>();

    [ForeignKey("FkArcustomerPaymentId")]
    [InverseProperty("ArsaleOrderPaymentTimes")]
    public virtual ArcustomerPayment FkArcustomerPayment { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderPaymentTimes")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("ArsaleOrderPaymentTimes")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }

    [ForeignKey("FkGepaymentTermItemId")]
    [InverseProperty("ArsaleOrderPaymentTimes")]
    public virtual GepaymentTermItem FkGepaymentTermItem { get; set; }
}
