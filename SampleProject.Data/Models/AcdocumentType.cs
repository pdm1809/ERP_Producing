using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACDocumentTypes")]
public partial class AcdocumentType
{
    [Key]
    [Column("ACDocumentTypeID")]
    public int AcdocumentTypeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Required]
    [Column("ACDocumentTypeName")]
    [StringLength(100)]
    public string AcdocumentTypeName { get; set; }

    [Required]
    [Column("ACDocumentTypeDesc")]
    [StringLength(512)]
    public string AcdocumentTypeDesc { get; set; }

    [InverseProperty("FkAcdocumentType")]
    public virtual ICollection<AcaccountTranferCost> AcaccountTranferCosts { get; set; } = new List<AcaccountTranferCost>();

    [InverseProperty("FkAcdocumentType")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkAcdocumentType")]
    public virtual ICollection<AcdocTypeEntry> AcdocTypeEntries { get; set; } = new List<AcdocTypeEntry>();

    [InverseProperty("FkAcdocumentType")]
    public virtual ICollection<AcdocTypeEntryFunctionMapping> AcdocTypeEntryFunctionMappings { get; set; } = new List<AcdocTypeEntryFunctionMapping>();

    [InverseProperty("FkAcdocumentType")]
    public virtual ICollection<Acdocument> Acdocuments { get; set; } = new List<Acdocument>();

    [InverseProperty("FkAcdocumentType")]
    public virtual ICollection<AcsegmentDocumentControl> AcsegmentDocumentControls { get; set; } = new List<AcsegmentDocumentControl>();
}
