using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("BRHistoryDetails")]
public partial class BrhistoryDetail
{
    [Key]
    [Column("BRHistoryDetailID")]
    public int BrhistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_BRHistoryID")]
    public int FkBrhistoryId { get; set; }

    [Required]
    [Column("BRHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrhistoryDetailTableName { get; set; }

    [Required]
    [Column("BRHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string BrhistoryDetailColumnName { get; set; }

    [Required]
    [Column("BRHistoryDetailOldValue")]
    [StringLength(512)]
    public string BrhistoryDetailOldValue { get; set; }

    [Required]
    [Column("BRHistoryDetailNewValue")]
    [StringLength(512)]
    public string BrhistoryDetailNewValue { get; set; }

    [ForeignKey("FkBrhistoryId")]
    [InverseProperty("BrhistoryDetails")]
    public virtual Brhistory FkBrhistory { get; set; }
}
