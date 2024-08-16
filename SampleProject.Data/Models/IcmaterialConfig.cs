using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICMaterialConfigs")]
public partial class IcmaterialConfig
{
    [Key]
    [Column("ICMaterialConfigID")]
    public int IcmaterialConfigId { get; set; }

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

    [Column("ICMaterialConfigName")]
    [StringLength(100)]
    public string IcmaterialConfigName { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICMaterialConfigQty", TypeName = "decimal(18, 5)")]
    public decimal? IcmaterialConfigQty { get; set; }

    public bool? IsActive { get; set; }

    [Column("FK_ICProductAttributeSpecialityID")]
    public int? FkIcproductAttributeSpecialityId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICMaterialConfigCalByQty")]
    public bool? IcmaterialConfigCalByQty { get; set; }

    [Column("FK_ICProductAttHTType")]
    public int? FkIcproductAttHttype { get; set; }

    [Column("FK_ICProductAttPackingMaterialSpeciality")]
    public int? FkIcproductAttPackingMaterialSpeciality { get; set; }

    [Column("ICMaterialConfigCalByType")]
    [StringLength(50)]
    public string IcmaterialConfigCalByType { get; set; }

    [Column("ICMaterialConfigType")]
    [StringLength(50)]
    public string IcmaterialConfigType { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcmaterialConfigs")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcmaterialConfigs")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttHttype")]
    [InverseProperty("IcmaterialConfigFkIcproductAttHttypeNavigations")]
    public virtual IcproductAttribute FkIcproductAttHttypeNavigation { get; set; }

    [ForeignKey("FkIcproductAttPackingMaterialSpeciality")]
    [InverseProperty("IcmaterialConfigFkIcproductAttPackingMaterialSpecialityNavigations")]
    public virtual IcproductAttribute FkIcproductAttPackingMaterialSpecialityNavigation { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcmaterialConfigFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }
}
