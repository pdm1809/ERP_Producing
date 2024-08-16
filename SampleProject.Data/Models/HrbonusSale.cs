using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRBonusSales")]
public partial class HrbonusSale
{
    [Key]
    [Column("HRBonusSaleID")]
    public int HrbonusSaleId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Required]
    [Column("HRBonusSaleNo")]
    [StringLength(50)]
    public string HrbonusSaleNo { get; set; }

    [Required]
    [Column("HRBonusSaleName")]
    [StringLength(100)]
    public string HrbonusSaleName { get; set; }

    [Column("HRBonusSaleDesc")]
    [StringLength(512)]
    public string HrbonusSaleDesc { get; set; }

    [Column("HRBonusSaleDate", TypeName = "datetime")]
    public DateTime? HrbonusSaleDate { get; set; }

    [Column("HRBonusSaleFromDate", TypeName = "datetime")]
    public DateTime HrbonusSaleFromDate { get; set; }

    [Column("HRBonusSaleToDate", TypeName = "datetime")]
    public DateTime HrbonusSaleToDate { get; set; }

    [Column("HRBonusSaleStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrbonusSaleStatus { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrbonusSales")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrbonusSales")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrbonusSale")]
    public virtual ICollection<HrbonusSaleItem> HrbonusSaleItems { get; set; } = new List<HrbonusSaleItem>();
}
