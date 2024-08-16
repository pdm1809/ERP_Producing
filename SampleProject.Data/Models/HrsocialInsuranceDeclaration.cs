using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRSocialInsuranceDeclarations")]
[Microsoft.EntityFrameworkCore.Index("HrsocialInsuranceDeclarationNo", "HrsocialInsuranceDeclarationDate", "FkBrbranchId", "FkHremployeeId", "HrsocialInsuranceDeclarationType", Name = "Idx_HRSocialInsuranceDeclarations")]
public partial class HrsocialInsuranceDeclaration
{
    [Key]
    [Column("HRSocialInsuranceDeclarationID")]
    public int HrsocialInsuranceDeclarationId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("HRSocialInsuranceDeclarationNo")]
    [StringLength(50)]
    public string HrsocialInsuranceDeclarationNo { get; set; }

    [Required]
    [Column("HRSocialInsuranceDeclarationName")]
    [StringLength(50)]
    public string HrsocialInsuranceDeclarationName { get; set; }

    [Column("HRSocialInsuranceDeclarationDesc")]
    [StringLength(512)]
    public string HrsocialInsuranceDeclarationDesc { get; set; }

    [Column("HRSocialInsuranceDeclarationDate", TypeName = "datetime")]
    public DateTime HrsocialInsuranceDeclarationDate { get; set; }

    [Column("HRSocialInsuranceDeclarationStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrsocialInsuranceDeclarationStatus { get; set; }

    [Column("HRSocialInsuranceDeclarationType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrsocialInsuranceDeclarationType { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrsocialInsuranceDeclarations")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrsocialInsuranceDeclarations")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrsocialInsuranceDeclaration")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();
}
