using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeKPIEvaluationItems")]
public partial class HremployeeKpievaluationItem
{
    [Key]
    [Column("HREmployeeKPIEvaluationItemID")]
    public int HremployeeKpievaluationItemId { get; set; }

    [Column("FK_HRKPIEvaluationID")]
    public int? FkHrkpievaluationId { get; set; }

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

    [Column("HREmployeeKPIEvaluationItemNo")]
    [StringLength(50)]
    public string HremployeeKpievaluationItemNo { get; set; }

    [Column("HREmployeeKPIEvaluationItemName")]
    [StringLength(256)]
    public string HremployeeKpievaluationItemName { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeKPIRegistrationItemID")]
    public int? FkHremployeeKpiregistrationItemId { get; set; }

    [Column("FK_HRKPIRegistrationID")]
    public int? FkHrkpiregistrationId { get; set; }

    [Column("HREmployeeKPIEvaluationItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeKpievaluationItemTotalAmount { get; set; }

    [Column("HREmployeeKPIEvaluationItemTotalAmountBonus", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeKpievaluationItemTotalAmountBonus { get; set; }

    public bool? IsExcessReward { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeeKpievaluationItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeKpievaluationItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeKpievaluationItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeKpiregistrationItemId")]
    [InverseProperty("HremployeeKpievaluationItems")]
    public virtual HremployeeKpiregistrationItem FkHremployeeKpiregistrationItem { get; set; }

    [ForeignKey("FkHrkpievaluationId")]
    [InverseProperty("HremployeeKpievaluationItems")]
    public virtual Hrkpievaluation FkHrkpievaluation { get; set; }

    [ForeignKey("FkHrkpiregistrationId")]
    [InverseProperty("HremployeeKpievaluationItems")]
    public virtual Hrkpiregistration FkHrkpiregistration { get; set; }

    [InverseProperty("FkHremployeeKpievaluationItem")]
    public virtual ICollection<HrkpievaluationItem> HrkpievaluationItems { get; set; } = new List<HrkpievaluationItem>();
}
