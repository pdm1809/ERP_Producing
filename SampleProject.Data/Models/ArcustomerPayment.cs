using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerPayments")]
[Microsoft.EntityFrameworkCore.Index("ArcustomerPaymentNo", "ArcustomerPaymentDate", "FkBrbranchId", "FkArcustomerId", "ArcustomerPaymentType", Name = "Idx_ARCustomerPayments")]
public partial class ArcustomerPayment
{
    [Key]
    [Column("ARCustomerPaymentID")]
    public int ArcustomerPaymentId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ARCustomerPaymentNo")]
    [StringLength(50)]
    public string ArcustomerPaymentNo { get; set; }

    [Column("ARCustomerPaymentName")]
    [StringLength(100)]
    public string ArcustomerPaymentName { get; set; }

    [Column("ARCustomerPaymentDesc")]
    [StringLength(512)]
    public string ArcustomerPaymentDesc { get; set; }

    [Column("ARCustomerPaymentDate", TypeName = "datetime")]
    public DateTime? ArcustomerPaymentDate { get; set; }

    [Column("ARCustomerPaymentType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerPaymentType { get; set; }

    [Column("ARCustomerPaymentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerPaymentStatus { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ARCustomerPaymentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentExchangeRate { get; set; }

    [Column("ARCustomerPaymentTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal ArcustomerPaymentTotalAmount { get; set; }

    [Column("ARCustomerPaymentExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentExchangeAmount { get; set; }

    [Column("ARCustomerPaymentBankAccount")]
    [StringLength(50)]
    public string ArcustomerPaymentBankAccount { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARCustomerPaymentTransferredDate", TypeName = "datetime")]
    public DateTime? ArcustomerPaymentTransferredDate { get; set; }

    [Required]
    [Column("ARCustomerPaymentSenderName")]
    [StringLength(100)]
    public string ArcustomerPaymentSenderName { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("ARCustomerPaymentPONo")]
    [StringLength(50)]
    public string ArcustomerPaymentPono { get; set; }

    [Column("FK_CSCashFundID")]
    public int? FkCscashFundId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ARSaleOrderSaleAgreement")]
    [StringLength(250)]
    public string ArsaleOrderSaleAgreement { get; set; }

    [Column("ARCustomerPaymentFromType")]
    [StringLength(128)]
    public string ArcustomerPaymentFromType { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("ARCustomerPaymentPostedStatus")]
    [StringLength(50)]
    public string ArcustomerPaymentPostedStatus { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("ARCustomerPaymentProject")]
    [StringLength(100)]
    public string ArcustomerPaymentProject { get; set; }

    [Column("ARCustomerPaymentSaleContract")]
    [StringLength(100)]
    public string ArcustomerPaymentSaleContract { get; set; }

    [InverseProperty("FkArcustomerPayment")]
    public virtual ICollection<ArclearingDetail> ArclearingDetails { get; set; } = new List<ArclearingDetail>();

    [InverseProperty("FkArcustomerPayment")]
    public virtual ICollection<ArcustomerPaymentDetail> ArcustomerPaymentDetails { get; set; } = new List<ArcustomerPaymentDetail>();

    [InverseProperty("FkArcustomerPayment")]
    public virtual ICollection<ArcustomerPaymentDocument> ArcustomerPaymentDocuments { get; set; } = new List<ArcustomerPaymentDocument>();

    [InverseProperty("FkArcustomerPayment")]
    public virtual ICollection<ArcustomerPaymentTimePayment> ArcustomerPaymentTimePayments { get; set; } = new List<ArcustomerPaymentTimePayment>();

    [InverseProperty("FkArcustomerPayment")]
    public virtual ICollection<ArdocumentPayment> ArdocumentPayments { get; set; } = new List<ArdocumentPayment>();

    [InverseProperty("FkArcustomerPayment")]
    public virtual ICollection<ArpospaymentDetail> ArpospaymentDetails { get; set; } = new List<ArpospaymentDetail>();

    [InverseProperty("FkArcustomerPayment")]
    public virtual ICollection<ArproposalPaymentTime> ArproposalPaymentTimes { get; set; } = new List<ArproposalPaymentTime>();

    [InverseProperty("FkArcustomerPayment")]
    public virtual ICollection<ArsaleOrderPaymentTime> ArsaleOrderPaymentTimes { get; set; } = new List<ArsaleOrderPaymentTime>();

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("ArcustomerPayments")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcustomerPayments")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArcustomerPayments")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArcustomerPayments")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscashFundId")]
    [InverseProperty("ArcustomerPayments")]
    public virtual CscashFund FkCscashFund { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("ArcustomerPayments")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArcustomerPayments")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArcustomerPaymentFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeCompletedId")]
    [InverseProperty("ArcustomerPaymentFkHremployeeCompleteds")]
    public virtual Hremployee FkHremployeeCompleted { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArcustomerPayments")]
    public virtual Pmproject FkPmproject { get; set; }
}
