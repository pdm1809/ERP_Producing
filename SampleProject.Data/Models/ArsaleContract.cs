using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleContracts")]
public partial class ArsaleContract
{
    [Key]
    [Column("ARSaleContractID")]
    public int ArsaleContractId { get; set; }

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

    [Required]
    [Column("ARSaleContractNo")]
    [StringLength(50)]
    public string ArsaleContractNo { get; set; }

    [Column("ARSaleContractName")]
    [StringLength(256)]
    public string ArsaleContractName { get; set; }

    [Column("ARSaleContractType")]
    [StringLength(256)]
    public string ArsaleContractType { get; set; }

    [Column("FK_ARSaleContractGroupID")]
    public int? FkArsaleContractGroupId { get; set; }

    [Column("ARSaleContractDate", TypeName = "datetime")]
    public DateTime? ArsaleContractDate { get; set; }

    [Column("ARSaleContractValidDate", TypeName = "datetime")]
    public DateTime? ArsaleContractValidDate { get; set; }

    [Column("ARSaleContractInvalidDate", TypeName = "datetime")]
    public DateTime? ArsaleContractInvalidDate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("ARObjectName")]
    [StringLength(50)]
    public string ArobjectName { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ARSaleContractSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleContractSubTotalAmount { get; set; }

    [Column("ARSaleContractDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleContractDiscountPercent { get; set; }

    [Column("ARSaleContractDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleContractDiscountAmount { get; set; }

    [Column("ARSaleContractTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleContractTotalAmount { get; set; }

    [Column("ARSaleContractGuaranteePercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleContractGuaranteePercent { get; set; }

    [Column("ARSaleContractGuaranteeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleContractGuaranteeAmount { get; set; }

    [Column("ARSaleContractAnswerablePercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleContractAnswerablePercent { get; set; }

    [Column("ARSaleContractAnswerableAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleContractAnswerableAmount { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ARProposalID")]
    public int? FkArproposalId { get; set; }

    [Column("ARSaleContractNotedContent")]
    [StringLength(512)]
    public string ArsaleContractNotedContent { get; set; }

    [Column("ARSaleContractStatus")]
    [StringLength(50)]
    public string ArsaleContractStatus { get; set; }

    [Column("ARSaleContractParentID")]
    public int? ArsaleContractParentId { get; set; }

    [Column("ACObjectAccessKey")]
    [StringLength(50)]
    public string AcobjectAccessKey { get; set; }

    [Column("ARSaleContractAnswerablePeriod", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleContractAnswerablePeriod { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARSaleContractKHNos")]
    [StringLength(256)]
    public string ArsaleContractKhnos { get; set; }

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<AcbankTransaction> AcbankTransactions { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<Aracceptance> Aracceptances { get; set; } = new List<Aracceptance>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArcancelVoucher> ArcancelVouchers { get; set; } = new List<ArcancelVoucher>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArcanceledDeliveryPlan> ArcanceledDeliveryPlans { get; set; } = new List<ArcanceledDeliveryPlan>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArcustomerPaymentTimePayment> ArcustomerPaymentTimePayments { get; set; } = new List<ArcustomerPaymentTimePayment>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPayments { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArdeliveryPlan> ArdeliveryPlans { get; set; } = new List<ArdeliveryPlan>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArinvoiceTransaction> ArinvoiceTransactions { get; set; } = new List<ArinvoiceTransaction>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArpaymentProposalItem> ArpaymentProposalItems { get; set; } = new List<ArpaymentProposalItem>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArreceiptVoucher> ArreceiptVouchers { get; set; } = new List<ArreceiptVoucher>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArsaleContractTemplate> ArsaleContractTemplates { get; set; } = new List<ArsaleContractTemplate>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<ArsaleReturn> ArsaleReturns { get; set; } = new List<ArsaleReturn>();

    [ForeignKey("FkArproposalId")]
    [InverseProperty("ArsaleContracts")]
    public virtual Arproposal FkArproposal { get; set; }

    [ForeignKey("FkArsaleContractGroupId")]
    [InverseProperty("ArsaleContracts")]
    public virtual ArsaleContractGroup FkArsaleContractGroup { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArsaleContracts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArsaleContracts")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArsaleContracts")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArsaleContracts")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkArsaleContract")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();
}
