using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ICProductPackageItemBackups")]
public partial class IcproductPackageItemBackup
{
    [Column("ICProductPackageItemID")]
    public int IcproductPackageItemId { get; set; }

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

    [Column("ICProductPackageItemNo")]
    [StringLength(50)]
    public string IcproductPackageItemNo { get; set; }

    [Column("ICProductPackageItemName")]
    [StringLength(256)]
    public string IcproductPackageItemName { get; set; }

    [Column("ICProductPackageItemLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageItemLength { get; set; }

    [Column("ICProductPackageItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageItemWidth { get; set; }

    [Column("ICProductPackageItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageItemHeight { get; set; }

    [Column("ICProductPackageItemHasDetail")]
    public bool? IcproductPackageItemHasDetail { get; set; }

    [Column("ICProductPackageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageItemQty { get; set; }

    [Column("FK_ICProductPackageID")]
    public int FkIcproductPackageId { get; set; }

    [Column("ICProductPackageMethodType")]
    [StringLength(256)]
    public string IcproductPackageMethodType { get; set; }
}
