using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRKPIRegistrations")]
public partial class Hrkpiregistration
{
    [Key]
    [Column("HRKPIRegistrationID")]
    public int HrkpiregistrationId { get; set; }

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
    [Column("HRKPIRegistrationNo")]
    [StringLength(50)]
    public string HrkpiregistrationNo { get; set; }

    [Column("HRKPIRegistrationDate", TypeName = "datetime")]
    public DateTime? HrkpiregistrationDate { get; set; }

    [Column("HRKPIRegistrationStartDate", TypeName = "datetime")]
    public DateTime? HrkpiregistrationStartDate { get; set; }

    [Column("HRKPIRegistrationFinishedDate", TypeName = "datetime")]
    public DateTime? HrkpiregistrationFinishedDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeID2")]
    public int? FkHremployeeId2 { get; set; }

    [Column("HRKPIRegistrationTotalAmountBonus", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiregistrationTotalAmountBonus { get; set; }

    [Column("HRKPIRegistrationTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiregistrationTotalAmount { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("HRKPIRegistrationStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrkpiregistrationStatus { get; set; }

    [Column("FK_BRBranchID2")]
    public int? FkBrbranchId2 { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("HRKPIRegistrationType")]
    [StringLength(64)]
    [Unicode(false)]
    public string HrkpiregistrationType { get; set; }

    [Required]
    [Column("HRKPIRegistrationName")]
    [StringLength(256)]
    public string HrkpiregistrationName { get; set; }

    [Column("FK_HRKPIFormID")]
    public int? FkHrkpiformId { get; set; }

    [Column("HRKPIRegistrationMonth", TypeName = "datetime")]
    public DateTime? HrkpiregistrationMonth { get; set; }

    [Column("HRKPIRegistrationEndMonth", TypeName = "datetime")]
    public DateTime? HrkpiregistrationEndMonth { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrkpiregistrationFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrbranchId2")]
    [InverseProperty("HrkpiregistrationFkBrbranchId2Navigations")]
    public virtual Brbranch FkBrbranchId2Navigation { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Hrkpiregistrations")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Hrkpiregistrations")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrkpiregistrationFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeId2")]
    [InverseProperty("HrkpiregistrationFkHremployeeId2Navigations")]
    public virtual Hremployee FkHremployeeId2Navigation { get; set; }

    [ForeignKey("FkHrkpiformId")]
    [InverseProperty("Hrkpiregistrations")]
    public virtual Hrkpiform FkHrkpiform { get; set; }

    [InverseProperty("FkHrkpiregistration")]
    public virtual ICollection<HremployeeKpievaluationItem> HremployeeKpievaluationItems { get; set; } = new List<HremployeeKpievaluationItem>();

    [InverseProperty("FkHrkpiregistration")]
    public virtual ICollection<HremployeeKpiregistrationItem> HremployeeKpiregistrationItems { get; set; } = new List<HremployeeKpiregistrationItem>();

    [InverseProperty("FkHrkpiregistration")]
    public virtual ICollection<HrkpievaluationItem> HrkpievaluationItems { get; set; } = new List<HrkpievaluationItem>();

    [InverseProperty("FkHrkpiregistration")]
    public virtual ICollection<Hrkpievaluation> Hrkpievaluations { get; set; } = new List<Hrkpievaluation>();

    [InverseProperty("FkHrkpiregistration")]
    public virtual ICollection<HrkpiregistrationItemTarget> HrkpiregistrationItemTargets { get; set; } = new List<HrkpiregistrationItemTarget>();

    [InverseProperty("FkHrkpiregistration")]
    public virtual ICollection<HrkpiregistrationItem> HrkpiregistrationItems { get; set; } = new List<HrkpiregistrationItem>();
}
