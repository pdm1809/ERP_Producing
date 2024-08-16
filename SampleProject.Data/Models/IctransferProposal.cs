using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICTransferProposals")]
public partial class IctransferProposal
{
    [Key]
    [Column("ICTransferProposalID")]
    public int IctransferProposalId { get; set; }

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
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICFromStockID")]
    public int FkIcfromStockId { get; set; }

    [Column("FK_ICToStockID")]
    public int FkIctoStockId { get; set; }

    [Column("FK_ICTransitStockID")]
    public int? FkIctransitStockId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("ICTransferProposalNo")]
    [StringLength(50)]
    public string IctransferProposalNo { get; set; }

    [Column("ICTransferProposalName")]
    [StringLength(100)]
    public string IctransferProposalName { get; set; }

    [Column("ICTransferProposalDesc")]
    [StringLength(512)]
    public string IctransferProposalDesc { get; set; }

    [Column("ICTransferProposalDate", TypeName = "datetime")]
    public DateTime? IctransferProposalDate { get; set; }

    [Column("ICTransferProposalExpiredDate", TypeName = "datetime")]
    public DateTime? IctransferProposalExpiredDate { get; set; }

    [Column("ICTransferProposalReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferProposalReference { get; set; }

    [Column("ICTransferProposalType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferProposalType { get; set; }

    [Column("ICTransferProposalStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferProposalStatus { get; set; }

    [Column("ICTransferProposalValidDate", TypeName = "datetime")]
    public DateTime? IctransferProposalValidDate { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IctransferProposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IctransferProposals")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcfromStockId")]
    [InverseProperty("IctransferProposalFkIcfromStocks")]
    public virtual Icstock FkIcfromStock { get; set; }

    [ForeignKey("FkIctoStockId")]
    [InverseProperty("IctransferProposalFkIctoStocks")]
    public virtual Icstock FkIctoStock { get; set; }

    [ForeignKey("FkIctransitStockId")]
    [InverseProperty("IctransferProposalFkIctransitStocks")]
    public virtual Icstock FkIctransitStock { get; set; }

    [InverseProperty("FkIctransferProposal")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItems { get; set; } = new List<IctransferProposalItem>();
}
