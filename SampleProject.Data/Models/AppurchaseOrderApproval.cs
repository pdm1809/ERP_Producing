using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPurchaseOrderApprovals")]
public partial class AppurchaseOrderApproval
{
    [Key]
    [Column("APPurchaseOrderApprovalID")]
    public int AppurchaseOrderApprovalId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int FkAppurchaseOrderId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("APPurchaseOrderApprovalDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderApprovalDate { get; set; }

    [Column("APPurchaseOrderApprovalAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderApprovalAction { get; set; }

    [Column("APPurchaseOrderApprovalMessages")]
    public string AppurchaseOrderApprovalMessages { get; set; }
}
