using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMTemplates")]
public partial class Pmtemplate
{
    [Key]
    [Column("PMTemplateID")]
    public int PmtemplateId { get; set; }

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
    [Column("PMTemplateNo")]
    [StringLength(50)]
    public string PmtemplateNo { get; set; }

    [Column("PMTemplateName")]
    [StringLength(50)]
    public string PmtemplateName { get; set; }

    [Column("PMTemplateDesc")]
    [StringLength(255)]
    public string PmtemplateDesc { get; set; }

    [Column("FK_PMProjectTypeID")]
    public int? FkPmprojectTypeId { get; set; }

    [Column("PMTemplateDate", TypeName = "datetime")]
    public DateTime? PmtemplateDate { get; set; }

    [Column("PMTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtemplateStatus { get; set; }

    [Column("PMTemplateType")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtemplateType { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeApproveID")]
    public int? FkHremployeeApproveId { get; set; }

    [Column("PMTemplateApproveDate", TypeName = "datetime")]
    public DateTime? PmtemplateApproveDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_PMPhaseTypeID")]
    public int? FkPmphaseTypeId { get; set; }

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<Aracceptance> Aracceptances { get; set; } = new List<Aracceptance>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<ArdeliveryPlan> ArdeliveryPlans { get; set; } = new List<ArdeliveryPlan>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<ArproposalTemplateItem> ArproposalTemplateItems { get; set; } = new List<ArproposalTemplateItem>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Pmtemplates")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmtemplateFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApproveId")]
    [InverseProperty("PmtemplateFkHremployeeApproves")]
    public virtual Hremployee FkHremployeeApprove { get; set; }

    [ForeignKey("FkPmphaseTypeId")]
    [InverseProperty("Pmtemplates")]
    public virtual PmphaseType FkPmphaseType { get; set; }

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("Pmtemplates")]
    public virtual PmprojectType FkPmprojectType { get; set; }

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<PmprojectTemplateRelationship> PmprojectTemplateRelationships { get; set; } = new List<PmprojectTemplateRelationship>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<Pmproject> Pmprojects { get; set; } = new List<Pmproject>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<PmtemplateItemComponent> PmtemplateItemComponents { get; set; } = new List<PmtemplateItemComponent>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<PmtemplateItemTask> PmtemplateItemTasks { get; set; } = new List<PmtemplateItemTask>();

    [InverseProperty("FkPmtemplate")]
    public virtual ICollection<PmtemplateItem> PmtemplateItems { get; set; } = new List<PmtemplateItem>();
}
