using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRBugManagements")]
public partial class HrbugManagement
{
    [Key]
    [Column("HRBugManagementID")]
    public int HrbugManagementId { get; set; }

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

    [Column("HRBugManagementNo")]
    [StringLength(250)]
    public string HrbugManagementNo { get; set; }

    [Column("HRBugManagementName")]
    [StringLength(255)]
    public string HrbugManagementName { get; set; }

    [Column("HRBugManagementDate", TypeName = "datetime")]
    public DateTime? HrbugManagementDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HRBugManagementDesc")]
    [StringLength(1024)]
    public string HrbugManagementDesc { get; set; }

    [Column("HRBugManagementHandleType")]
    [StringLength(250)]
    public string HrbugManagementHandleType { get; set; }

    [Column("FK_HRErrorTypeID")]
    public int? FkHrerrorTypeId { get; set; }

    [Column("HRBugManagementBarCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrbugManagementBarCode { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("HRBugManagementDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? HrbugManagementDetailQty { get; set; }

    [Column("HRBugManagementHandleWaitQty", TypeName = "decimal(18, 5)")]
    public decimal? HrbugManagementHandleWaitQty { get; set; }

    [Column("HRBugManagementOvercome")]
    [StringLength(1024)]
    public string HrbugManagementOvercome { get; set; }

    [Column("HRBugManagementStatus")]
    [StringLength(100)]
    public string HrbugManagementStatus { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrbugManagements")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrerrorTypeId")]
    [InverseProperty("HrbugManagements")]
    public virtual HrerrorType FkHrerrorType { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("HrbugManagements")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [InverseProperty("FkHrbugManagement")]
    public virtual ICollection<HrbugManagementTemplate> HrbugManagementTemplates { get; set; } = new List<HrbugManagementTemplate>();
}
