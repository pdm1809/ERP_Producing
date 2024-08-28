using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("update_Hopdongvay")]
public partial class UpdateHopdongvay
{
    [Column("ACLoanAgreementNo")]
    [StringLength(50)]
    public string AcloanAgreementNo { get; set; }

    [Column("ACLoanAgreementDate", TypeName = "datetime")]
    public DateTime? AcloanAgreementDate { get; set; }

    [Column("ACLoanAgreementDeadline", TypeName = "datetime")]
    public DateTime? AcloanAgreementDeadline { get; set; }

    [Column("ACLoanAgreementAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanAgreementAmount { get; set; }

    [Column("ACLoanAgreementAmountVay", TypeName = "decimal(18, 5)")]
    public decimal? AcloanAgreementAmountVay { get; set; }

    [Column("ACLoanAgreementReceiptAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanAgreementReceiptAmount { get; set; }

    [Column("ACLoanAgreementRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcloanAgreementRemainAmount { get; set; }

    [StringLength(50)]
    public string LoaiTien { get; set; }
}
