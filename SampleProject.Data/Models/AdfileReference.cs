using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADFileReferences")]
public partial class AdfileReference
{
    [Key]
    [Column("ADFileReferenceID")]
    public int AdfileReferenceId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("ADFileReferenceContentType")]
    [StringLength(100)]
    public string AdfileReferenceContentType { get; set; }

    [Column("ADFileReferenceFileExtension")]
    [StringLength(10)]
    [Unicode(false)]
    public string AdfileReferenceFileExtension { get; set; }

    [Column("ADFileReferenceFileName")]
    [StringLength(256)]
    public string AdfileReferenceFileName { get; set; }

    [Column("ADFileReferenceOriginalName")]
    [StringLength(256)]
    public string AdfileReferenceOriginalName { get; set; }
}
