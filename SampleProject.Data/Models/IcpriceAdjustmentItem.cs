using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPriceAdjustmentItems")]
public partial class IcpriceAdjustmentItem
{
    [Key]
    [Column("ICPriceAdjustmentItemID")]
    public int IcpriceAdjustmentItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_ICPriceAdjustmentID")]
    public int? FkIcpriceAdjustmentId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICPriceAdjustmentItemProductType")]
    [StringLength(50)]
    public string IcpriceAdjustmentItemProductType { get; set; }

    [Column("ICPriceAdjustmentItemProductName")]
    [StringLength(50)]
    public string IcpriceAdjustmentItemProductName { get; set; }

    [Column("ICPriceAdjustmentItemProductDesc", TypeName = "ntext")]
    public string IcpriceAdjustmentItemProductDesc { get; set; }

    [Column("ICPriceAdjustmentItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcpriceAdjustmentItemProductUnitCost { get; set; }

    [Column("ICPriceAdjustmentItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcpriceAdjustmentItemProductQty { get; set; }

    [Column("ICPriceAdjustmentItemComment")]
    [StringLength(50)]
    public string IcpriceAdjustmentItemComment { get; set; }

    [Column("ICPriceAdjustmentItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcpriceAdjustmentItemTotalCost { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICInventoryStockID")]
    public int? FkIcinventoryStockId { get; set; }

    [Column("ICPriceAdjustmentItemInventoryCostOld", TypeName = "decimal(18, 5)")]
    public decimal? IcpriceAdjustmentItemInventoryCostOld { get; set; }

    [Column("ICPriceAdjustmentItemInventoryCostNew", TypeName = "decimal(18, 5)")]
    public decimal? IcpriceAdjustmentItemInventoryCostNew { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcpriceAdjustmentItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcinventoryStockId")]
    [InverseProperty("IcpriceAdjustmentItems")]
    public virtual IcinventoryStock FkIcinventoryStock { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcpriceAdjustmentItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcpriceAdjustmentId")]
    [InverseProperty("IcpriceAdjustmentItems")]
    public virtual IcpriceAdjustment FkIcpriceAdjustment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcpriceAdjustmentItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcpriceAdjustmentItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcpriceAdjustmentItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcpriceAdjustmentItems")]
    public virtual Icstock FkIcstock { get; set; }
}
