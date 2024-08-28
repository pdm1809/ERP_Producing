using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMBuidingCommandItems")]
public partial class PmbuidingCommandItem
{
    [Key]
    [Column("PMBuidingCommandItemID")]
    public int PmbuidingCommandItemId { get; set; }

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

    [Column("FK_PMBuidingProposalID")]
    public int? FkPmbuidingProposalId { get; set; }

    [Column("FK_PMBuidingProposalItemID")]
    public int? FkPmbuidingProposalItemId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("PMBuidingCommandItemProductType")]
    [StringLength(50)]
    public string PmbuidingCommandItemProductType { get; set; }

    [Column("PMBuidingCommandItemSortOrder")]
    public int? PmbuidingCommandItemSortOrder { get; set; }

    [Column("PMBuidingCommandItemProductNo")]
    [StringLength(50)]
    public string PmbuidingCommandItemProductNo { get; set; }

    [Column("PMBuidingCommandItemProductName")]
    [StringLength(50)]
    public string PmbuidingCommandItemProductName { get; set; }

    [Column("PMBuidingCommandItemProductDesc", TypeName = "ntext")]
    public string PmbuidingCommandItemProductDesc { get; set; }

    [Column("PMBuidingCommandItemProductQty", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingCommandItemProductQty { get; set; }

    [Column("PMBuidingCommandItemComment")]
    [StringLength(50)]
    public string PmbuidingCommandItemComment { get; set; }

    [Column("PMBuidingCommandItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmbuidingCommandItemStatus { get; set; }

    [Column("PMBuidingCommandItemDeliveryDate", TypeName = "datetime")]
    public DateTime? PmbuidingCommandItemDeliveryDate { get; set; }

    [Column("PMBuidingCommandItemBeginDate", TypeName = "datetime")]
    public DateTime? PmbuidingCommandItemBeginDate { get; set; }

    [Column("PMBuidingCommandItemDueDate", TypeName = "datetime")]
    public DateTime? PmbuidingCommandItemDueDate { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("PmbuidingCommandItems")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmbuidingCommandItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("PmbuidingCommandItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmbuidingCommandItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmbuidingCommandItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("PmbuidingCommandItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkPmbuidingProposalId")]
    [InverseProperty("PmbuidingCommandItems")]
    public virtual PmbuidingProposal FkPmbuidingProposal { get; set; }

    [ForeignKey("FkPmbuidingProposalItemId")]
    [InverseProperty("PmbuidingCommandItems")]
    public virtual PmbuidingProposalItem FkPmbuidingProposalItem { get; set; }

    [InverseProperty("FkPmbuidingCommandItem")]
    public virtual ICollection<PmbuildingPlanItem> PmbuildingPlanItems { get; set; } = new List<PmbuildingPlanItem>();
}
