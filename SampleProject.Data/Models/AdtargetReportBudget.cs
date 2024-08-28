using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADTargetReportBudgets")]
public partial class AdtargetReportBudget
{
    [Key]
    [Column("ADTargetReportBudgetID")]
    public int AdtargetReportBudgetId { get; set; }

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

    [Column("ADTargetReportBudgetNo")]
    [StringLength(50)]
    public string AdtargetReportBudgetNo { get; set; }

    [Column("ADTargetReportBudgetName")]
    [StringLength(256)]
    public string AdtargetReportBudgetName { get; set; }

    [Column("ADTargetReportBudgetEnglish")]
    [StringLength(256)]
    public string AdtargetReportBudgetEnglish { get; set; }

    [Column("ADTargetReportBudgetIsShowPrint")]
    public bool? AdtargetReportBudgetIsShowPrint { get; set; }

    [Column("ADTargetReportBudgetIsBold")]
    public bool? AdtargetReportBudgetIsBold { get; set; }

    [Column("ADTargetReportBudgetType")]
    [StringLength(50)]
    public string AdtargetReportBudgetType { get; set; }

    [Column("ADTargetReportBudgetFormula")]
    [StringLength(256)]
    public string AdtargetReportBudgetFormula { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("ICProductIsShowDetail")]
    public bool? IcproductIsShowDetail { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("ADCostBudgetType")]
    [StringLength(64)]
    public string AdcostBudgetType { get; set; }

    [Column("ADTargetReportBudgetProfitType")]
    [StringLength(100)]
    public string AdtargetReportBudgetProfitType { get; set; }

    [InverseProperty("FkAdtargetReportBudget")]
    public virtual ICollection<Acsegment> Acsegments { get; set; } = new List<Acsegment>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AdtargetReportBudgets")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AdtargetReportBudgetFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AdtargetReportBudgetFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AdtargetReportBudgets")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AdtargetReportBudgets")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }
}
