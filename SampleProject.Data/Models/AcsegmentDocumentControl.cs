using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACSegmentDocumentControls")]
public partial class AcsegmentDocumentControl
{
    [Key]
    [Column("ACSegmentDocumentControlID")]
    public int AcsegmentDocumentControlId { get; set; }

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

    [Column("FK_ACSegmentID")]
    public int FkAcsegmentId { get; set; }

    [Column("FK_ACDocumentTypeID")]
    public int FkAcdocumentTypeId { get; set; }

    [ForeignKey("FkAcdocumentTypeId")]
    [InverseProperty("AcsegmentDocumentControls")]
    public virtual AcdocumentType FkAcdocumentType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcsegmentDocumentControls")]
    public virtual Acsegment FkAcsegment { get; set; }
}
