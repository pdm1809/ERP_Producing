using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APFeePaymentInvoices")]
public partial class ApfeePaymentInvoice
{
    [Key]
    [Column("APFeePaymentInvoiceID")]
    public int ApfeePaymentInvoiceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int FkArinvoiceId { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ApfeePaymentInvoices")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ApfeePaymentInvoices")]
    public virtual Arinvoice FkArinvoice { get; set; }
}
