using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProcessChangeDetails")]
public partial class MmprocessChangeDetail
{
    [Key]
    [Column("MMProcessChangeDetailID")]
    public int MmprocessChangeDetailId { get; set; }

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

    [Column("FK_MMChangeBOMInformationItemID")]
    public int? FkMmchangeBominformationItemId { get; set; }

    [Column("MMProcessChangeDetailVoucher")]
    [StringLength(512)]
    public string MmprocessChangeDetailVoucher { get; set; }

    [Column("MMProcessChangeDetailVoucherID")]
    public int? MmprocessChangeDetailVoucherId { get; set; }

    [Column("MMProcessChangeDetailObjectID")]
    public int? MmprocessChangeDetailObjectId { get; set; }

    [Column("MMProcessChangeDetailObjectNo")]
    [StringLength(1024)]
    public string MmprocessChangeDetailObjectNo { get; set; }

    [Column("MMProcessChangeDetailObjectDesc")]
    [StringLength(1024)]
    public string MmprocessChangeDetailObjectDesc { get; set; }

    [Column("MMProcessChangeDetailObjectQty", TypeName = "decimal(18, 5)")]
    public decimal? MmprocessChangeDetailObjectQty { get; set; }

    [Column("MMProcessChangeDetailObjectProcessedQty", TypeName = "decimal(18, 5)")]
    public decimal? MmprocessChangeDetailObjectProcessedQty { get; set; }

    [Column("MMProcessChangeDetailObjectCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? MmprocessChangeDetailObjectCanceledQty { get; set; }

    [Column("MMProcessChangeDetailProcessType")]
    [StringLength(512)]
    public string MmprocessChangeDetailProcessType { get; set; }

    [Column("MMProcessChangeDetailProcessNote")]
    [StringLength(1024)]
    public string MmprocessChangeDetailProcessNote { get; set; }

    [ForeignKey("FkMmchangeBominformationItemId")]
    [InverseProperty("MmprocessChangeDetails")]
    public virtual MmchangeBominformationItem FkMmchangeBominformationItem { get; set; }
}
