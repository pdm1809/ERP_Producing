using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADReports")]
[Microsoft.EntityFrameworkCore.Index("AdreportNo", Name = "Idx_ADReports")]
public partial class Adreport
{
    [Key]
    [Column("ADReportID")]
    public int AdreportId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GELanguageID")]
    public int FkGelanguageId { get; set; }

    [Required]
    [Column("ADReportNo")]
    [StringLength(50)]
    public string AdreportNo { get; set; }

    [Required]
    [Column("ADReportName")]
    [StringLength(100)]
    public string AdreportName { get; set; }

    [Column("ADReportDesc")]
    [StringLength(512)]
    public string AdreportDesc { get; set; }

    [Column("ADReportType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdreportType { get; set; }

    [Column("ADReportSection")]
    [StringLength(50)]
    public string AdreportSection { get; set; }

    [Column("ADReportViewType")]
    [StringLength(50)]
    public string AdreportViewType { get; set; }

    [Column("ADReportSortOrder")]
    public int? AdreportSortOrder { get; set; }

    [Column("ADReportCopies")]
    public byte? AdreportCopies { get; set; }

    [InverseProperty("FkAdreport")]
    public virtual ICollection<AdreportPermission> AdreportPermissions { get; set; } = new List<AdreportPermission>();

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("Adreports")]
    public virtual Gelanguage FkGelanguage { get; set; }
}
