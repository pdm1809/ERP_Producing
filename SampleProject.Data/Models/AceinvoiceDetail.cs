using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEInvoiceDetails")]
public partial class AceinvoiceDetail
{
    [Key]
    [Column("ACEInvoiceDetailID")]
    public int AceinvoiceDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    public int? LineNumber { get; set; }

    [StringLength(50)]
    public string ItemCode { get; set; }

    [StringLength(255)]
    public string ItemName { get; set; }

    [StringLength(10)]
    public string UnitCode { get; set; }

    [StringLength(50)]
    public string UnitName { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? UnitPrice { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? ItemTotalAmountWithoutVat { get; set; }

    [Column(TypeName = "decimal(7, 3)")]
    public decimal? VatPercentage { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? VatAmount { get; set; }

    public bool? Promotion { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? AdjustmentVatAmount { get; set; }

    public bool? IsIncreaseItem { get; set; }

    [Column("FK_ACEInvoiceGeneralID")]
    public int? FkAceinvoiceGeneralId { get; set; }

    [Column("ACEInvoiceDetailFunction")]
    [StringLength(256)]
    public string AceinvoiceDetailFunction { get; set; }

    [Column("ACEInvoiceDetailVATCode")]
    [StringLength(50)]
    public string AceinvoiceDetailVatcode { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? DiscountPercent { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? DiscountAmount { get; set; }

    [StringLength(50)]
    public string ProductItemCustomerCode { get; set; }

    public int? OrderIndex { get; set; }

    [Column("ACEInvoiceDetailModuleName")]
    [StringLength(50)]
    public string AceinvoiceDetailModuleName { get; set; }

    [Column("ACEInvoiceDetailReferenceID")]
    public int? AceinvoiceDetailReferenceId { get; set; }

    [Column("ACEInvoiceDetailReferenceNo")]
    [StringLength(50)]
    public string AceinvoiceDetailReferenceNo { get; set; }

    [Column("ACEInvoiceDetailRefItemID")]
    public int? AceinvoiceDetailRefItemId { get; set; }

    [ForeignKey("FkAceinvoiceGeneralId")]
    [InverseProperty("AceinvoiceDetails")]
    public virtual AceinvoiceGeneral FkAceinvoiceGeneral { get; set; }
}
