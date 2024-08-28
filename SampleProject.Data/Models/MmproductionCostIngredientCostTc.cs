using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostTCs")]
public partial class MmproductionCostIngredientCostTc
{
    [Key]
    [Column("MMProductionCostIngredientCostTCID")]
    public int MmproductionCostIngredientCostTcid { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_MMProductionCostID")]
    public int FkMmproductionCostId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductIDForBatch")]
    public int? FkIcproductIdforBatch { get; set; }

    [Column("MMProductionCostIngredientCostTCReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostTcreferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostTCReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostTcreferenceType { get; set; }

    [Column("MMProductionCostIngredientCostTCBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostTcbatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostTCOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostTcoperationName { get; set; }

    [Column("MMProductionCostIngredientCostTCMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostTcmeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostTCStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostTcstockName { get; set; }

    [Column("MMProductionCostIngredientCostTCProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostTcproductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostTCProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostTcproductNo { get; set; }

    [Column("MMProductionCostIngredientCostTCProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostTcproductName { get; set; }

    [Column("MMProductionCostIngredientCostTCProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostTcproductDesc { get; set; }

    [Column("MMProductionCostIngredientCostTCProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostTcproductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostTCProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostTcproductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostTCProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcproductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostTCProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcproductQty { get; set; }

    [Column("MMProductionCostIngredientCostTCTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTctotalCost { get; set; }

    [Column("MMProductionCostIngredientCostTCBatchComponent")]
    public int? MmproductionCostIngredientCostTcbatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostTCProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcproductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostTCWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcwoodFee { get; set; }

    [Column("MMProductionCostIngredientCostTCGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcgeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostTCDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcdirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostTCHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTchardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostTCPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcpaintFee { get; set; }

    [Column("MMProductionCostIngredientCostTCMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcmaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostTCElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcelecFee { get; set; }

    [Column("MMProductionCostIngredientCostTCDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcdepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostTCOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostTcotherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostTcs")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
