using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRConfigSalesTargets")]
public partial class HrconfigSalesTarget
{
    [Key]
    [Column("HRConfigSalesTargetID")]
    public int HrconfigSalesTargetId { get; set; }

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

    [Required]
    [Column("HRConfigSalesTargetNo")]
    [StringLength(50)]
    public string HrconfigSalesTargetNo { get; set; }

    [Column("HRConfigSalesTargetName")]
    [StringLength(256)]
    public string HrconfigSalesTargetName { get; set; }

    [Column("HRConfigSalesTargetDesc")]
    [StringLength(512)]
    public string HrconfigSalesTargetDesc { get; set; }

    [Column("HRConfigSalesTargetDate", TypeName = "datetime")]
    public DateTime? HrconfigSalesTargetDate { get; set; }

    [Column("FK_HREmployeeApprovedID")]
    public int? FkHremployeeApprovedId { get; set; }

    [Column("HRConfigSalesTargetStatus")]
    [StringLength(50)]
    public string HrconfigSalesTargetStatus { get; set; }

    [Column("HRConfigSalesTargetApplicableSubjects")]
    [StringLength(50)]
    public string HrconfigSalesTargetApplicableSubjects { get; set; }

    [Column("FK_HRConfigSalesTargetParentID")]
    public int? FkHrconfigSalesTargetParentId { get; set; }

    [Column("FK_CSCompanyID")]
    public int? FkCscompanyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("HRConfigSalesTargetAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigSalesTargetAmount { get; set; }

    [Column("HRConfigSalesTargetApplyFromDate", TypeName = "datetime")]
    public DateTime? HrconfigSalesTargetApplyFromDate { get; set; }

    [Column("HRConfigSalesTargetApplyToDate", TypeName = "datetime")]
    public DateTime? HrconfigSalesTargetApplyToDate { get; set; }

    [Column("HRConfigSalesTargetType")]
    [StringLength(50)]
    public string HrconfigSalesTargetType { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrconfigSalesTargets")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscompanyId")]
    [InverseProperty("HrconfigSalesTargets")]
    public virtual Cscompany FkCscompany { get; set; }

    [ForeignKey("FkHrconfigSalesTargetParentId")]
    [InverseProperty("InverseFkHrconfigSalesTargetParent")]
    public virtual HrconfigSalesTarget FkHrconfigSalesTargetParent { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrconfigSalesTargetFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("HrconfigSalesTargetFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [InverseProperty("FkHrconfigSalesTarget")]
    public virtual ICollection<HrconfigSalesTargetItem> HrconfigSalesTargetItems { get; set; } = new List<HrconfigSalesTargetItem>();

    [InverseProperty("FkHrconfigSalesTargetParent")]
    public virtual ICollection<HrconfigSalesTarget> InverseFkHrconfigSalesTargetParent { get; set; } = new List<HrconfigSalesTarget>();
}
