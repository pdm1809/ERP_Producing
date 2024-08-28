using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductTemplateConfigs")]
public partial class IcproductTemplateConfig
{
    [Key]
    [Column("ICProductTemplateConfigID")]
    public int IcproductTemplateConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ICProductTemplateConfigNo")]
    [StringLength(50)]
    public string IcproductTemplateConfigNo { get; set; }

    [Column("ICProductTemplateConfigName")]
    [StringLength(256)]
    public string IcproductTemplateConfigName { get; set; }

    [Column("ICProductTemplateConfigParentID")]
    public int? IcproductTemplateConfigParentId { get; set; }

    [Column("ICProductTemplateConfigSortOrder")]
    public int? IcproductTemplateConfigSortOrder { get; set; }

    [Column("ICProductTemplateConfigRootType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductTemplateConfigRootType { get; set; }
}
