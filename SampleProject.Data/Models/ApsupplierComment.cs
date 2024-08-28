using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierComments")]
[Microsoft.EntityFrameworkCore.Index("FkApsupplierId", Name = "Idx_APSupplierComments")]
public partial class ApsupplierComment
{
    [Key]
    [Column("APSupplierCommentID")]
    public int ApsupplierCommentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("APSupplierCommentStartDate", TypeName = "datetime")]
    public DateTime? ApsupplierCommentStartDate { get; set; }

    [Column("APSupplierCommentExpiredDate", TypeName = "datetime")]
    public DateTime? ApsupplierCommentExpiredDate { get; set; }

    [Column("APSupplierCommentDesc", TypeName = "ntext")]
    public string ApsupplierCommentDesc { get; set; }

    [Column("APSupplierCommentPriority")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierCommentPriority { get; set; }

    [Column("APSupplierCommentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierCommentStatus { get; set; }

    [Column("APSupplierCommentPercentComplete", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierCommentPercentComplete { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApsupplierComments")]
    public virtual Apsupplier FkApsupplier { get; set; }
}
