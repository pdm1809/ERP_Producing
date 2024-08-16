using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCancelAllocationProposals")]
public partial class MmcancelAllocationProposal
{
    [Key]
    [Column("MMCancelAllocationProposalID")]
    public int MmcancelAllocationProposalId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_MMAllocationProposalID")]
    public int? FkMmallocationProposalId { get; set; }

    [Required]
    [Column("MMCancelAllocationProposalNo")]
    [StringLength(50)]
    public string MmcancelAllocationProposalNo { get; set; }

    [Column("MMCancelAllocationProposalDesc")]
    [StringLength(512)]
    public string MmcancelAllocationProposalDesc { get; set; }

    [Column("MMCancelAllocationProposalDate", TypeName = "datetime")]
    public DateTime MmcancelAllocationProposalDate { get; set; }

    [Column("MMCancelAllocationProposalApprovedDate", TypeName = "datetime")]
    public DateTime? MmcancelAllocationProposalApprovedDate { get; set; }

    [Column("MMCancelAllocationProposalApprovedEmployee")]
    public int? MmcancelAllocationProposalApprovedEmployee { get; set; }

    [Column("MMCancelAllocationProposalStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmcancelAllocationProposalStatus { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmcancelAllocationProposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmcancelAllocationProposalFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("MmcancelAllocationProposals")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("MmcancelAllocationProposalApprovedEmployee")]
    [InverseProperty("MmcancelAllocationProposalMmcancelAllocationProposalApprovedEmployeeNavigations")]
    public virtual Hremployee MmcancelAllocationProposalApprovedEmployeeNavigation { get; set; }

    [InverseProperty("FkMmcancelAllocationProposal")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();
}
