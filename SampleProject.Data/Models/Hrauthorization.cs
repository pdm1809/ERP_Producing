using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAuthorizations")]
public partial class Hrauthorization
{
    [Key]
    [Column("HRAuthorizationID")]
    public int HrauthorizationId { get; set; }

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
    [Column("HRAuthorizationNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrauthorizationNo { get; set; }

    [Column("HRAuthorizationType")]
    [StringLength(100)]
    public string HrauthorizationType { get; set; }

    [Column("HRAuthorizationDateFrom", TypeName = "datetime")]
    public DateTime? HrauthorizationDateFrom { get; set; }

    [Column("HRAuthorizationDateTo", TypeName = "datetime")]
    public DateTime? HrauthorizationDateTo { get; set; }

    [Column("HRAuthorizationSignDate", TypeName = "datetime")]
    public DateTime? HrauthorizationSignDate { get; set; }

    [Column("FK_HREmployeeAuthorizationSigner")]
    public int? FkHremployeeAuthorizationSigner { get; set; }

    [Column("HRAuthorizationRemark")]
    [StringLength(500)]
    public string HrauthorizationRemark { get; set; }

    [Column("HRAuthorizationCV")]
    [StringLength(100)]
    public string HrauthorizationCv { get; set; }

    [Column("HRAuthorizationContent", TypeName = "ntext")]
    public string HrauthorizationContent { get; set; }

    [Column("FK_BRBranchIDToWork")]
    public int? FkBrbranchIdtoWork { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrauthorizationFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrbranchIdtoWork")]
    [InverseProperty("HrauthorizationFkBrbranchIdtoWorkNavigations")]
    public virtual Brbranch FkBrbranchIdtoWorkNavigation { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Hrauthorizations")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Hrauthorizations")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrauthorizationFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeAuthorizationSigner")]
    [InverseProperty("HrauthorizationFkHremployeeAuthorizationSignerNavigations")]
    public virtual Hremployee FkHremployeeAuthorizationSignerNavigation { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("Hrauthorizations")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
