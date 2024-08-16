using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADInsurrances")]
public partial class Adinsurrance
{
    [Key]
    [Column("ADInsurranceID")]
    public int AdinsurranceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADInsurranceNo")]
    [StringLength(512)]
    public string AdinsurranceNo { get; set; }

    [Column("ADInsurranceName")]
    [StringLength(512)]
    public string AdinsurranceName { get; set; }

    [Column("ADInsurranceDesc")]
    [StringLength(512)]
    public string AdinsurranceDesc { get; set; }

    [Column("HRInsurranceSocialInsPercentDN", TypeName = "decimal(18, 5)")]
    public decimal? HrinsurranceSocialInsPercentDn { get; set; }

    [Column("HRInsurranceHealthInsPercentDN", TypeName = "decimal(18, 5)")]
    public decimal? HrinsurranceHealthInsPercentDn { get; set; }

    [Column("HRInsurranceOutOfWorkInsPercentDN", TypeName = "decimal(18, 5)")]
    public decimal? HrinsurranceOutOfWorkInsPercentDn { get; set; }

    [Column("HRInsurranceSocialInsPercent", TypeName = "decimal(18, 5)")]
    public decimal? HrinsurranceSocialInsPercent { get; set; }

    [Column("HRInsurranceHealthInsPercent", TypeName = "decimal(18, 5)")]
    public decimal? HrinsurranceHealthInsPercent { get; set; }

    [Column("HRInsurranceOutOfWorkInsPercent", TypeName = "decimal(18, 5)")]
    public decimal? HrinsurranceOutOfWorkInsPercent { get; set; }

    [Column("ADInsurranceLevelNotTaxable", TypeName = "decimal(18, 5)")]
    public decimal? AdinsurranceLevelNotTaxable { get; set; }

    [Column("ADInsurranceDependencyLevel", TypeName = "decimal(18, 5)")]
    public decimal? AdinsurranceDependencyLevel { get; set; }

    [Column("ADInsurranceSyndicatePaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? AdinsurranceSyndicatePaymentPercent { get; set; }
}
