using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptPackageItems")]
public partial class IcreceiptPackageItem
{
    [Key]
    [Column("ICReceiptPackageItemID")]
    public int IcreceiptPackageItemId { get; set; }

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

    [Column("ICReceiptPackageItemNo")]
    [StringLength(50)]
    public string IcreceiptPackageItemNo { get; set; }

    [Column("ICReceiptPackageItemName")]
    [StringLength(256)]
    public string IcreceiptPackageItemName { get; set; }

    [Column("ICReceiptPackageItemLength", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptPackageItemLength { get; set; }

    [Column("ICReceiptPackageItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptPackageItemWidth { get; set; }

    [Column("ICReceiptPackageItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptPackageItemHeight { get; set; }

    [Column("ICProductPackageMethodType")]
    [StringLength(256)]
    public string IcproductPackageMethodType { get; set; }

    [Column("ICReceiptPackageItemHasDetail")]
    public bool? IcreceiptPackageItemHasDetail { get; set; }

    [Column("ICReceiptPackageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptPackageItemQty { get; set; }

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_APInvoiceInPackageItemID")]
    public int? FkApinvoiceInPackageItemId { get; set; }

    [Column("FK_APPOPackageItemID")]
    public int? FkAppopackageItemId { get; set; }

    [Column("ICReceiptPackageItemBarCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptPackageItemBarCode { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductPackageItemID")]
    public int? FkIcproductPackageItemId { get; set; }

    [Column("ICReceiptPackageItemProductSerieNo")]
    [StringLength(50)]
    public string IcreceiptPackageItemProductSerieNo { get; set; }

    [ForeignKey("FkApinvoiceInPackageItemId")]
    [InverseProperty("IcreceiptPackageItems")]
    public virtual ApinvoiceInPackageItem FkApinvoiceInPackageItem { get; set; }

    [ForeignKey("FkAppopackageItemId")]
    [InverseProperty("IcreceiptPackageItems")]
    public virtual AppopackageItem FkAppopackageItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcreceiptPackageItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("IcreceiptPackageItems")]
    public virtual Icreceipt FkIcreceipt { get; set; }

    [InverseProperty("FkIcreceiptPackageItem")]
    public virtual ICollection<IcreceiptPackageItemDetail> IcreceiptPackageItemDetails { get; set; } = new List<IcreceiptPackageItemDetail>();
}
