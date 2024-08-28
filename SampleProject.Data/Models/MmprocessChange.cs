using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProcessChanges")]
public partial class MmprocessChange
{
    [Key]
    [Column("MMProcessChangeID")]
    public int MmprocessChangeId { get; set; }

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

    [Column("MMProcessChangeOrderNumber")]
    public int? MmprocessChangeOrderNumber { get; set; }

    [Column("MMProcessChangeGroup")]
    public int? MmprocessChangeGroup { get; set; }

    [Column("MMProcessChangeVoucherNo")]
    [StringLength(512)]
    public string MmprocessChangeVoucherNo { get; set; }

    [Column("MMProcessChangeVoucherName")]
    [StringLength(512)]
    public string MmprocessChangeVoucherName { get; set; }

    [Column("MMProcessChangeDesc")]
    [StringLength(1024)]
    public string MmprocessChangeDesc { get; set; }

    [Column("MMProcessChangeCount")]
    public int? MmprocessChangeCount { get; set; }

    [Column("MMProcessChangeStatus")]
    [StringLength(512)]
    public string MmprocessChangeStatus { get; set; }

    [Column("MMProcessChangeDate", TypeName = "datetime")]
    public DateTime? MmprocessChangeDate { get; set; }

    [Column("FK_MMChangeBOMInformationItemID")]
    public int? FkMmchangeBominformationItemId { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

    [ForeignKey("FkMmchangeBominformationItemId")]
    [InverseProperty("MmprocessChanges")]
    public virtual MmchangeBominformationItem FkMmchangeBominformationItem { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmprocessChanges")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }
}
