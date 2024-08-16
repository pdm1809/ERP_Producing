using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInventoryItemPackages")]
public partial class IcinventoryItemPackage
{
    [Key]
    [Column("ICInventoryItemPackageID")]
    public int IcinventoryItemPackageId { get; set; }

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

    [Column("ICInventoryItemPackageNo")]
    [StringLength(50)]
    public string IcinventoryItemPackageNo { get; set; }

    [Column("ICInventoryItemPackageName")]
    [StringLength(256)]
    public string IcinventoryItemPackageName { get; set; }

    [Column("ICInventoryItemPackageLength", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryItemPackageLength { get; set; }

    [Column("ICInventoryItemPackageWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryItemPackageWidth { get; set; }

    [Column("ICInventoryItemPackageHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryItemPackageHeight { get; set; }

    [Column("ICProductPackageMethodType")]
    [StringLength(256)]
    public string IcproductPackageMethodType { get; set; }

    [Column("ICInventoryItemPackageHasDetail")]
    public bool? IcinventoryItemPackageHasDetail { get; set; }

    [Column("ICInventoryItemPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IcinventoryItemPackageQty { get; set; }

    [Column("ICInventoryItemPackageBarCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcinventoryItemPackageBarCode { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICProductPackageItemID")]
    public int? FkIcproductPackageItemId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcinventoryItemPackages")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductPackageItemId")]
    [InverseProperty("IcinventoryItemPackages")]
    public virtual IcproductPackageItem FkIcproductPackageItem { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcinventoryItemPackages")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcinventoryItemPackages")]
    public virtual Icstock FkIcstock { get; set; }
}
