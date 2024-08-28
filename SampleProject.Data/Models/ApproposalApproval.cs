using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APProposalApprovals")]
public partial class ApproposalApproval
{
    [Key]
    [Column("APProposalApprovalID")]
    public int ApproposalApprovalId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APProposalID")]
    public int FkApproposalId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("APProposalApprovalDate", TypeName = "datetime")]
    public DateTime? ApproposalApprovalDate { get; set; }

    [Column("APProposalApprovalAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApproposalApprovalAction { get; set; }

    [Column("APProposalApprovalMessages")]
    public string ApproposalApprovalMessages { get; set; }
}
