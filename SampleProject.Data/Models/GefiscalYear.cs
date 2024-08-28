using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEFiscalYears")]
[Microsoft.EntityFrameworkCore.Index("GefiscalYearNo", Name = "Idx_GEFiscalYears")]
public partial class GefiscalYear
{
    [Key]
    [Column("GEFiscalYearID")]
    public int GefiscalYearId { get; set; }

    [Column("AAStatus")]
    [StringLength(20)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("GEFiscalYearNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string GefiscalYearNo { get; set; }

    [Column("GEFiscalYearName")]
    [StringLength(50)]
    public string GefiscalYearName { get; set; }

    [Column("GEFiscalYearActiveCheck")]
    public bool? GefiscalYearActiveCheck { get; set; }

    [InverseProperty("FkGefiscalYear")]
    public virtual ICollection<GefiscalPeriod> GefiscalPeriods { get; set; } = new List<GefiscalPeriod>();
}
