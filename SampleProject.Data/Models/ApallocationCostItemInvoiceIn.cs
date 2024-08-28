using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APAllocationCostItemInvoiceIns")]
public partial class ApallocationCostItemInvoiceIn
{
    [Key]
    [Column("APAllocationCostItemInvoiceInID")]
    public int ApallocationCostItemInvoiceInId { get; set; }

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

    [Column("FK_APAllocationCostID")]
    public int? FkApallocationCostId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("APAllocationCostItemInvoiceInTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemInvoiceInTotalCost { get; set; }

    [ForeignKey("FkApallocationCostId")]
    [InverseProperty("ApallocationCostItemInvoiceIns")]
    public virtual ApallocationCost FkApallocationCost { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApallocationCostItemInvoiceIns")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }
}
