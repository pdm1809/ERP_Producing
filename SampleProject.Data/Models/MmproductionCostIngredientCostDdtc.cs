using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostDDTCs")]
public partial class MmproductionCostIngredientCostDdtc
{
    [Key]
    [Column("MMProductionCostIngredientCostDDTCID")]
    public int MmproductionCostIngredientCostDdtcid { get; set; }

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

    [Column("MMProductionCostIngredientCostDDTCReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdtcreferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostDDTCReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdtcreferenceType { get; set; }

    [Column("MMProductionCostIngredientCostDDTCBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdtcbatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDTCOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdtcoperationName { get; set; }

    [Column("MMProductionCostIngredientCostDDTCMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdtcmeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostDDTCStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdtcstockName { get; set; }

    [Column("MMProductionCostIngredientCostDDTCProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdtcproductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostDDTCProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdtcproductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDTCProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdtcproductName { get; set; }

    [Column("MMProductionCostIngredientCostDDTCProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostDdtcproductDesc { get; set; }

    [Column("MMProductionCostIngredientCostDDTCProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdtcproductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostDDTCProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostDdtcproductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostDDTCProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcproductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostDDTCProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcproductQty { get; set; }

    [Column("MMProductionCostIngredientCostDDTCTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtctotalCost { get; set; }

    [Column("MMProductionCostIngredientCostDDTCBatchComponent")]
    public int? MmproductionCostIngredientCostDdtcbatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostDDTCProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcproductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostDDTCWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcwoodFee { get; set; }

    [Column("MMProductionCostIngredientCostDDTCGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcgeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostDDTCDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcdirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostDDTCHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtchardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostDDTCPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcpaintFee { get; set; }

    [Column("MMProductionCostIngredientCostDDTCMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcmaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostDDTCElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcelecFee { get; set; }

    [Column("MMProductionCostIngredientCostDDTCDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcdepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostDDTCOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtcotherFee { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostDdtcs")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
