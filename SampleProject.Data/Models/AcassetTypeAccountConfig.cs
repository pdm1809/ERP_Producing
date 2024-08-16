using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAssetTypeAccountConfigs")]
public partial class AcassetTypeAccountConfig
{
    [Key]
    [Column("ACAssetTypeAccountConfigID")]
    public int AcassetTypeAccountConfigId { get; set; }

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

    [Column("ACAssetTypeAccountConfigName")]
    [StringLength(512)]
    public string AcassetTypeAccountConfigName { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACDepreciationAccountID")]
    public int? FkAcdepreciationAccountId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [InverseProperty("FkAcassetTypeAccountConfig")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcassetTypeAccountConfigFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcdepreciationAccountId")]
    [InverseProperty("AcassetTypeAccountConfigFkAcdepreciationAccounts")]
    public virtual Acaccount FkAcdepreciationAccount { get; set; }

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("AcassetTypeAccountConfigFkAcdepreciationCostAccounts")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }
}
