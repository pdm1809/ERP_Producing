using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARComments")]
public partial class Arcomment
{
    [Key]
    [Column("ARCommentID")]
    public int ArcommentId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("ARCommentDate", TypeName = "datetime")]
    public DateTime? ArcommentDate { get; set; }

    [Column("ARCommentDescription")]
    [StringLength(4000)]
    public string ArcommentDescription { get; set; }

    [Column("ARCommentObjectID")]
    public long? ArcommentObjectId { get; set; }

    [Column("ARCommentParentID")]
    public long? ArcommentParentId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ARCommentType")]
    [StringLength(50)]
    public string ArcommentType { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Arcomments")]
    public virtual Hremployee FkHremployee { get; set; }
}
