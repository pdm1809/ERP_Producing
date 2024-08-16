using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADReportViews")]
public partial class AdreportView
{
    [Key]
    [Column("ADReportViewID")]
    public int AdreportViewId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADReportViewNo")]
    [StringLength(50)]
    public string AdreportViewNo { get; set; }

    [Column("ADReportViewName")]
    [StringLength(100)]
    public string AdreportViewName { get; set; }

    [Column("ADReportViewType")]
    [StringLength(100)]
    public string AdreportViewType { get; set; }

    [Column("ADReportViewDesc")]
    [StringLength(512)]
    public string AdreportViewDesc { get; set; }

    [Column("ADReportViewDataSource")]
    [StringLength(512)]
    public string AdreportViewDataSource { get; set; }

    [Column("ADReportViewCol")]
    [StringLength(256)]
    public string AdreportViewCol { get; set; }
}
