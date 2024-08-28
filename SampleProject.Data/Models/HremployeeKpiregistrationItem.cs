using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeKPIRegistrationItems")]
public partial class HremployeeKpiregistrationItem
{
    [Key]
    [Column("HREmployeeKPIRegistrationItemID")]
    public int HremployeeKpiregistrationItemId { get; set; }

    [Column("FK_HRKPIRegistrationID")]
    public int? FkHrkpiregistrationId { get; set; }

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

    [Column("HREmployeeKPIRegistrationItemNo")]
    [StringLength(50)]
    public string HremployeeKpiregistrationItemNo { get; set; }

    [Column("HREmployeeKPIRegistrationItemName")]
    [StringLength(256)]
    public string HremployeeKpiregistrationItemName { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeeKPIRegistrationItemTotalAmountBonus", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeKpiregistrationItemTotalAmountBonus { get; set; }

    public bool? IsExcessReward { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeeKpiregistrationItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeKpiregistrationItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeKpiregistrationItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrkpiregistrationId")]
    [InverseProperty("HremployeeKpiregistrationItems")]
    public virtual Hrkpiregistration FkHrkpiregistration { get; set; }

    [InverseProperty("FkHremployeeKpiregistrationItem")]
    public virtual ICollection<HremployeeKpievaluationItem> HremployeeKpievaluationItems { get; set; } = new List<HremployeeKpievaluationItem>();

    [InverseProperty("FkHremployeeKpiregistrationItem")]
    public virtual ICollection<HrkpiregistrationItem> HrkpiregistrationItems { get; set; } = new List<HrkpiregistrationItem>();
}
