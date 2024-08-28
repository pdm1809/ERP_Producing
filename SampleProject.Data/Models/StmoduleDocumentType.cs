using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleDocumentTypes")]
public partial class StmoduleDocumentType
{
    [Key]
    [Column("STModuleDocumentTypeID")]
    public int StmoduleDocumentTypeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("STModuleID")]
    public int? StmoduleId { get; set; }

    [Column("ACDocumentTypeID")]
    public int? AcdocumentTypeId { get; set; }

    [Column("STModuleDocumentTypePostingFunction")]
    [StringLength(512)]
    [Unicode(false)]
    public string StmoduleDocumentTypePostingFunction { get; set; }
}
