using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRequestEditEmployees")]
public partial class HrrequestEditEmployee
{
    [Key]
    [Column("HRRequestEditEmployeeID")]
    public int HrrequestEditEmployeeId { get; set; }

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

    [Column("HRRequestEditEmployeeAddress")]
    [StringLength(500)]
    public string HrrequestEditEmployeeAddress { get; set; }

    [Column("HRRequestEditEmployeeDob", TypeName = "datetime")]
    public DateTime? HrrequestEditEmployeeDob { get; set; }

    [Column("HRRequestEditEmployeeIDNumber")]
    [StringLength(255)]
    public string HrrequestEditEmployeeIdnumber { get; set; }

    [Column("HRRequestEditEmployeeTel")]
    [StringLength(500)]
    public string HrrequestEditEmployeeTel { get; set; }

    [Column("HRRequestEditEmployeeGenderCombo")]
    [StringLength(50)]
    public string HrrequestEditEmployeeGenderCombo { get; set; }

    [Column("HRRequestEditEmployeeStatus")]
    [StringLength(50)]
    public string HrrequestEditEmployeeStatus { get; set; }

    [Column("HRRequestEditEmployeeReasonStatus")]
    [StringLength(500)]
    public string HrrequestEditEmployeeReasonStatus { get; set; }

    [Column("HRRequestEditEmployeeName")]
    [StringLength(256)]
    public string HrrequestEditEmployeeName { get; set; }

    [Column("HRRequestEditEmployeeBirthPlace")]
    [StringLength(256)]
    public string HrrequestEditEmployeeBirthPlace { get; set; }

    [Column("HRRequestEditEmployeeBankAccount1")]
    [StringLength(256)]
    public string HrrequestEditEmployeeBankAccount1 { get; set; }

    [Column("HRRequestEditEmployeeTaxNumber")]
    [StringLength(256)]
    public string HrrequestEditEmployeeTaxNumber { get; set; }

    [Column("HRRequestEditEmployeeDepartmentID")]
    public int? HrrequestEditEmployeeDepartmentId { get; set; }

    [Column("HRRequestEditEmployeeDepartmentRoomID")]
    public int? HrrequestEditEmployeeDepartmentRoomId { get; set; }

    [Column("HRRequestEditEmployeeLevelID")]
    public int? HrrequestEditEmployeeLevelId { get; set; }

    [Column("HRRequestEditEmployeeBranchID")]
    public int? HrrequestEditEmployeeBranchId { get; set; }

    [Column("HRRequestEditEmployeeNo")]
    [StringLength(50)]
    public string HrrequestEditEmployeeNo { get; set; }

    [ForeignKey("FkHrapproveEmployeeId")]
    [InverseProperty("HrrequestEditEmployeeFkHrapproveEmployees")]
    public virtual Hremployee FkHrapproveEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrrequestEditEmployeeFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("HrrequestEditEmployeeBranchId")]
    [InverseProperty("HrrequestEditEmployees")]
    public virtual Brbranch HrrequestEditEmployeeBranch { get; set; }

    [ForeignKey("HrrequestEditEmployeeDepartmentId")]
    [InverseProperty("HrrequestEditEmployees")]
    public virtual Hrdepartment HrrequestEditEmployeeDepartment { get; set; }

    [ForeignKey("HrrequestEditEmployeeDepartmentRoomId")]
    [InverseProperty("HrrequestEditEmployees")]
    public virtual HrdepartmentRoom HrrequestEditEmployeeDepartmentRoom { get; set; }

    [ForeignKey("HrrequestEditEmployeeLevelId")]
    [InverseProperty("HrrequestEditEmployees")]
    public virtual Hrlevel HrrequestEditEmployeeLevel { get; set; }
}
