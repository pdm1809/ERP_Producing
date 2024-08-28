using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProposalTemplates")]
public partial class MmproposalTemplate
{
    [Key]
    [Column("MMProposalTemplateID")]
    public int MmproposalTemplateId { get; set; }

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

    [Column("FK_MMProposalID")]
    public int FkMmproposalId { get; set; }

    [Column("MMProposalTemplateName")]
    [StringLength(256)]
    public string MmproposalTemplateName { get; set; }

    [Column("MMProposalTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmproposalTemplateStatus { get; set; }

    [Column("MMProposalTemplateFileGUID")]
    [StringLength(256)]
    public string MmproposalTemplateFileGuid { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("MmproposalTemplates")]
    public virtual Mmproposal FkMmproposal { get; set; }
}
