using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACLoanReceiptPaymentPlans")]
public partial class AcloanReceiptPaymentPlan
{
    [Key]
    [Column("ACLoanReceiptPaymentPlanID")]
    public int AcloanReceiptPaymentPlanId { get; set; }

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

    [Column("ACLoanReceiptPaymentPlanPeriod")]
    [StringLength(64)]
    public string AcloanReceiptPaymentPlanPeriod { get; set; }

    [Column("ACLoanReceiptPaymentPlanDate", TypeName = "datetime")]
    public DateTime? AcloanReceiptPaymentPlanDate { get; set; }

    [Column("ACLoanReceiptPaymentPlanOpeningBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaymentPlanOpeningBalance { get; set; }

    [Column("ACLoanReceiptPaymentPlanRootPayment", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaymentPlanRootPayment { get; set; }

    [Column("ACLoanReceiptPaymentPlanProfitsPayment", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaymentPlanProfitsPayment { get; set; }

    [Column("ACLoanReceiptPaymentPlanPayment", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaymentPlanPayment { get; set; }

    [Column("ACLoanReceiptPaymentPlanBeginDate", TypeName = "datetime")]
    public DateTime? AcloanReceiptPaymentPlanBeginDate { get; set; }

    [Column("ACLoanReceiptPaymentPlanEndDate", TypeName = "datetime")]
    public DateTime? AcloanReceiptPaymentPlanEndDate { get; set; }

    [Column("ACLoanReceiptPaymentDay", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaymentDay { get; set; }

    [Column("ACLoanReceiptPaymentPlanActualPaymentDate", TypeName = "datetime")]
    public DateTime? AcloanReceiptPaymentPlanActualPaymentDate { get; set; }

    [Column("ACLoanReceiptPaymentPlanActualRootPayment", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaymentPlanActualRootPayment { get; set; }

    [Column("ACLoanReceiptPaymentPlanActialProfitsPayment", TypeName = "decimal(18, 5)")]
    public decimal? AcloanReceiptPaymentPlanActialProfitsPayment { get; set; }

    [InverseProperty("FkAcloanReceiptPaymentPlan")]
    public virtual ICollection<AcbankTransaction> AcbankTransactions { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkAcloanReceiptPaymentPlan")]
    public virtual ICollection<AppaymentVoucher> AppaymentVouchers { get; set; } = new List<AppaymentVoucher>();

    [ForeignKey("FkAcloanReceiptId")]
    [InverseProperty("AcloanReceiptPaymentPlans")]
    public virtual AcloanReceipt FkAcloanReceipt { get; set; }
}
