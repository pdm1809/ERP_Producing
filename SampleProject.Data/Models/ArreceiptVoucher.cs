using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARReceiptVouchers")]
[Microsoft.EntityFrameworkCore.Index("ArreceiptVoucherNo", "ArreceiptVoucherDate", "FkBrbranchId", "FkAcobjectId", "ArobjectType", "ArreceiptVoucherReference", "ArreceiptVoucherType", Name = "Idx_ARReceiptVouchers")]
public partial class ArreceiptVoucher
{
    [Key]
    [Column("ARReceiptVoucherID")]
    public int ArreceiptVoucherId { get; set; }

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

    [Column("FK_ACObjectID")]
    public int FkAcobjectId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Required]
    [Column("ARReceiptVoucherNo")]
    [StringLength(50)]
    public string ArreceiptVoucherNo { get; set; }

    [Column("ARReceiptVoucherName")]
    [StringLength(100)]
    public string ArreceiptVoucherName { get; set; }

    [Column("ARReceiptVoucherDesc")]
    [StringLength(512)]
    public string ArreceiptVoucherDesc { get; set; }

    [Column("ARReceiptVoucherType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArreceiptVoucherType { get; set; }

    [Column("ARReceiptVoucherDate", TypeName = "datetime")]
    public DateTime? ArreceiptVoucherDate { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ARReceiptVoucherTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArreceiptVoucherTotalAmount { get; set; }

    [Column("ARReceiptVoucherExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArreceiptVoucherExchangeRate { get; set; }

    [Column("ARReceiptVoucherExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArreceiptVoucherExchangeAmount { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("ARReceiptVoucherReference")]
    [StringLength(50)]
    public string ArreceiptVoucherReference { get; set; }

    [Column("ARReceiptVoucherSenderName")]
    [StringLength(100)]
    public string ArreceiptVoucherSenderName { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARReceiptVoucherTransferredDate", TypeName = "datetime")]
    public DateTime? ArreceiptVoucherTransferredDate { get; set; }

    [Column("ARReceiptVoucherBankAccount")]
    [StringLength(50)]
    public string ArreceiptVoucherBankAccount { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("ARReceiptVoucherVoucherNo")]
    [StringLength(50)]
    public string ArreceiptVoucherVoucherNo { get; set; }

    [Column("ARReceiptVoucherFormNo")]
    [StringLength(50)]
    public string ArreceiptVoucherFormNo { get; set; }

    [Column("ARReceiptVoucherSymbol")]
    [StringLength(50)]
    public string ArreceiptVoucherSymbol { get; set; }

    [Column("ARReceiptVoucherObjectTaxNumber")]
    [StringLength(50)]
    public string ArreceiptVoucherObjectTaxNumber { get; set; }

    [Column("AROutputVATDocumentType")]
    [StringLength(1000)]
    public string AroutputVatdocumentType { get; set; }

    [Column("AROutputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string AroutputVatinvoiceNoCombo { get; set; }

    [Column("FK_CSCashFundID")]
    public int? FkCscashFundId { get; set; }

    [Column("ARReceiptVoucherStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArreceiptVoucherStatus { get; set; }

    [Column("ARReceiptVoucherAgreement")]
    [StringLength(50)]
    public string ArreceiptVoucherAgreement { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("PMProjectNo")]
    [StringLength(50)]
    public string PmprojectNo { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("ARReceiptVoucherPurpose")]
    [StringLength(50)]
    public string ArreceiptVoucherPurpose { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("ARReceiptVoucherPostedStatus")]
    [StringLength(50)]
    public string ArreceiptVoucherPostedStatus { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [InverseProperty("FkArreceiptVoucher")]
    public virtual ICollection<ArclearingDetail> ArclearingDetails { get; set; } = new List<ArclearingDetail>();

    [InverseProperty("FkArreceiptVoucher")]
    public virtual ICollection<ArreceiptVoucherItem> ArreceiptVoucherItems { get; set; } = new List<ArreceiptVoucherItem>();

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("ArreceiptVouchers")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArreceiptVouchers")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArreceiptVouchers")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscashFundId")]
    [InverseProperty("ArreceiptVouchers")]
    public virtual CscashFund FkCscashFund { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("ArreceiptVouchers")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArreceiptVouchers")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArreceiptVoucherFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeCompletedId")]
    [InverseProperty("ArreceiptVoucherFkHremployeeCompleteds")]
    public virtual Hremployee FkHremployeeCompleted { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArreceiptVouchers")]
    public virtual Pmproject FkPmproject { get; set; }
}
