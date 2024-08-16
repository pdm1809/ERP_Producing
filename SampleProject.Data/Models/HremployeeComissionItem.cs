using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeComissionItems")]
public partial class HremployeeComissionItem
{
    [Key]
    [Column("HREmployeeComissionItemID")]
    public int HremployeeComissionItemId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeComissionID")]
    public int? FkHremployeeComissionId { get; set; }

    [Column("HREmployeeCardNumber")]
    [StringLength(50)]
    public string HremployeeCardNumber { get; set; }

    [Column("HREmployeeTotalDepositAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTotalDepositAmount { get; set; }

    [Column("HREmployeeTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTotalAmount { get; set; }

    [Column("HREmployeeComissionFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeComissionFactor { get; set; }

    [Column("HREmployeeComissionDate", TypeName = "datetime")]
    public DateTime? HremployeeComissionDate { get; set; }

    [Column("HREmployeeComissionTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeComissionTotalAmount { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HremployeeComissionItems")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeComissionItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeComissionId")]
    [InverseProperty("HremployeeComissionItems")]
    public virtual HremployeeComission FkHremployeeComission { get; set; }
}
