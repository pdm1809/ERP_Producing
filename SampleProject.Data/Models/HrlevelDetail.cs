using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLevelDetails")]
public partial class HrlevelDetail
{
    [Key]
    [Column("HRLevelDetailID")]
    public int HrlevelDetailId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("HRLevelDetailName")]
    [StringLength(512)]
    public string HrlevelDetailName { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Required]
    [Column("HRLevelDetailNo")]
    [StringLength(100)]
    public string HrlevelDetailNo { get; set; }

    [Column("HRLevelDetailAdjustmentTime")]
    [StringLength(100)]
    public string HrlevelDetailAdjustmentTime { get; set; }

    [Column("HRLevelDetailDate", TypeName = "datetime")]
    public DateTime? HrlevelDetailDate { get; set; }

    [Column("FK_HREmployeeEditerID")]
    public int? FkHremployeeEditerId { get; set; }

    [Column("FK_HREmployeeConsiderID")]
    public int? FkHremployeeConsiderId { get; set; }

    [Column("FK_HREmployeeApproverID")]
    public int? FkHremployeeApproverId { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrlevelDetails")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHremployeeApproverId")]
    [InverseProperty("HrlevelDetailFkHremployeeApprovers")]
    public virtual Hremployee FkHremployeeApprover { get; set; }

    [ForeignKey("FkHremployeeConsiderId")]
    [InverseProperty("HrlevelDetailFkHremployeeConsiders")]
    public virtual Hremployee FkHremployeeConsider { get; set; }

    [ForeignKey("FkHremployeeEditerId")]
    [InverseProperty("HrlevelDetailFkHremployeeEditers")]
    public virtual Hremployee FkHremployeeEditer { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrlevelDetails")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
