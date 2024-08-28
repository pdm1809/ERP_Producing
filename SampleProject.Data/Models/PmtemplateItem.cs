using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMTemplateItems")]
public partial class PmtemplateItem
{
    [Key]
    [Column("PMTemplateItemID")]
    public int PmtemplateItemId { get; set; }

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

    [Column("PMTemplateItemProductNo")]
    [StringLength(50)]
    public string PmtemplateItemProductNo { get; set; }

    [Column("PMTemplateItemProductName")]
    [StringLength(256)]
    public string PmtemplateItemProductName { get; set; }

    [Column("PMTemplateItemProductDesc")]
    [StringLength(512)]
    public string PmtemplateItemProductDesc { get; set; }

    [Column("PMTemplateItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemProductQty { get; set; }

    [Column("FK_ICProductWorkGroupParentID")]
    public int? FkIcproductWorkGroupParentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("PMTemplateItemParentID")]
    public int? PmtemplateItemParentId { get; set; }

    [Column("PMTemplateItemType")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtemplateItemType { get; set; }

    [Column("PMTemplateItemWorkType")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtemplateItemWorkType { get; set; }

    [Column("PMTemplateItemSortOrder")]
    public int? PmtemplateItemSortOrder { get; set; }

    [Column("PMTemplateItemSortOrderNo")]
    [StringLength(50)]
    public string PmtemplateItemSortOrderNo { get; set; }

    [Column("PMTemplateItemProductNetWeight", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemProductNetWeight { get; set; }

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("PmtemplateItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmtemplateItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmtemplateItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("PmtemplateItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductWorkGroupId")]
    [InverseProperty("PmtemplateItemFkIcproductWorkGroups")]
    public virtual IcproductWorkGroup FkIcproductWorkGroup { get; set; }

    [ForeignKey("FkIcproductWorkGroupParentId")]
    [InverseProperty("PmtemplateItemFkIcproductWorkGroupParents")]
    public virtual IcproductWorkGroup FkIcproductWorkGroupParent { get; set; }

    [ForeignKey("FkPmphaseTypeId")]
    [InverseProperty("PmtemplateItems")]
    public virtual PmphaseType FkPmphaseType { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("PmtemplateItems")]
    public virtual Pmtemplate FkPmtemplate { get; set; }

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<PmprojectNormItem> PmprojectNormItems { get; set; } = new List<PmprojectNormItem>();

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<PmtemplateItemComponent> PmtemplateItemComponents { get; set; } = new List<PmtemplateItemComponent>();

    [InverseProperty("FkPmtemplateItem")]
    public virtual ICollection<PmtemplateItemTask> PmtemplateItemTasks { get; set; } = new List<PmtemplateItemTask>();
}
