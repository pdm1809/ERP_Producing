using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACDocTypeEntryAccounts")]
public partial class AcdocTypeEntryAccount
{
    [Key]
    [Column("ACDocTypeEntryAccountID")]
    public int AcdocTypeEntryAccountId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocTypeEntryID")]
    public int FkAcdocTypeEntryId { get; set; }

    [Column("FK_ACAccountID")]
    public int FkAcaccountId { get; set; }

    [Required]
    [Column("ACPostingType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcpostingType { get; set; }

    public bool IsDefault { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcdocTypeEntryAccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcdocTypeEntryId")]
    [InverseProperty("AcdocTypeEntryAccounts")]
    public virtual AcdocTypeEntry FkAcdocTypeEntry { get; set; }
}
