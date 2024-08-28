using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACRelativeDocuments")]
[Microsoft.EntityFrameworkCore.Index("FkAcdocumentId", Name = "Idx_ACRelativeDocuments")]
public partial class AcrelativeDocument
{
    [Key]
    [Column("ACRelativeDocumentID")]
    public int AcrelativeDocumentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ACRelativeDocumentID")]
    public int FkAcrelativeDocumentId { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcrelativeDocumentFkAcdocuments")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcrelativeDocumentId")]
    [InverseProperty("AcrelativeDocumentFkAcrelativeDocuments")]
    public virtual Acdocument FkAcrelativeDocument { get; set; }
}
