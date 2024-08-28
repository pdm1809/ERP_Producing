using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProposalTemplateItems")]
public partial class ArproposalTemplateItem
{
    [Key]
    [Column("ARProposalTemplateItemID")]
    public int ArproposalTemplateItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_PMPhaseTypeID")]
    public int? FkPmphaseTypeId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductWorkGroupID")]
    public int? FkIcproductWorkGroupId { get; set; }

    [Column("ARProposalTemplateItemProductNo")]
    [StringLength(50)]
    public string ArproposalTemplateItemProductNo { get; set; }

    [Column("ARProposalTemplateItemProductName")]
    [StringLength(256)]
    public string ArproposalTemplateItemProductName { get; set; }

    [Column("ARProposalTemplateItemProductDesc")]
    [StringLength(512)]
    public string ArproposalTemplateItemProductDesc { get; set; }

    [Column("ARProposalTemplateItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalTemplateItemProductQty { get; set; }

    [Column("FK_ICProductWorkGroupParentID")]
    public int? FkIcproductWorkGroupParentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ARProposalTemplateItemParentID")]
    public int? ArproposalTemplateItemParentId { get; set; }

    [Column("ARProposalTemplateItemType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArproposalTemplateItemType { get; set; }

    [Column("ARProposalTemplateItemWorkType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArproposalTemplateItemWorkType { get; set; }

    [Column("ARProposalTemplateItemSortOrder")]
    public int? ArproposalTemplateItemSortOrder { get; set; }

    [Column("ARProposalTemplateItemSortOrderNo")]
    [StringLength(50)]
    public string ArproposalTemplateItemSortOrderNo { get; set; }

    [Column("ARProposalTemplateItemProductNetWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalTemplateItemProductNetWeight { get; set; }

    [Column("FK_ARProposalID")]
    public int? FkArproposalId { get; set; }

    [ForeignKey("FkArproposalId")]
    [InverseProperty("ArproposalTemplateItems")]
    public virtual Arproposal FkArproposal { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArproposalTemplateItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArproposalTemplateItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArproposalTemplateItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArproposalTemplateItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductWorkGroupId")]
    [InverseProperty("ArproposalTemplateItemFkIcproductWorkGroups")]
    public virtual IcproductWorkGroup FkIcproductWorkGroup { get; set; }

    [ForeignKey("FkIcproductWorkGroupParentId")]
    [InverseProperty("ArproposalTemplateItemFkIcproductWorkGroupParents")]
    public virtual IcproductWorkGroup FkIcproductWorkGroupParent { get; set; }

    [ForeignKey("FkPmphaseTypeId")]
    [InverseProperty("ArproposalTemplateItems")]
    public virtual PmphaseType FkPmphaseType { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("ArproposalTemplateItems")]
    public virtual Pmtemplate FkPmtemplate { get; set; }
}
