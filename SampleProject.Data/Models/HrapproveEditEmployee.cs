using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRApproveEditEmployees")]
public partial class HrapproveEditEmployee
{
    [Key]
    [Column("HRApproveEditEmployeeID")]
    public int HrapproveEditEmployeeId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRApproveEmployeeID")]
    public int? FkHrapproveEmployeeId { get; set; }

    [Column("HRApproveEditEmployeeNewAddress")]
    [StringLength(500)]
    public string HrapproveEditEmployeeNewAddress { get; set; }

    [Column("HRApproveEditEmployeeNewTel")]
    [StringLength(500)]
    public string HrapproveEditEmployeeNewTel { get; set; }

    [Column("HRApproveEditEmployeeStatus")]
    [StringLength(50)]
    public string HrapproveEditEmployeeStatus { get; set; }

    [Column("HRApproveEditEmployeeReasonStatus")]
    [StringLength(500)]
    public string HrapproveEditEmployeeReasonStatus { get; set; }

    [Column("HRApproveEditEmployeeGenderCombo")]
    [StringLength(50)]
    public string HrapproveEditEmployeeGenderCombo { get; set; }

    [Column("HRApproveEditEmployeeEmail")]
    [StringLength(255)]
    public string HrapproveEditEmployeeEmail { get; set; }

    [Column("HRApproveEditEmployeeDob", TypeName = "datetime")]
    public DateTime? HrapproveEditEmployeeDob { get; set; }

    [Column("HRApproveEditEmployeeIDNumber")]
    [StringLength(255)]
    public string HrapproveEditEmployeeIdnumber { get; set; }

    [ForeignKey("FkHrapproveEmployeeId")]
    [InverseProperty("HrapproveEditEmployeeFkHrapproveEmployees")]
    public virtual Hremployee FkHrapproveEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrapproveEditEmployeeFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }
}
