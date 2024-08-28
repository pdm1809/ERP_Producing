using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACLoanReceiptPayDocs")]
public partial class AcloanReceiptPayDoc
{
    [Key]
    [Column("ACLoanReceiptPayDocID")]
    public int AcloanReceiptPayDocId { get; set; }

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

    [Column("FK_ACLoanReceiptID")]
    public int FkAcloanReceiptId { get; set; }

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACLoanReceiptPayDocComment")]
    [StringLength(512)]
    public string AcloanReceiptPayDocComment { get; set; }

    [Column("ACLoanReceiptPayDocTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPayDocTotalAmount { get; set; }

    [Column("ACLoanReceiptPayDocsDebtRootPaid", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPayDocsDebtRootPaid { get; set; }

    [Column("ACLoanReceiptPayDocsInterestPaid", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPayDocsInterestPaid { get; set; }

    [Column("ACLoanReceiptPayDocsPenaltyPaid", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPayDocsPenaltyPaid { get; set; }

    [Column("ACLoanReceiptPayDocNo")]
    [StringLength(50)]
    public string AcloanReceiptPayDocNo { get; set; }

    [Column("ACLoanReceiptPayDocDate", TypeName = "datetime")]
    public DateTime? AcloanReceiptPayDocDate { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcloanReceiptPayDocs")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcloanReceiptId")]
    [InverseProperty("AcloanReceiptPayDocs")]
    public virtual AcloanReceipt FkAcloanReceipt { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcloanReceiptPayDocs")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcloanReceiptPayDocs")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
