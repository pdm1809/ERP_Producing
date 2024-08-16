using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierPayments")]
[Microsoft.EntityFrameworkCore.Index("ApsupplierPaymentNo", "ApsupplierPaymentDate", "FkBrbranchId", "FkApsupplierId", "ApsupplierPaymentType", Name = "Idx_APSupplierPayments")]
public partial class ApsupplierPayment
{
    [Key]
    [Column("APSupplierPaymentID")]
    public int ApsupplierPaymentId { get; set; }

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

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("APSupplierPaymentNo")]
    [StringLength(50)]
    public string ApsupplierPaymentNo { get; set; }

    [Column("APSupplierPaymentName")]
    [StringLength(100)]
    public string ApsupplierPaymentName { get; set; }

    [Column("APSupplierPaymentDesc")]
    [StringLength(512)]
    public string ApsupplierPaymentDesc { get; set; }

    [Column("APSupplierPaymentDate", TypeName = "datetime")]
    public DateTime? ApsupplierPaymentDate { get; set; }

    [Required]
    [Column("APSupplierPaymentType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierPaymentType { get; set; }

    [Column("APPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentMethodCombo { get; set; }

    [Column("APSupplierPaymentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentExchangeRate { get; set; }

    [Column("APSupplierPaymentTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentTotalAmount { get; set; }

    [Column("APSupplierPaymentExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentExchangeAmount { get; set; }

    [Column("APSupplierPaymentBankAccount")]
    [StringLength(50)]
    public string ApsupplierPaymentBankAccount { get; set; }

    [Column("FK_APAssociatedSupplierID")]
    public int? FkApassociatedSupplierId { get; set; }

    [Column("FK_GEAssCurrencyID")]
    public int? FkGeassCurrencyId { get; set; }

    [Column("APSupplierPaymentAssExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentAssExchangeRate { get; set; }

    [Column("APSupplierPaymentAssExchangeWay")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierPaymentAssExchangeWay { get; set; }

    [Column("APSupplierPaymentAssTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentAssTotalAmount { get; set; }

    [Column("APSupplierPaymentAssPostingExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentAssPostingExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("APSupplierPaymentTransferredDate", TypeName = "datetime")]
    public DateTime? ApsupplierPaymentTransferredDate { get; set; }

    [Column("APSupplierPaymentStatus")]
    [StringLength(50)]
    public string ApsupplierPaymentStatus { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("FK_CSCashFundID")]
    public int FkCscashFundId { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("APAssObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApassObjectType { get; set; }

    [Column("APSupplierPaymentObjectReceiptName")]
    [StringLength(500)]
    public string ApsupplierPaymentObjectReceiptName { get; set; }

    [Column("APSupplierPaymentReceiptAddress")]
    [StringLength(500)]
    public string ApsupplierPaymentReceiptAddress { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_HREmployeeApprovedID")]
    public int? FkHremployeeApprovedId { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("APSupplierPaymentPostedStatus")]
    [StringLength(50)]
    public string ApsupplierPaymentPostedStatus { get; set; }

    [Column("FK_ACLoanReceiptID")]
    public int? FkAcloanReceiptId { get; set; }

    [Column("FK_ACListAccountBankID")]
    public int? FkAclistAccountBankId { get; set; }

    [Column("APSupplierPaymentReceiverBankName")]
    [StringLength(100)]
    public string ApsupplierPaymentReceiverBankName { get; set; }

    [Column("APSupplierPaymentReceiverBankCode")]
    [StringLength(50)]
    public string ApsupplierPaymentReceiverBankCode { get; set; }

    [Column("APSupplierPaymentReceiverAccount")]
    [StringLength(50)]
    public string ApsupplierPaymentReceiverAccount { get; set; }

    [Column("APSupplierPaymentReceiverIDNumber")]
    [StringLength(50)]
    public string ApsupplierPaymentReceiverIdnumber { get; set; }

    [Column("APSupplierPaymentReceiverIDDate", TypeName = "datetime")]
    public DateTime? ApsupplierPaymentReceiverIddate { get; set; }

    [Column("APSupplierPaymentReceiverIDPlace")]
    [StringLength(100)]
    public string ApsupplierPaymentReceiverIdplace { get; set; }

    [Column("APSupplierPaymentBankFeeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentBankFeeAmount { get; set; }

    [Column("APSupplierPaymentBankFeeType")]
    [StringLength(50)]
    public string ApsupplierPaymentBankFeeType { get; set; }

    [Column("APSupplierPaymentProject")]
    [StringLength(100)]
    public string ApsupplierPaymentProject { get; set; }

    [InverseProperty("FkApsupplierPayment")]
    public virtual ICollection<ApclearingDetail> ApclearingDetails { get; set; } = new List<ApclearingDetail>();

    [InverseProperty("FkApsupplierPayment")]
    public virtual ICollection<ApdocumentPayment> ApdocumentPayments { get; set; } = new List<ApdocumentPayment>();

    [InverseProperty("FkApsupplierPayment")]
    public virtual ICollection<AppaymentProposalPayment> AppaymentProposalPayments { get; set; } = new List<AppaymentProposalPayment>();

    [InverseProperty("FkApsupplierPayment")]
    public virtual ICollection<ApsupplierPaymentDetail> ApsupplierPaymentDetails { get; set; } = new List<ApsupplierPaymentDetail>();

    [InverseProperty("FkApsupplierPayment")]
    public virtual ICollection<ApsupplierPaymentDocument> ApsupplierPaymentDocuments { get; set; } = new List<ApsupplierPaymentDocument>();

    [ForeignKey("FkAclistAccountBankId")]
    [InverseProperty("ApsupplierPayments")]
    public virtual AclistAccountBank FkAclistAccountBank { get; set; }

    [ForeignKey("FkAcloanReceiptId")]
    [InverseProperty("ApsupplierPayments")]
    public virtual AcloanReceipt FkAcloanReceipt { get; set; }

    [ForeignKey("FkApassociatedSupplierId")]
    [InverseProperty("ApsupplierPaymentFkApassociatedSuppliers")]
    public virtual Apsupplier FkApassociatedSupplier { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApsupplierPaymentFkApsuppliers")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApsupplierPayments")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscashFundId")]
    [InverseProperty("ApsupplierPayments")]
    public virtual CscashFund FkCscashFund { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("ApsupplierPayments")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGeassCurrencyId")]
    [InverseProperty("ApsupplierPaymentFkGeassCurrencies")]
    public virtual Gecurrency FkGeassCurrency { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApsupplierPaymentFkGecurrencies")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ApsupplierPaymentFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("ApsupplierPaymentFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [ForeignKey("FkHremployeeCompletedId")]
    [InverseProperty("ApsupplierPaymentFkHremployeeCompleteds")]
    public virtual Hremployee FkHremployeeCompleted { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ApsupplierPayments")]
    public virtual Pmproject FkPmproject { get; set; }
}
