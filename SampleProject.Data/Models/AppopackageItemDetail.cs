using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPOPackageItemDetails")]
public partial class AppopackageItemDetail
{
    [Key]
    [Column("APPOPackageItemDetailID")]
    public int AppopackageItemDetailId { get; set; }

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

    [Column("APPOPackageItemDetailNo")]
    [StringLength(50)]
    public string AppopackageItemDetailNo { get; set; }

    [Column("APPOPackageItemDetailName")]
    [StringLength(256)]
    public string AppopackageItemDetailName { get; set; }

    [Column("APPOPackageItemDetailFinalProductNo")]
    [StringLength(50)]
    public string AppopackageItemDetailFinalProductNo { get; set; }

    [Column("APPOPackageItemDetailFinalProductName")]
    [StringLength(256)]
    public string AppopackageItemDetailFinalProductName { get; set; }

    [Column("APPOPackageItemDetailFinalProductDesc")]
    [StringLength(512)]
    public string AppopackageItemDetailFinalProductDesc { get; set; }

    [Column("APPOPackageItemDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? AppopackageItemDetailQty { get; set; }

    [Column("FK_APPOPackageItemID")]
    public int? FkAppopackageItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductDetailID")]
    public int? FkIcproductDetailId { get; set; }

    [Column("APPOPackageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? AppopackageItemQty { get; set; }

    [ForeignKey("FkAppopackageItemId")]
    [InverseProperty("AppopackageItemDetails")]
    public virtual AppopackageItem FkAppopackageItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AppopackageItemDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductDetailId")]
    [InverseProperty("AppopackageItemDetails")]
    public virtual IcproductDetail FkIcproductDetail { get; set; }
}
