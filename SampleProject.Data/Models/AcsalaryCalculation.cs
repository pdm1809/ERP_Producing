using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACSalaryCalculations")]
public partial class AcsalaryCalculation
{
    [Key]
    [Column("ACSalaryCalculationID")]
    public int AcsalaryCalculationId { get; set; }

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

    [Column("FK_ACSalaryDocumentTypeID")]
    public int? FkAcsalaryDocumentTypeId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Required]
    [Column("ACSalaryCalculationNo")]
    [StringLength(50)]
    public string AcsalaryCalculationNo { get; set; }

    [Column("ACSalaryCalculationName")]
    [StringLength(100)]
    public string AcsalaryCalculationName { get; set; }

    [Column("ACSalaryCalculationDesc")]
    [StringLength(1024)]
    public string AcsalaryCalculationDesc { get; set; }

    [Column("ACSalaryCalculationDate", TypeName = "datetime")]
    public DateTime AcsalaryCalculationDate { get; set; }

    [Column("ACSalaryCalculationReference")]
    [StringLength(50)]
    public string AcsalaryCalculationReference { get; set; }

    [Column("ACSalaryCalculationStatus")]
    [StringLength(50)]
    public string AcsalaryCalculationStatus { get; set; }

    [Column("ACSalaryCalculationExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcsalaryCalculationExchangeRate { get; set; }

    [Column("ACSalaryCalculationExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcsalaryCalculationExchangeAmount { get; set; }

    public bool? IsPosted { get; set; }

    [Column("ACSalaryCalculationPostingDate", TypeName = "datetime")]
    public DateTime? AcsalaryCalculationPostingDate { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("ACSalaryCalculationPostedStatus")]
    [StringLength(64)]
    public string AcsalaryCalculationPostedStatus { get; set; }

    [InverseProperty("FkAcsalaryCalculation")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; } = new List<AcsalaryCalculationDetail>();

    [ForeignKey("FkAcsalaryDocumentTypeId")]
    [InverseProperty("AcsalaryCalculations")]
    public virtual AcsalaryDocumentType FkAcsalaryDocumentType { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcsalaryCalculations")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcsalaryCalculations")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AcsalaryCalculations")]
    public virtual Hremployee FkHremployee { get; set; }
}
