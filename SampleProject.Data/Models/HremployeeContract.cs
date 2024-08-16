using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeContracts")]
public partial class HremployeeContract
{
    [Key]
    [Column("HREmployeeContractID")]
    public int HremployeeContractId { get; set; }

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
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Required]
    [Column("HREmployeeContractNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeContractNo { get; set; }

    [Column("HREmployeeContractType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeContractType { get; set; }

    [Column("HREmployeeContractDateFrom", TypeName = "datetime")]
    public DateTime? HremployeeContractDateFrom { get; set; }

    [Column("HREmployeeContractDateTo", TypeName = "datetime")]
    public DateTime? HremployeeContractDateTo { get; set; }

    [Column("HREmployeeContractSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeContractSalary { get; set; }

    [Column("HREmployeeContractSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeContractSalaryFactor { get; set; }

    [Column("HREmployeeContractExtraSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeContractExtraSalary { get; set; }

    [Column("HREmployeeContractAllowances", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeContractAllowances { get; set; }

    [Column("HREmployeeContractSignDate", TypeName = "datetime")]
    public DateTime? HremployeeContractSignDate { get; set; }

    [Column("HREmployeeContractSigner")]
    public int? HremployeeContractSigner { get; set; }

    [Column("HREmployeeContractRemark")]
    [StringLength(500)]
    public string HremployeeContractRemark { get; set; }

    [Column("HREmployeeContractDeductionType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeContractDeductionType { get; set; }

    [Column("HREmployeeContractCVPL")]
    [StringLength(500)]
    public string HremployeeContractCvpl { get; set; }

    [Column("HREmployeeContractCD")]
    [StringLength(200)]
    public string HremployeeContractCd { get; set; }

    [Column("HREmployeeContractCV")]
    [StringLength(200)]
    public string HremployeeContractCv { get; set; }

    [Column("HREmployeeContractDC")]
    [StringLength(500)]
    public string HremployeeContractDc { get; set; }

    [Column("HREmployeeContractTTK")]
    [StringLength(500)]
    public string HremployeeContractTtk { get; set; }

    [Column("FK_BRBranchIDToWork")]
    public int? FkBrbranchIdtoWork { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_HRDepartmentRoomGroupTeamItemID")]
    public int? FkHrdepartmentRoomGroupTeamItemId { get; set; }

    [Column("HREmployeeContractStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeContractStatus { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HremployeeContractFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrbranchIdtoWork")]
    [InverseProperty("HremployeeContractFkBrbranchIdtoWorkNavigations")]
    public virtual Brbranch FkBrbranchIdtoWorkNavigation { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeeContracts")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeContracts")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HremployeeContracts")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupTeamItemId")]
    [InverseProperty("HremployeeContracts")]
    public virtual HrdepartmentRoomGroupTeamItem FkHrdepartmentRoomGroupTeamItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeContractFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeeContracts")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("HremployeeContractSigner")]
    [InverseProperty("HremployeeContractHremployeeContractSignerNavigations")]
    public virtual Hremployee HremployeeContractSignerNavigation { get; set; }

    [InverseProperty("FkHremployeeContract")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranfers { get; set; } = new List<HremployeeTranfer>();
}
