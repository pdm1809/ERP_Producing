using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBusinessResultDetails")]
public partial class AcbusinessResultDetail
{
    [Key]
    [Column("ACBusinessResultDetailID")]
    public int AcbusinessResultDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACBusinessResultID")]
    public int? FkAcbusinessResultId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ACBusinessResultDetailAcountNumber")]
    [StringLength(10)]
    public string AcbusinessResultDetailAcountNumber { get; set; }

    [Column("ACBusinessResultDetailAcountName")]
    [StringLength(200)]
    public string AcbusinessResultDetailAcountName { get; set; }

    [Column("ACBusinessResultDetailDesc")]
    [StringLength(200)]
    public string AcbusinessResultDetailDesc { get; set; }

    [Column("ACBusinessResultDetailStartPeriodBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbusinessResultDetailStartPeriodBalance { get; set; }

    [Column("ACBusinessResultDetailEndPeriodBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcbusinessResultDetailEndPeriodBalance { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcbusinessResultDetails")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcbusinessResultId")]
    [InverseProperty("AcbusinessResultDetails")]
    public virtual AcbusinessResult FkAcbusinessResult { get; set; }
}
