using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARHistoryDetails")]
public partial class ArhistoryDetail
{
    [Key]
    [Column("ARHistoryDetailID")]
    public int ArhistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARHistoryID")]
    public int FkArhistoryId { get; set; }

    [Required]
    [Column("ARHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArhistoryDetailTableName { get; set; }

    [Required]
    [Column("ARHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string ArhistoryDetailColumnName { get; set; }

    [Required]
    [Column("ARHistoryDetailOldValue")]
    [StringLength(512)]
    public string ArhistoryDetailOldValue { get; set; }

    [Required]
    [Column("ARHistoryDetailNewValue")]
    [StringLength(512)]
    public string ArhistoryDetailNewValue { get; set; }

    [ForeignKey("FkArhistoryId")]
    [InverseProperty("ArhistoryDetails")]
    public virtual Arhistory FkArhistory { get; set; }
}
