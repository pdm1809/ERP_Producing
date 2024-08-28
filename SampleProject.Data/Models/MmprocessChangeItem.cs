using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProcessChangeItems")]
public partial class MmprocessChangeItem
{
    [Key]
    [Column("MMProcessChangeItemID")]
    public int MmprocessChangeItemId { get; set; }

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

    [Column("MMProcessChangeItemVoucher")]
    [StringLength(512)]
    public string MmprocessChangeItemVoucher { get; set; }

    [Column("MMProcessChangeItemVoucherID")]
    public int? MmprocessChangeItemVoucherId { get; set; }

    [Column("MMProcessChangeItemVoucherNo")]
    [StringLength(512)]
    public string MmprocessChangeItemVoucherNo { get; set; }

    [Column("MMProcessChangeItemDesc")]
    [StringLength(1024)]
    public string MmprocessChangeItemDesc { get; set; }

    [Column("MMProcessChangeItemStatus")]
    [StringLength(512)]
    public string MmprocessChangeItemStatus { get; set; }

    [Column("MMProcessChangeItemDate", TypeName = "datetime")]
    public DateTime? MmprocessChangeItemDate { get; set; }

    [Column("MMProcessChangeItemProcessStatus")]
    [StringLength(512)]
    public string MmprocessChangeItemProcessStatus { get; set; }

    [Column("MMProcessChangeItemProcessDate", TypeName = "datetime")]
    public DateTime? MmprocessChangeItemProcessDate { get; set; }

    [Column("FK_MMChangeBOMInformationItemID")]
    public int? FkMmchangeBominformationItemId { get; set; }

    [ForeignKey("FkMmchangeBominformationItemId")]
    [InverseProperty("MmprocessChangeItems")]
    public virtual MmchangeBominformationItem FkMmchangeBominformationItem { get; set; }
}
