using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMergeBOMChanges")]
public partial class MmmergeBomchange
{
    [Key]
    [Column("MMMergeBOMChangeID")]
    public int MmmergeBomchangeId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Required]
    [Column("MMMergeBOMChangeNo")]
    [StringLength(50)]
    public string MmmergeBomchangeNo { get; set; }

    [Column("MMMergeBOMChangeDesc")]
    [StringLength(512)]
    public string MmmergeBomchangeDesc { get; set; }

    [Column("MMMergeBOMChangeDate", TypeName = "datetime")]
    public DateTime? MmmergeBomchangeDate { get; set; }

    [Column("MMMergeBOMChangeStatus")]
    [StringLength(50)]
    public string MmmergeBomchangeStatus { get; set; }

    [Column("MMMergeBOMChangeType")]
    [StringLength(50)]
    public string MmmergeBomchangeType { get; set; }

    [Column("FK_MMProductionNormApproveLogID")]
    public int? FkMmproductionNormApproveLogId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmmergeBomchanges")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmmergeBomchanges")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [InverseProperty("FkMmmergeBomchange")]
    public virtual ICollection<MmmergeBomchangeBatchProduct> MmmergeBomchangeBatchProducts { get; set; } = new List<MmmergeBomchangeBatchProduct>();

    [InverseProperty("FkMmmergeBomchange")]
    public virtual ICollection<MmmergeBomchangeItemBomlog> MmmergeBomchangeItemBomlogs { get; set; } = new List<MmmergeBomchangeItemBomlog>();

    [InverseProperty("FkMmmergeBomchange")]
    public virtual ICollection<MmmergeBomchangeItemBplog> MmmergeBomchangeItemBplogs { get; set; } = new List<MmmergeBomchangeItemBplog>();

    [InverseProperty("FkMmmergeBomchange")]
    public virtual ICollection<MmmergeBomchangeItemMaterialBomlog> MmmergeBomchangeItemMaterialBomlogs { get; set; } = new List<MmmergeBomchangeItemMaterialBomlog>();

    [InverseProperty("FkMmmergeBomchange")]
    public virtual ICollection<MmmergeBomchangeItemMaterialBplog> MmmergeBomchangeItemMaterialBplogs { get; set; } = new List<MmmergeBomchangeItemMaterialBplog>();

    [InverseProperty("FkMmmergeBomchange")]
    public virtual ICollection<MmmergeBomchangeItemProcessBomlog> MmmergeBomchangeItemProcessBomlogs { get; set; } = new List<MmmergeBomchangeItemProcessBomlog>();

    [InverseProperty("FkMmmergeBomchange")]
    public virtual ICollection<MmmergeBomchangeItemProcessBplog> MmmergeBomchangeItemProcessBplogs { get; set; } = new List<MmmergeBomchangeItemProcessBplog>();
}
