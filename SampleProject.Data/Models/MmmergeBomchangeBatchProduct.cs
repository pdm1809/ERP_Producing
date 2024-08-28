using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMergeBOMChangeBatchProducts")]
public partial class MmmergeBomchangeBatchProduct
{
    [Key]
    [Column("MMMergeBOMChangeBatchProductID")]
    public int MmmergeBomchangeBatchProductId { get; set; }

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
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeApproveID")]
    public int? FkHremployeeApproveId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMMergeBOMChangeID")]
    public int? FkMmmergeBomchangeId { get; set; }

    [Column("MMMergeBOMChangeBatchProductApproveDate", TypeName = "datetime")]
    public DateTime? MmmergeBomchangeBatchProductApproveDate { get; set; }

    [Column("MMMergeBOMChangeBatchProductStatus")]
    [StringLength(50)]
    public string MmmergeBomchangeBatchProductStatus { get; set; }

    [ForeignKey("FkHremployeeApproveId")]
    [InverseProperty("MmmergeBomchangeBatchProducts")]
    public virtual Hremployee FkHremployeeApprove { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmmergeBomchangeBatchProducts")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmmergeBomchangeId")]
    [InverseProperty("MmmergeBomchangeBatchProducts")]
    public virtual MmmergeBomchange FkMmmergeBomchange { get; set; }
}
