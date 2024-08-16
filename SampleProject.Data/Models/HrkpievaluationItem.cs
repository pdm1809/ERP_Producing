using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRKPIEvaluationItems")]
public partial class HrkpievaluationItem
{
    [Key]
    [Column("HRKPIEvaluationItemID")]
    public int HrkpievaluationItemId { get; set; }

    [Column("FK_HRKPIEvaluationID")]
    public int? FkHrkpievaluationId { get; set; }

    [Column("FK_HRKPIFormID")]
    public int? FkHrkpiformId { get; set; }

    [Column("FK_HRKPIFormItemID")]
    public int? FkHrkpiformItemId { get; set; }

    [Column("FK_HRKPIID")]
    public int? FkHrkpiid { get; set; }

    [Column("FK_HRKPIRegistrationID")]
    public int? FkHrkpiregistrationId { get; set; }

    [Column("FK_HRKPIRegistrationItemID")]
    public int? FkHrkpiregistrationItemId { get; set; }

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
    [Column("HRKPIEvaluationItemName")]
    [StringLength(256)]
    public string HrkpievaluationItemName { get; set; }

    [Column("HRKPIEvaluationItemMeasurementMethod")]
    [StringLength(256)]
    public string HrkpievaluationItemMeasurementMethod { get; set; }

    [Column("HRKPIEvaluationItemWeight", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemWeight { get; set; }

    [Column("HRKPIEvaluationItemWeightBouns", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemWeightBouns { get; set; }

    [Column("HRKPIEvaluationItemPercentComplete", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemPercentComplete { get; set; }

    [Column("HRKPIEvaluationItemAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemAmount { get; set; }

    [Column("HRKPIEvaluationItemTarget", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemTarget { get; set; }

    [Column("HRKPIEvaluationItemResult", TypeName = "decimal(18, 5)")]
    public decimal? HrkpievaluationItemResult { get; set; }

    public bool? IsReverseTarget { get; set; }

    [Column("FK_HREmployeeKPIEvaluationItemID")]
    public int? FkHremployeeKpievaluationItemId { get; set; }

    [Column("HRKPIEvaluationItemGuide")]
    [StringLength(256)]
    public string HrkpievaluationItemGuide { get; set; }

    [ForeignKey("FkHremployeeKpievaluationItemId")]
    [InverseProperty("HrkpievaluationItems")]
    public virtual HremployeeKpievaluationItem FkHremployeeKpievaluationItem { get; set; }

    [ForeignKey("FkHrkpiid")]
    [InverseProperty("HrkpievaluationItems")]
    public virtual Hrkpi FkHrkpi { get; set; }

    [ForeignKey("FkHrkpievaluationId")]
    [InverseProperty("HrkpievaluationItems")]
    public virtual Hrkpievaluation FkHrkpievaluation { get; set; }

    [ForeignKey("FkHrkpiformId")]
    [InverseProperty("HrkpievaluationItems")]
    public virtual Hrkpiform FkHrkpiform { get; set; }

    [ForeignKey("FkHrkpiformItemId")]
    [InverseProperty("HrkpievaluationItems")]
    public virtual HrkpiformItem FkHrkpiformItem { get; set; }

    [ForeignKey("FkHrkpiregistrationId")]
    [InverseProperty("HrkpievaluationItems")]
    public virtual Hrkpiregistration FkHrkpiregistration { get; set; }

    [ForeignKey("FkHrkpiregistrationItemId")]
    [InverseProperty("HrkpievaluationItems")]
    public virtual HrkpiregistrationItem FkHrkpiregistrationItem { get; set; }
}
