using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACLoanReceiptTypes")]
public partial class AcloanReceiptType
{
    [Key]
    [Column("ACLoanReceiptTypeID")]
    public int AcloanReceiptTypeId { get; set; }

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

    [Column("ACLoanReceiptTypeNo")]
    [StringLength(64)]
    public string AcloanReceiptTypeNo { get; set; }

    [Required]
    [Column("ACLoanReceiptTypeNanme")]
    [StringLength(128)]
    public string AcloanReceiptTypeNanme { get; set; }

    [Column("ACLoanReceiptTypeActive")]
    public bool? AcloanReceiptTypeActive { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACAccountCostID")]
    public int? FkAcaccountCostId { get; set; }

    [Column("FK_ACAccountCostExpiredID")]
    public int? FkAcaccountCostExpiredId { get; set; }

    [InverseProperty("FkAcloanReceiptType")]
    public virtual ICollection<AcloanReceipt> AcloanReceipts { get; set; } = new List<AcloanReceipt>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcloanReceiptTypeFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcaccountCostId")]
    [InverseProperty("AcloanReceiptTypeFkAcaccountCosts")]
    public virtual Acaccount FkAcaccountCost { get; set; }

    [ForeignKey("FkAcaccountCostExpiredId")]
    [InverseProperty("AcloanReceiptTypeFkAcaccountCostExpireds")]
    public virtual Acaccount FkAcaccountCostExpired { get; set; }
}
