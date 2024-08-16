using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADReportViewRefParams")]
public partial class AdreportViewRefParam
{
    [Key]
    [Column("ADReportViewRefParamID")]
    public int AdreportViewRefParamId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADReportViewRefParamNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdreportViewRefParamNo { get; set; }

    [Column("ADReportViewRefParamName")]
    [StringLength(250)]
    public string AdreportViewRefParamName { get; set; }

    [Column("ADReportViewRefParamValue")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdreportViewRefParamValue { get; set; }

    [Column("ADReportViewRefParamIsDisplay")]
    public bool? AdreportViewRefParamIsDisplay { get; set; }

    [Column("FK_ADReportViewRefID")]
    public int? FkAdreportViewRefId { get; set; }

    [Column("ADReportViewRefParamOrder")]
    public byte? AdreportViewRefParamOrder { get; set; }

    [Column("ADReportViewRefParamDataType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdreportViewRefParamDataType { get; set; }

    [Column("ADReportViewRefParamLookupEdit")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdreportViewRefParamLookupEdit { get; set; }

    [Column("ADReportViewRefParamColumns")]
    [StringLength(250)]
    [Unicode(false)]
    public string AdreportViewRefParamColumns { get; set; }

    [Column("ADReportViewRefParamFilter")]
    [StringLength(250)]
    public string AdreportViewRefParamFilter { get; set; }

    [ForeignKey("FkAdreportViewRefId")]
    [InverseProperty("AdreportViewRefParams")]
    public virtual AdreportViewRef FkAdreportViewRef { get; set; }
}
