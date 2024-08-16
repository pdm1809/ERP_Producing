using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPackagingNormItems")]
public partial class IcpackagingNormItem
{
    [Key]
    [Column("ICPackagingNormItemID")]
    public int IcpackagingNormItemId { get; set; }

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
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICPackagingNormItemNo")]
    [StringLength(50)]
    public string IcpackagingNormItemNo { get; set; }

    [Column("ICPackagingNormItemProductName")]
    [StringLength(512)]
    public string IcpackagingNormItemProductName { get; set; }

    [Column("ICPackagingNormItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemProductQty { get; set; }

    [Column("ICPackagingNormItemProductSizeAndPacking")]
    [StringLength(512)]
    public string IcpackagingNormItemProductSizeAndPacking { get; set; }

    [Column("ICPackagingNormItemTotalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemTotalQuantity { get; set; }

    [Column("ICPackagingNormItemPackagingGW", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemPackagingGw { get; set; }

    [Column("ICPackagingNormItemPackagingNW", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemPackagingNw { get; set; }

    [Column("ICPackagingNormItemComment")]
    [StringLength(512)]
    public string IcpackagingNormItemComment { get; set; }

    [Column("ICPackagingNormItemProductDesc")]
    [StringLength(512)]
    public string IcpackagingNormItemProductDesc { get; set; }

    [Column("ICPackagingNormItemProductOverallDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemProductOverallDimensionHeight { get; set; }

    [Column("ICPackagingNormItemProductOverallDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemProductOverallDimensionWidth { get; set; }

    [Column("ICPackagingNormItemProductOverallDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemProductOverallDimensionLength { get; set; }

    [Column("ICPackagingNormItemProductInsideDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemProductInsideDimensionHeight { get; set; }

    [Column("ICPackagingNormItemProductInsideDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemProductInsideDimensionWidth { get; set; }

    [Column("ICPackagingNormItemProductInsideDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? IcpackagingNormItemProductInsideDimensionLength { get; set; }

    [Column("FK_ICProdAttPackingMaterialSpecialityID")]
    public int? FkIcprodAttPackingMaterialSpecialityId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSizeID")]
    public int? FkIcprodAttPackingMaterialSizeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    public int? FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [Column("FK_ICProductParentID")]
    public int? FkIcproductParentId { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcpackagingNormItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcpackagingNormItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductParentId")]
    [InverseProperty("IcpackagingNormItemFkIcproductParents")]
    public virtual Icproduct FkIcproductParent { get; set; }
}
