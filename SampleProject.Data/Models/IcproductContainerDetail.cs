using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductContainerDetails")]
public partial class IcproductContainerDetail
{
    [Key]
    [Column("ICProductContainerDetailID")]
    public int IcproductContainerDetailId { get; set; }

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

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductContainerType")]
    [StringLength(100)]
    public string IcproductContainerType { get; set; }

    [Column("ICProductContainerDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductContainerDetailQty { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductContainerDetails")]
    public virtual Icproduct FkIcproduct { get; set; }
}
