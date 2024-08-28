using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductPackageItemDetails")]
public partial class IcproductPackageItemDetail
{
    [Key]
    [Column("ICProductPackageItemDetailID")]
    public int IcproductPackageItemDetailId { get; set; }

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

    [Column("ICProductPackageItemDetailNo")]
    [StringLength(50)]
    public string IcproductPackageItemDetailNo { get; set; }

    [Column("ICProductPackageItemDetailName")]
    [StringLength(256)]
    public string IcproductPackageItemDetailName { get; set; }

    [Column("ICProductPackageItemDetailFinalProductNo")]
    [StringLength(50)]
    public string IcproductPackageItemDetailFinalProductNo { get; set; }

    [Column("ICProductPackageItemDetailFinalProductName")]
    [StringLength(256)]
    public string IcproductPackageItemDetailFinalProductName { get; set; }

    [Column("ICProductPackageItemDetailFinalProductDesc")]
    [StringLength(512)]
    public string IcproductPackageItemDetailFinalProductDesc { get; set; }

    [Column("ICProductPackageItemDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageItemDetailQty { get; set; }

    [Column("FK_ICProductPackageItemID")]
    public int? FkIcproductPackageItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductDetailID")]
    public int? FkIcproductDetailId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductPackageItemDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductDetailId")]
    [InverseProperty("IcproductPackageItemDetails")]
    public virtual IcproductDetail FkIcproductDetail { get; set; }

    [ForeignKey("FkIcproductPackageItemId")]
    [InverseProperty("IcproductPackageItemDetails")]
    public virtual IcproductPackageItem FkIcproductPackageItem { get; set; }
}
