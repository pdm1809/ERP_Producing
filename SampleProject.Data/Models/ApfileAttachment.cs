using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APFileAttachments")]
public partial class ApfileAttachment
{
    [Key]
    [Column("APFileAttachmentID")]
    public int ApfileAttachmentId { get; set; }

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

    [Column("APFileAttachmentModuleName")]
    [StringLength(256)]
    public string ApfileAttachmentModuleName { get; set; }

    [Column("APFileAttachmentTableName")]
    [StringLength(256)]
    public string ApfileAttachmentTableName { get; set; }

    [Column("APFileAttachmentObjectID")]
    public int? ApfileAttachmentObjectId { get; set; }

    [Column("APFileAttachmentObjectItemID")]
    public int? ApfileAttachmentObjectItemId { get; set; }

    [Column("APFileAttachmentName")]
    [StringLength(256)]
    public string ApfileAttachmentName { get; set; }

    [Column("APFileAttachmentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApfileAttachmentStatus { get; set; }

    [Column("APFileAttachmentFileGUID")]
    [StringLength(256)]
    public string ApfileAttachmentFileGuid { get; set; }
}
