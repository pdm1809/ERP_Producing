using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProposalItemWorkItems")]
public partial class ArproposalItemWorkItem
{
    [Key]
    [Column("ARProposalItemWorkItemID")]
    public int ArproposalItemWorkItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARProposalItemID")]
    public int? FkArproposalItemId { get; set; }

    [Column("FK_ARProposalID")]
    public int? FkArproposalId { get; set; }

    [Column("FK_ARProposalItemWorkID")]
    public int? FkArproposalItemWorkId { get; set; }

    [Column("ARProposalItemWorkItemProductNo")]
    [StringLength(50)]
    public string ArproposalItemWorkItemProductNo { get; set; }

    [Column("ARProposalItemWorkItemProductName")]
    [StringLength(256)]
    public string ArproposalItemWorkItemProductName { get; set; }

    [Column("ARProposalItemWorkItemProductDesc")]
    [StringLength(512)]
    public string ArproposalItemWorkItemProductDesc { get; set; }

    [Column("ARProposalItemWorkItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkItemProductQty { get; set; }

    [Column("ARProposalItemWorkItemProductType")]
    [StringLength(50)]
    public string ArproposalItemWorkItemProductType { get; set; }

    [Column("ARProposalItemWorkItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkItemProductUnitPrice { get; set; }

    [Column("ARProposalItemWorkItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkItemTotalAmount { get; set; }

    [Column("ARProposalItemWorkItemSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalItemWorkItemSubTotalAmount { get; set; }

    [Column("ARProposalItemWorkItemProductChargeCheck")]
    public bool? ArproposalItemWorkItemProductChargeCheck { get; set; }

    [Column("ARProposalItemWorkItemStatus")]
    [StringLength(50)]
    public string ArproposalItemWorkItemStatus { get; set; }

    [ForeignKey("FkArproposalId")]
    [InverseProperty("ArproposalItemWorkItems")]
    public virtual Arproposal FkArproposal { get; set; }

    [ForeignKey("FkArproposalItemId")]
    [InverseProperty("ArproposalItemWorkItems")]
    public virtual ArproposalItem FkArproposalItem { get; set; }

    [ForeignKey("FkArproposalItemWorkId")]
    [InverseProperty("ArproposalItemWorkItems")]
    public virtual ArproposalItemWork FkArproposalItemWork { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArproposalItemWorkItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArproposalItemWorkItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArproposalItemWorkItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArproposalItemWorkItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
