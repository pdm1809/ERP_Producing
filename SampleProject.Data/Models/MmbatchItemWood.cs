using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchItemWoods")]
public partial class MmbatchItemWood
{
    [Key]
    [Column("MMBatchItemWoodID")]
    public int MmbatchItemWoodId { get; set; }

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

    [Column("FK_MMBatchItemPlanID")]
    public int? FkMmbatchItemPlanId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("MMBatchItemWoodNo")]
    [StringLength(50)]
    public string MmbatchItemWoodNo { get; set; }

    [Column("MMBatchItemWoodBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodBlocks { get; set; }

    [Column("MMBatchItemWoodMDFBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodMdfblocks { get; set; }

    [Column("MMBatchItemWoodVeneer", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodVeneer { get; set; }

    [Column("MMBatchItemWoodPlywood", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodPlywood { get; set; }

    [Column("MMBatchItemWoodPaintA", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodPaintA { get; set; }

    [Column("MMBatchItemWoodPaintB", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodPaintB { get; set; }

    [Column("MMBatchItemWoodQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodQuantity { get; set; }

    [Column("MMBatchItemWoodAllocationTotalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodAllocationTotalQuantity { get; set; }

    [Column("MMBatchItemWoodBuyTotalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodBuyTotalQuantity { get; set; }

    [Column("MMBatchItemWoodICProductName")]
    [StringLength(512)]
    public string MmbatchItemWoodIcproductName { get; set; }

    [Column("MMBatchItemWoodICProductSupplierName")]
    [StringLength(50)]
    public string MmbatchItemWoodIcproductSupplierName { get; set; }

    [Column("MMBatchItemWoodICProductSupplierNumber")]
    [StringLength(50)]
    public string MmbatchItemWoodIcproductSupplierNumber { get; set; }

    [Column("MMBatchItemWoodICProductAttribute")]
    [StringLength(50)]
    public string MmbatchItemWoodIcproductAttribute { get; set; }

    [Column("MMBatchItemWoodICProductLong", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodIcproductLong { get; set; }

    [Column("MMBatchItemWoodICProductThick", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodIcproductThick { get; set; }

    [Column("MMBatchItemWoodICProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodIcproductWidth { get; set; }

    [Column("MMBatchItemWoodICProductWoodType")]
    [StringLength(50)]
    public string MmbatchItemWoodIcproductWoodType { get; set; }

    [Column("MMBatchItemWoodParentOrderName")]
    [StringLength(256)]
    public string MmbatchItemWoodParentOrderName { get; set; }

    [Column("MMBatchItemWoodDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodDepreciationRate { get; set; }

    [Column("MMBatchItemWoodActualDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodActualDepreciationRate { get; set; }

    [Column("MMBatchItemWoodDesc")]
    [StringLength(512)]
    public string MmbatchItemWoodDesc { get; set; }

    [Column("MMBatchItemWoodParentNo")]
    [StringLength(50)]
    public string MmbatchItemWoodParentNo { get; set; }

    [Column("MMBatchItemWoodParentID")]
    public int? MmbatchItemWoodParentId { get; set; }

    [Column("MMBatchItemWoodSortOrder")]
    public int? MmbatchItemWoodSortOrder { get; set; }

    [Column("MMBatchItemWoodIsComponent")]
    public bool? MmbatchItemWoodIsComponent { get; set; }

    [Column("MMBatchItemWoodNeededTime", TypeName = "datetime")]
    public DateTime? MmbatchItemWoodNeededTime { get; set; }

    [Column("MMBatchItemWoodGroup")]
    [StringLength(50)]
    public string MmbatchItemWoodGroup { get; set; }

    [Column("MMBatchItemWoodUnit")]
    [StringLength(50)]
    public string MmbatchItemWoodUnit { get; set; }

    [Column("MMBatchItemWoodVeneerKey")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmbatchItemWoodVeneerKey { get; set; }

    [Column("MMBatchItemWoodPaintAKey")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmbatchItemWoodPaintAkey { get; set; }

    [Column("MMBatchItemWoodPaintBKey")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmbatchItemWoodPaintBkey { get; set; }

    [Column("MMBatchItemWoodPriority")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmbatchItemWoodPriority { get; set; }

    [Column("MMBatchItemWoodEditProductThick", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodEditProductThick { get; set; }

    [Column("MMBatchItemWoodEditProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodEditProductWidth { get; set; }

    [Column("MMBatchItemWoodEditProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodEditProductHeight { get; set; }

    [Column("MMBatchItemWoodEditProductBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodEditProductBlocks { get; set; }

    [Column("MMBatchItemWoodIsReuse")]
    public bool? MmbatchItemWoodIsReuse { get; set; }

    [Column("MMBatchItemWoodIsAllocation")]
    public bool? MmbatchItemWoodIsAllocation { get; set; }

    [Column("MMBatchItemWoodProductAttribute")]
    [StringLength(100)]
    public string MmbatchItemWoodProductAttribute { get; set; }

    [Column("MMBatchItemWoodProductAttributeKey")]
    public int? MmbatchItemWoodProductAttributeKey { get; set; }

    [Column("MMBatchItemWoodProductDryThick", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodProductDryThick { get; set; }

    [Column("MMBatchItemWoodProductFreshThick", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemWoodProductFreshThick { get; set; }

    [Column("MMBatchItemWoodDetailPlanType")]
    [StringLength(50)]
    public string MmbatchItemWoodDetailPlanType { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmbatchItemWoods")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmbatchItemWoods")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmbatchItemWoods")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmbatchItemWoods")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkMmbatchItemPlanId")]
    [InverseProperty("MmbatchItemWoods")]
    public virtual MmbatchItemPlan FkMmbatchItemPlan { get; set; }
}
