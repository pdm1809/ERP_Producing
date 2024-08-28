using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectNormItems")]
public partial class PmprojectNormItem
{
    [Key]
    [Column("PMProjectNormItemID")]
    public int PmprojectNormItemId { get; set; }

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

    [Column("FK_PMProjectNormID")]
    public int? FkPmprojectNormId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_PMTemplateItemComponentID")]
    public int? FkPmtemplateItemComponentId { get; set; }

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("PMProjectNormItemProductNo")]
    [StringLength(50)]
    public string PmprojectNormItemProductNo { get; set; }

    [Column("PMProjectNormItemProductName")]
    [StringLength(256)]
    public string PmprojectNormItemProductName { get; set; }

    [Column("PMProjectNormItemProductDesc")]
    [StringLength(512)]
    public string PmprojectNormItemProductDesc { get; set; }

    [Column("PMProjectNormItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormItemProductUnitPrice { get; set; }

    [Column("PMProjectNormItemType")]
    [StringLength(50)]
    public string PmprojectNormItemType { get; set; }

    [Column("PMProjectNormItemQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormItemQty { get; set; }

    [Column("PMProjectNormItemUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormItemUnitPrice { get; set; }

    [Column("PMProjectNormItemBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormItemBasicQty { get; set; }

    [Column("PMProjectNormItemProductType")]
    [StringLength(50)]
    public string PmprojectNormItemProductType { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmprojectNormItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmprojectNormItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmprojectNormItems")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmprojectNormId")]
    [InverseProperty("PmprojectNormItems")]
    public virtual PmprojectNorm FkPmprojectNorm { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("PmprojectNormItems")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }

    [ForeignKey("FkPmtemplateItemComponentId")]
    [InverseProperty("PmprojectNormItems")]
    public virtual PmtemplateItemComponent FkPmtemplateItemComponent { get; set; }
}
