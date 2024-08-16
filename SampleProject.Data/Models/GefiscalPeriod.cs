using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEFiscalPeriods")]
[Microsoft.EntityFrameworkCore.Index("GefiscalPeriodNo", Name = "Idx_GEFiscalPeriods")]
public partial class GefiscalPeriod
{
    [Key]
    [Column("GEFiscalPeriodID")]
    public int GefiscalPeriodId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GEFiscalYearID")]
    public int? FkGefiscalYearId { get; set; }

    [Column("GEFiscalPeriodNo")]
    [StringLength(50)]
    public string GefiscalPeriodNo { get; set; }

    [Column("GEFiscalPeriodDesc")]
    [StringLength(50)]
    public string GefiscalPeriodDesc { get; set; }

    [Column("GEFiscalPeriodDateFrom", TypeName = "datetime")]
    public DateTime? GefiscalPeriodDateFrom { get; set; }

    [Column("GEFiscalPeriodDateTo", TypeName = "datetime")]
    public DateTime? GefiscalPeriodDateTo { get; set; }

    [Column("GEFiscalPeriodStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string GefiscalPeriodStatus { get; set; }

    [ForeignKey("FkGefiscalYearId")]
    [InverseProperty("GefiscalPeriods")]
    public virtual GefiscalYear FkGefiscalYear { get; set; }
}
