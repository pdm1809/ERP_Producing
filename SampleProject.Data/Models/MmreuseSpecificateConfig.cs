using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMReuseSpecificateConfigs")]
public partial class MmreuseSpecificateConfig
{
    [Key]
    [Column("MMReuseSpecificateConfigID")]
    public int MmreuseSpecificateConfigId { get; set; }

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

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeSpecialityID")]
    public int FkIcproductAttributeSpecialityId { get; set; }

    [Column("MMReuseSpecificateConfigThickMin", TypeName = "decimal(18, 5)")]
    public decimal? MmreuseSpecificateConfigThickMin { get; set; }

    [Column("MMReuseSpecificateConfigThickMax", TypeName = "decimal(18, 5)")]
    public decimal? MmreuseSpecificateConfigThickMax { get; set; }

    [Column("MMReuseSpecificateConfigWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmreuseSpecificateConfigWidthMin { get; set; }

    [Column("MMReuseSpecificateConfigWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmreuseSpecificateConfigWidthMax { get; set; }

    [Column("MMReuseSpecificateConfigHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? MmreuseSpecificateConfigHeightMin { get; set; }

    [Column("MMReuseSpecificateConfigHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? MmreuseSpecificateConfigHeightMax { get; set; }

    [Column("MMReuseSpecificateConfigAttributeNo")]
    [StringLength(512)]
    public string MmreuseSpecificateConfigAttributeNo { get; set; }

    [Column("MMReuseSpecificateConfigAttributeValue")]
    [StringLength(512)]
    public string MmreuseSpecificateConfigAttributeValue { get; set; }

    [ForeignKey("FkIcproductAttributeSpecialityId")]
    [InverseProperty("MmreuseSpecificateConfigFkIcproductAttributeSpecialities")]
    public virtual IcproductAttribute FkIcproductAttributeSpeciality { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmreuseSpecificateConfigFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }
}
