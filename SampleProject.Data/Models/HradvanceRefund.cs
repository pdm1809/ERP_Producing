using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAdvanceRefunds")]
public partial class HradvanceRefund
{
    [Key]
    [Column("HRAdvanceRefundID")]
    public int HradvanceRefundId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("HRAdvanceRefundNo")]
    [StringLength(50)]
    public string HradvanceRefundNo { get; set; }

    [Column("HRAdvanceRefundDesc")]
    [StringLength(512)]
    public string HradvanceRefundDesc { get; set; }

    [Column("HRAdvanceRefundDate", TypeName = "datetime")]
    public DateTime? HradvanceRefundDate { get; set; }

    [Column("HRAdvanceRefundExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRefundExchangeRate { get; set; }

    [Column("HRAdvanceRefundStatus")]
    [StringLength(100)]
    public string HradvanceRefundStatus { get; set; }

    [Column("HRAdvanceRefundType")]
    [StringLength(100)]
    public string HradvanceRefundType { get; set; }

    [Column("HRAdvanceRefundTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRefundTotalAmount { get; set; }

    [Column("HRAdvanceRefundPaymentType")]
    [StringLength(50)]
    public string HradvanceRefundPaymentType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("HRObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrobjectType { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("HRAdvanceRefundPostedStatus")]
    [StringLength(64)]
    public string HradvanceRefundPostedStatus { get; set; }

    [Column("HRAdvanceRefundDueDate", TypeName = "datetime")]
    public DateTime? HradvanceRefundDueDate { get; set; }

    [InverseProperty("FkHradvanceRefund")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkHradvanceRefund")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [InverseProperty("FkHradvanceRefund")]
    public virtual ICollection<ApsupplierPaymentDocument> ApsupplierPaymentDocuments { get; set; } = new List<ApsupplierPaymentDocument>();

    [InverseProperty("FkHradvanceRefund")]
    public virtual ICollection<ArcustomerPaymentDocument> ArcustomerPaymentDocuments { get; set; } = new List<ArcustomerPaymentDocument>();

    [InverseProperty("FkHradvanceRefund")]
    public virtual ICollection<ArreceiptVoucherItem> ArreceiptVoucherItems { get; set; } = new List<ArreceiptVoucherItem>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HradvanceRefunds")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("HradvanceRefunds")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HradvanceRefundFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeCompletedId")]
    [InverseProperty("HradvanceRefundFkHremployeeCompleteds")]
    public virtual Hremployee FkHremployeeCompleted { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("HradvanceRefunds")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkHradvanceRefund")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkHradvanceRefund")]
    public virtual ICollection<HradvanceRefundItemRequest> HradvanceRefundItemRequests { get; set; } = new List<HradvanceRefundItemRequest>();

    [InverseProperty("FkHradvanceRefund")]
    public virtual ICollection<HradvanceRefundTemplate> HradvanceRefundTemplates { get; set; } = new List<HradvanceRefundTemplate>();
}
