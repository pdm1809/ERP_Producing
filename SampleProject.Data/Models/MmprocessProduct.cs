using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProcessProducts")]
public partial class MmprocessProduct
{
    [Key]
    [Column("MMProcessProductID")]
    public int MmprocessProductId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("MMProcessProductDesc")]
    [StringLength(1024)]
    public string MmprocessProductDesc { get; set; }

    [Column("FK_MMProcessID")]
    public int? FkMmprocessId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmprocessProducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmprocessId")]
    [InverseProperty("MmprocessProducts")]
    public virtual Mmprocesss FkMmprocess { get; set; }
}
