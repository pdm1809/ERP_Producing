using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMBuildingPlanItems")]
public partial class PmbuildingPlanItem
{
    [Key]
    [Column("PMBuildingPlanItemID")]
    public int PmbuildingPlanItemId { get; set; }

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

    [Column("FK_PMBuildingPlanID")]
    public int? FkPmbuildingPlanId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_PMBuidingCommandID")]
    public int? FkPmbuidingCommandId { get; set; }

    [Column("FK_PMBuidingCommandItemID")]
    public int? FkPmbuidingCommandItemId { get; set; }

    [Column("PMBuildingPlanItemProductNo")]
    [StringLength(50)]
    public string PmbuildingPlanItemProductNo { get; set; }

    [Column("PMBuildingPlanItemProductName")]
    [StringLength(512)]
    public string PmbuildingPlanItemProductName { get; set; }

    [Column("PMBuildingPlanItemProductDesc")]
    [StringLength(512)]
    public string PmbuildingPlanItemProductDesc { get; set; }

    [Column("PMBuildingPlanItemProductBlocks", TypeName = "decimal(18, 0)")]
    public decimal? PmbuildingPlanItemProductBlocks { get; set; }

    [Column("PMBuildingPlanItemProductHeight", TypeName = "decimal(18, 0)")]
    public decimal? PmbuildingPlanItemProductHeight { get; set; }

    [Column("PMBuildingPlanItemProductWidth", TypeName = "decimal(18, 0)")]
    public decimal? PmbuildingPlanItemProductWidth { get; set; }

    [Column("PMBuildingPlanItemProductLength", TypeName = "decimal(18, 0)")]
    public decimal? PmbuildingPlanItemProductLength { get; set; }

    [Column("PMBuildingPlanItemParentOrderName")]
    [StringLength(256)]
    public string PmbuildingPlanItemParentOrderName { get; set; }

    [Column("PMBuildingPlanItemNeededTime", TypeName = "datetime")]
    public DateTime? PmbuildingPlanItemNeededTime { get; set; }

    [Column("PMBuildingPlanItemIsReuse")]
    public bool? PmbuildingPlanItemIsReuse { get; set; }

    [Column("PMBuildingPlanItemDonePercent")]
    public int? PmbuildingPlanItemDonePercent { get; set; }

    [Column("PMBuildingPlanItemSerialNo")]
    [StringLength(256)]
    public string PmbuildingPlanItemSerialNo { get; set; }

    [Column("PMBuildingPlanItemPriority")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmbuildingPlanItemPriority { get; set; }

    [Column("PMBuildingPlanItemType")]
    [StringLength(50)]
    public string PmbuildingPlanItemType { get; set; }

    [Column("PMBuildingPlanItemComment")]
    [StringLength(512)]
    public string PmbuildingPlanItemComment { get; set; }

    [Column("PMBuildingPlanItemSpecialityComment")]
    [StringLength(512)]
    public string PmbuildingPlanItemSpecialityComment { get; set; }

    [Column("PMBuildingPlanItemStartDate", TypeName = "datetime")]
    public DateTime? PmbuildingPlanItemStartDate { get; set; }

    [Column("PMBuildingPlanItemEndDate", TypeName = "datetime")]
    public DateTime? PmbuildingPlanItemEndDate { get; set; }

    [Column("PMBuildingPlanItemStartTime", TypeName = "datetime")]
    public DateTime? PmbuildingPlanItemStartTime { get; set; }

    [Column("PMBuildingPlanItemEndTime", TypeName = "datetime")]
    public DateTime? PmbuildingPlanItemEndTime { get; set; }

    [Column("PMBuildingPlanItemUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? PmbuildingPlanItemUnitCost { get; set; }

    [Column("PMBuildingPlanItemTotalDays")]
    public int? PmbuildingPlanItemTotalDays { get; set; }

    [Column("PMBuildingPlanItemTotalHours")]
    public int? PmbuildingPlanItemTotalHours { get; set; }

    [Column("PMBuildingPlanItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmbuildingPlanItemTotalCost { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("PmbuildingPlanItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmbuildingPlanItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmbuildingPlanItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkPmbuidingCommandId")]
    [InverseProperty("PmbuildingPlanItems")]
    public virtual PmbuidingCommand FkPmbuidingCommand { get; set; }

    [ForeignKey("FkPmbuidingCommandItemId")]
    [InverseProperty("PmbuildingPlanItems")]
    public virtual PmbuidingCommandItem FkPmbuidingCommandItem { get; set; }

    [ForeignKey("FkPmbuildingPlanId")]
    [InverseProperty("PmbuildingPlanItems")]
    public virtual PmbuildingPlan FkPmbuildingPlan { get; set; }

    [InverseProperty("FkPmbuildingPlanItem")]
    public virtual ICollection<PmbuildingAllocationItem> PmbuildingAllocationItems { get; set; } = new List<PmbuildingAllocationItem>();
}
