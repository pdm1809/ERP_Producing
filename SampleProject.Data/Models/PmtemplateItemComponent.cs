using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMTemplateItemComponents")]
public partial class PmtemplateItemComponent
{
    [Key]
    [Column("PMTemplateItemComponentID")]
    public int PmtemplateItemComponentId { get; set; }

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

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("FK_ICProductWorkID")]
    public int? FkIcproductWorkId { get; set; }

    [Column("FK_ICProductWorkItemID")]
    public int? FkIcproductWorkItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("PMTemplateItemComponentProductNo")]
    [StringLength(50)]
    public string PmtemplateItemComponentProductNo { get; set; }

    [Column("PMTemplateItemComponentProductName")]
    [StringLength(256)]
    public string PmtemplateItemComponentProductName { get; set; }

    [Column("PMTemplateItemComponentProductDesc")]
    [StringLength(512)]
    public string PmtemplateItemComponentProductDesc { get; set; }

    [Column("PMTemplateItemComponentWorkType")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtemplateItemComponentWorkType { get; set; }

    [Column("PMTemplateItemComponentQty", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemComponentQty { get; set; }

    [Column("PMTemplateItemComponentBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemComponentBasicQty { get; set; }

    [Column("PMTemplateItemComponentType")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtemplateItemComponentType { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmtemplateItemComponents")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmtemplateItemComponentFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductWorkId")]
    [InverseProperty("PmtemplateItemComponentFkIcproductWorks")]
    public virtual Icproduct FkIcproductWork { get; set; }

    [ForeignKey("FkIcproductWorkItemId")]
    [InverseProperty("PmtemplateItemComponents")]
    public virtual IcproductWorkItem FkIcproductWorkItem { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("PmtemplateItemComponents")]
    public virtual Pmtemplate FkPmtemplate { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("PmtemplateItemComponents")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }

    [InverseProperty("FkPmtemplateItemComponent")]
    public virtual ICollection<PmprojectNormItem> PmprojectNormItems { get; set; } = new List<PmprojectNormItem>();
}
