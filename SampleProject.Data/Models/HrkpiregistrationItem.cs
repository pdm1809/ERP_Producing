using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRKPIRegistrationItems")]
public partial class HrkpiregistrationItem
{
    [Key]
    [Column("HRKPIRegistrationItemID")]
    public int HrkpiregistrationItemId { get; set; }

    [Column("FK_HRKPIRegistrationID")]
    public int? FkHrkpiregistrationId { get; set; }

    [Column("FK_HRKPIFormID")]
    public int? FkHrkpiformId { get; set; }

    [Column("FK_HRKPIFormItemID")]
    public int? FkHrkpiformItemId { get; set; }

    [Column("FK_HRKPIID")]
    public int? FkHrkpiid { get; set; }

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

    [Required]
    [Column("HRKPIRegistrationItemName")]
    [StringLength(256)]
    public string HrkpiregistrationItemName { get; set; }

    [Column("HRKPIRegistrationItemMeasurementMethod")]
    [StringLength(256)]
    public string HrkpiregistrationItemMeasurementMethod { get; set; }

    [Column("HRKPIRegistrationItemWeight", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiregistrationItemWeight { get; set; }

    [Column("HRKPIRegistrationItemWeightBouns", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiregistrationItemWeightBouns { get; set; }

    [Column("HRKPIRegistrationItemTarget", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiregistrationItemTarget { get; set; }

    [Column("HRKPIRegistrationItemGeneralTarget", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiregistrationItemGeneralTarget { get; set; }

    [Column("FK_HREmployeeKPIRegistrationItemID")]
    public int? FkHremployeeKpiregistrationItemId { get; set; }

    public bool? IsReverseTarget { get; set; }

    [Column("HRKPIRegistrationItemGuide")]
    [StringLength(256)]
    public string HrkpiregistrationItemGuide { get; set; }

    [ForeignKey("FkHremployeeKpiregistrationItemId")]
    [InverseProperty("HrkpiregistrationItems")]
    public virtual HremployeeKpiregistrationItem FkHremployeeKpiregistrationItem { get; set; }

    [ForeignKey("FkHrkpiid")]
    [InverseProperty("HrkpiregistrationItems")]
    public virtual Hrkpi FkHrkpi { get; set; }

    [ForeignKey("FkHrkpiformId")]
    [InverseProperty("HrkpiregistrationItems")]
    public virtual Hrkpiform FkHrkpiform { get; set; }

    [ForeignKey("FkHrkpiformItemId")]
    [InverseProperty("HrkpiregistrationItems")]
    public virtual HrkpiformItem FkHrkpiformItem { get; set; }

    [ForeignKey("FkHrkpiregistrationId")]
    [InverseProperty("HrkpiregistrationItems")]
    public virtual Hrkpiregistration FkHrkpiregistration { get; set; }

    [InverseProperty("FkHrkpiregistrationItem")]
    public virtual ICollection<HrkpievaluationItem> HrkpievaluationItems { get; set; } = new List<HrkpievaluationItem>();
}
