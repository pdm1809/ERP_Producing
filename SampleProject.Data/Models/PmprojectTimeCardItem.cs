using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectTimeCardItems")]
public partial class PmprojectTimeCardItem
{
    [Key]
    [Column("PMProjectTimeCardItemID")]
    public int PmprojectTimeCardItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_PMProjectID")]
    public int FkPmprojectId { get; set; }

    [Column("FK_PMProjectPhaseID")]
    public int FkPmprojectPhaseId { get; set; }

    [Column("PMProjectTimeCardItemStartDate", TypeName = "datetime")]
    public DateTime? PmprojectTimeCardItemStartDate { get; set; }

    [Column("PMProjectTimeCardItemEndDate", TypeName = "datetime")]
    public DateTime? PmprojectTimeCardItemEndDate { get; set; }

    [Column("PMProjectTimeCardItemStartTime", TypeName = "datetime")]
    public DateTime? PmprojectTimeCardItemStartTime { get; set; }

    [Column("PMProjectTimeCardItemEndTime", TypeName = "datetime")]
    public DateTime? PmprojectTimeCardItemEndTime { get; set; }

    [Column("PMProjectTimeCardItemUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectTimeCardItemUnitCost { get; set; }

    [Column("PMProjectTimeCardItemTotalDays")]
    public int? PmprojectTimeCardItemTotalDays { get; set; }

    [Column("PMProjectTimeCardItemTotalHours")]
    public int? PmprojectTimeCardItemTotalHours { get; set; }

    [Column("PMProjectTimeCardItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectTimeCardItemTotalCost { get; set; }
}
