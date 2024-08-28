using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOverallInsideDimensionConfigs")]
public partial class MmoverallInsideDimensionConfig
{
    [Key]
    [Column("MMOverallInsideDimensionConfigID")]
    public int MmoverallInsideDimensionConfigId { get; set; }

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

    [Column("FK_ICProductAttributePackingMaterialSpecialityID")]
    public int FkIcproductAttributePackingMaterialSpecialityId { get; set; }

    [Column("MMOverallInsideDimensionConfigType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmoverallInsideDimensionConfigType { get; set; }

    [Column("MMOverallInsideDimensionConfigOperationType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmoverallInsideDimensionConfigOperationType { get; set; }

    [Column("MMOverallInsideDimensionConfigOperationValue")]
    public int? MmoverallInsideDimensionConfigOperationValue { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [ForeignKey("FkIcproductAttributePackingMaterialSpecialityId")]
    [InverseProperty("MmoverallInsideDimensionConfigs")]
    public virtual IcproductAttribute FkIcproductAttributePackingMaterialSpeciality { get; set; }
}
