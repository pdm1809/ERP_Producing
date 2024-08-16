using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAdvanceRequests")]
public partial class HradvanceRequest
{
    [Key]
    [Column("HRAdvanceRequestID")]
    public int HradvanceRequestId { get; set; }

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

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Required]
    [Column("HRAdvanceRequestNo")]
    [StringLength(50)]
    public string HradvanceRequestNo { get; set; }

    [Column("HRAdvanceRequestName")]
    [StringLength(100)]
    public string HradvanceRequestName { get; set; }

    [Column("HRAdvanceRequestDesc")]
    [StringLength(512)]
    public string HradvanceRequestDesc { get; set; }

    [Column("HRAdvanceRequestDate", TypeName = "datetime")]
    public DateTime? HradvanceRequestDate { get; set; }

    [Column("HRAdvanceRequestExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRequestExchangeRate { get; set; }

    [Column("HRAdvanceRequestStatus")]
    [StringLength(100)]
    public string HradvanceRequestStatus { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("HRAdvanceRequestTransferredDate", TypeName = "datetime")]
    public DateTime? HradvanceRequestTransferredDate { get; set; }

    [Column("HRAdvanceRequestType")]
    [StringLength(100)]
    public string HradvanceRequestType { get; set; }

    [Column("HRAdvanceRequestTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRequestTotalAmount { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("HradvanceRequests")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HradvanceRequests")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("HradvanceRequests")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HradvanceRequestFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeCompletedId")]
    [InverseProperty("HradvanceRequestFkHremployeeCompleteds")]
    public virtual Hremployee FkHremployeeCompleted { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("HradvanceRequests")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkHradvanceRequest")]
    public virtual ICollection<HradvanceRefundItemRequest> HradvanceRefundItemRequests { get; set; } = new List<HradvanceRefundItemRequest>();

    [InverseProperty("FkHradvanceRequest")]
    public virtual ICollection<HradvanceRequestItem> HradvanceRequestItems { get; set; } = new List<HradvanceRequestItem>();

    [InverseProperty("FkHradvanceRequest")]
    public virtual ICollection<HradvanceRequestPaymentTime> HradvanceRequestPaymentTimes { get; set; } = new List<HradvanceRequestPaymentTime>();
}
