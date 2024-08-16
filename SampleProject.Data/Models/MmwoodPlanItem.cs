using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMWoodPlanItems")]
public partial class MmwoodPlanItem
{
    [Key]
    [Column("MMWoodPlanItemID")]
    public int MmwoodPlanItemId { get; set; }

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

    [Column("FK_MMWoodPlanID")]
    public int? FkMmwoodPlanId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeSpecialityID")]
    public int? FkIcproductAttributeSpecialityId { get; set; }

    [Column("MMWoodPlanItemProductNo")]
    [StringLength(50)]
    public string MmwoodPlanItemProductNo { get; set; }

    [Column("MMWoodPlanItemProductName")]
    [StringLength(512)]
    public string MmwoodPlanItemProductName { get; set; }

    [Column("MMWoodPlanItemProductDesc")]
    [StringLength(512)]
    public string MmwoodPlanItemProductDesc { get; set; }

    [Column("MMWoodPlanItemProductBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemProductBlocks { get; set; }

    [Column("MMWoodPlanItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemProductHeight { get; set; }

    [Column("MMWoodPlanItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemProductWidth { get; set; }

    [Column("MMWoodPlanItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemProductLength { get; set; }

    [Column("MMWoodPlanItemParentOrderName")]
    [StringLength(256)]
    public string MmwoodPlanItemParentOrderName { get; set; }

    [Column("MMWoodPlanItemDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDepreciationRate { get; set; }

    [Column("MMWoodPlanItemActualDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemActualDepreciationRate { get; set; }

    [Column("MMWoodPlanItemParentNo")]
    [StringLength(50)]
    public string MmwoodPlanItemParentNo { get; set; }

    [Column("MMWoodPlanItemParentID")]
    public int? MmwoodPlanItemParentId { get; set; }

    [Column("MMWoodPlanItemNeededTime", TypeName = "datetime")]
    public DateTime? MmwoodPlanItemNeededTime { get; set; }

    [Column("MMWoodPlanItemIsReuse")]
    public bool? MmwoodPlanItemIsReuse { get; set; }

    [Column("MMWoodPlanItemSerialNo")]
    [StringLength(256)]
    public string MmwoodPlanItemSerialNo { get; set; }

    [Column("MMPriority")]
    [StringLength(50)]
    [Unicode(false)]
    public string Mmpriority { get; set; }

    [Column("FK_ICProductWoodIngredientID")]
    public int? FkIcproductWoodIngredientId { get; set; }

    [Column("MMWoodPlanItemAllocationType")]
    [StringLength(50)]
    public string MmwoodPlanItemAllocationType { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMWoodPlanItemComment")]
    [StringLength(512)]
    public string MmwoodPlanItemComment { get; set; }

    [Column("MMWoodPlanItemSpecialityComment")]
    [StringLength(512)]
    public string MmwoodPlanItemSpecialityComment { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmwoodPlanItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmwoodPlanItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmwoodPlanItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmwoodPlanItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeSpecialityId")]
    [InverseProperty("MmwoodPlanItemFkIcproductAttributeSpecialities")]
    public virtual IcproductAttribute FkIcproductAttributeSpeciality { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmwoodPlanItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmwoodPlanItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductWoodIngredientId")]
    [InverseProperty("MmwoodPlanItemFkIcproductWoodIngredients")]
    public virtual Icproduct FkIcproductWoodIngredient { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmwoodPlanItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmwoodPlanItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmwoodPlanItems")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmwoodPlanItems")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [InverseProperty("FkMmwoodPlanItem")]
    public virtual ICollection<MmwoodPlanItemDetail> MmwoodPlanItemDetails { get; set; } = new List<MmwoodPlanItemDetail>();
}
