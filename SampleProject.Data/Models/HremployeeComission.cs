using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeComissions")]
public partial class HremployeeComission
{
    [Key]
    [Column("HREmployeeComissionID")]
    public int HremployeeComissionId { get; set; }

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

    [Column("FK_HREmployeePayrollFormulaID")]
    public int? FkHremployeePayrollFormulaId { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("HREmployeeComissionNo")]
    [StringLength(50)]
    public string HremployeeComissionNo { get; set; }

    [Column("HREmployeeComissionStatus")]
    [StringLength(100)]
    public string HremployeeComissionStatus { get; set; }

    [Column("HREmployeeComissionName")]
    [StringLength(512)]
    public string HremployeeComissionName { get; set; }

    [Column("HREmployeeComissionDesc")]
    [StringLength(512)]
    public string HremployeeComissionDesc { get; set; }

    [Column("HREmployeeComissionFromDate", TypeName = "datetime")]
    public DateTime? HremployeeComissionFromDate { get; set; }

    [Column("HREmployeeComissionToDate", TypeName = "datetime")]
    public DateTime? HremployeeComissionToDate { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("HremployeeComissions")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeeComissions")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [InverseProperty("FkHremployeeComission")]
    public virtual ICollection<HremployeeComissionItem> HremployeeComissionItems { get; set; } = new List<HremployeeComissionItem>();
}
