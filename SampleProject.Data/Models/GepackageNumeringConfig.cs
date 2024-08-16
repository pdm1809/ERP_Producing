using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEPackageNumeringConfigs")]
public partial class GepackageNumeringConfig
{
    [Key]
    [Column("GEPackageNumeringConfigID")]
    public int GepackageNumeringConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Column("GEPackageNumeringConfigStart")]
    public int? GepackageNumeringConfigStart { get; set; }

    [Column("GEPackageNumeringConfigLength")]
    public int? GepackageNumeringConfigLength { get; set; }

    [Column("GEPackageNumeringConfigPrefix")]
    [StringLength(10)]
    public string GepackageNumeringConfigPrefix { get; set; }

    [Column("GEPackageNumeringConfigWoodType")]
    public bool? GepackageNumeringConfigWoodType { get; set; }

    [Column("GEPackageNumeringConfigHeigth", TypeName = "decimal(18, 2)")]
    public decimal? GepackageNumeringConfigHeigth { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("GepackageNumeringConfigs")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }
}
