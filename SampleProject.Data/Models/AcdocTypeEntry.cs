using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACDocTypeEntrys")]
public partial class AcdocTypeEntry
{
    [Key]
    [Column("ACDocTypeEntryID")]
    public int AcdocTypeEntryId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentTypeID")]
    public int FkAcdocumentTypeId { get; set; }

    [Column("FK_ACEntryTypeID")]
    public int FkAcentryTypeId { get; set; }

    [Column("ACDocTypeEntrySortOrder")]
    public int? AcdocTypeEntrySortOrder { get; set; }

    [InverseProperty("FkAcdocTypeEntry")]
    public virtual ICollection<AcdocTypeEntryAccount> AcdocTypeEntryAccounts { get; set; } = new List<AcdocTypeEntryAccount>();

    [ForeignKey("FkAcdocumentTypeId")]
    [InverseProperty("AcdocTypeEntries")]
    public virtual AcdocumentType FkAcdocumentType { get; set; }

    [ForeignKey("FkAcentryTypeId")]
    [InverseProperty("AcdocTypeEntries")]
    public virtual AcentryType FkAcentryType { get; set; }
}
