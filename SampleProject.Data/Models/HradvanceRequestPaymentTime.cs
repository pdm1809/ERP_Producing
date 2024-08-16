using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAdvanceRequestPaymentTimes")]
public partial class HradvanceRequestPaymentTime
{
    [Key]
    [Column("HRAdvanceRequestPaymentTimeID")]
    public int HradvanceRequestPaymentTimeId { get; set; }

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

    [Column("FK_HRAdvanceRequestItemID")]
    public int? FkHradvanceRequestItemId { get; set; }

    [Column("HRAdvanceRequestPaymentTimeAmount", TypeName = "decimal(18, 0)")]
    public decimal? HradvanceRequestPaymentTimeAmount { get; set; }

    [Column("FK_HRAdvanceRequestID")]
    public int? FkHradvanceRequestId { get; set; }

    [Column("FK_APPaymentVoucherID")]
    public int? FkAppaymentVoucherId { get; set; }

    [Column("HRAdvanceRequestPaymentTimeDesc")]
    [StringLength(200)]
    public string HradvanceRequestPaymentTimeDesc { get; set; }

    [Column("HRAdvanceRequestPaymentTimeTotalAmount", TypeName = "decimal(18, 0)")]
    public decimal? HradvanceRequestPaymentTimeTotalAmount { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_ACBankTransactionID")]
    public int? FkAcbankTransactionId { get; set; }

    [ForeignKey("FkAcbankTransactionId")]
    [InverseProperty("HradvanceRequestPaymentTimes")]
    public virtual AcbankTransaction FkAcbankTransaction { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("HradvanceRequestPaymentTimes")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkAppaymentVoucherId")]
    [InverseProperty("HradvanceRequestPaymentTimes")]
    public virtual AppaymentVoucher FkAppaymentVoucher { get; set; }

    [ForeignKey("FkHradvanceRequestId")]
    [InverseProperty("HradvanceRequestPaymentTimes")]
    public virtual HradvanceRequest FkHradvanceRequest { get; set; }

    [ForeignKey("FkHradvanceRequestItemId")]
    [InverseProperty("HradvanceRequestPaymentTimes")]
    public virtual HradvanceRequestItem FkHradvanceRequestItem { get; set; }
}
