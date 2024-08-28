using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentPackageItemDetails")]
public partial class IcshipmentPackageItemDetail
{
    [Key]
    [Column("ICShipmentPackageItemDetailID")]
    public int IcshipmentPackageItemDetailId { get; set; }

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

    [Column("ICShipmentPackageItemDetailNo")]
    [StringLength(50)]
    public string IcshipmentPackageItemDetailNo { get; set; }

    [Column("ICShipmentPackageItemDetailName")]
    [StringLength(256)]
    public string IcshipmentPackageItemDetailName { get; set; }

    [Column("ICShipmentPackageItemDetailFinalProductNo")]
    [StringLength(50)]
    public string IcshipmentPackageItemDetailFinalProductNo { get; set; }

    [Column("ICShipmentPackageItemDetailFinalProductName")]
    [StringLength(256)]
    public string IcshipmentPackageItemDetailFinalProductName { get; set; }

    [Column("ICShipmentPackageItemDetailFinalProductDesc")]
    [StringLength(512)]
    public string IcshipmentPackageItemDetailFinalProductDesc { get; set; }

    [Column("ICShipmentPackageItemDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageItemDetailQty { get; set; }

    [Column("FK_ICShipmentPackageItemID")]
    public int? FkIcshipmentPackageItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductDetailID")]
    public int? FkIcproductDetailId { get; set; }

    [Column("ICShipmentPackageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageItemQty { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcshipmentPackageItemDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductDetailId")]
    [InverseProperty("IcshipmentPackageItemDetails")]
    public virtual IcproductDetail FkIcproductDetail { get; set; }

    [ForeignKey("FkIcshipmentPackageItemId")]
    [InverseProperty("IcshipmentPackageItemDetails")]
    public virtual IcshipmentPackageItem FkIcshipmentPackageItem { get; set; }
}
