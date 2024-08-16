using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationProducts")]
public partial class MmoperationProduct
{
    [Key]
    [Column("MMOperationProductID")]
    public int MmoperationProductId { get; set; }

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

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmoperationProducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmoperationProducts")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
