using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AAPayRollColumnAlias")]
public partial class AapayRollColumnAlias
{
    [Key]
    [Column("AAPayRollColumnAliasID")]
    public int AapayRollColumnAliasId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("AAPayRollColumnAliasName")]
    [StringLength(255)]
    [Unicode(false)]
    public string AapayRollColumnAliasName { get; set; }

    [Required]
    [Column("AAPayRollColumnAliasCaption")]
    [StringLength(255)]
    public string AapayRollColumnAliasCaption { get; set; }
}
