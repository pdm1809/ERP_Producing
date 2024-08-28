using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRecruitmentNeeds")]
public partial class HrrecruitmentNeed
{
    [Key]
    [Column("HRRecruitmentNeedID")]
    public int HrrecruitmentNeedId { get; set; }

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
    [Column("HRRecruitmentNeedNo")]
    [StringLength(50)]
    public string HrrecruitmentNeedNo { get; set; }

    [Column("HRRecruitmentNeedName")]
    [StringLength(200)]
    public string HrrecruitmentNeedName { get; set; }

    [Column("HRRecruitmentNeedDesc")]
    [StringLength(255)]
    public string HrrecruitmentNeedDesc { get; set; }

    [Column("HRRecruitmentNeedDate", TypeName = "datetime")]
    public DateTime? HrrecruitmentNeedDate { get; set; }

    [Column("HRRecruitmentNeedStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string HrrecruitmentNeedStatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrrecruitmentNeeds")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrrecruitmentNeeds")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HrrecruitmentNeeds")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrrecruitmentNeeds")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrrecruitmentNeed")]
    public virtual ICollection<HrrecruitmentNeedItem> HrrecruitmentNeedItems { get; set; } = new List<HrrecruitmentNeedItem>();

    [InverseProperty("FkHrrecruitmentNeed")]
    public virtual ICollection<HrrecruitmentPlanItem> HrrecruitmentPlanItems { get; set; } = new List<HrrecruitmentPlanItem>();
}
