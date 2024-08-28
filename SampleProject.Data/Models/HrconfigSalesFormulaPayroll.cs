using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRConfigSalesFormulaPayrolls")]
public partial class HrconfigSalesFormulaPayroll
{
    [Key]
    [Column("HRConfigSalesFormulaPayrollID")]
    public int HrconfigSalesFormulaPayrollId { get; set; }

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

    [Required]
    [Column("HRConfigSalesFormulaPayrollNo")]
    [StringLength(50)]
    public string HrconfigSalesFormulaPayrollNo { get; set; }

    [Column("HRConfigSalesFormulaPayrollName")]
    [StringLength(255)]
    public string HrconfigSalesFormulaPayrollName { get; set; }

    [Column("HRConfigSalesFormulaPayrollDesc")]
    [StringLength(512)]
    public string HrconfigSalesFormulaPayrollDesc { get; set; }

    [Column("HRConfigSalesFormulaPayrollDate", TypeName = "datetime")]
    public DateTime? HrconfigSalesFormulaPayrollDate { get; set; }

    [Column("HRConfigSalesFormulaPayrollFromDate", TypeName = "datetime")]
    public DateTime? HrconfigSalesFormulaPayrollFromDate { get; set; }

    [Column("HRConfigSalesFormulaPayrollToDate", TypeName = "datetime")]
    public DateTime? HrconfigSalesFormulaPayrollToDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HREmployeeApprovedID")]
    public int? FkHremployeeApprovedId { get; set; }

    [Column("HRConfigSalesFormulaPayrollType")]
    [StringLength(50)]
    public string HrconfigSalesFormulaPayrollType { get; set; }

    [Column("HRConfigSalesFormulaPayrollStatus")]
    [StringLength(50)]
    public string HrconfigSalesFormulaPayrollStatus { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrconfigSalesFormulaPayrollFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("HrconfigSalesFormulaPayrollFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [InverseProperty("FkHrconfigSalesFormulaPayroll")]
    public virtual ICollection<HrconfigSalesFormulaPayrollItem> HrconfigSalesFormulaPayrollItems { get; set; } = new List<HrconfigSalesFormulaPayrollItem>();
}
