using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostIngredientCostDDs")]
public partial class MmproductionCostIngredientCostDd
{
    [Key]
    [Column("MMProductionCostIngredientCostDDID")]
    public int MmproductionCostIngredientCostDdid { get; set; }

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

    [Column("MMProductionCostIngredientCostDDReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdreferenceNo { get; set; }

    [Column("MMProductionCostIngredientCostDDReferenceType")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdreferenceType { get; set; }

    [Column("MMProductionCostIngredientCostDDBatchProductNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdbatchProductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDOperationName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdoperationName { get; set; }

    [Column("MMProductionCostIngredientCostDDMeasureUnitName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdmeasureUnitName { get; set; }

    [Column("MMProductionCostIngredientCostDDStockName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdstockName { get; set; }

    [Column("MMProductionCostIngredientCostDDProductGroupName")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdproductGroupName { get; set; }

    [Column("MMProductionCostIngredientCostDDProductNo")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdproductNo { get; set; }

    [Column("MMProductionCostIngredientCostDDProductName")]
    [StringLength(100)]
    public string MmproductionCostIngredientCostDdproductName { get; set; }

    [Column("MMProductionCostIngredientCostDDProductDesc")]
    [StringLength(512)]
    public string MmproductionCostIngredientCostDdproductDesc { get; set; }

    [Column("MMProductionCostIngredientCostDDProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostIngredientCostDdproductSerialNo { get; set; }

    [Column("MMProductionCostIngredientCostDDProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostIngredientCostDdproductAttribute { get; set; }

    [Column("MMProductionCostIngredientCostDDProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdproductUnitCost { get; set; }

    [Column("MMProductionCostIngredientCostDDProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdproductQty { get; set; }

    [Column("MMProductionCostIngredientCostDDTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdtotalCost { get; set; }

    [Column("MMProductionCostIngredientCostDDBatchComponent")]
    public int? MmproductionCostIngredientCostDdbatchComponent { get; set; }

    [Column("MMProductionCostIngredientCostDDProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdproductWoodQty { get; set; }

    [Column("MMProductionCostIngredientCostDDWoodFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdwoodFee { get; set; }

    [Column("MMProductionCostIngredientCostDDGeneralFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdgeneralFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDirectSalaryFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddirectSalaryFee { get; set; }

    [Column("MMProductionCostIngredientCostDDHardwareFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdhardwareFee { get; set; }

    [Column("MMProductionCostIngredientCostDDPaintFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdpaintFee { get; set; }

    [Column("MMProductionCostIngredientCostDDMaintainFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdmaintainFee { get; set; }

    [Column("MMProductionCostIngredientCostDDElecFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdelecFee { get; set; }

    [Column("MMProductionCostIngredientCostDDDepreciationFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDddepreciationFee { get; set; }

    [Column("MMProductionCostIngredientCostDDOtherFee", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostIngredientCostDdotherFee { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductionCostIngredientCostDds")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostIngredientCostDds")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
