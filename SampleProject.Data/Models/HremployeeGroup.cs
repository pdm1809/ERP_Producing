using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeGroups")]
public partial class HremployeeGroup
{
    [Key]
    [Column("HREmployeeGroupID")]
    public int HremployeeGroupId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRGroupID")]
    public int FkHrgroupId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    public bool IsLeader { get; set; }

    [Column("HREmployeeGroupCRMRole")]
    [StringLength(50)]
    public string HremployeeGroupCrmrole { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HremployeeGroups")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeGroups")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("HremployeeGroups")]
    public virtual Hrgroup FkHrgroup { get; set; }
}
