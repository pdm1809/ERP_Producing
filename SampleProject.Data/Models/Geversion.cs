using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEVersions")]
public partial class Geversion
{
    [Key]
    [Column("GEVersionID")]
    public int GeversionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("GEVersionMajor")]
    public int GeversionMajor { get; set; }

    [Column("GEVersionMinor")]
    public int GeversionMinor { get; set; }

    [Column("GEVersionRevision")]
    public int GeversionRevision { get; set; }

    [Column("GEVersionSubRevision")]
    public int GeversionSubRevision { get; set; }

    [Column("GEVersionDateMod", TypeName = "datetime")]
    public DateTime GeversionDateMod { get; set; }

    [Column("GEVersionActive")]
    public bool GeversionActive { get; set; }
}
