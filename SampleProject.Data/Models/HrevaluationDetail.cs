using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREvaluationDetails")]
[Microsoft.EntityFrameworkCore.Index("FkHremployeeId", Name = "Idx_HREvaluationDetails")]
public partial class HrevaluationDetail
{
    [Key]
    [Column("HREvaluationDetailID")]
    public int HrevaluationDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREvaluationID")]
    public int FkHrevaluationId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HREvaluationStandardID")]
    public int FkHrevaluationStandardId { get; set; }

    [Column("HREvaluationDetailResult", TypeName = "decimal(18, 5)")]
    public decimal? HrevaluationDetailResult { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrevaluationDetails")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrevaluationId")]
    [InverseProperty("HrevaluationDetails")]
    public virtual Hrevaluation FkHrevaluation { get; set; }

    [ForeignKey("FkHrevaluationStandardId")]
    [InverseProperty("HrevaluationDetails")]
    public virtual HrevaluationStandard FkHrevaluationStandard { get; set; }
}
