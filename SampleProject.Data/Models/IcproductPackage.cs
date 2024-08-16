using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductPackages")]
public partial class IcproductPackage
{
    [Key]
    [Column("ICProductPackageID")]
    public int IcproductPackageId { get; set; }

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

    [Column("ICProductPackageNo")]
    [StringLength(50)]
    public string IcproductPackageNo { get; set; }

    [Column("ICProductPackageName")]
    [StringLength(256)]
    public string IcproductPackageName { get; set; }

    [Column("ICProductPackageMethodType")]
    [StringLength(256)]
    public string IcproductPackageMethodType { get; set; }

    [Column("ICProductPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageQty { get; set; }

    [Column("ICProductPackageDesc")]
    [StringLength(512)]
    public string IcproductPackageDesc { get; set; }

    [Column("ICProductPackageStatus")]
    [StringLength(50)]
    public string IcproductPackageStatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductPackageProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageProductQty { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Column("ICProductPackageSerialNo")]
    [StringLength(100)]
    public string IcproductPackageSerialNo { get; set; }

    [Column("ICProductPackageSupplierSerialNo")]
    [StringLength(100)]
    public string IcproductPackageSupplierSerialNo { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("ICProductPackageBarcodeNo")]
    [StringLength(100)]
    public string IcproductPackageBarcodeNo { get; set; }

    [Column("ICProductPackageVolumn", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageVolumn { get; set; }

    [Column("ICProductPackageAbstract")]
    [StringLength(256)]
    public string IcproductPackageAbstract { get; set; }

    [Column("ICProductPackageLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageLength { get; set; }

    [Column("ICProductPackageWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageWidth { get; set; }

    [Column("ICProductPackageHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageHeight { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductPackages")]
    public virtual Icproduct FkIcproduct { get; set; }

    [InverseProperty("FkIcproductPackage")]
    public virtual ICollection<IcproductPackageItem> IcproductPackageItems { get; set; } = new List<IcproductPackageItem>();
}
