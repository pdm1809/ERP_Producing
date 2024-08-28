using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCalMaterialConfigs")]
public partial class MmcalMaterialConfig
{
    [Key]
    [Column("MMCalMaterialConfigID")]
    public int MmcalMaterialConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("MMProductType")]
    [StringLength(50)]
    public string MmproductType { get; set; }

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Column("MMCalMaterialConfigConsumableExpression")]
    [StringLength(1024)]
    public string MmcalMaterialConfigConsumableExpression { get; set; }

    [Column("MMCalMaterialConfigQuantityExpression")]
    [StringLength(1024)]
    public string MmcalMaterialConfigQuantityExpression { get; set; }

    [Column("MMCalMaterialConfigDepreciationQtyExpression")]
    [StringLength(1024)]
    public string MmcalMaterialConfigDepreciationQtyExpression { get; set; }
}
