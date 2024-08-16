using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPOPackageItems")]
public partial class AppopackageItem
{
    [Key]
    [Column("APPOPackageItemID")]
    public int AppopackageItemId { get; set; }

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

    [Column("APPOPackageItemNo")]
    [StringLength(50)]
    public string AppopackageItemNo { get; set; }

    [Column("APPOPackageItemName")]
    [StringLength(256)]
    public string AppopackageItemName { get; set; }

    [Column("APPOPackageItemLength", TypeName = "decimal(18, 5)")]
    public decimal? AppopackageItemLength { get; set; }

    [Column("APPOPackageItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? AppopackageItemWidth { get; set; }

    [Column("APPOPackageItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? AppopackageItemHeight { get; set; }

    [Column("APProductPackageMethodType")]
    [StringLength(256)]
    public string ApproductPackageMethodType { get; set; }

    [Column("APPOPackageItemHasDetail")]
    public bool? AppopackageItemHasDetail { get; set; }

    [Column("APPOPackageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? AppopackageItemQty { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("APPOPackageItemProductNo")]
    [StringLength(128)]
    public string AppopackageItemProductNo { get; set; }

    [InverseProperty("FkAppopackageItem")]
    public virtual ICollection<ApinvoiceInPackageItemDetail> ApinvoiceInPackageItemDetails { get; set; } = new List<ApinvoiceInPackageItemDetail>();

    [InverseProperty("FkAppopackageItem")]
    public virtual ICollection<ApinvoiceInPackageItem> ApinvoiceInPackageItems { get; set; } = new List<ApinvoiceInPackageItem>();

    [InverseProperty("FkAppopackageItem")]
    public virtual ICollection<AppopackageItemDetail> AppopackageItemDetails { get; set; } = new List<AppopackageItemDetail>();

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppopackageItems")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AppopackageItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [InverseProperty("FkAppopackageItem")]
    public virtual ICollection<IcreceiptPackageItemDetail> IcreceiptPackageItemDetails { get; set; } = new List<IcreceiptPackageItemDetail>();

    [InverseProperty("FkAppopackageItem")]
    public virtual ICollection<IcreceiptPackageItem> IcreceiptPackageItems { get; set; } = new List<IcreceiptPackageItem>();
}
