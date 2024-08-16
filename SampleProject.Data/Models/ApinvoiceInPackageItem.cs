using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APInvoiceInPackageItems")]
public partial class ApinvoiceInPackageItem
{
    [Key]
    [Column("APInvoiceInPackageItemID")]
    public int ApinvoiceInPackageItemId { get; set; }

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

    [Column("APInvoiceInPackageItemNo")]
    [StringLength(50)]
    public string ApinvoiceInPackageItemNo { get; set; }

    [Column("APInvoiceInPackageItemName")]
    [StringLength(256)]
    public string ApinvoiceInPackageItemName { get; set; }

    [Column("APInvoiceInPackageItemLength", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInPackageItemLength { get; set; }

    [Column("APInvoiceInPackageItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInPackageItemWidth { get; set; }

    [Column("APInvoiceInPackageItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInPackageItemHeight { get; set; }

    [Column("APProductPackageMethodType")]
    [StringLength(256)]
    public string ApproductPackageMethodType { get; set; }

    [Column("APInvoiceInPackageItemHasDetail")]
    public bool? ApinvoiceInPackageItemHasDetail { get; set; }

    [Column("APInvoiceInPackageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInPackageItemQty { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("FK_APPOPackageItemID")]
    public int? FkAppopackageItemId { get; set; }

    [InverseProperty("FkApinvoiceInPackageItem")]
    public virtual ICollection<ApinvoiceInPackageItemDetail> ApinvoiceInPackageItemDetails { get; set; } = new List<ApinvoiceInPackageItemDetail>();

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApinvoiceInPackageItems")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkAppopackageItemId")]
    [InverseProperty("ApinvoiceInPackageItems")]
    public virtual AppopackageItem FkAppopackageItem { get; set; }

    [InverseProperty("FkApinvoiceInPackageItem")]
    public virtual ICollection<IcreceiptPackageItemDetail> IcreceiptPackageItemDetails { get; set; } = new List<IcreceiptPackageItemDetail>();

    [InverseProperty("FkApinvoiceInPackageItem")]
    public virtual ICollection<IcreceiptPackageItem> IcreceiptPackageItems { get; set; } = new List<IcreceiptPackageItem>();
}
