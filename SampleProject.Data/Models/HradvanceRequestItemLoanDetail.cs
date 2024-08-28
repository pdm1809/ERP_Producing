using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAdvanceRequestItemLoanDetails")]
public partial class HradvanceRequestItemLoanDetail
{
    [Key]
    [Column("HRAdvanceRequestItemLoanDetailID")]
    public int HradvanceRequestItemLoanDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_HRAdvanceRequestItemID")]
    public int FkHradvanceRequestItemId { get; set; }

    [Column("HRAdvanceRequestItemLoanDetailDate", TypeName = "datetime")]
    public DateTime? HradvanceRequestItemLoanDetailDate { get; set; }

    [Column("HRAdvanceRequestItemLoanDetailTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRequestItemLoanDetailTotalAmount { get; set; }

    [Column("HRAdvanceRequestItemLoanDetailStatus")]
    [StringLength(100)]
    public string HradvanceRequestItemLoanDetailStatus { get; set; }

    [ForeignKey("FkHradvanceRequestItemId")]
    [InverseProperty("HradvanceRequestItemLoanDetails")]
    public virtual HradvanceRequestItem FkHradvanceRequestItem { get; set; }
}
