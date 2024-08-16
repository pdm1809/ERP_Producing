using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACLoanReceiptInterestRateChanges")]
public partial class AcloanReceiptInterestRateChange
{
    [Key]
    [Column("ACLoanReceiptInterestRateChangeID")]
    public int AcloanReceiptInterestRateChangeId { get; set; }

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

    [Column("FK_ACLoanReceiptID")]
    public int? FkAcloanReceiptId { get; set; }

    [Column("ACLoanReceiptInterestRateChangeValue", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptInterestRateChangeValue { get; set; }

    [Column("ACLoanReceiptInterestRateChangeStartPeriodChange")]
    public int? AcloanReceiptInterestRateChangeStartPeriodChange { get; set; }

    [Column("ACLoanReceiptInterestRateChangeDesc")]
    [StringLength(512)]
    public string AcloanReceiptInterestRateChangeDesc { get; set; }

    [ForeignKey("FkAcloanReceiptId")]
    [InverseProperty("AcloanReceiptInterestRateChanges")]
    public virtual AcloanReceipt FkAcloanReceipt { get; set; }
}
