using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormItemConfigs")]
public partial class MmproductionNormItemConfig
{
    [Key]
    [Column("MMProductionNormItemConfigID")]
    public int MmproductionNormItemConfigId { get; set; }

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

    [Column("MMProductionNormItemConfigBlocks")]
    public bool? MmproductionNormItemConfigBlocks { get; set; }

    [Column("MMProductionNormItemConfigMDFBlocks")]
    public bool? MmproductionNormItemConfigMdfblocks { get; set; }

    [Column("MMProductionNormItemConfigPlyWood")]
    public bool? MmproductionNormItemConfigPlyWood { get; set; }

    [Column("MMProductionNormItemConfigVeneer")]
    public bool? MmproductionNormItemConfigVeneer { get; set; }

    [Column("MMProductionNormItemConfigPrefixU")]
    [StringLength(10)]
    public string MmproductionNormItemConfigPrefixU { get; set; }

    [Column("MMProductionNormItemConfigPrefixV")]
    [StringLength(10)]
    public string MmproductionNormItemConfigPrefixV { get; set; }

    [Column("MMProductionNormItemConfigAutoGenPackage")]
    public bool? MmproductionNormItemConfigAutoGenPackage { get; set; }

    [Column("MMProductionNormItemConfigPackageNo")]
    [StringLength(50)]
    public string MmproductionNormItemConfigPackageNo { get; set; }

    [Column("MMProductionNormItemConfigPrefix")]
    [StringLength(10)]
    public string MmproductionNormItemConfigPrefix { get; set; }

    [Column("MMProductionNormItemConfigPrefixQC")]
    [StringLength(10)]
    public string MmproductionNormItemConfigPrefixQc { get; set; }

    [Column("MMProductionNormItemConfigUseLotNo")]
    public bool? MmproductionNormItemConfigUseLotNo { get; set; }

    [Column("MMProductionNormItemConfigUseForm")]
    public bool? MmproductionNormItemConfigUseForm { get; set; }

    [Column("MMProductionNormItemConfigUseStatus")]
    public bool? MmproductionNormItemConfigUseStatus { get; set; }

    [Column("MMProductionNormItemConfigUseQC")]
    public bool? MmproductionNormItemConfigUseQc { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("MmproductionNormItemConfigs")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }
}
