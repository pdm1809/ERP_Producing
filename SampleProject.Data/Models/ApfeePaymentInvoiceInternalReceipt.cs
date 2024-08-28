using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APFeePaymentInvoiceInternalReceipts")]
public partial class ApfeePaymentInvoiceInternalReceipt
{
    [Key]
    [Column("APFeePaymentInvoiceInternalReceiptID")]
    public int ApfeePaymentInvoiceInternalReceiptId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ICInvoiceInternalReceiptID")]
    public int FkIcinvoiceInternalReceiptId { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ApfeePaymentInvoiceInternalReceipts")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkIcinvoiceInternalReceiptId")]
    [InverseProperty("ApfeePaymentInvoiceInternalReceipts")]
    public virtual Icreceipt FkIcinvoiceInternalReceipt { get; set; }
}
