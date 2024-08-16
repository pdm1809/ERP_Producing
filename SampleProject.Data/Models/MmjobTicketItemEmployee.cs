using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMJobTicketItemEmployees")]
public partial class MmjobTicketItemEmployee
{
    [Key]
    [Column("MMJobTicketItemEmployeeID")]
    public int MmjobTicketItemEmployeeId { get; set; }

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
    public string Aastatus { get; set; }

    [Column("FK_MMJobTicketItemID")]
    public int? FkMmjobTicketItemId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int? FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("MMJobTicketItemEmployeeDesc")]
    [StringLength(512)]
    public string MmjobTicketItemEmployeeDesc { get; set; }

    [Column("MMJobTicketItemEmployeeAbstract")]
    public int? MmjobTicketItemEmployeeAbstract { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmjobTicketItemEmployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmjobTicketItemId")]
    [InverseProperty("MmjobTicketItemEmployees")]
    public virtual MmjobTicketItem FkMmjobTicketItem { get; set; }
}
