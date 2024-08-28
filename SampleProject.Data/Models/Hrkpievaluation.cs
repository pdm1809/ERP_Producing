using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRKPIEvaluations")]
public partial class Hrkpievaluation
{
    [Key]
    [Column("HRKPIEvaluationID")]
    public int HrkpievaluationId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("HRKPIEvaluationNo")]
    [StringLength(50)]
    public string HrkpievaluationNo { get; set; }

    [Column("HRKPIEvaluationDate", TypeName = "datetime")]
    public DateTime? HrkpievaluationDate { get; set; }

    [Column("HRKPIEvaluationStartDate", TypeName = "datetime")]
    public DateTime? HrkpievaluationStartDate { get; set; }

    [Column("HRKPIEvaluationFinishedDate", TypeName = "datetime")]
    public DateTime? HrkpievaluationFinishedDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeID2")]
    public int? FkHremployeeId2 { get; set; }

    [Column("HRKPIEvaluationTotalAmountBonus", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationTotalAmountBonus { get; set; }

    [Column("HRKPIEvaluationTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationTotalAmount { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HRKPIRegistrationID")]
    public int? FkHrkpiregistrationId { get; set; }

    [Column("FK_BRBranchID2")]
    public int? FkBrbranchId2 { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("HRKPIEvaluationType")]
    [StringLength(64)]
    [Unicode(false)]
    public string HrkpievaluationType { get; set; }

    [Column("HRKPIEvaluationStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string HrkpievaluationStatus { get; set; }

    [Column("HRKPIEvaluationName")]
    [StringLength(128)]
    public string HrkpievaluationName { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrkpievaluationFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrbranchId2")]
    [InverseProperty("HrkpievaluationFkBrbranchId2Navigations")]
    public virtual Brbranch FkBrbranchId2Navigation { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Hrkpievaluations")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Hrkpievaluations")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrkpievaluationFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeId2")]
    [InverseProperty("HrkpievaluationFkHremployeeId2Navigations")]
    public virtual Hremployee FkHremployeeId2Navigation { get; set; }

    [ForeignKey("FkHrkpiregistrationId")]
    [InverseProperty("Hrkpievaluations")]
    public virtual Hrkpiregistration FkHrkpiregistration { get; set; }

    [InverseProperty("FkHrkpievaluation")]
    public virtual ICollection<HremployeeKpievaluationItem> HremployeeKpievaluationItems { get; set; } = new List<HremployeeKpievaluationItem>();

    [InverseProperty("FkHrkpievaluation")]
    public virtual ICollection<HrkpievaluationItemTarget> HrkpievaluationItemTargets { get; set; } = new List<HrkpievaluationItemTarget>();

    [InverseProperty("FkHrkpievaluation")]
    public virtual ICollection<HrkpievaluationItem> HrkpievaluationItems { get; set; } = new List<HrkpievaluationItem>();
}
