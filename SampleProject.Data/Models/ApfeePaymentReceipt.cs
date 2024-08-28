using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APFeePaymentReceipts")]
public partial class ApfeePaymentReceipt
{
    [Key]
    [Column("APFeePaymentReceiptID")]
    public int ApfeePaymentReceiptId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ICReceiptID")]
    public int FkIcreceiptId { get; set; }

    [Column("APFeePaymentReceiptAllocationCost", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentReceiptAllocationCost { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ApfeePaymentReceipts")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("ApfeePaymentReceipts")]
    public virtual Icreceipt FkIcreceipt { get; set; }
}
