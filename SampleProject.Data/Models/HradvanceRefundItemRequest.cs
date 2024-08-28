using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAdvanceRefundItemRequests")]
public partial class HradvanceRefundItemRequest
{
    [Key]
    [Column("HRAdvanceRefundItemRequestID")]
    public int HradvanceRefundItemRequestId { get; set; }

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

    [Column("FK_HRAdvanceRefundID")]
    public int FkHradvanceRefundId { get; set; }

    [Column("FK_HRAdvanceRequestID")]
    public int FkHradvanceRequestId { get; set; }

    [Column("FK_HRAdvanceRequestItemID")]
    public int FkHradvanceRequestItemId { get; set; }

    [Column("HRAdvanceRefundItemRequestDesc")]
    [StringLength(512)]
    public string HradvanceRefundItemRequestDesc { get; set; }

    [Column("HRAdvanceRefundItemRequestTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRefundItemRequestTotalAmount { get; set; }

    [Column("HRAdvanceRefundItemRequestStatus")]
    [StringLength(128)]
    public string HradvanceRefundItemRequestStatus { get; set; }

    [Column("ACTransactionReferenceNo")]
    [StringLength(500)]
    public string ActransactionReferenceNo { get; set; }

    [ForeignKey("FkHradvanceRefundId")]
    [InverseProperty("HradvanceRefundItemRequests")]
    public virtual HradvanceRefund FkHradvanceRefund { get; set; }

    [ForeignKey("FkHradvanceRequestId")]
    [InverseProperty("HradvanceRefundItemRequests")]
    public virtual HradvanceRequest FkHradvanceRequest { get; set; }

    [ForeignKey("FkHradvanceRequestItemId")]
    [InverseProperty("HradvanceRefundItemRequests")]
    public virtual HradvanceRequestItem FkHradvanceRequestItem { get; set; }
}
