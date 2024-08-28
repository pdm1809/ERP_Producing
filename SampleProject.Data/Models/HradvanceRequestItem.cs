using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAdvanceRequestItems")]
public partial class HradvanceRequestItem
{
    [Key]
    [Column("HRAdvanceRequestItemID")]
    public int HradvanceRequestItemId { get; set; }

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
    public int FkHremployeeId { get; set; }

    [Column("FK_HRAdvanceRequestID")]
    public int FkHradvanceRequestId { get; set; }

    [Required]
    [Column("HRAdvanceRequestItemEmployeeNo")]
    [StringLength(50)]
    public string HradvanceRequestItemEmployeeNo { get; set; }

    [Column("HRAdvanceRequestItemEmployeeName")]
    [StringLength(100)]
    public string HradvanceRequestItemEmployeeName { get; set; }

    [Column("HRAdvanceRequestItemDesc")]
    [StringLength(512)]
    public string HradvanceRequestItemDesc { get; set; }

    [Column("HRAdvanceRequestItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRequestItemTotalAmount { get; set; }

    [Column("HRAdvanceRequestItemStatus")]
    [StringLength(100)]
    public string HradvanceRequestItemStatus { get; set; }

    [Column("HRAdvanceRequestItemPaymentType")]
    [StringLength(50)]
    public string HradvanceRequestItemPaymentType { get; set; }

    [Column("HRAdvanceRequestItemPaymentStartDate", TypeName = "datetime")]
    public DateTime? HradvanceRequestItemPaymentStartDate { get; set; }

    [Column("HRAdvanceRequestItemPaymentMonthQty", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRequestItemPaymentMonthQty { get; set; }

    [Column("HRAdvanceRequestItemPaymentPerMonthAmount", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRequestItemPaymentPerMonthAmount { get; set; }

    [InverseProperty("FkHradvanceRequestItem")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkHradvanceRequestItem")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [ForeignKey("FkHradvanceRequestId")]
    [InverseProperty("HradvanceRequestItems")]
    public virtual HradvanceRequest FkHradvanceRequest { get; set; }

    [InverseProperty("FkHradvanceRequestItem")]
    public virtual ICollection<HradvanceRefundItemRequest> HradvanceRefundItemRequests { get; set; } = new List<HradvanceRefundItemRequest>();

    [InverseProperty("FkHradvanceRequestItem")]
    public virtual ICollection<HradvanceRequestItemLoanDetail> HradvanceRequestItemLoanDetails { get; set; } = new List<HradvanceRequestItemLoanDetail>();

    [InverseProperty("FkHradvanceRequestItem")]
    public virtual ICollection<HradvanceRequestPaymentTime> HradvanceRequestPaymentTimes { get; set; } = new List<HradvanceRequestPaymentTime>();
}
