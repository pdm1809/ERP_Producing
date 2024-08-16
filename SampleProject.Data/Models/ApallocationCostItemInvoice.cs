using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APAllocationCostItemInvoices")]
public partial class ApallocationCostItemInvoice
{
    [Key]
    [Column("APAllocationCostItemInvoiceID")]
    public int ApallocationCostItemInvoiceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_APAllocationCostID")]
    public int? FkApallocationCostId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("APAllocationCostItemInvoiceProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemInvoiceProductQty { get; set; }

    [Column("APAllocationCostItemInvoiceTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemInvoiceTotalCost { get; set; }

    [Column("APAllocationCostItemInvoiceReceiptedQty", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemInvoiceReceiptedQty { get; set; }

    [Column("APAllocationCostItemInvoiceReceiptedCost", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemInvoiceReceiptedCost { get; set; }

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("APAllocationCostItemInvoiceDocumentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemInvoiceDocumentAmount { get; set; }

    [Column("APAllocationCostItemInvoiceDocumentTotalInvoiceQty", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemInvoiceDocumentTotalInvoiceQty { get; set; }

    [Column("APAllocationCostItemInvoiceDocumentTotalInvoiceCost", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemInvoiceDocumentTotalInvoiceCost { get; set; }

    [Column("APAllocationCostItemInvoiceFeeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemInvoiceFeeAmount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ApallocationCostItemInvoices")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkApallocationCostId")]
    [InverseProperty("ApallocationCostItemInvoices")]
    public virtual ApallocationCost FkApallocationCost { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApallocationCostItemInvoices")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }
}
