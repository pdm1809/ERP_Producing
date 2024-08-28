using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRConfigSalesFormulaPayrollItems")]
public partial class HrconfigSalesFormulaPayrollItem
{
    [Key]
    [Column("HRConfigSalesFormulaPayrollItemID")]
    public int HrconfigSalesFormulaPayrollItemId { get; set; }

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

    [Column("HRConfigSalesFormulaPayrollItemRewardAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigSalesFormulaPayrollItemRewardAmount { get; set; }

    [Column("HRConfigSalesFormulaPayrollItemRewardPercent", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigSalesFormulaPayrollItemRewardPercent { get; set; }

    [Column("HRConfigSalesFormulaPayrollItemSalesFrom", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigSalesFormulaPayrollItemSalesFrom { get; set; }

    [Column("HRConfigSalesFormulaPayrollItemSalesTo", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigSalesFormulaPayrollItemSalesTo { get; set; }

    [Column("HRConfigSalesFormulaPayrollItemDependenceType")]
    [StringLength(50)]
    public string HrconfigSalesFormulaPayrollItemDependenceType { get; set; }

    [Column("HRConfigSalesFormulaPayrollItemDependenceSalesFrom", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigSalesFormulaPayrollItemDependenceSalesFrom { get; set; }

    [Column("HRConfigSalesFormulaPayrollItemDependenceSalesTo", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigSalesFormulaPayrollItemDependenceSalesTo { get; set; }

    [Column("HRCircumstancesRewardType")]
    [StringLength(50)]
    public string HrcircumstancesRewardType { get; set; }

    [Column("FK_HRConfigSalesFormulaPayrollID")]
    public int? FkHrconfigSalesFormulaPayrollId { get; set; }

    [ForeignKey("FkHrconfigSalesFormulaPayrollId")]
    [InverseProperty("HrconfigSalesFormulaPayrollItems")]
    public virtual HrconfigSalesFormulaPayroll FkHrconfigSalesFormulaPayroll { get; set; }
}
