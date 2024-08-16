using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMSaleWorks")]
public partial class PmsaleWork
{
    [Key]
    [Column("PMSaleWorkID")]
    public int PmsaleWorkId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HREmployeeApprovedID")]
    public int FkHremployeeApprovedId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("PMSaleWorkNo")]
    [StringLength(50)]
    public string PmsaleWorkNo { get; set; }

    [Column("PMSaleWorkName")]
    [StringLength(256)]
    public string PmsaleWorkName { get; set; }

    [Column("PMSaleWorkDesc")]
    [StringLength(512)]
    public string PmsaleWorkDesc { get; set; }

    [Column("PMSaleWorkType")]
    [StringLength(50)]
    public string PmsaleWorkType { get; set; }

    [Column("PMSaleWorkBeginDate", TypeName = "datetime")]
    public DateTime? PmsaleWorkBeginDate { get; set; }

    [Column("PMSaleWorkEndDate", TypeName = "datetime")]
    public DateTime? PmsaleWorkEndDate { get; set; }

    [Column("PMSaleWorkDate", TypeName = "datetime")]
    public DateTime? PmsaleWorkDate { get; set; }

    [Column("PMSaleWorkStatus")]
    [StringLength(50)]
    public string PmsaleWorkStatus { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("PmsaleWorks")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmsaleWorkFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApprovedId")]
    [InverseProperty("PmsaleWorkFkHremployeeApproveds")]
    public virtual Hremployee FkHremployeeApproved { get; set; }

    [InverseProperty("FkPmsaleWork")]
    public virtual ICollection<PmsaleWorkItem> PmsaleWorkItems { get; set; } = new List<PmsaleWorkItem>();
}
