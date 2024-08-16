using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentPackages")]
public partial class IcshipmentPackage
{
    [Key]
    [Column("ICShipmentPackageID")]
    public int IcshipmentPackageId { get; set; }

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

    [Column("ICShipmentPackageNo")]
    [StringLength(50)]
    public string IcshipmentPackageNo { get; set; }

    [Column("ICShipmentPackageName")]
    [StringLength(256)]
    public string IcshipmentPackageName { get; set; }

    [Column("ICShipmentPackageMethodType")]
    [StringLength(256)]
    public string IcshipmentPackageMethodType { get; set; }

    [Column("ICShipmentPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageQty { get; set; }

    [Column("ICShipmentPackageDesc")]
    [StringLength(512)]
    public string IcshipmentPackageDesc { get; set; }

    [Column("ICShipmentPackageStatus")]
    [StringLength(50)]
    public string IcshipmentPackageStatus { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Column("FK_ICProductPackageID")]
    public int? FkIcproductPackageId { get; set; }

    [Column("ICShipmentPackageSerialNo")]
    [StringLength(100)]
    public string IcshipmentPackageSerialNo { get; set; }

    [Column("ICShipmentPackageSupplierSerialNo")]
    [StringLength(100)]
    public string IcshipmentPackageSupplierSerialNo { get; set; }

    [Column("ICShipmentPackageBarcodeNo")]
    [StringLength(100)]
    public string IcshipmentPackageBarcodeNo { get; set; }

    [Column("ICShipmentPackageVolumn", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageVolumn { get; set; }

    [Column("ICShipmentPackageWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageWeight { get; set; }

    [Column("ICShipmentPackageAbstract")]
    [StringLength(256)]
    public string IcshipmentPackageAbstract { get; set; }

    [Column("ICShipmentPackageLength", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageLength { get; set; }

    [Column("ICShipmentPackageWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageWidth { get; set; }

    [Column("ICShipmentPackageHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentPackageHeight { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("IcshipmentPackages")]
    public virtual Icshipment FkIcshipment { get; set; }
}
