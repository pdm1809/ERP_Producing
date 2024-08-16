using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPaymentProposalApprovals")]
public partial class AppaymentProposalApproval
{
    [Key]
    [Column("APPaymentProposalApprovalID")]
    public int AppaymentProposalApprovalId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APPaymentProposalID")]
    public int FkAppaymentProposalId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("APPaymentProposalApprovalDate", TypeName = "datetime")]
    public DateTime? AppaymentProposalApprovalDate { get; set; }

    [Column("APPaymentProposalApprovalAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentProposalApprovalAction { get; set; }

    [Column("APPaymentProposalApprovalMessages")]
    public string AppaymentProposalApprovalMessages { get; set; }
}
