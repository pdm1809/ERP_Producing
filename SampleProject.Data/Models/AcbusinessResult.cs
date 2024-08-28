using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBusinessResults")]
public partial class AcbusinessResult
{
    [Key]
    [Column("ACBusinessResultID")]
    public int AcbusinessResultId { get; set; }

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
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ACBusinessResultNo")]
    [StringLength(50)]
    public string AcbusinessResultNo { get; set; }

    [Column("ACBusinessResultstatus")]
    [StringLength(100)]
    public string AcbusinessResultstatus { get; set; }

    [Column("ACBusinessResultName")]
    [StringLength(512)]
    public string AcbusinessResultName { get; set; }

    [Column("ACBusinessResultDesc")]
    [StringLength(512)]
    public string AcbusinessResultDesc { get; set; }

    [Column("ACBusinessResultFromDate", TypeName = "datetime")]
    public DateTime? AcbusinessResultFromDate { get; set; }

    [Column("ACBusinessResultToDate", TypeName = "datetime")]
    public DateTime? AcbusinessResultToDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ACBusinessResultOpeningFromDate", TypeName = "datetime")]
    public DateTime? AcbusinessResultOpeningFromDate { get; set; }

    [Column("ACBusinessResultOpeningToDate", TypeName = "datetime")]
    public DateTime? AcbusinessResultOpeningToDate { get; set; }

    [Column("FK_BRBranchCentralID")]
    public int? FkBrbranchCentralId { get; set; }

    [InverseProperty("FkAcbusinessResult")]
    public virtual ICollection<AcbusinessResultDetail> AcbusinessResultDetails { get; set; } = new List<AcbusinessResultDetail>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcbusinessResultFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrbranchCentralId")]
    [InverseProperty("AcbusinessResultFkBrbranchCentrals")]
    public virtual Brbranch FkBrbranchCentral { get; set; }
}
