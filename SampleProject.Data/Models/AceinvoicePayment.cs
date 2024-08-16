using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEInvoicePayments")]
public partial class AceinvoicePayment
{
    [Key]
    [Column("ACEInvoicePaymentID")]
    public int AceinvoicePaymentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [StringLength(50)]
    public string PaymentMethodName { get; set; }

    [StringLength(255)]
    public string PaymentNote { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? PaymentAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDueDate { get; set; }

    [StringLength(255)]
    public string PaymentTerm { get; set; }

    [StringLength(100)]
    public string BankName { get; set; }

    [StringLength(20)]
    public string BankAccountName { get; set; }

    [Column("FK_ACEInvoiceGeneralID")]
    public int? FkAceinvoiceGeneralId { get; set; }

    [ForeignKey("FkAceinvoiceGeneralId")]
    [InverseProperty("AceinvoicePayments")]
    public virtual AceinvoiceGeneral FkAceinvoiceGeneral { get; set; }
}
