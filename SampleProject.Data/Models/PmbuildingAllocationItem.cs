using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMBuildingAllocationItems")]
public partial class PmbuildingAllocationItem
{
    [Key]
    [Column("PMBuildingAllocationItemID")]
    public int PmbuildingAllocationItemId { get; set; }

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

    [Column("FK_PMBuildingAllocationID")]
    public int? FkPmbuildingAllocationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_PMBuildingPlanID")]
    public int? FkPmbuildingPlanId { get; set; }

    [Column("FK_PMBuildingPlanItemID")]
    public int? FkPmbuildingPlanItemId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeOwnerID")]
    public int? FkHremployeeOwnerId { get; set; }

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

    [Column("PMBuildingPlanItemDepreciationRate", TypeName = "decimal(18, 0)")]
    public decimal? PmbuildingPlanItemDepreciationRate { get; set; }

    [Column("PMBuildingPlanItemItemActualDepreciationRate", TypeName = "decimal(18, 0)")]
    public decimal? PmbuildingPlanItemItemActualDepreciationRate { get; set; }

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

    [Column("PMBuildingPlanItemIngredientID")]
    public int? PmbuildingPlanItemIngredientId { get; set; }

    [Column("PMBuildingPlanItemAllocationType")]
    [StringLength(50)]
    public string PmbuildingPlanItemAllocationType { get; set; }

    [Column("PMBuildingPlanItemComment")]
    [StringLength(512)]
    public string PmbuildingPlanItemComment { get; set; }

    [Column("PMBuildingPlanItemSpecialityComment")]
    [StringLength(512)]
    public string PmbuildingPlanItemSpecialityComment { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmbuildingAllocationItemFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeOwnerId")]
    [InverseProperty("PmbuildingAllocationItemFkHremployeeOwners")]
    public virtual Hremployee FkHremployeeOwner { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("PmbuildingAllocationItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmbuildingAllocationItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmbuildingAllocationItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkPmbuildingAllocationId")]
    [InverseProperty("PmbuildingAllocationItems")]
    public virtual PmbuildingAllocation FkPmbuildingAllocation { get; set; }

    [ForeignKey("FkPmbuildingPlanId")]
    [InverseProperty("PmbuildingAllocationItems")]
    public virtual PmbuildingPlan FkPmbuildingPlan { get; set; }

    [ForeignKey("FkPmbuildingPlanItemId")]
    [InverseProperty("PmbuildingAllocationItems")]
    public virtual PmbuildingPlanItem FkPmbuildingPlanItem { get; set; }
}
