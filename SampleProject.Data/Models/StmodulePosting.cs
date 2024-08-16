using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModulePostings")]
public partial class StmodulePosting
{
    [Key]
    [Column("STModulePostingID")]
    public int StmodulePostingId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("STModuleID")]
    public int? StmoduleId { get; set; }

    [Column("STModulePostingAccountingFunction")]
    [StringLength(512)]
    [Unicode(false)]
    public string StmodulePostingAccountingFunction { get; set; }

    [Column("STModulePostingStockFunction")]
    [StringLength(512)]
    [Unicode(false)]
    public string StmodulePostingStockFunction { get; set; }

    [Column("STModulePostingPurchaseFunction")]
    [StringLength(256)]
    [Unicode(false)]
    public string StmodulePostingPurchaseFunction { get; set; }

    [Column("STModulePostingAllocationPlanFunction")]
    [StringLength(256)]
    [Unicode(false)]
    public string StmodulePostingAllocationPlanFunction { get; set; }

    [Column("STModulePostingSaleOrderFunction")]
    [StringLength(256)]
    [Unicode(false)]
    public string StmodulePostingSaleOrderFunction { get; set; }

    [Column("STModulePostingTransitInFunction")]
    [StringLength(256)]
    [Unicode(false)]
    public string StmodulePostingTransitInFunction { get; set; }

    [Column("STModulePostingTransitOutFunction")]
    [StringLength(256)]
    [Unicode(false)]
    public string StmodulePostingTransitOutFunction { get; set; }

    [Column("STModulePostingInvoiceTransFunction")]
    [StringLength(256)]
    [Unicode(false)]
    public string StmodulePostingInvoiceTransFunction { get; set; }

    [Column("STModulePostingInvoiceInTransFunction")]
    [StringLength(256)]
    [Unicode(false)]
    public string StmodulePostingInvoiceInTransFunction { get; set; }
}
