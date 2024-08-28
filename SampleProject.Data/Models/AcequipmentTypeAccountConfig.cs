using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEquipmentTypeAccountConfigs")]
public partial class AcequipmentTypeAccountConfig
{
    [Key]
    [Column("ACEquipmentTypeAccountConfigID")]
    public int AcequipmentTypeAccountConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("ACEquipmentTypeAccountConfigName")]
    [StringLength(512)]
    public string AcequipmentTypeAccountConfigName { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACDepreciationAccountID")]
    public int? FkAcdepreciationAccountId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("ACEquipmentTypeAccountConfigAllocationMonthMax")]
    public int? AcequipmentTypeAccountConfigAllocationMonthMax { get; set; }

    [Column("ACEquipmentTypeAccountConfigAllocationMonthMin")]
    public int? AcequipmentTypeAccountConfigAllocationMonthMin { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcequipmentTypeAccountConfigFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcdepreciationAccountId")]
    [InverseProperty("AcequipmentTypeAccountConfigFkAcdepreciationAccounts")]
    public virtual Acaccount FkAcdepreciationAccount { get; set; }

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("AcequipmentTypeAccountConfigFkAcdepreciationCostAccounts")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }

    [InverseProperty("FkAcequipmentTypeAccountConfig")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();
}
