using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEInvoiceTaxLevelAndAmounts")]
public partial class AceinvoiceTaxLevelAndAmount
{
    [Key]
    [Column("ACEInvoiceTaxLevelAndAmountID")]
    public int AceinvoiceTaxLevelAndAmountId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column(TypeName = "decimal(7, 3)")]
    public decimal? VatPercentage { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? VatTaxableAmount { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? VatTaxAmount { get; set; }

    public bool? IsVatTaxableAmountPos { get; set; }

    public bool? IsVatTaxAmountPos { get; set; }

    [StringLength(255)]
    public string VatExemptionReason { get; set; }

    [Column("FK_ACEInvoiceGeneralID")]
    public int? FkAceinvoiceGeneralId { get; set; }

    [ForeignKey("FkAceinvoiceGeneralId")]
    [InverseProperty("AceinvoiceTaxLevelAndAmounts")]
    public virtual AceinvoiceGeneral FkAceinvoiceGeneral { get; set; }
}
