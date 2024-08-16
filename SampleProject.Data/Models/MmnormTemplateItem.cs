using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMNormTemplateItems")]
public partial class MmnormTemplateItem
{
    [Key]
    [Column("MMNormTemplateItemID")]
    public int MmnormTemplateItemId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_MMNormTemplateID")]
    public int FkMmnormTemplateId { get; set; }

    [Column("MMNormTemplateItemParentNo")]
    [StringLength(50)]
    public string MmnormTemplateItemParentNo { get; set; }

    [Column("MMNormTemplateItemParentName")]
    [StringLength(50)]
    public string MmnormTemplateItemParentName { get; set; }

    [Column("MMNormTemplateItemGroup")]
    [StringLength(50)]
    public string MmnormTemplateItemGroup { get; set; }

    [Column("MMNormTemplateItemNo")]
    [StringLength(50)]
    public string MmnormTemplateItemNo { get; set; }

    [Column("MMNormTemplateItemProductName")]
    [StringLength(256)]
    public string MmnormTemplateItemProductName { get; set; }

    [Column("MMNormTemplateItemProductParentName")]
    [StringLength(256)]
    public string MmnormTemplateItemProductParentName { get; set; }

    [Column("MMNormTemplateItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmnormTemplateItemProductHeight { get; set; }

    [Column("MMNormTemplateItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmnormTemplateItemProductWidth { get; set; }

    [Column("MMNormTemplateItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmnormTemplateItemProductLength { get; set; }

    [Column("MMNormTemplateItemProductJoinery", TypeName = "decimal(18, 5)")]
    public decimal? MmnormTemplateItemProductJoinery { get; set; }

    [Column("MMNormTemplateItemProductJoineryDesc")]
    [StringLength(124)]
    public string MmnormTemplateItemProductJoineryDesc { get; set; }

    [Column("MMNormTemplateItemAttributeQuality")]
    [StringLength(124)]
    public string MmnormTemplateItemAttributeQuality { get; set; }

    [Column("MMNormTemplateItemProductSpeciality")]
    [StringLength(124)]
    public string MmnormTemplateItemProductSpeciality { get; set; }

    [Column("MMNormTemplateItemProductAttribute")]
    [StringLength(124)]
    public string MmnormTemplateItemProductAttribute { get; set; }

    [Column("MMNormTemplateItemProductWoodType")]
    [StringLength(124)]
    public string MmnormTemplateItemProductWoodType { get; set; }

    [Column("MMNormTemplateItemDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmnormTemplateItemDepreciationRate { get; set; }

    [Column("MMNormTemplateItemOperation")]
    [StringLength(512)]
    public string MmnormTemplateItemOperation { get; set; }

    [Column("MMNormTemplateItemPackagingName")]
    [StringLength(124)]
    public string MmnormTemplateItemPackagingName { get; set; }

    [Column("MMNormTemplateItemPackagingType")]
    [StringLength(124)]
    public string MmnormTemplateItemPackagingType { get; set; }

    [Column("MMNormTemplateItemFormula")]
    [StringLength(124)]
    public string MmnormTemplateItemFormula { get; set; }

    [Column("MMNormTemplateItemUnit")]
    [StringLength(50)]
    public string MmnormTemplateItemUnit { get; set; }

    [ForeignKey("FkMmnormTemplateId")]
    [InverseProperty("MmnormTemplateItems")]
    public virtual MmnormTemplate FkMmnormTemplate { get; set; }
}
