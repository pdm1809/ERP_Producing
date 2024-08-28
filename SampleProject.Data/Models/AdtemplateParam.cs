using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADTemplateParams")]
public partial class AdtemplateParam
{
    [Key]
    [Column("ADTemplateParamID")]
    public int AdtemplateParamId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADTemplateParamNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdtemplateParamNo { get; set; }

    [Column("ADTemplateParamName")]
    [StringLength(250)]
    public string AdtemplateParamName { get; set; }

    [Column("ADTemplateParamValue")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdtemplateParamValue { get; set; }

    [Column("ADTemplateParamIsDisplay")]
    public bool? AdtemplateParamIsDisplay { get; set; }

    [Column("FK_ADTemplateID")]
    public int? FkAdtemplateId { get; set; }

    [Column("ADTemplateParamOrder")]
    public byte? AdtemplateParamOrder { get; set; }

    [Column("ADTemplateParamDataType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdtemplateParamDataType { get; set; }

    [Column("ADTemplateParamLookupEdit")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdtemplateParamLookupEdit { get; set; }

    [Column("ADTemplateParamColumns")]
    [StringLength(250)]
    [Unicode(false)]
    public string AdtemplateParamColumns { get; set; }

    [Column("ADTemplateParamFilter")]
    [StringLength(4000)]
    public string AdtemplateParamFilter { get; set; }

    [Column("ADTemplateParamParentField")]
    [StringLength(100)]
    public string AdtemplateParamParentField { get; set; }

    [Column("ADTemplateParamFieldRelation")]
    [StringLength(100)]
    public string AdtemplateParamFieldRelation { get; set; }

    [Column("ADTemplateParamIsNotNull")]
    public bool? AdtemplateParamIsNotNull { get; set; }

    [ForeignKey("FkAdtemplateId")]
    [InverseProperty("AdtemplateParams")]
    public virtual Adtemplate FkAdtemplate { get; set; }
}
