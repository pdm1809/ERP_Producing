using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBudgetTrackingItems")]
public partial class AcbudgetTrackingItem
{
    [Key]
    [Column("ACBudgetTrackingItemID")]
    public int AcbudgetTrackingItemId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ACBudgetTrackingItemOrderNumber")]
    public int? AcbudgetTrackingItemOrderNumber { get; set; }

    [Column("ACBudgetTrackingItemNo")]
    [StringLength(50)]
    public string AcbudgetTrackingItemNo { get; set; }

    [Column("ACBudgetTrackingItemName")]
    [StringLength(512)]
    public string AcbudgetTrackingItemName { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount1", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount1 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount1", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount1 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount1", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount1 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount1", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount1 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount1", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount1 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent1", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent1 { get; set; }

    [Column("ACBudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string AcbudgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemTotalBudgetAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemTotalBudgetAmount { get; set; }

    [Column("ACBudgetTrackingItemGeneralAccumulationAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemGeneralAccumulationAmount { get; set; }

    [Column("ACBudgetTrackingItemImplementingAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemImplementingAmount { get; set; }

    [Column("ACBudgetTrackingItemImplementingPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemImplementingPercent { get; set; }

    [Column("FK_ACBudgetTrackingID")]
    public int? FkAcbudgetTrackingId { get; set; }

    [Column("A1BudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string A1budgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount2", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount2 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount2", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount2 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount2", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount2 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount2", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount2 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount2", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount2 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent2", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent2 { get; set; }

    [Column("A2BudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string A2budgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount3", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount3 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount3", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount3 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount3", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount3 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount3", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount3 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount3", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount3 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent3", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent3 { get; set; }

    [Column("A3BudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string A3budgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount4", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount4 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount4", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount4 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount4", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount4 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount4", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount4 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount4", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount4 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent4", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent4 { get; set; }

    [Column("A4BudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string A4budgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount5", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount5 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount5", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount5 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount5", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount5 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount5", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount5 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount5", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount5 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent5", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent5 { get; set; }

    [Column("A5BudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string A5budgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount6", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount6 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount6", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount6 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount6", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount6 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount6", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount6 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount6", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount6 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent6", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent6 { get; set; }

    [Column("A6BudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string A6budgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount7", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount7 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount7", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount7 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount7", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount7 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount7", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount7 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount7", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount7 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent7", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent7 { get; set; }

    [Column("A7BudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string A7budgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount8", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount8 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount8", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount8 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount8", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount8 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount8", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount8 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount8", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount8 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent8", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent8 { get; set; }

    [Column("A8BudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string A8budgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount9", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount9 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount9", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount9 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount9", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount9 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount9", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount9 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount9", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount9 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent9", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent9 { get; set; }

    [Column("A9BudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string A9budgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount10", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount10 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount10", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount10 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount10", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount10 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount10", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount10 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount10", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount10 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent10", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent10 { get; set; }

    [Column("AABudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string AabudgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount11", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount11 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount11", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount11 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount11", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount11 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount11", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount11 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount11", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount11 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent11", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent11 { get; set; }

    [Column("ABBudgetTrackingItemEvaluateType")]
    [StringLength(50)]
    public string AbbudgetTrackingItemEvaluateType { get; set; }

    [Column("ACBudgetTrackingItemMonthEntryAmount12", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthEntryAmount12 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdditionAmount12", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdditionAmount12 { get; set; }

    [Column("ACBudgetTrackingItemMonthAdjustAmount12", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthAdjustAmount12 { get; set; }

    [Column("ACBudgetTrackingItemMonthTotalAmount12", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthTotalAmount12 { get; set; }

    [Column("ACBudgetTrackingItemMonthPerformAmount12", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPerformAmount12 { get; set; }

    [Column("ACBudgetTrackingItemMonthPercent12", TypeName = "decimal(18, 5)")]
    public decimal? AcbudgetTrackingItemMonthPercent12 { get; set; }

    [ForeignKey("FkAcbudgetTrackingId")]
    [InverseProperty("AcbudgetTrackingItems")]
    public virtual AcbudgetTracking FkAcbudgetTracking { get; set; }
}
