using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADCompletePermissionConfigs")]
public partial class AdcompletePermissionConfig
{
    [Key]
    [Column("ADCompletePermissionConfigID")]
    public int AdcompletePermissionConfigId { get; set; }

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

    [Column("FK_STModuleID")]
    public int FkStmoduleId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Column("ADCompletePermissionConfigSaleType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdcompletePermissionConfigSaleType { get; set; }

    [Column("ADCompletePermissionConfigMaxValue", TypeName = "decimal(18, 5)")]
    public decimal? AdcompletePermissionConfigMaxValue { get; set; }

    [Column("ADCompletePermissionConfigCriteriaOperator")]
    [StringLength(1024)]
    public string AdcompletePermissionConfigCriteriaOperator { get; set; }

    [Column("ADCompletePermissionConfigSqlWhereClause")]
    [StringLength(1024)]
    public string AdcompletePermissionConfigSqlWhereClause { get; set; }

    [Column("ADCompletePermissionConfigLinqWhereClause")]
    [StringLength(1024)]
    public string AdcompletePermissionConfigLinqWhereClause { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("AdcompletePermissionConfigs")]
    public virtual AduserGroup FkAduserGroup { get; set; }
}
