using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEndingAllocationDeclarations")]
public partial class AcendingAllocationDeclaration
{
    [Key]
    [Column("ACEndingAllocationDeclarationID")]
    public int AcendingAllocationDeclarationId { get; set; }

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
    [Column("ACEndingAllocationDeclarationNo")]
    [StringLength(50)]
    public string AcendingAllocationDeclarationNo { get; set; }

    [Column("ACEndingAllocationDeclarationOrderNo")]
    [StringLength(50)]
    public string AcendingAllocationDeclarationOrderNo { get; set; }

    [Column("ACEndingAllocationDeclarationName")]
    [StringLength(512)]
    public string AcendingAllocationDeclarationName { get; set; }

    [Column("ACEndingAllocationDeclarationDesc")]
    [StringLength(512)]
    public string AcendingAllocationDeclarationDesc { get; set; }

    [Column("ACEndingAllocationDeclarationType")]
    [StringLength(50)]
    public string AcendingAllocationDeclarationType { get; set; }

    [Column("ACEndingAllocationDeclarationMethod")]
    [StringLength(50)]
    public string AcendingAllocationDeclarationMethod { get; set; }

    [InverseProperty("FkAcendingAllocationDeclaration")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkAcendingAllocationDeclaration")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkAcendingAllocationDeclaration")]
    public virtual ICollection<AcendingAllocation> AcendingAllocations { get; set; } = new List<AcendingAllocation>();
}
