using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADReportViewRefs")]
public partial class AdreportViewRef
{
    [Key]
    [Column("ADReportViewRefID")]
    public int AdreportViewRefId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ADReportViewID")]
    public int? FkAdreportViewId { get; set; }

    [Column("ADReportViewRefType")]
    [StringLength(100)]
    public string AdreportViewRefType { get; set; }

    [Column("ADReportViewRefName")]
    [StringLength(100)]
    public string AdreportViewRefName { get; set; }

    [Column("ADReportViewRefCol")]
    [StringLength(256)]
    public string AdreportViewRefCol { get; set; }

    [Column("ADReportViewRefDataSource")]
    [StringLength(256)]
    public string AdreportViewRefDataSource { get; set; }

    [Column("ADReportViewRefStoreProc")]
    [StringLength(256)]
    public string AdreportViewRefStoreProc { get; set; }

    [Column("ADReportViewRefNo")]
    [StringLength(100)]
    public string AdreportViewRefNo { get; set; }

    [Column("ADReportViewRefDrillDown")]
    public bool? AdreportViewRefDrillDown { get; set; }

    [Column("ADReportViewRefFieldModuleName")]
    [StringLength(100)]
    public string AdreportViewRefFieldModuleName { get; set; }

    [Column("ADReportViewRefDrillDownValue")]
    [StringLength(100)]
    public string AdreportViewRefDrillDownValue { get; set; }

    [InverseProperty("FkAdreportViewRef")]
    public virtual ICollection<AdreportViewRefParam> AdreportViewRefParams { get; set; } = new List<AdreportViewRefParam>();
}
