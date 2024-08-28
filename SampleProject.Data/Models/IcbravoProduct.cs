using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICBravoProducts")]
public partial class IcbravoProduct
{
    [Key]
    [Column("ICBravoProductID")]
    public int IcbravoProductId { get; set; }

    [Column("ICBravoProductNumber")]
    public int? IcbravoProductNumber { get; set; }

    [Column("ICBravoProductWoodType")]
    [StringLength(512)]
    public string IcbravoProductWoodType { get; set; }

    [Column("ICBravoProductStockID")]
    public int? IcbravoProductStockId { get; set; }

    [Column("ICBravoProductBatchProductNo")]
    [StringLength(50)]
    public string IcbravoProductBatchProductNo { get; set; }

    [Column("ICBravoProductProductName")]
    [StringLength(1024)]
    public string IcbravoProductProductName { get; set; }

    [Column("ICBravoProductProductBravoNo")]
    [StringLength(50)]
    public string IcbravoProductProductBravoNo { get; set; }

    [Column("ICBravoProductProductERPNo")]
    [StringLength(50)]
    public string IcbravoProductProductErpno { get; set; }

    [Column("ICBravoProductSemiProductName")]
    [StringLength(1024)]
    public string IcbravoProductSemiProductName { get; set; }

    [Column("ICBravoProductSemiProductBravoNo")]
    [StringLength(50)]
    public string IcbravoProductSemiProductBravoNo { get; set; }

    [Column("ICBravoProductSemiProductERPNo")]
    [StringLength(50)]
    public string IcbravoProductSemiProductErpno { get; set; }

    [Column("ICBravoProductSemiProductOldERPNo")]
    [StringLength(50)]
    public string IcbravoProductSemiProductOldErpno { get; set; }

    [Column("ICBravoProductSemiProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcbravoProductSemiProductHeight { get; set; }

    [Column("ICBravoProductSemiProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcbravoProductSemiProductWidth { get; set; }

    [Column("ICBravoProductSemiProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcbravoProductSemiProductLength { get; set; }

    [Column("ICBravoProductSemiProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcbravoProductSemiProductQty { get; set; }

    [Column("ICBravoProductSemiProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcbravoProductSemiProductUnitCost { get; set; }

    [Column("ICBravoProductSemiProductTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcbravoProductSemiProductTotalCost { get; set; }

    [Column("ICBravoProductSemiProductNewERPNo")]
    [StringLength(50)]
    public string IcbravoProductSemiProductNewErpno { get; set; }

    [Column("ICBravoProductMappingERPNo")]
    [StringLength(50)]
    public string IcbravoProductMappingErpno { get; set; }

    [Column("ICBravoProductHasChecked")]
    public bool? IcbravoProductHasChecked { get; set; }

    [Column("FK_ICNewStockID")]
    public int? FkIcnewStockId { get; set; }

    [Column("FK_OldStockID")]
    public int? FkOldStockId { get; set; }

    [Column("ICBravoProductProductSerieNo")]
    [StringLength(50)]
    public string IcbravoProductProductSerieNo { get; set; }

    [Column("ICBravoProductHasImported")]
    public bool? IcbravoProductHasImported { get; set; }

    [Column("ICBravoProductPart")]
    [StringLength(50)]
    public string IcbravoProductPart { get; set; }

    [Column("ICBravoProductParentID")]
    public int? IcbravoProductParentId { get; set; }

    [Column("ICBravoProductSemiProductUnitCost1", TypeName = "decimal(18, 5)")]
    public decimal? IcbravoProductSemiProductUnitCost1 { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICProductSerieNewNo")]
    [StringLength(50)]
    public string IcproductSerieNewNo { get; set; }
}
