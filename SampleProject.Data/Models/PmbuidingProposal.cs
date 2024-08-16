using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMBuidingProposals")]
public partial class PmbuidingProposal
{
    [Key]
    [Column("PMBuidingProposalID")]
    public int PmbuidingProposalId { get; set; }

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

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("PMBuidingProposalNo")]
    [StringLength(50)]
    public string PmbuidingProposalNo { get; set; }

    [Column("PMBuidingProposalName")]
    [StringLength(100)]
    public string PmbuidingProposalName { get; set; }

    [Column("PMBuidingProposalDesc")]
    [StringLength(512)]
    public string PmbuidingProposalDesc { get; set; }

    [Column("PMBuidingProposalComment")]
    [StringLength(512)]
    public string PmbuidingProposalComment { get; set; }

    [Column("PMBuidingProposalDate", TypeName = "datetime")]
    public DateTime? PmbuidingProposalDate { get; set; }

    [Column("PMBuidingProposalSaleOrderDeliveryDate", TypeName = "datetime")]
    public DateTime? PmbuidingProposalSaleOrderDeliveryDate { get; set; }

    [Column("PMBuidingProposalType")]
    [StringLength(100)]
    [Unicode(false)]
    public string PmbuidingProposalType { get; set; }

    [Column("PMBuidingProposalPriority")]
    [StringLength(50)]
    public string PmbuidingProposalPriority { get; set; }

    [Column("PMBuidingProposalShippingType")]
    [StringLength(50)]
    public string PmbuidingProposalShippingType { get; set; }

    [Column("PMBuidingProposalStatus")]
    [StringLength(50)]
    public string PmbuidingProposalStatus { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("PmbuidingProposals")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("PmbuidingProposals")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("PmbuidingProposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("PmbuidingProposals")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmbuidingProposals")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmbuidingProposals")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkPmbuidingProposal")]
    public virtual ICollection<PmbuidingCommandItem> PmbuidingCommandItems { get; set; } = new List<PmbuidingCommandItem>();

    [InverseProperty("FkPmbuidingProposal")]
    public virtual ICollection<PmbuidingCommand> PmbuidingCommands { get; set; } = new List<PmbuidingCommand>();

    [InverseProperty("FkPmbuidingProposal")]
    public virtual ICollection<PmbuidingProposalItem> PmbuidingProposalItems { get; set; } = new List<PmbuidingProposalItem>();
}
