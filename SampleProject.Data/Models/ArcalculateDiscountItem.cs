using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCalculateDiscountItems")]
public partial class ArcalculateDiscountItem
{
    [Key]
    [Column("ARCalculateDiscountItemID")]
    public int ArcalculateDiscountItemId { get; set; }

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

    [Column("FK_ARCalculateDiscountID")]
    public int? FkArcalculateDiscountId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("FK_ARDiscountProgramItemTargetID")]
    public int? FkArdiscountProgramItemTargetId { get; set; }

    [Column("ARCalculateDiscountItemTargetValue", TypeName = "decimal(18, 5)")]
    public decimal? ArcalculateDiscountItemTargetValue { get; set; }

    [Column("ARCalculateDiscountItemSalesAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcalculateDiscountItemSalesAmount { get; set; }

    [Column("ARCalculateDiscountItemTargetBonus01", TypeName = "decimal(18, 5)")]
    public decimal? ArcalculateDiscountItemTargetBonus01 { get; set; }

    [Column("ARCalculateDiscountItemTargetBonus02", TypeName = "decimal(18, 5)")]
    public decimal? ArcalculateDiscountItemTargetBonus02 { get; set; }

    [Column("ARCalculateDiscountItemTargetBonusAmount01", TypeName = "decimal(18, 5)")]
    public decimal? ArcalculateDiscountItemTargetBonusAmount01 { get; set; }

    [Column("ARCalculateDiscountItemTargetBonusAmount02", TypeName = "decimal(18, 5)")]
    public decimal? ArcalculateDiscountItemTargetBonusAmount02 { get; set; }

    [Column("FK_HREmployeeApprovedID")]
    public int? FkHremployeeApprovedId { get; set; }

    [Column("ARCalculateDiscountItemPostedStatus")]
    [StringLength(50)]
    public string ArcalculateDiscountItemPostedStatus { get; set; }

    [Column("ARCalculateDiscountItemApprovedDate", TypeName = "datetime")]
    public DateTime? ArcalculateDiscountItemApprovedDate { get; set; }

    [ForeignKey("FkArcalculateDiscountId")]
    [InverseProperty("ArcalculateDiscountItems")]
    public virtual ArcalculateDiscount FkArcalculateDiscount { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("ArcalculateDiscountItems")]
    public virtual Hremployee FkHremployeeApproved { get; set; }
}
