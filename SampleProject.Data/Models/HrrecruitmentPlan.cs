using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRecruitmentPlans")]
public partial class HrrecruitmentPlan
{
    [Key]
    [Column("HRRecruitmentPlanID")]
    public int HrrecruitmentPlanId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HRDepartmentID")]
    public int FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int FkHrdepartmentRoomId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Required]
    [Column("HRRecruitmentPlanNo")]
    [StringLength(50)]
    public string HrrecruitmentPlanNo { get; set; }

    [Column("HRRecruitmentPlanName")]
    [StringLength(200)]
    public string HrrecruitmentPlanName { get; set; }

    [Column("HRRecruitmentPlanDesc")]
    [StringLength(255)]
    public string HrrecruitmentPlanDesc { get; set; }

    [Column("HRRecruitmentPlanDate", TypeName = "datetime")]
    public DateTime? HrrecruitmentPlanDate { get; set; }

    [Column("HRRecruitmentPlanStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string HrrecruitmentPlanStatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrrecruitmentPlans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrrecruitmentPlans")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HrrecruitmentPlans")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrrecruitmentPlans")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrrecruitmentPlan")]
    public virtual ICollection<HrrecruitmentPlanItem> HrrecruitmentPlanItems { get; set; } = new List<HrrecruitmentPlanItem>();
}
