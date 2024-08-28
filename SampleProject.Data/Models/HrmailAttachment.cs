using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRMailAttachments")]
public partial class HrmailAttachment
{
    [Key]
    [Column("HRMailAttachmentID")]
    public int HrmailAttachmentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRMailID")]
    public int FkHrmailId { get; set; }

    [Required]
    [Column("HRMailAttachmentName")]
    [StringLength(100)]
    public string HrmailAttachmentName { get; set; }

    [Column("HRMailAttachmentFileType")]
    [StringLength(10)]
    [Unicode(false)]
    public string HrmailAttachmentFileType { get; set; }

    [Column("HRMailAttachmentFileSize")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrmailAttachmentFileSize { get; set; }

    [ForeignKey("FkHrmailId")]
    [InverseProperty("HrmailAttachments")]
    public virtual Hrmail FkHrmail { get; set; }
}
