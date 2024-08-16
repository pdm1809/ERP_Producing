using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APInvoiceInPackageItemDetails")]
public partial class ApinvoiceInPackageItemDetail
{
    [Key]
    [Column("APInvoiceInPackageItemDetailID")]
    public int ApinvoiceInPackageItemDetailId { get; set; }

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

    [Column("APInvoiceInPackageItemDetailNo")]
    [StringLength(50)]
    public string ApinvoiceInPackageItemDetailNo { get; set; }

    [Column("APInvoiceInPackageItemDetailName")]
    [StringLength(256)]
    public string ApinvoiceInPackageItemDetailName { get; set; }

    [Column("APInvoiceInPackageItemDetailFinalProductNo")]
    [StringLength(50)]
    public string ApinvoiceInPackageItemDetailFinalProductNo { get; set; }

    [Column("APInvoiceInPackageItemDetailFinalProductName")]
    [StringLength(256)]
    public string ApinvoiceInPackageItemDetailFinalProductName { get; set; }

    [Column("APInvoiceInPackageItemDetailFinalProductDesc")]
    [StringLength(512)]
    public string ApinvoiceInPackageItemDetailFinalProductDesc { get; set; }

    [Column("APInvoiceInPackageItemDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInPackageItemDetailQty { get; set; }

    [Column("FK_APInvoiceInPackageItemID")]
    public int? FkApinvoiceInPackageItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductDetailID")]
    public int? FkIcproductDetailId { get; set; }

    [Column("APInvoiceInPackageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInPackageItemQty { get; set; }

    [Column("FK_APPOPackageItemID")]
    public int? FkAppopackageItemId { get; set; }

    [ForeignKey("FkApinvoiceInPackageItemId")]
    [InverseProperty("ApinvoiceInPackageItemDetails")]
    public virtual ApinvoiceInPackageItem FkApinvoiceInPackageItem { get; set; }

    [ForeignKey("FkAppopackageItemId")]
    [InverseProperty("ApinvoiceInPackageItemDetails")]
    public virtual AppopackageItem FkAppopackageItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApinvoiceInPackageItemDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductDetailId")]
    [InverseProperty("ApinvoiceInPackageItemDetails")]
    public virtual IcproductDetail FkIcproductDetail { get; set; }
}
