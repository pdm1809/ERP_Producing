using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADOTFactors")]
[Microsoft.EntityFrameworkCore.Index("AdotfactorType", Name = "Idx_ADOTFactors")]
public partial class Adotfactor
{
    [Key]
    [Column("ADOTFactorID")]
    public int AdotfactorId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ADOTFactorName")]
    [StringLength(150)]
    public string AdotfactorName { get; set; }

    [Required]
    [Column("ADOTFactorType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdotfactorType { get; set; }

    [Column("ADOTFactorFromTime", TypeName = "datetime")]
    public DateTime? AdotfactorFromTime { get; set; }

    [Column("ADOTFactorToTime", TypeName = "datetime")]
    public DateTime? AdotfactorToTime { get; set; }

    [Column("ADOTFactorValue", TypeName = "decimal(18, 5)")]
    public decimal? AdotfactorValue { get; set; }
}
