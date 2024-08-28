using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACHistoryDetails")]
public partial class AchistoryDetail
{
    [Key]
    [Column("ACHistoryDetailID")]
    public int AchistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACHistoryID")]
    public int FkAchistoryId { get; set; }

    [Required]
    [Column("ACHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string AchistoryDetailTableName { get; set; }

    [Required]
    [Column("ACHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string AchistoryDetailColumnName { get; set; }

    [Required]
    [Column("ACHistoryDetailOldValue")]
    [StringLength(512)]
    public string AchistoryDetailOldValue { get; set; }

    [Required]
    [Column("ACHistoryDetailNewValue")]
    [StringLength(512)]
    public string AchistoryDetailNewValue { get; set; }

    [ForeignKey("FkAchistoryId")]
    [InverseProperty("AchistoryDetails")]
    public virtual Achistory FkAchistory { get; set; }
}
