using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProcesss")]
public partial class Mmprocesss
{
    [Key]
    [Column("MMProcessID")]
    public int MmprocessId { get; set; }

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
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("MMProcessName")]
    [StringLength(512)]
    public string MmprocessName { get; set; }

    [Column("MMProcessNo")]
    [StringLength(50)]
    public string MmprocessNo { get; set; }

    [Column("MMProcessDesc")]
    [StringLength(512)]
    public string MmprocessDesc { get; set; }

    [Column("MMProcessDate", TypeName = "datetime")]
    public DateTime? MmprocessDate { get; set; }

    [Column("MMProcessStatus")]
    [StringLength(50)]
    public string MmprocessStatus { get; set; }

    [Column("MMProcessTypeCombo")]
    [StringLength(50)]
    public string MmprocessTypeCombo { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Mmprocessses")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkMmprocess")]
    public virtual ICollection<IcproductAttributeItem> IcproductAttributeItems { get; set; } = new List<IcproductAttributeItem>();

    [InverseProperty("FkMmprocess")]
    public virtual ICollection<IcproductItemProcesss> IcproductItemProcessses { get; set; } = new List<IcproductItemProcesss>();

    [InverseProperty("FkMmprocess")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkMmprocess")]
    public virtual ICollection<MmbatchProductProductionNormItemProcesss> MmbatchProductProductionNormItemProcessses { get; set; } = new List<MmbatchProductProductionNormItemProcesss>();

    [InverseProperty("FkMmprocess")]
    public virtual ICollection<MmcalculatorProductionNormCost> MmcalculatorProductionNormCosts { get; set; } = new List<MmcalculatorProductionNormCost>();

    [InverseProperty("FkMmprocess")]
    public virtual ICollection<MmmergeBomchangeItemProcessBomlog> MmmergeBomchangeItemProcessBomlogs { get; set; } = new List<MmmergeBomchangeItemProcessBomlog>();

    [InverseProperty("FkMmprocess")]
    public virtual ICollection<MmmergeBomchangeItemProcessBplog> MmmergeBomchangeItemProcessBplogs { get; set; } = new List<MmmergeBomchangeItemProcessBplog>();

    [InverseProperty("FkMmprocess")]
    public virtual ICollection<MmprocessProduct> MmprocessProducts { get; set; } = new List<MmprocessProduct>();
}
