using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACLoanAgreements")]
public partial class AcloanAgreement
{
    [Key]
    [Column("ACLoanAgreementID")]
    public int AcloanAgreementId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int FkCscompanyBankId { get; set; }

    [Required]
    [Column("ACLoanAgreementNo")]
    [StringLength(50)]
    public string AcloanAgreementNo { get; set; }

    [Column("ACLoanAgreementDesc")]
    [StringLength(512)]
    public string AcloanAgreementDesc { get; set; }

    [Column("ACLoanAgreementDate", TypeName = "datetime")]
    public DateTime? AcloanAgreementDate { get; set; }

    [Column("ACLoanAgreementDeadline", TypeName = "datetime")]
    public DateTime? AcloanAgreementDeadline { get; set; }

    [Column("ACLoanAgreementAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanAgreementAmount { get; set; }

    [Column("ACLoanAgreementReceiptAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanAgreementReceiptAmount { get; set; }

    [Column("ACLoanAgreementRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanAgreementRemainAmount { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ACLoanAgreementTotalLimit", TypeName = "decimal(18, 5)")]
    public decimal? AcloanAgreementTotalLimit { get; set; }

    [Column("ACLoanAgreementLCLimit", TypeName = "decimal(18, 5)")]
    public decimal? AcloanAgreementLclimit { get; set; }

    [InverseProperty("FkAcloanAgreement")]
    public virtual ICollection<AcloanReceipt> AcloanReceipts { get; set; } = new List<AcloanReceipt>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcloanAgreements")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("AcloanAgreements")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcloanAgreements")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcloanAgreements")]
    public virtual Pmproject FkPmproject { get; set; }
}
