using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptPackageItemDetails")]
public partial class IcreceiptPackageItemDetail
{
    [Key]
    [Column("ICReceiptPackageItemDetailID")]
    public int IcreceiptPackageItemDetailId { get; set; }

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

    [Column("ICReceiptPackageItemDetailNo")]
    [StringLength(50)]
    public string IcreceiptPackageItemDetailNo { get; set; }

    [Column("ICReceiptPackageItemDetailName")]
    [StringLength(256)]
    public string IcreceiptPackageItemDetailName { get; set; }

    [Column("ICReceiptPackageItemDetailFinalProductNo")]
    [StringLength(50)]
    public string IcreceiptPackageItemDetailFinalProductNo { get; set; }

    [Column("ICReceiptPackageItemDetailFinalProductName")]
    [StringLength(256)]
    public string IcreceiptPackageItemDetailFinalProductName { get; set; }

    [Column("ICReceiptPackageItemDetailFinalProductDesc")]
    [StringLength(512)]
    public string IcreceiptPackageItemDetailFinalProductDesc { get; set; }

    [Column("ICReceiptPackageItemDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptPackageItemDetailQty { get; set; }

    [Column("FK_ICReceiptPackageItemID")]
    public int? FkIcreceiptPackageItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductDetailID")]
    public int? FkIcproductDetailId { get; set; }

    [Column("FK_APInvoiceInPackageItemID")]
    public int? FkApinvoiceInPackageItemId { get; set; }

    [Column("ICReceiptPackageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptPackageItemQty { get; set; }

    [Column("FK_APPOPackageItemID")]
    public int? FkAppopackageItemId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [ForeignKey("FkApinvoiceInPackageItemId")]
    [InverseProperty("IcreceiptPackageItemDetails")]
    public virtual ApinvoiceInPackageItem FkApinvoiceInPackageItem { get; set; }

    [ForeignKey("FkAppopackageItemId")]
    [InverseProperty("IcreceiptPackageItemDetails")]
    public virtual AppopackageItem FkAppopackageItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcreceiptPackageItemDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductDetailId")]
    [InverseProperty("IcreceiptPackageItemDetails")]
    public virtual IcproductDetail FkIcproductDetail { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcreceiptPackageItemDetails")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcreceiptPackageItemId")]
    [InverseProperty("IcreceiptPackageItemDetails")]
    public virtual IcreceiptPackageItem FkIcreceiptPackageItem { get; set; }
}
