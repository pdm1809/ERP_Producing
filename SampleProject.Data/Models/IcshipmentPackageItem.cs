using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentPackageItems")]
public partial class IcshipmentPackageItem
{
    [Key]
    [Column("ICShipmentPackageItemID")]
    public int IcshipmentPackageItemId { get; set; }

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

    [Column("ICShipmentPackageItemNo")]
    [StringLength(50)]
    public string IcshipmentPackageItemNo { get; set; }

    [Column("ICShipmentPackageItemName")]
    [StringLength(256)]
    public string IcshipmentPackageItemName { get; set; }

    [Column("ICShipmentPackageItemLength", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageItemLength { get; set; }

    [Column("ICShipmentPackageItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageItemWidth { get; set; }

    [Column("ICShipmentPackageItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageItemHeight { get; set; }

    [Column("ICProductPackageMethodType")]
    [StringLength(256)]
    public string IcproductPackageMethodType { get; set; }

    [Column("ICShipmentPackageItemHasDetail")]
    public bool? IcshipmentPackageItemHasDetail { get; set; }

    [Column("ICShipmentPackageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageItemQty { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("IcshipmentPackageItems")]
    public virtual Icshipment FkIcshipment { get; set; }

    [InverseProperty("FkIcshipmentPackageItem")]
    public virtual ICollection<IcshipmentPackageItemDetail> IcshipmentPackageItemDetails { get; set; } = new List<IcshipmentPackageItemDetail>();
}
