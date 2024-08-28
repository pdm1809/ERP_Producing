using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AAColumnAlias")]
public partial class AacolumnAlias
{
    [Key]
    [Column("AAColumnAliasID")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AacolumnAliasId { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("AAColumnAliasName")]
    [StringLength(255)]
    [Unicode(false)]
    public string AacolumnAliasName { get; set; }

    [Required]
    [Column("AAColumnAliasCaption")]
    [StringLength(255)]
    public string AacolumnAliasCaption { get; set; }

    [Required]
    [Column("AATableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string AatableName { get; set; }

    [Column("AAReferenceTable")]
    [StringLength(512)]
    [Unicode(false)]
    public string AareferenceTable { get; set; }

    [Column("AADisplayedMember")]
    [StringLength(512)]
    [Unicode(false)]
    public string AadisplayedMember { get; set; }

    [Column("AAFilteredColumn")]
    [StringLength(512)]
    [Unicode(false)]
    public string AafilteredColumn { get; set; }

    [Column("AAFilteredValues")]
    [StringLength(512)]
    [Unicode(false)]
    public string AafilteredValues { get; set; }

    [Column("AAAllowDummy")]
    public bool? AaallowDummy { get; set; }

    [Column("AAColumnAliasIsSaveHistory")]
    public bool? AacolumnAliasIsSaveHistory { get; set; }
}
