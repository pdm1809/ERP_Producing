using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APFeePaymentInvoiceIns")]
public partial class ApfeePaymentInvoiceIn
{
    [Key]
    [Column("APFeePaymentInvoiceInID")]
    public int ApfeePaymentInvoiceInId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int FkApinvoiceInId { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ApfeePaymentInvoiceIns")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApfeePaymentInvoiceIns")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }
}
