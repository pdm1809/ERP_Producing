using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRSalaryEvaluations")]
public partial class HrsalaryEvaluation
{
    [Key]
    [Column("HRSalaryEvaluationID")]
    public int HrsalaryEvaluationId { get; set; }

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

    [Column("HRSalaryEvaluationNo")]
    [StringLength(256)]
    public string HrsalaryEvaluationNo { get; set; }

    [Column("HRSalaryEvaluationName")]
    [StringLength(256)]
    public string HrsalaryEvaluationName { get; set; }

    [Column("HRSalaryEvaluationDate", TypeName = "datetime")]
    public DateTime? HrsalaryEvaluationDate { get; set; }

    [Column("HRSalaryEvaluationPeriodType")]
    [StringLength(256)]
    public string HrsalaryEvaluationPeriodType { get; set; }

    [Column("HRSalaryEvaluationStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrsalaryEvaluationStatus { get; set; }

    [Column("HRSalaryEvaluationDesc")]
    [StringLength(256)]
    public string HrsalaryEvaluationDesc { get; set; }

    [Column("HRSalaryEvaluationSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HrsalaryEvaluationSlrAmt { get; set; }

    [Column("HRSalaryEvaluationWorkingSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HrsalaryEvaluationWorkingSlrAmt { get; set; }
}
