using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACFileAttachments")]
public partial class AcfileAttachment
{
    [Key]
    [Column("ACFileAttachmentID")]
    public int AcfileAttachmentId { get; set; }

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

    [Column("ACFileAttachmentModuleName")]
    [StringLength(256)]
    public string AcfileAttachmentModuleName { get; set; }

    [Column("ACFileAttachmentTableName")]
    [StringLength(256)]
    public string AcfileAttachmentTableName { get; set; }

    [Column("ACFileAttachmentObjectID")]
    public int? AcfileAttachmentObjectId { get; set; }

    [Column("ACFileAttachmentObjectItemID")]
    public int? AcfileAttachmentObjectItemId { get; set; }

    [Column("ACFileAttachmentName")]
    [StringLength(256)]
    public string AcfileAttachmentName { get; set; }

    [Column("ACFileAttachmentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcfileAttachmentStatus { get; set; }

    [Column("ACFileAttachmentFileGUID")]
    [StringLength(256)]
    public string AcfileAttachmentFileGuid { get; set; }
}
