using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APDocumentPayments")]
[Microsoft.EntityFrameworkCore.Index("ApdocumentPaymentDate", Name = "Idx_APDocumentPayments")]
public partial class ApdocumentPayment
{
    [Key]
    [Column("APDocumentPaymentID")]
    public int ApdocumentPaymentId { get; set; }

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

    [Column("APDocumentPaymentDate", TypeName = "datetime")]
    public DateTime? ApdocumentPaymentDate { get; set; }

    [Column("FK_APOpenDocumentID")]
    public int FkApopenDocumentId { get; set; }

    [Column("FK_APSupplierPaymentID")]
    public int FkApsupplierPaymentId { get; set; }

    [Column("APDocumentPaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApdocumentPaymentAmount { get; set; }

    [ForeignKey("FkApopenDocumentId")]
    [InverseProperty("ApdocumentPayments")]
    public virtual ApopenDocument FkApopenDocument { get; set; }

    [ForeignKey("FkApsupplierPaymentId")]
    [InverseProperty("ApdocumentPayments")]
    public virtual ApsupplierPayment FkApsupplierPayment { get; set; }
}
