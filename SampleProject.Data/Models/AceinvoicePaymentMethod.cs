using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEInvoicePaymentMethods")]
public partial class AceinvoicePaymentMethod
{
    [Key]
    [Column("ACEInvoicePaymentMethodID")]
    public int AceinvoicePaymentMethodId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ACEInvoicePaymentMethodNo")]
    [StringLength(100)]
    public string AceinvoicePaymentMethodNo { get; set; }

    [Column("ACEInvoicePaymentMethodName")]
    [StringLength(512)]
    public string AceinvoicePaymentMethodName { get; set; }

    [Column("ACEInvoiceSytemPaymentMethodName")]
    [StringLength(512)]
    public string AceinvoiceSytemPaymentMethodName { get; set; }

    [InverseProperty("FkAceinvoicePaymentMethod")]
    public virtual ICollection<AceinvoiceGeneral> AceinvoiceGenerals { get; set; } = new List<AceinvoiceGeneral>();
}
