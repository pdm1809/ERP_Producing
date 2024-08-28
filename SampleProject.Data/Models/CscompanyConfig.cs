using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("CSCompanyConfigs")]
[Microsoft.EntityFrameworkCore.Index("CscompanyConfigType", Name = "Idx_CSCompanyConfigs")]
public partial class CscompanyConfig
{
    [Key]
    [Column("A1CompanyConfigID")]
    public int A1companyConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [Column("CSCompanyConfigKey")]
    [StringLength(50)]
    public string CscompanyConfigKey { get; set; }

    [Column("CSCompanyConfigLabel")]
    [StringLength(50)]
    public string CscompanyConfigLabel { get; set; }

    [Column("CSCompanyConfigValue")]
    [StringLength(50)]
    public string CscompanyConfigValue { get; set; }

    [Column("CSCompanyConfigType")]
    [StringLength(50)]
    public string CscompanyConfigType { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("CscompanyConfigs")]
    public virtual AduserGroup FkAduserGroup { get; set; }
}
