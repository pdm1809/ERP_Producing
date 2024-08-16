using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProfileManagementItems")]
public partial class MmprofileManagementItem
{
    [Key]
    [Column("MMProfileManagementItemID")]
    public int MmprofileManagementItemId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("MMProfileManagementItemNo")]
    [StringLength(50)]
    public string MmprofileManagementItemNo { get; set; }

    [Column("MMProfileManagementItemName")]
    [StringLength(100)]
    public string MmprofileManagementItemName { get; set; }

    [Column("MMProfileManagementItemReason")]
    [StringLength(512)]
    public string MmprofileManagementItemReason { get; set; }

    [Column("MMProfileManagementItemDesc")]
    [StringLength(4000)]
    public string MmprofileManagementItemDesc { get; set; }

    [Column("MMProfileManagementItemOldValue")]
    [StringLength(512)]
    public string MmprofileManagementItemOldValue { get; set; }

    [Column("MMProfileManagementItemNewValue")]
    [StringLength(512)]
    public string MmprofileManagementItemNewValue { get; set; }

    [Column("MMProfileManagementItemDate", TypeName = "datetime")]
    public DateTime? MmprofileManagementItemDate { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmprofileManagementItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmprofileManagementItems")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }
}
