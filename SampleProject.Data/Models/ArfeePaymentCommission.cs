using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARFeePaymentCommissions")]
public partial class ArfeePaymentCommission
{
    [Key]
    [Column("ARFeePaymentCommissionID")]
    public int ArfeePaymentCommissionId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ARInvoiceCommissionID")]
    public int FkArinvoiceCommissionId { get; set; }

    [Column("ARFeePaymentCommissionReferenceID")]
    public int? ArfeePaymentCommissionReferenceId { get; set; }

    [Column("ARFeePaymentCommissionReferenceNo")]
    [StringLength(128)]
    public string ArfeePaymentCommissionReferenceNo { get; set; }

    [Column("ARFeePaymentCommissionInvoiceDate", TypeName = "datetime")]
    public DateTime? ArfeePaymentCommissionInvoiceDate { get; set; }

    [Column("ARFeePaymentCommissionInvoiceCustomerName")]
    [StringLength(4000)]
    public string ArfeePaymentCommissionInvoiceCustomerName { get; set; }

    [Column("ARFeePaymentCommissionInvoiceTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArfeePaymentCommissionInvoiceTotalAmount { get; set; }

    [Column("ARFeePaymentCommissionInvoiceTotalProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArfeePaymentCommissionInvoiceTotalProductQty { get; set; }

    [Column("ARInvoiceCommissionType")]
    [StringLength(100)]
    public string ArinvoiceCommissionType { get; set; }

    [Column("ARFeePaymentCommissionValue", TypeName = "decimal(18, 5)")]
    public decimal? ArfeePaymentCommissionValue { get; set; }

    [Column("ARFeePaymentCommissionAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArfeePaymentCommissionAmount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ArfeePaymentCommissions")]
    public virtual Acdocument FkAcdocument { get; set; }
}
