using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCancelAllocationPlanItems")]
public partial class MmcancelAllocationPlanItem
{
    [Key]
    [Column("MMCancelAllocationPlanItemID")]
    public int MmcancelAllocationPlanItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("FK_MMCancelAllocationPlanID")]
    public int FkMmcancelAllocationPlanId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_MMAllocationPlanID")]
    public int? FkMmallocationPlanId { get; set; }

    [Column("FK_MMAllocationPlanItemID")]
    public int? FkMmallocationPlanItemId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("MMCancelAllocationPlanItemProductName")]
    [StringLength(50)]
    public string MmcancelAllocationPlanItemProductName { get; set; }

    [Column("MMCancelAllocationPlanItemProductDesc")]
    [StringLength(512)]
    public string MmcancelAllocationPlanItemProductDesc { get; set; }

    [Column("MMCancelAllocationPlanItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemHeight { get; set; }

    [Column("MMCancelAllocationPlanItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemWidth { get; set; }

    [Column("MMCancelAllocationPlanItemLength", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemLength { get; set; }

    [Column("MMCancelAllocationPlanItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemHeightMin { get; set; }

    [Column("MMCancelAllocationPlanItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemWidthMin { get; set; }

    [Column("MMCancelAllocationPlanItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemLengthMin { get; set; }

    [Column("MMCancelAllocationPlanItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemHeightMax { get; set; }

    [Column("MMCancelAllocationPlanItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemWidthMax { get; set; }

    [Column("MMCancelAllocationPlanItemLengthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemLengthMax { get; set; }

    [Column("MMCancelAllocationPlanItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemQty { get; set; }

    [Column("MMCancelAllocationPlanItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemWoodQty { get; set; }

    [Column("MMCancelAllocationPlanItemAllocatedQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemAllocatedQty { get; set; }

    [Column("MMCancelAllocationPlanItemAllocatedWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationPlanItemAllocatedWoodQty { get; set; }

    [Column("MMPriority")]
    [StringLength(50)]
    public string Mmpriority { get; set; }

    [Column("MMCancelAllocationPlanItemDeliveryDate", TypeName = "datetime")]
    public DateTime? MmcancelAllocationPlanItemDeliveryDate { get; set; }

    [Column("MMCancelAllocationPlanItemHWQtySource")]
    [StringLength(50)]
    public string MmcancelAllocationPlanItemHwqtySource { get; set; }

    [Column("MMCancelAllocationPlanItemComment")]
    [StringLength(512)]
    public string MmcancelAllocationPlanItemComment { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmcancelAllocationPlanItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmcancelAllocationPlanItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmcancelAllocationPlanItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmcancelAllocationPlanItems")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmcancelAllocationPlanItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("MmcancelAllocationPlanItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmallocationPlanId")]
    [InverseProperty("MmcancelAllocationPlanItems")]
    public virtual MmallocationPlan FkMmallocationPlan { get; set; }

    [ForeignKey("FkMmallocationPlanItemId")]
    [InverseProperty("MmcancelAllocationPlanItems")]
    public virtual MmallocationPlanItem FkMmallocationPlanItem { get; set; }

    [ForeignKey("FkMmcancelAllocationPlanId")]
    [InverseProperty("MmcancelAllocationPlanItems")]
    public virtual MmcancelAllocationPlan FkMmcancelAllocationPlan { get; set; }
}
