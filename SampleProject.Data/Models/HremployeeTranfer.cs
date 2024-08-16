using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeTranfers")]
public partial class HremployeeTranfer
{
    [Key]
    [Column("HREmployeeTranferID")]
    public int HremployeeTranferId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int FkHrdepartmentRoomId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_HRLevelID")]
    public int FkHrlevelId { get; set; }

    [Column("HREmployeeTranferType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeTranferType { get; set; }

    [Column("HREmployeeTranferDateFrom", TypeName = "datetime")]
    public DateTime? HremployeeTranferDateFrom { get; set; }

    [Column("HREmployeeTranferDateTo", TypeName = "datetime")]
    public DateTime? HremployeeTranferDateTo { get; set; }

    [Column("HREmployeeTranferSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTranferSalary { get; set; }

    [Column("HREmployeeTranferSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTranferSalaryFactor { get; set; }

    [Column("HREmployeeTranferExtraSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTranferExtraSalary { get; set; }

    [Column("HREmployeeTranferAllowances", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTranferAllowances { get; set; }

    [Column("HREmployeeTranferSignDate", TypeName = "datetime")]
    public DateTime? HremployeeTranferSignDate { get; set; }

    [Column("HREmployeeTranferSigner")]
    public int? HremployeeTranferSigner { get; set; }

    [Column("HREmployeeTranferRemark")]
    [StringLength(500)]
    public string HremployeeTranferRemark { get; set; }

    [Column("HREmployeeTranferNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeTranferNo { get; set; }

    [Column("FK_HREmployeeContractID")]
    public int? FkHremployeeContractId { get; set; }

    [Column("HREmployeeTranferAllowanceAnother")]
    [StringLength(500)]
    public string HremployeeTranferAllowanceAnother { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_HRDepartmentRoomGroupTeamItemID")]
    public int? FkHrdepartmentRoomGroupTeamItemId { get; set; }

    [Column("FK_HREmployeeReceivedID")]
    public int? FkHremployeeReceivedId { get; set; }

    [Column("HREmployeeTranferTotalSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTranferTotalSalary { get; set; }

    [Column("HREmployeeTranferSalarySocialInsurance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTranferSalarySocialInsurance { get; set; }

    [Column("HREmployeeTranferTotalSalaryOriginal", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTranferTotalSalaryOriginal { get; set; }

    [Column("HREmployeeTranferSalarySocialInsuranceOriginal", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTranferSalarySocialInsuranceOriginal { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HremployeeTranfers")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeeTranfers")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeTranfers")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HremployeeTranfers")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupTeamItemId")]
    [InverseProperty("HremployeeTranfers")]
    public virtual HrdepartmentRoomGroupTeamItem FkHrdepartmentRoomGroupTeamItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeTranferFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeContractId")]
    [InverseProperty("HremployeeTranfers")]
    public virtual HremployeeContract FkHremployeeContract { get; set; }

    [ForeignKey("FkHremployeeReceivedId")]
    [InverseProperty("HremployeeTranferFkHremployeeReceiveds")]
    public virtual Hremployee FkHremployeeReceived { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeeTranfers")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("HremployeeTranferSigner")]
    [InverseProperty("HremployeeTranferHremployeeTranferSignerNavigations")]
    public virtual Hremployee HremployeeTranferSignerNavigation { get; set; }
}
