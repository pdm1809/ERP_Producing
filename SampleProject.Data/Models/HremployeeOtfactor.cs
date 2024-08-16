using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeOTFactors")]
public partial class HremployeeOtfactor
{
    [Key]
    [Column("HREmployeeOTFactorID")]
    public int HremployeeOtfactorId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Required]
    [Column("HROTFactorType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrotfactorType { get; set; }

    [Column("HREmployeeOTFactorFromTime", TypeName = "datetime")]
    public DateTime? HremployeeOtfactorFromTime { get; set; }

    [Column("HREmployeeOTFactorToTime", TypeName = "datetime")]
    public DateTime? HremployeeOtfactorToTime { get; set; }

    [Column("HREmployeeOTFactorValue", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeOtfactorValue { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeOtfactors")]
    public virtual Hremployee FkHremployee { get; set; }
}
