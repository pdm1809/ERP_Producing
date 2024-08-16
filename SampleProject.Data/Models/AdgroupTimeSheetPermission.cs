using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADGroupTimeSheetPermissions")]
public partial class AdgroupTimeSheetPermission
{
    [Key]
    [Column("ADGroupTimeSheetPermissionID")]
    public int AdgroupTimeSheetPermissionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int FkHremployeePayrollFormulaId { get; set; }

    [Column("ADGroupTimeSheetPermissionType")]
    public byte AdgroupTimeSheetPermissionType { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("AdgroupTimeSheetPermissions")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("AdgroupTimeSheetPermissions")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }
}
