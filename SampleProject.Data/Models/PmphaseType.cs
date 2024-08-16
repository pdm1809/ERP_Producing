using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMPhaseTypes")]
[Microsoft.EntityFrameworkCore.Index("PmphaseTypeNo", Name = "Idx_PMPhaseTypes")]
public partial class PmphaseType
{
    [Key]
    [Column("PMPhaseTypeID")]
    public int PmphaseTypeId { get; set; }

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
    [Column("PMPhaseTypeNo")]
    [StringLength(50)]
    public string PmphaseTypeNo { get; set; }

    [Column("PMPhaseTypeName")]
    [StringLength(50)]
    public string PmphaseTypeName { get; set; }

    [Column("PMPhaseTypeDesc")]
    [StringLength(255)]
    public string PmphaseTypeDesc { get; set; }

    [Column("PMPhaseTypeInfo", TypeName = "ntext")]
    public string PmphaseTypeInfo { get; set; }

    [Column("PMPhaseTypeRemark")]
    [StringLength(500)]
    public string PmphaseTypeRemark { get; set; }

    [Column("FK_PMProjectTypeID")]
    public int? FkPmprojectTypeId { get; set; }

    [InverseProperty("FkPmphaseType")]
    public virtual ICollection<ArproposalTemplateItem> ArproposalTemplateItems { get; set; } = new List<ArproposalTemplateItem>();

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("PmphaseTypes")]
    public virtual PmprojectType FkPmprojectType { get; set; }

    [InverseProperty("FkPmphaseType")]
    public virtual ICollection<IcproductWorkGroup> IcproductWorkGroups { get; set; } = new List<IcproductWorkGroup>();

    [InverseProperty("FkPmphaseType")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkPmphaseType")]
    public virtual ICollection<PmprojectPhase> PmprojectPhases { get; set; } = new List<PmprojectPhase>();

    [InverseProperty("FkPmphaseType")]
    public virtual ICollection<PmprojectTemplateRelationship> PmprojectTemplateRelationships { get; set; } = new List<PmprojectTemplateRelationship>();

    [InverseProperty("FkPmphaseType")]
    public virtual ICollection<PmtemplateItem> PmtemplateItems { get; set; } = new List<PmtemplateItem>();

    [InverseProperty("FkPmphaseType")]
    public virtual ICollection<Pmtemplate> Pmtemplates { get; set; } = new List<Pmtemplate>();
}
