using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostDDSCs")]
public partial class MmproductionCostIngredientCostDdsc
{
    [Key]
    [Column("MMProductionCostIngredientCostDDSCID")]
    public int MmproductionCostIngredientCostDdscid { get; set; }

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

    [Column("MMProductionCostIngredientCostDDSCReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdscreferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostDDSCReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdscreferenceType { get; set; }

    [Column("MMProductionCostIngredientCostDDSCBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdscbatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDSCOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdscoperationName { get; set; }

    [Column("MMProductionCostIngredientCostDDSCMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdscmeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostDDSCStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdscstockName { get; set; }

    [Column("MMProductionCostIngredientCostDDSCProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdscproductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostDDSCProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdscproductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDSCProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdscproductName { get; set; }

    [Column("MMProductionCostIngredientCostDDSCProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostDdscproductDesc { get; set; }

    [Column("MMProductionCostIngredientCostDDSCProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdscproductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostDDSCProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostDdscproductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostDDSCProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscproductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostDDSCProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscproductQty { get; set; }

    [Column("MMProductionCostIngredientCostDDSCTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdsctotalCost { get; set; }

    [Column("MMProductionCostIngredientCostDDSCBatchComponent")]
    public int? MmproductionCostIngredientCostDdscbatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostDDSCProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscproductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostDDSCWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscwoodFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSCGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscgeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSCDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscdirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSCHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdschardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSCPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscpaintFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSCMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscmaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSCElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscelecFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSCDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscdepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostDDSCOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdscotherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostDdscs")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
