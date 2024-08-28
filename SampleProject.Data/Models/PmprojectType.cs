using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectTypes")]
public partial class PmprojectType
{
    [Key]
    [Column("PMProjectTypeID")]
    public int PmprojectTypeId { get; set; }

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
    [Column("PMProjectTypeNo")]
    [StringLength(50)]
    public string PmprojectTypeNo { get; set; }

    [Column("PMProjectTypeName")]
    [StringLength(50)]
    public string PmprojectTypeName { get; set; }

    [Column("PMProjectTypeDesc")]
    [StringLength(255)]
    public string PmprojectTypeDesc { get; set; }

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<ArproposalItemWorkTask> ArproposalItemWorkTasks { get; set; } = new List<ArproposalItemWorkTask>();

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<IcproductTask> IcproductTasks { get; set; } = new List<IcproductTask>();

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<IcproductWorkGroup> IcproductWorkGroups { get; set; } = new List<IcproductWorkGroup>();

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<Ictask> Ictasks { get; set; } = new List<Ictask>();

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<PmphaseType> PmphaseTypes { get; set; } = new List<PmphaseType>();

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<Pmproject> Pmprojects { get; set; } = new List<Pmproject>();

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<PmtemplateItemTask> PmtemplateItemTasks { get; set; } = new List<PmtemplateItemTask>();

    [InverseProperty("FkPmprojectType")]
    public virtual ICollection<Pmtemplate> Pmtemplates { get; set; } = new List<Pmtemplate>();
}
