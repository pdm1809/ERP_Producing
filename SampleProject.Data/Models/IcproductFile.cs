using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductFiles")]
public partial class IcproductFile
{
    [Key]
    [Column("ICProductFileID")]
    public int IcproductFileId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductFileType")]
    [StringLength(50)]
    public string IcproductFileType { get; set; }

    [Column("ICProductFileName")]
    public Guid? IcproductFileName { get; set; }

    [Column("ICProductFileDesc")]
    [StringLength(256)]
    public string IcproductFileDesc { get; set; }

    [Column("ICProductFileLinkRoot")]
    [StringLength(256)]
    public string IcproductFileLinkRoot { get; set; }

    [Column("ICProductFileLink")]
    [StringLength(256)]
    public string IcproductFileLink { get; set; }

    [Column("ICProductFileExtension")]
    [StringLength(10)]
    public string IcproductFileExtension { get; set; }

    [Column("ICProductFileDefault")]
    public bool? IcproductFileDefault { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductFiles")]
    public virtual Icproduct FkIcproduct { get; set; }
}
