using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMHistoryDetails")]
public partial class MmhistoryDetail
{
    [Key]
    [Column("MMHistoryDetailID")]
    public int MmhistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_MMHistoryID")]
    public int FkMmhistoryId { get; set; }

    [Required]
    [Column("MMHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmhistoryDetailTableName { get; set; }

    [Required]
    [Column("MMHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string MmhistoryDetailColumnName { get; set; }

    [Required]
    [Column("MMHistoryDetailOldValue")]
    [StringLength(512)]
    public string MmhistoryDetailOldValue { get; set; }

    [Required]
    [Column("MMHistoryDetailNewValue")]
    [StringLength(512)]
    public string MmhistoryDetailNewValue { get; set; }

    [ForeignKey("FkMmhistoryId")]
    [InverseProperty("MmhistoryDetails")]
    public virtual Mmhistory FkMmhistory { get; set; }
}
