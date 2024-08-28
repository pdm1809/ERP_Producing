using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACRetailVATItems")]
public partial class AcretailVatitem
{
    [Key]
    [Column("ACRetailVATItemID")]
    public int AcretailVatitemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACRetailVATID")]
    public int? FkAcretailVatid { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARInvoiceItemID")]
    public int? FkArinvoiceItemId { get; set; }

    [Column("ACRetailVATItemSortOrder")]
    public int? AcretailVatitemSortOrder { get; set; }

    [Column("ACRetailVATItemProductNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcretailVatitemProductNo { get; set; }

    [Column("ACRetailVATItemProductName")]
    [StringLength(50)]
    public string AcretailVatitemProductName { get; set; }

    [Column("ACRetailVATItemProductName2")]
    [StringLength(255)]
    public string AcretailVatitemProductName2 { get; set; }

    [Column("ACRetailVATItemProductDesc", TypeName = "ntext")]
    public string AcretailVatitemProductDesc { get; set; }

    [Column("ACRetailVATItemProductNoOfOldSys")]
    [StringLength(100)]
    public string AcretailVatitemProductNoOfOldSys { get; set; }

    [Column("ACRetailVATItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatitemProductUnitPrice { get; set; }

    [Column("ACRetailVATItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatitemProductQty { get; set; }

    [Column("ACRetailVATItemProductDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatitemProductDiscountPercent { get; set; }

    [Column("ACRetailVATItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatitemDiscountAmount { get; set; }

    [Column("ACRetailVATItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatitemProductTaxPercent { get; set; }

    [Column("ACRetailVATItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatitemTaxAmount { get; set; }

    [Column("ACRetailVATItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcretailVatitemTotalAmount { get; set; }

    [Column("ACRetailVATItemComment")]
    [StringLength(50)]
    public string AcretailVatitemComment { get; set; }

    [ForeignKey("FkAcretailVatid")]
    [InverseProperty("AcretailVatitems")]
    public virtual AcretailVat FkAcretailVat { get; set; }

    [ForeignKey("FkArinvoiceItemId")]
    [InverseProperty("AcretailVatitems")]
    public virtual ArinvoiceItem FkArinvoiceItem { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("AcretailVatitems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcretailVatitems")]
    public virtual Icproduct FkIcproduct { get; set; }
}
