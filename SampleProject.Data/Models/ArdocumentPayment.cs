using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDocumentPayments")]
[Microsoft.EntityFrameworkCore.Index("ArdocumentPaymentDate", Name = "Idx_ARDocumentPayments")]
public partial class ArdocumentPayment
{
    [Key]
    [Column("ARDocumentPaymentID")]
    public int ArdocumentPaymentId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_AROpenDocumentID")]
    public int? FkAropenDocumentId { get; set; }

    [Column("FK_ARCustomerPaymentID")]
    public int FkArcustomerPaymentId { get; set; }

    [Column("ARDocumentPaymentDate", TypeName = "datetime")]
    public DateTime? ArdocumentPaymentDate { get; set; }

    [Column("ARDocumentPaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArdocumentPaymentAmount { get; set; }

    [Column("ARDocumentPaymentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArdocumentPaymentExchangeRate { get; set; }

    [ForeignKey("FkArcustomerPaymentId")]
    [InverseProperty("ArdocumentPayments")]
    public virtual ArcustomerPayment FkArcustomerPayment { get; set; }

    [ForeignKey("FkAropenDocumentId")]
    [InverseProperty("ArdocumentPayments")]
    public virtual AropenDocument FkAropenDocument { get; set; }
}
