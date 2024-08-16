using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACLoanReceiptItems")]
public partial class AcloanReceiptItem
{
    [Key]
    [Column("ACLoanReceiptItemID")]
    public int AcloanReceiptItemId { get; set; }

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

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACLoanReceiptItemComment")]
    [StringLength(512)]
    public string AcloanReceiptItemComment { get; set; }

    [Column("ACLoanReceiptItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptItemTotalAmount { get; set; }

    [Column("ACLoanReceiptItemDocumentNo")]
    [StringLength(50)]
    public string AcloanReceiptItemDocumentNo { get; set; }

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("ACLoanReceiptItemDocumentDate", TypeName = "datetime")]
    public DateTime? AcloanReceiptItemDocumentDate { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcloanReceiptItems")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcloanReceiptId")]
    [InverseProperty("AcloanReceiptItems")]
    public virtual AcloanReceipt FkAcloanReceipt { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcloanReceiptItems")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcloanReceiptItems")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
