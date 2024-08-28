using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormItemOperations")]
public partial class MmproductionNormItemOperation
{
    [Key]
    [Column("MMProductionNormItemOperationID")]
    public int MmproductionNormItemOperationId { get; set; }

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

    [Column("FK_MMProductionNormID")]
    public int FkMmproductionNormId { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int FkMmproductionNormItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionNormItemOperations")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionNormItemOperations")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmproductionNormItemOperations")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmproductionNormItemOperations")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }

    [InverseProperty("FkMmproductionNormItemOperation")]
    public virtual ICollection<MmbatchProductItemOperationInfo> MmbatchProductItemOperationInfos { get; set; } = new List<MmbatchProductItemOperationInfo>();
}
