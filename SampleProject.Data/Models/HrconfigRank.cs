using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRConfigRanks")]
public partial class HrconfigRank
{
    [Key]
    [Column("HRConfigRankID")]
    public int HrconfigRankId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("HRConfigRankNo")]
    [StringLength(50)]
    public string HrconfigRankNo { get; set; }

    [Required]
    [Column("HRConfigRankName")]
    [StringLength(256)]
    public string HrconfigRankName { get; set; }

    [Column("HRConfigRankDesc")]
    [StringLength(512)]
    public string HrconfigRankDesc { get; set; }

    [Column("HRConfigRankWorkingSalary", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigRankWorkingSalary { get; set; }

    [Column("HRConfigRankSocialIns", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigRankSocialIns { get; set; }

    public bool? IsUpdate { get; set; }

    [Column("FK_HRConfigScaleID")]
    public int? FkHrconfigScaleId { get; set; }

    [ForeignKey("FkHrconfigScaleId")]
    [InverseProperty("HrconfigRanks")]
    public virtual HrconfigScale FkHrconfigScale { get; set; }

    [InverseProperty("FkHrconfigRank")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();
}
