using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMBuidingCommands")]
public partial class PmbuidingCommand
{
    [Key]
    [Column("PMBuidingCommandID")]
    public int PmbuidingCommandId { get; set; }

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

    [Column("FK_PMBuidingProposalID")]
    public int? FkPmbuidingProposalId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("PMBuidingCommandNo")]
    [StringLength(50)]
    public string PmbuidingCommandNo { get; set; }

    [Column("PMBuidingCommandName")]
    [StringLength(100)]
    public string PmbuidingCommandName { get; set; }

    [Column("PMBuidingCommandDesc")]
    [StringLength(512)]
    public string PmbuidingCommandDesc { get; set; }

    [Column("PMBuidingCommandComment")]
    [StringLength(512)]
    public string PmbuidingCommandComment { get; set; }

    [Column("PMBuidingCommandDate", TypeName = "datetime")]
    public DateTime? PmbuidingCommandDate { get; set; }

    [Column("PMBuidingCommandDeliveryDate", TypeName = "datetime")]
    public DateTime? PmbuidingCommandDeliveryDate { get; set; }

    [Column("PMBuidingCommandType")]
    [StringLength(100)]
    [Unicode(false)]
    public string PmbuidingCommandType { get; set; }

    [Column("PMBuidingCommandPriority")]
    [StringLength(50)]
    public string PmbuidingCommandPriority { get; set; }

    [Column("PMBuidingCommandStatus")]
    [StringLength(50)]
    public string PmbuidingCommandStatus { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("PmbuidingCommands")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("PmbuidingCommands")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("PmbuidingCommands")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkPmbuidingProposalId")]
    [InverseProperty("PmbuidingCommands")]
    public virtual PmbuidingProposal FkPmbuidingProposal { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmbuidingCommands")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkPmbuidingCommand")]
    public virtual ICollection<PmbuildingPlanItem> PmbuildingPlanItems { get; set; } = new List<PmbuildingPlanItem>();

    [InverseProperty("FkPmbuidingCommand")]
    public virtual ICollection<PmbuildingPlan> PmbuildingPlans { get; set; } = new List<PmbuildingPlan>();
}
