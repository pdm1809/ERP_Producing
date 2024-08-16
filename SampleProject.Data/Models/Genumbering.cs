using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GENumbering")]
[Microsoft.EntityFrameworkCore.Index("FkBrbranchId", Name = "Idx_GENumbering")]
public partial class Genumbering
{
    [Key]
    [Column("GENumberingID")]
    public int GenumberingId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("GENumberingName")]
    [StringLength(50)]
    public string GenumberingName { get; set; }

    [Column("GENumberingPrefix")]
    [StringLength(50)]
    public string GenumberingPrefix { get; set; }

    [Column("GENumberingLength")]
    public int GenumberingLength { get; set; }

    [Column("GENumberingStart")]
    public int GenumberingStart { get; set; }

    /// <summary>
    /// 0:Auto
    /// 1:Manual
    /// </summary>
    [Column("GENumberingDesc")]
    [StringLength(255)]
    public string GenumberingDesc { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("GENumberingPrefixHaveYear")]
    public bool? GenumberingPrefixHaveYear { get; set; }

    [Column("GENumberingPrefixHaveMonth")]
    public bool? GenumberingPrefixHaveMonth { get; set; }

    [Column("GENumberingPrefixHaveDay")]
    public bool? GenumberingPrefixHaveDay { get; set; }

    [Column("GENumberingPrefixHaveStock")]
    public bool? GenumberingPrefixHaveStock { get; set; }

    [Column("GENumberingPrefixHaveBankAbbreviation")]
    public bool? GenumberingPrefixHaveBankAbbreviation { get; set; }

    [Column("GENumberingFormat")]
    [StringLength(50)]
    public string GenumberingFormat { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Genumberings")]
    public virtual Brbranch FkBrbranch { get; set; }
}
