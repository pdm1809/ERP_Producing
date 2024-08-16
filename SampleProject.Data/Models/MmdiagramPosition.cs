using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMDiagramPositions")]
public partial class MmdiagramPosition
{
    [Key]
    [Column("MMDiagramPositionID")]
    public int MmdiagramPositionId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_MMWSPositionID")]
    public int FkMmwspositionId { get; set; }

    [Column("FK_MMRangePositionID")]
    public int FkMmrangePositionId { get; set; }

    [Column("FK_MMRowPositionID")]
    public int FkMmrowPositionId { get; set; }

    [Column("MMDiagramPositionName")]
    [StringLength(100)]
    public string MmdiagramPositionName { get; set; }
}
