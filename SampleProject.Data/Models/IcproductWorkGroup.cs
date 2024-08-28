using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductWorkGroups")]
public partial class IcproductWorkGroup
{
    [Key]
    [Column("ICProductWorkGroupID")]
    public int IcproductWorkGroupId { get; set; }

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

    [Required]
    [Column("ICProductWorkGroupNo")]
    [StringLength(50)]
    public string IcproductWorkGroupNo { get; set; }

    [Column("ICProductWorkGroupName")]
    [StringLength(50)]
    public string IcproductWorkGroupName { get; set; }

    [Column("ICProductWorkGroupDesc")]
    [StringLength(255)]
    public string IcproductWorkGroupDesc { get; set; }

    [Column("FK_PMPhaseTypeID")]
    public int? FkPmphaseTypeId { get; set; }

    [Column("FK_PMProjectTypeID")]
    public int? FkPmprojectTypeId { get; set; }

    [InverseProperty("FkIcproductWorkGroupParent")]
    public virtual ICollection<ArproposalTemplateItem> ArproposalTemplateItemFkIcproductWorkGroupParents { get; set; } = new List<ArproposalTemplateItem>();

    [InverseProperty("FkIcproductWorkGroup")]
    public virtual ICollection<ArproposalTemplateItem> ArproposalTemplateItemFkIcproductWorkGroups { get; set; } = new List<ArproposalTemplateItem>();

    [ForeignKey("FkPmphaseTypeId")]
    [InverseProperty("IcproductWorkGroups")]
    public virtual PmphaseType FkPmphaseType { get; set; }

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("IcproductWorkGroups")]
    public virtual PmprojectType FkPmprojectType { get; set; }

    [InverseProperty("FkIcproductWorkGroupParent")]
    public virtual ICollection<PmprojectNorm> PmprojectNormFkIcproductWorkGroupParents { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkIcproductWorkGroup")]
    public virtual ICollection<PmprojectNorm> PmprojectNormFkIcproductWorkGroups { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkIcproductWorkGroupParent")]
    public virtual ICollection<PmtemplateItem> PmtemplateItemFkIcproductWorkGroupParents { get; set; } = new List<PmtemplateItem>();

    [InverseProperty("FkIcproductWorkGroup")]
    public virtual ICollection<PmtemplateItem> PmtemplateItemFkIcproductWorkGroups { get; set; } = new List<PmtemplateItem>();
}
