using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerComments")]
[Microsoft.EntityFrameworkCore.Index("FkArcustomerId", Name = "Idx_ARCustomerComments")]
public partial class ArcustomerComment
{
    [Key]
    [Column("ARCustomerCommentID")]
    public int ArcustomerCommentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ARCustomerCommentStartDate", TypeName = "datetime")]
    public DateTime? ArcustomerCommentStartDate { get; set; }

    [Column("ARCustomerCommentExpiredDate", TypeName = "datetime")]
    public DateTime? ArcustomerCommentExpiredDate { get; set; }

    [Column("ARCustomerCommentDesc", TypeName = "ntext")]
    public string ArcustomerCommentDesc { get; set; }

    [Column("ARCustomerCommentPriority")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerCommentPriority { get; set; }

    [Column("ARCustomerCommentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerCommentStatus { get; set; }

    [Column("ARCustomerCommentPercentComplete", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerCommentPercentComplete { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcustomerComments")]
    public virtual Arcustomer FkArcustomer { get; set; }
}
